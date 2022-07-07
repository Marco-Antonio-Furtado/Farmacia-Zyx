using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.viewmodel
{
    public class EntradaViewModel
    {
        public double Valor_Unitario { get; set; }   
        public int ENTRADA_ID { get; set; }
        public string NOME_PRODUTO { get; set; }
        public double preco { get; set; }
        public double Quantidade { get; set; }
        public string FORMA_PAGAMENTO { get; set; }
        public string RAZAO_SOCIAL { get; set; }
        public string NOME_FUNCIONARIO { get; set; }
        public DateTime DATA_ENTRADA { get; set; }
    }
}
