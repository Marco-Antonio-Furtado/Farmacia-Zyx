using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.viewmodel
{
    public class SaidaViewModel
    {
        public int SAIDA_ID { get; set; }
        public string NOME_PRODUTO { get; set; }
        public double VALOR_UNITARIO { get; set; }
        public double Quantidade { get; set; }
        public string FORMA_PAGAMENTO { get; set; }
        public string NOME_FUNCIONARIO { get; set; }
        public string NOME_CLIENTE { get; set; }
        public double VALOR { get; set; }
        public DateTime DATA_SAIDA { get; set; }
    }
}
