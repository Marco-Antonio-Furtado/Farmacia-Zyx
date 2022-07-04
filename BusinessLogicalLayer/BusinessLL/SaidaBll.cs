using BusinessLogicalLayer.RegraDePreco;
using BusinessLogicalLayer.RegraEstoque;
using DataAccessLayer;
using Entities;
using Entities.viewmodel;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class SaidaBll
    {
        SaidaDAL saidaDAL = new SaidaDAL();

   
        public Response Insert(Saida transacao)
        {
           return RegraControleEstoque.EstoqueSaida(transacao);

        }
        public DataResponse<SaidaViewModel> LerTransacoes(DateTime inicio, DateTime fim)
        {
            return saidaDAL.LerTransacoes(inicio,fim);
        }
        public DataResponse<SaidaViewModel> GetAll()
        {
            return saidaDAL.GetAll();
        }
        public SingleResponse<Saida> GetByID(int id)
        {
            return saidaDAL.GetByID(id);
        }

    }
}
