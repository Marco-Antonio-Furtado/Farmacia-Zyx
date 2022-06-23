using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class EnderecoBll : ICRUD<Endereco>
    {
        private EnderecoDAL EnderecoDAL = new EnderecoDAL();
        private EnderecoValitor enderecoValitor = new EnderecoValitor();
        public Response Insert(Endereco item)
        {
            Response resposta = enderecoValitor.Validate(item);
            if (resposta.HasSuccess)
            {
                EnderecoDAL.Insert(item);
            }
            return resposta;
        }

        public Response Update(Endereco item)
        {
            Response resposta = enderecoValitor.Validate(item);
            if (resposta.HasSuccess)
            {
                return EnderecoDAL.Update(item);
            }
            else { return resposta; }
        }
        public Response Delete(int id)
        {
            return EnderecoDAL.Delete(id);
        }

        public DataResponse<Endereco> GetAll()
        {
            return EnderecoDAL.GetAll();

        }
        public SingleResponse<Endereco> GetByID(int id)
        {
            return EnderecoDAL.GetByID(id);
        }

        public SingleResponse<Endereco> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

    }
}
