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
        public string ProdutoCompra { get; set; }
        public string NomeEmpresa { get; set; }
        public int Quantidade { get; set; }
        public int PrecoUnitario { get; set; }

    }
}
