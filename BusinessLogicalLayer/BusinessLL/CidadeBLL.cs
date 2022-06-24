using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Entities.Propriedades;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class CidadeBLL : ICRUD<Cidade>
    {
        private EnderecoValitor enderecoValitor = new EnderecoValitor();
        private CidadeDAL cidadeDAL = new CidadeDAL();
        public Response Insert(Cidade item)
        {
            Response resposta = EnderecoValitor.ValidateCidade(item);
            if (resposta.HasSuccess)
            {
                return cidadeDAL.Insert(item);
            }
            else { return resposta; }
        }
        public Response Update(Cidade item)
        {
            Response resposta = EnderecoValitor.ValidateCidade(item);
            if (resposta.HasSuccess)
            {
                return cidadeDAL.Update(item);
            }
            else { return resposta; }
        }
 
        public Response Delete(int id)
        {
            return cidadeDAL.Delete(id);
        }

        public DataResponse<Cidade> GetAll()
        {
            return cidadeDAL.GetAll();
        }

        public SingleResponse<Cidade> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Cidade> GetByID(int id)
        {
            return cidadeDAL.GetByID(id);
        }

    }
}
