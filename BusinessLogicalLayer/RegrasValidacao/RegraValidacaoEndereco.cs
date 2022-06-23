using Entities;

namespace BusinessLogicalLayer.RegrasValidacao
{
    internal class RegraValidacaoEndereco
    {
        internal string ValidateRua(string rua)
        {
            if (string.IsNullOrWhiteSpace(rua))
            {
                return "rua tem que ser informada\r\n";
            }
            else return "";
        }
        internal string ValidateCep(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
            {
                return "Cep tem que ser informado\r\n";
            }
            else return "";
        }
        internal string ValidateNumero(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                return "numero tem que ser informado\r\n";
            }
            else return "";
        }
        internal string ValidateCidade(string Cidade)
        {
            if (string.IsNullOrWhiteSpace(Cidade))
            {
                return "Cidade tem que ser informado\r\n";
            }
            else return "";
        }
        internal string ValidateEstado(Estado Estado)
        {
            if (string.IsNullOrWhiteSpace(Estado.Nome))
            {
                return "Estado tem que ser informado\r\n";
            }
            if(Estado.UF.Length != 2)
            {
                return "Estado Com Formato Incorreto\r\n";
            }
            else return "";
        }
    }
}
