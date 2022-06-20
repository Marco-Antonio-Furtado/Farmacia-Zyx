using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BusinessLL
{
    public class ProdutoBll : ICRUD<Produto>
    {
        ProdutoDal produtoDAL = new ProdutoDal();
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
            throw new NotImplementedException();
        }

        public SingleResponse<Produto> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Produto> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
