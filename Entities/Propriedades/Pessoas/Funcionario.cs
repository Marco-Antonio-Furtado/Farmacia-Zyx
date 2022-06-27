using Entities.Propriedades.Pessoas;
using Shared;

namespace Entities
{
    public class Funcionario : Pessoa
    {
        public Funcionario()
        {
        }

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
        public Endereco Endereco { get; set; }
        public Cargo Cargo { get; set; }
        public string Senha { get; set; }

        public override string ToString()
        {
            return this.Nome + "\r\n" +
                   this.CPF + "\r\n" +
                   this.Email + "\r\n" +
                   this.Telefone + "\r\n" +
                   this.Ativo + "\r\n" +
                   this.Endereco.ToString() + "\r\n" +
                   this.Cargo.ToString();
        }





    }
}
