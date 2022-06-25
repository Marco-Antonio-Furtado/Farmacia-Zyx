using BusinessLogicalLayer.RegrasValidacao;
using Entities;
using Entities.Propriedades;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class EnderecoValitor
    {
        internal static Response Validate(Endereco Endereco)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(RegraValidacaoEndereco.ValidateRua(Endereco.NomeRua));
            erros.Append(RegraValidacaoEndereco.ValidateCep(Endereco.CEP));
            erros.Append(RegraValidacaoEndereco.ValidateNumero(Endereco.NumeroCasa));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Daqui esta indo pro banco", true);
        }
        internal static Response ValidateEstado(Estado estado)
        {
            StringBuilder erros = new StringBuilder("");
            erros.Append(RegraValidacaoEndereco.ValidateEstado(estado.ID));
            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Daqui esta indo pro banco", true);
        }
        internal static Response ValidateCidade(Cidade cidade)
        {
            StringBuilder erros = new StringBuilder("");
            erros.Append(RegraValidacaoEndereco.ValidateCidade(cidade.ID));
            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}
