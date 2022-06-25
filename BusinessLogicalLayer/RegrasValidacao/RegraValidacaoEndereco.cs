using Entities;

namespace BusinessLogicalLayer.RegrasValidacao
{
    internal class RegraValidacaoEndereco
    {
        internal static string ValidateRua(string rua)
        {
            if (string.IsNullOrWhiteSpace(rua))
            {
                return "rua tem que ser informada\r\n";
            }
            else return "";
        }
        internal static string ValidateCep(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
            {
                return "Cep tem que ser informado\r\n";
            }
            else return "";
        }
        internal static string ValidateNumero(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                return "numero tem que ser informado\r\n";
            }
            else return "";
        }
        internal static string ValidateCidade(int Cidade)
        {
            if (string.IsNullOrWhiteSpace(Cidade.ToString()))
            {
                return "Cidade tem que ser informado\r\n";
            }
            else return "";
        }
        internal static string ValidateEstado(int Estado)
        {
            if (string.IsNullOrWhiteSpace(Estado.ToString()))
            {
                return "Estado tem que ser informado\r\n";
            }
           
            else return "";
        }
    }
}
