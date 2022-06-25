using Entities;

namespace BusinessLogicalLayer.RegrasValidacao
{

    internal class RegraValidacaoEndereco
    {
        private const int CARACTERES_CEP = 8;

        internal static string ValidateRua(string rua)
        {
            if (string.IsNullOrWhiteSpace(rua))
            {
                return "rua tem que ser informada\r\n";
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
        internal static string ValidateCEP(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
            {
                return "CEP deve ser informado.\r\n";
            }
            cep = cep.Trim();
            cep = cep.Replace("-", "").Replace(".", "");
            if (cep.Length != CARACTERES_CEP)
            {
                return "CEP deve conter 8 dígitos (sem considerar hífen/ponto).\r\n";
            }
            int temp = 0;
            if (!int.TryParse(cep, out temp))
            {
                //Se a conversão não funcionar
                return "CEP em formato incorreto.\r\n";
            }
            return "";
        }
    }
}
