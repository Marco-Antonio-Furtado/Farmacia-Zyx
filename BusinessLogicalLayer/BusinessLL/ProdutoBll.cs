using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class ProdutoBll : ICRUD<Produto>
    {
        readonly ProdutoDal produtoDAL = new ProdutoDal();
        ProdutoValidator produtoValidator = new ProdutoValidator();
        public Response Insert(Produto item)
        {
            
            Response resposta = produtoValidator.ValidateIten(item);
            if (resposta.HasSuccess)
            {
                return produtoDAL.Insert(item);
            }
            else { return resposta; }
        }

        public Response Update(Produto item)
        {
            Response resposta = produtoValidator.ValidateIten(item);
            if (resposta.HasSuccess)
            {
               return produtoDAL.Update(item);
            }
            else { return resposta; }
        }
        public Response Delete(int id)
        {
            return produtoDAL.Delete(id);
        }

        public DataResponse<Produto> GetAll()
        {
            return produtoDAL.GetAll();
        }

        public SingleResponse<Produto> GetByID(int id)
        {
            return produtoDAL.GetByID(id);
        }

        public SingleResponse<Produto> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
