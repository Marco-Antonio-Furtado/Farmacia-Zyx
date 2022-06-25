using BusinessLogicalLayer.RegrasValidacao;
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

            erros.Append(RegraValidacaoString.ValidateEmail(fornecedor.Email));
            erros.Append(RegraValidacaoString.ValidateTelefone(fornecedor.Telefone));
            erros.Append(EmpresaValidator.Validate(fornecedor));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}