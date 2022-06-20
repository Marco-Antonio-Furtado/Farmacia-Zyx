using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    internal class RegraValidacaoString
    {
        private const int MAXIMO_CARACTERES_NOME = 100;
        private const int MINIMO_CARACTERES_NOME = 3;
        private const int CARACTERES_CPF = 11;
        private const int MAXIMO_CARACTERES_EMAIL = 100;
        private const int MINIMO_CARACTERES_EMAIL = 3;
        private const int CARACTERES_CEP = 8;
        private const int CARACTERES_CNPJ = 14;

        internal string ValidateNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "Nome deve ser informado.\r\n";
            }
            //Trim -> Remove espaços em branco do começo e do fim da string (mas não do meio)
            nome = nome.Trim();

            //Função que remove os espaços extra entre as strings (deixando apenas um)
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
            //Alfabeto romano e acentos gráficos
            string regex = @"^[a-zA-Záâãéêíïóõôüúç ÁÂÃÉÊÍÏÓÔÜÚÇ]+$";
            if (!Regex.IsMatch(nome,regex))
            {
                return "Nome deve conter apenas caracteres do alfabeto romano.\r\n";
            }

            if (nome.Length > MAXIMO_CARACTERES_NOME)
            {
                return "Nome não pode conter mais que o maximo de caracteres.\r\n";
            }

            //Se chegou aqui, o nome ta certinho e retornamos "";
            return "";
        }

        /// <summary>
        /// Executa validação de CPF utilizando as regras disponibilizadas pela Receita Federal
        /// </summary>
        /// <param name="cpf">Cpf a ser validado</param>
        /// <returns>Retorna "" se o CPF está válido, caso contrário retorna a mensagem de erro</returns>
        internal string ValidateCPF(string cpf)
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
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            bool ehValido = cpf.EndsWith(digito);
            if (!ehValido)
            {
                return "CPF com formato inválido.\r\n";
            }
            return "";
        }


        //Validação do email deve estar errada
        internal string ValidateEmail(string email)
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

        internal string ValidateCEP(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
            {
                return "CEP deve ser informado.\r\n";
            }
            //Remove espaços em branco do inicio e fim da string
            cep = cep.Trim();
            //Substitui - e . por "" (vazio)
            cep = cep.Replace("-", "").Replace(".", "");

            if (cep.Length != CARACTERES_CEP)
            {
                return "CEP deve conter 8 dígitos (sem considerar hífen/ponto).\r\n";
            }

            int temp = 0;
            if(!int.TryParse(cep, out temp))
            {
                //Se a conversão não funcionar
                return "CEP em formato incorreto.\r\n";
            }

            return "";
        }

        internal string ValidateTelefone(string telefone)
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
            
            if (telefone.Length != 8 && telefone.Length != 9 && telefone.Length!= 11 && telefone.Length != 13)
            {
                return "Telefone deve conter 8, 9, 11 ou 13 dígitos.\r\n";
            }

            long temp;
            if(!long.TryParse(telefone, out temp))
            {
                return "Telefone inválido.\r\n";
            }
            return "";
        }
        internal string ValidateRG(string RG)
        {
            if (string.IsNullOrWhiteSpace(RG))
            {
                return "RG tem que ser informado\r\n";
            }
            return "";
        }
        internal bool IsCnpj(string cnpj)
        {


            {
                int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma;
                int resto;
                string digito;
                string tempCnpj;
                cnpj = cnpj.Trim();
                cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
                if (cnpj.Length != 14)
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
                tempCnpj = tempCnpj + digito;
                soma = 0;
                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cnpj.EndsWith(digito);
            }

            internal string ValidateCNPJ(string cnpj)
            {
                if (string.IsNullOrWhiteSpace(cnpj))
                {
                    return "CNPJ deve ser informado.";
                }
                if (IsCnpj(cnpj))
                {
                    return "";
                }
                return "CNPJ invalido.";
            }
            internal string ValidateRazaoSocial(string Razao)
        {
            if (string.IsNullOrWhiteSpace(Razao))
            {
                return "Razao Social tem que ser informada\r\n";
            }
            else if (Razao.Length > 3)
            {
                return "Razao Social invalida\r\n";
            }
            else { return ""; }
        }
       
    }
}
