using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class FornecedorValidator
    {
        internal static Response Validate(Fornecedor fornecedor)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(RegraValidacaoString.ValidateNome(fornecedor.NomeResponsavel));
            erros.Append(RegraValidacaoString.ValidateEmail(fornecedor.Email));
            erros.Append(RegraValidacaoString.ValidateTelefone(fornecedor.Telefone));
            if (!RegraValidacaoString.IsCnpj(fornecedor.CNPJ)) erros.Append("CNPJ Invalido");
            erros.Append(RegraValidacaoString.ValidateRazaoSocial(fornecedor.RazaoSocial));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }

            //Se chegou aqui, validamos com sucesso!
            fornecedor.NomeResponsavel = RegraNormatizacao.NormatizeName(fornecedor.NomeResponsavel);
            // tem que ser fornecedorDAL ao invés de clienteDAL
            //return clienteDAL.Insert(fornecedor);
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}