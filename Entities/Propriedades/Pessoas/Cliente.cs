using Entities.Propriedades.Pessoas;

namespace Entities
{
    /// <summary>
    /// Classe que Herda de pessoa e representa cada cliente
    /// e tem um contrutor padrao e outro preenchido por causa de um melhor funcionamento do sistema 
    /// por exemplo o funcionamento do dbexecuter
    /// </summary>
    public class Cliente : Pessoa
    {
        public Cliente()
        {
        }

        public Cliente(string nome, string cPF, string rG, string email, string telefone, string telefone2)
        {
            Nome_Cliente = nome;
            CPF = cPF;
            RG = rG;
            Email = email;
            Telefone = telefone;
            Telefone2 = telefone2;
        }
        public string Telefone2 { get; set; }
        public int Programa_Fidelidade { get; set; }
        public string Nome_Cliente { get; set; }
        public override string ToString()
        {
            return this.Nome_Cliente + "\r\n" +
                   this.CPF + "\r\n" +
                   this.Email + "\r\n" +
                   this.Telefone + "\r\n" +
                   this.Ativo + "\r\n";
        }
    }


}

