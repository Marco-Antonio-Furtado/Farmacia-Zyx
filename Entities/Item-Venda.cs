using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Item_Venda
    {
        public int ID { get; set; }
        public string ProdutoVenda { get; set; }
        public string NomeCliente { get; set; }
        public string NomeFuncionario { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double ValorTotal;
    }
}
