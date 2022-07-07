using Entities;

namespace BusinessLogicalLayer.RegrasValidacao
{
    /// <summary>
    /// Nesta classe existe todas as regras de validacoes de endereco
    /// </summary>
    internal class RegraValidacaoEndereco
    {
        private const int CARACTERES_CEP = 8;

        /// <summary>
        /// Como nao ha padrão apenas nao deixei a rua vazia
        /// </summary>
        /// <param name="rua"></param>
        /// <returns></returns>
        internal static string ValidateRua(string rua)
        {
            if (string.IsNullOrWhiteSpace(rua))
            {
                return "rua tem que ser informada\r\n";
            }
            else return "";
        }
        /// <summary>
        /// Como nao ha padrão apenas nao deixei a numero vazia
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        internal static string ValidateNumero(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                return "numero tem que ser informado\r\n";
            }
            else return "";
        }
        /// <summary>
        /// Metodo padrão para validar cep que foi pego direto do site do governo federal
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
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
