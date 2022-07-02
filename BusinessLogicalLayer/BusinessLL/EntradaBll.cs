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
        RegraDeNovoPreco NovoPreco = new RegraDeNovoPreco();
        public Response Insert(Entrada item)
        {
            SingleResponse<Entrada> single = entradaDal.EfetuarTransacao(NovoPreco.RefaturarPreco(item).Item);
            if (single.HasSuccess)
            {
                Response Resposta = Regra.EstoqueProduto(single.Item);
                if (Resposta.HasSuccess)
                {
                    return ResponseFactory.CreateInstance().CreateSuccessResponse();
                }
            }
            return ResponseFactory.CreateInstance().CreateFailedResponse();
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
