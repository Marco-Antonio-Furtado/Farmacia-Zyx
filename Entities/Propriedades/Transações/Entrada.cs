using Entities.Propriedades;

namespace Entities
{
    /// <summary>
    /// Classe de saida que herda de transação e sua funcao é representar cada entrada
    /// </summary>
    public class Entrada : Transacao
    {
        public Entrada()
        {
        }

        public Fornecedor IDFornecedor { get; set; }
       
    }
}
