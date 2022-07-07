using BusinessLogicalLayer.RegraDePreco;
using BusinessLogicalLayer.RegraEstoque;
using Entities;
using Entities.viewmodel;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    /// <summary>
    /// Meio para ligar o banco de dados Das entradas de produtos com a tela
    /// e fazendo sua regras de negocios onde no caso de das entradas das vendas sao
    /// as regras de estoque e regras de novo preco de produto
    /// </summary>
    public class EntradaBll
    {
        EntradaDal entradaDal = new();
        public Response Insert(Entrada entrada)
        {
            if(!RegraPrecoProduto.AtualizarPrecos(entrada, 20).HasSuccess )
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
            if (!RegraControleEstoque.EstoqueEntrada(entrada).HasSuccess)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
            if (!entradaDal.EfetuarTransacao(entrada).HasSuccess)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
            return ResponseFactory.CreateInstance().CreateSuccessResponse();     
        }
        public Response Insert(Entrada entrada, double taxaDeLucro)
        {
            Response estoqueResponse = RegraControleEstoque.EstoqueEntrada(entrada);
            if (!estoqueResponse.HasSuccess)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
            if(!RegraPrecoProduto.AtualizarPrecos(entrada, taxaDeLucro).HasSuccess )
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
            return ResponseFactory.CreateInstance().CreateSuccessResponse();  
        }
        public DataResponse<EntradaViewModel> LerTransacoes(DateTime inicio, DateTime fim)
        {
            return entradaDal.LerTransacoes( inicio,  fim);
        }
        public DataResponse<EntradaViewModel> GetAll()
        {
            return entradaDal.GetAll();
        }
    }
}
