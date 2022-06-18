using Entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Funcionario
    {
        public Funcionario(string nome, string cPF, string rG, string email, string telefone1, Endereco endereco,string senha)
        {
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Email = email;
            Telefone1 = telefone1;
            Endereco = endereco;
            Senha = senha;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public Endereco Endereco { get; set; }
        public Hierarquia PosicaoHierarquica { get; set; }
        public string Senha { get; set; }

    }
}
