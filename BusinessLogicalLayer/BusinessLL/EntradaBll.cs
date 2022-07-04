using BusinessLogicalLayer.RegraDePreco;
using BusinessLogicalLayer.RegraEstoque;
using DataAccessLayer;
using Entities;
using Entities.viewmodel;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class EntradaBll
    {
        EntradaDal entradaDal = new EntradaDal();
        RegraControleEstoque regraEstoque = new RegraControleEstoque();
    
        public Response Insert(Entrada entrada)
        {
            Response estoqueResponse = RegraControleEstoque.EstoqueEntrada(entrada);
            if (!estoqueResponse.HasSuccess)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
            if(!RegraPrecoProduto.AtualizarPrecos(entrada, 20).HasSuccess )
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
        public SingleResponse<Entrada> GetByID(int id)
        {
            return entradaDal.GetByID(id);
        }

    }
}
