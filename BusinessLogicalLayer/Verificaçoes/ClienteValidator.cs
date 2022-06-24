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
            
            erros.Append(RegraValidacaoString.ValidateNome(cliente.Nome));
            erros.Append(RegraValidacaoString.ValidateCPF(cliente.CPF));
            erros.Append(RegraValidacaoString.ValidateEmail(cliente.Email));
            erros.Append(RegraValidacaoString.ValidateTelefone(cliente.Telefone1));
            erros.Append(RegraValidacaoString.ValidateTelefone(cliente.Telefone2));
            erros.Append(RegraValidacaoString.ValidateRG(cliente.RG));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            cliente.Nome = RegraNormatizacao.NormatizeName(cliente.Nome);
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}