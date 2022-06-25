using Entities.Propriedades.Pessoas;

namespace Entities
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, string cPF, string rG, string email, string telefone, string telefone2)
        {
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Email = email;
            Telefone = telefone;
            Telefone2 = telefone2;
        }

        public Estado Endereco { get; set; }
        public string Telefone2 { get; set; }
        public int ProgramaFidelidade { get; set; }
        public override string ToString()
        {
            return this.Nome + "\r\n" +
                   this.CPF + "\r\n" +
                   this.Email + "\r\n" +
                   this.Telefone + "\r\n" +
                   this.Ativo + "\r\n" +
                   this.Endereco.ToString() + "\r\n";
        }
    }


}

