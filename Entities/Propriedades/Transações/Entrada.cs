using Entities.Propriedades;

namespace Entities
{
    public class Entrada : Transacao
    {
        public Entrada()
        {
        }

        public Fornecedor IDFornecedor { get; set; }
       
    }
}
