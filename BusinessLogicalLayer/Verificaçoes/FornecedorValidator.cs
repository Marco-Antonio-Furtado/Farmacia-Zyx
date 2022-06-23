using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class FornecedorValidator
    {
        private RegraValidacaoString stringValidator = new RegraValidacaoString();
        private RegraNormatizacao normatization = new RegraNormatizacao();

        internal Response Validate(Fornecedor fornecedor)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(stringValidator.ValidateNome(fornecedor.NomeResponsavel));
            erros.Append(stringValidator.ValidateEmail(fornecedor.Email));
            erros.Append(stringValidator.ValidateTelefone(fornecedor.Telefone));
            if (!stringValidator.IsCnpj(fornecedor.CNPJ)) erros.Append("CNPJ Invalido");
            erros.Append(stringValidator.ValidateRazaoSocial(fornecedor.RazaoSocial));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }

            //Se chegou aqui, validamos com sucesso!
            fornecedor.NomeResponsavel = normatization.NormatizeName(fornecedor.NomeResponsavel);
            // tem que ser fornecedorDAL ao invés de clienteDAL
            //return clienteDAL.Insert(fornecedor);
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}