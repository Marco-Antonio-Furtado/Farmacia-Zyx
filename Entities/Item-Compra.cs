using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Item_Compra
    {
        public int ID { get; set; }
        public DateTime DataCompra { get; set; }

        public string ProdutoCompra { get; set; }
        public string NomeEmpresa/*fornecedor*/ { get; set; }
        public int Quantidade { get; set; }
        public int PrecoUnitario { get; set; }

        //sendo que o valor total deve ser calculado automaticamente pelo sistema???
        public double ValorTotal { get; set; }

        //Em uma entrada deverá ser possível a inserção de vários produtos distintos.

    }
}
