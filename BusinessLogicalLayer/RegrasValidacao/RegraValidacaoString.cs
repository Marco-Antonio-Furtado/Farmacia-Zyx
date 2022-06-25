using System.Text.RegularExpressions;

namespace BusinessLogicalLayer
{
    internal class RegraValidacaoString
    {
        private const int MAXIMO_CARACTERES_NOME = 100;
        private const int MINIMO_CARACTERES_NOME = 3;
        private const int CARACTERES_CPF = 11;
        private const int MAXIMO_CARACTERES_EMAIL = 100;
        private const int MINIMO_CARACTERES_EMAIL = 3;
        internal static string ValidateNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "Nome deve ser informado.\r\n";
            }
            nome = nome.Trim();
            nome = Regex.Replace(nome, @"\s+", " ");
            if (nome.Length < MINIMO_CARACTERES_NOME)
            {
                return "Nome deve conter o minimo de caracteres.\r\n";
            }
            string[] nomes = nome.Split(" ");
            if (nomes.Length <= 1)
            {
                return "Nome completo deve ser informado.\r\n";
            }
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Length < 2)
                {
                    return "Nome/Sobrenome deve possuir ao menos 2 caractere.\r\n";
                }
            }
            string regex = @"^[a-zA-Záâãéêíïóõôüúç ÁÂÃÉÊÍÏÓÔÜÚÇ]+$";
            if (!Regex.IsMatch(nome, regex))
            {
                return "Nome deve conter apenas caracteres do alfabeto romano.\r\n";
            }
            if (nome.Length > MAXIMO_CARACTERES_NOME)
            {
                return "Nome não pode conter mais que o maximo de caracteres.\r\n";
            }
            return "";
        }
        internal static string ValidateCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                return "CPF deve ser informado.\r\n";
            }
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != CARACTERES_CPF)
                return "CPF com numeros de caracteres invalidos\r\n";
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            bool ehValido = cpf.EndsWith(digito);
            if (!ehValido)
            {
                return "CPF com formato inválido.\r\n";
            }
            return "";
        }
        internal static string ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return "Email deve ser informado.\r\n";
            }
            string pattern = @"^[^@\s]+@[^@\s]+.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
            {
                return "Email inválido.\r\n";
            }
            email = email.Trim();
            if (email.Length < MINIMO_CARACTERES_EMAIL)
            {
                return "Email não pode conter menos que 5 caracteres.\r\n";
            }
            if (email.Length > MAXIMO_CARACTERES_EMAIL)
            {
                return "Email não pode conter mais que 100 caracteres.\r\n";
            }
            return "";
        }
        internal static string ValidateTelefone(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
            {
                return "Telefone deve ser informado.\r\n";
            }
            telefone = telefone.Trim();
            telefone =
                telefone.Replace("(", "")
                        .Replace(")", "")
                        .Replace("-", "")
                        .Replace(" ", "")
                        .Replace(".", "")
                        .Replace("+", "");
            if (telefone.Length != 8 && telefone.Length != 9 && telefone.Length != 11 && telefone.Length != 13)
            {
                return "Telefone deve conter 8, 9, 11 ou 13 dígitos.\r\n";
            }
            long temp;
            if (!long.TryParse(telefone, out temp))
            {
                return "Telefone inválido.\r\n";
            }
            return "";
        }
        internal static string ValidateRG(string RG)
        {
            if (string.IsNullOrWhiteSpace(RG))
            {
                return "RG tem que ser informado\r\n";
            }
            return "";
        }
    }
}
       

