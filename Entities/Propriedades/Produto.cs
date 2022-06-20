using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produto
    {
        public Produto(string nome, string descriscao, string laboratorio,double valorunitario)
        {
            Nome = nome;
            Descriscao = descriscao;
            Laboratorio = laboratorio;
            ValorUnitario = valorunitario;
            
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descriscao { get; set; }
        public double ValorUnitario { get; set; }
        public string Laboratorio { get; set; }
        public int QuantiaEstoque { get; set; }
        public bool Ativo { get; set; }

        //public double ValorCompra { get; set; }
        //public double ValorVenda { get; set; }

    }
}
