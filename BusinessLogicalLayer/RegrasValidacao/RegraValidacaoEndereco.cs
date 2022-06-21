using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.RegrasValidacao
{
    internal class RegraValidacaoEndereco
    {
        internal string ValidateRua(string rua)
        {
            if (string.IsNullOrWhiteSpace(rua))
            {
                return "rua tem que ser informada";
            }
            else return "";
        }
        internal string ValidateBairro(string bairro)
        {
            if (string.IsNullOrWhiteSpace(bairro))
            {
                return "Bairro tem que ser informada";
            }
            else return "";
        }
        internal string ValidateCep(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
            {
                return "Cep tem que ser informado";
            }
            else return "";
        }
        internal string ValidateNumero(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                return "numero tem que ser informado";
            }
            else return "";
        }
        internal string ValidatePontoReferencia(string pontoReferencia)
        {
            if (string.IsNullOrWhiteSpace(pontoReferencia))
            {
                return "Ponto de Referencia tem que ser informado";
            }
            else return "";
        }
        internal string Validatecidade(string cidade)
        {
            if (string.IsNullOrWhiteSpace(cidade))
            {
                return "Bairro tem que ser informada";
            }
            else return "";
        }
        internal string ValidateEstado(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
            {
                return "estado tem que ser informada";
            }
            else return "";
        }

    }
}
