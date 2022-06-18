using BusinessLogicalLayer.Verificaçoes;
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
        public Response Insert(Produto item)
        {
            ProdutoValidator produtoValidator = new ProdutoValidator();
            return produtoValidator.ValidateIten(item);
        }

        public Response Update(Produto item)
        {
            throw new NotImplementedException();
        }
        public Response Delete(int id)
        {
            throw new NotImplementedException();
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
