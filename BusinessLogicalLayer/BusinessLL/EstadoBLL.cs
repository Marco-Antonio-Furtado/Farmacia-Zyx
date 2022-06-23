using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class EstadoBLL : ICRUD<Estado>
    {
        EnderecoValitor enderecoValitor = new EnderecoValitor();
        EstadoDAL EstadoDal = new EstadoDAL();  
        public Response Insert(Estado item)
        {
            Response resposta = enderecoValitor.ValidateEstado(item);
            if (resposta.HasSuccess)
            {
                return EstadoDal.Insert(item);
            }
            else { return resposta; }
        }
        public Response Update(Estado item)
        {
            Response resposta = enderecoValitor.ValidateEstado(item);
            if (resposta.HasSuccess)
            {
                return EstadoDal.Update(item);
            }
            else { return resposta; }
        }
        public Response Delete(int id)
        {
            return EstadoDal.Delete(id);
        }

        public DataResponse<Estado> GetAll()
        {
            return EstadoDal.GetAll();
        }

        public SingleResponse<Estado> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Estado> GetByID(int id)
        {
            return EstadoDal.GetByID(id);
        }

    }
}
