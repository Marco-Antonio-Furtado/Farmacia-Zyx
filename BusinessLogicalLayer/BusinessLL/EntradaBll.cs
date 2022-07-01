using BusinessLogicalLayer.RegraDePreco;
using DataAccessLayer;
using Entities;
using Entities.viewmodel;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class EntradaBll
    {
        EntradaDal entradaDal = new EntradaDal();
        RegraControleEstoque Regra = new RegraControleEstoque();
        public Response Insert(Entrada item)
        {
            SingleResponse<Entrada> single = entradaDal.EfetuarTransacao(item);
            if (single.HasSuccess)
            {
                Regra.EstoqueProduto(single.Item);
            }
            return new Response("chato", false);
        }
        public DataResponse<EntradaViewModel> GetAll(DateTime inicio, DateTime fim)
        {
            return entradaDal.LerTransacoes( inicio,  fim);
        }
        
        public SingleResponse<Entrada> GetByID(int id)
        {
            return entradaDal.GetByID(id);
        }

    }
}
