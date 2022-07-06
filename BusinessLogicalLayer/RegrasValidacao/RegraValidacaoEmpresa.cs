namespace BusinessLogicalLayer.RegrasValidacao
{
    /// <summary>
    /// Nesta classe contem as validacões de empresa 
    /// </summary>
    internal class RegraValidacaoEmpresa
    {
        private const int CARACTERES_CNPJ = 14;
        /// <summary>
        /// classe que verifica se é um cnpj valido
        /// </summary>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        internal static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
            if (cnpj.Length != CARACTERES_CNPJ)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            return cnpj.EndsWith(digito);
        }

        /// <summary>
        /// Como nao ha um padrao este metodo retorna se a razao social da empresa é valida
        /// </summary>
        /// <param name="RazaoSocial"></param>
        /// <returns></returns>
        internal static string ValidateRazaoSocial(string RazaoSocial)
        {
            if (string.IsNullOrWhiteSpace(RazaoSocial))
            {
                return "Razao Social tem que ser informada\r\n";
            }
            else if (RazaoSocial.Length < 3)
            {
                return "Razao Social invalida\r\n";
            }
            return "";
        }
    }
}
