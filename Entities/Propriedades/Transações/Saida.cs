using Entities.Propriedades;

namespace Entities
{
    /// <summary>
    /// Classe de saida que herda de transação e sua funcao é representar cada saida
    /// </summary>
    public class Saida : Transacao
    {
       
        public Cliente Cliente { get; set; }

        
    }
}
