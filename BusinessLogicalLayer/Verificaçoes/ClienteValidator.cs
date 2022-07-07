using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    /// <summary>
    /// Nesta classe eu valido o Cliente para ver se ele esta em condicoes de entrar no banco ou ser alterado
    /// chamando os metodos da validacao de string
    /// onde instancio um string builder e encho ele com as especificacoes que o cliente pede
    /// </summary>
    internal class ClienteValidator
    {
        internal static Response Validate(Cliente cliente)
        {
            StringBuilder erros = new("");
            
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