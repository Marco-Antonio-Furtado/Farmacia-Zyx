using BusinessLogicalLayer.RegrasValidacao;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class EnderecoValitor
    {
        RegraValidacaoEndereco validacaoEndereco = new RegraValidacaoEndereco();
        internal Response Validate(Endereco Endereco)
        {

            StringBuilder erros = new StringBuilder("");


            erros.Append(validacaoEndereco.ValidateRua(Endereco.Rua));
            erros.Append(validacaoEndereco.ValidateBairro(Endereco.Bairro));
            erros.Append(validacaoEndereco.ValidateCep(Endereco.CEP));
            erros.Append(validacaoEndereco.ValidateNumero(Endereco.Numero));
            erros.Append(validacaoEndereco.ValidatePontoReferencia(Endereco.PontoReferencia));
            erros.Append(validacaoEndereco.Validatecidade(Endereco.Cidade));
            erros.Append(validacaoEndereco.ValidateEstado(Endereco.Estado));


            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}
