using Entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente
    {
        public Cliente(string nome, string cPF, string rG, string email, string telefone1, string telefone2)
        {
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Email = email;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }  
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public int ProgramaFidelidade { get; set; }
        public bool Ativo { get; set; }
    }

    //public override string ToString()
    //{
    //    return this.Nome + "\r\n" +
    //           this.CPF + "\r\n" +
    //           this.Email + "\r\n" +
    //           this.NomeResponsavel + "\r\n" +
    //           this.Telefone + "\r\n" +
    //           this.DataNascimento.ToString("dd/MM/yyyy") + "\r\n" +
    //           this.Genero + "\r\n" +
    //           this.Ativo + "\r\n" +
    //           this.Endereco.ToString() + "\r\n";
    //}
}

