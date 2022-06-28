using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    internal class ClienteValidator
    {
        internal static Response Validate(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder("");
            
            erros.Append(RegraValidacaoString.ValidateNome(cliente.Nome_Cliente));
            erros.Append(RegraValidacaoString.ValidateCPF(cliente.CPF));
            erros.Append(RegraValidacaoString.ValidateEmail(cliente.Email));
            erros.Append(RegraValidacaoString.ValidateTelefone(cliente.Telefone));
            erros.Append(RegraValidacaoString.ValidateTelefone(cliente.Telefone2));
            erros.Append(RegraValidacaoString.ValidateRG(cliente.RG));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            cliente.Nome_Cliente = RegraNormatizacao.NormatizeName(cliente.Nome_Cliente);
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}