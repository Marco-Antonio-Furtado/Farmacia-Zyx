using BusinessLogicalLayer.RegrasValidacao;
using Entities;
using Entities.Propriedades;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class EnderecoValitor
    {
        private RegraValidacaoEndereco validacaoEndereco = new RegraValidacaoEndereco();
         
        internal Response Validate(Endereco Endereco)
        {

            StringBuilder erros = new StringBuilder("");


            erros.Append(validacaoEndereco.ValidateRua(Endereco.NomeRua));
            erros.Append(validacaoEndereco.ValidateCep(Endereco.CEP));
            erros.Append(validacaoEndereco.ValidateNumero(Endereco.NumeroCasa));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Daqui esta indo pro banco", true);
        }
        internal Response ValidateEstado(Estado estado)
        {
            StringBuilder erros = new StringBuilder("");
            erros.Append(validacaoEndereco.ValidateEstado(estado));
            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Daqui esta indo pro banco", true);
        }
        internal Response ValidateCidade(Cidade cidade)
        {
            StringBuilder erros = new StringBuilder("");
            erros.Append(validacaoEndereco.ValidateCidade(cidade.Nome));
            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}
