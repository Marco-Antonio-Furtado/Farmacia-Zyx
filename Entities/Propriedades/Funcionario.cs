using Shared;

namespace Entities
{
    public class Funcionario
    {
        public Funcionario(string nome, string cPF, string rG, string email, string telefone, Endereco endereco, Cargo cargo, string senha)
        {
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Cargo = cargo;
            Senha = senha;
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public Cargo Cargo { get; set; }
        public string Senha { get; set; }


    }
}
