using BusinessLogicalLayer.RegrasValidacao;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    /// <summary>
    /// Nesta classe eu valido o endereco para ver se ele esta em condicoes de entrar no banco ou ser alterado
    /// chamando os metodos da validacao de endereco
    /// onde instancio um string builder e encho ele com as especificacoes que o endereco pede
    /// </summary>
    internal class EnderecoValitor
    {
        internal static Response Validate(Endereco Endereco)
        {
            StringBuilder erros = new("");

            erros.Append(RegraValidacaoEndereco.ValidateRua(Endereco.NomeRua));
            erros.Append(RegraValidacaoEndereco.ValidateCEP(Endereco.CEP));
            erros.Append(RegraValidacaoEndereco.ValidateNumero(Endereco.NumeroCasa));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("", true);
        }
    }
}
