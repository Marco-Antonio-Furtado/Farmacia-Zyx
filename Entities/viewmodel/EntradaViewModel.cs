using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.viewmodel
{
    public class EntradaViewModel
    {
        public int TransacaoID { get; set; }
        public string ProdutoNome { get; set; }
        public double ValorTotal { get; set; }
        public double Quantidade { get; set; }
        public string FormaPagamento { get; set; }
        public string Fornecedor { get; set; }
        public string Funcionario { get; set; }
        public DateTime Data { get; set; }
    }
}
