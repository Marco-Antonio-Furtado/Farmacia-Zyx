using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class SaidaBll
    {
        SaidaDAL saidaDAL = new SaidaDAL();
        public Response Insert(Saida item)
        {
            return saidaDAL.EfetuarSaida(item);
        }
        public DataResponse<Saida> GetAll(DateTime inicio, DateTime fim)
        {
            return saidaDAL.LerSaidas(inicio,fim);
        }
        public SingleResponse<Saida> GetByID(int id)
        {
            return saidaDAL.GetByID(id);
        }

    }
}
