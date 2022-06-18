using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class FornecedorDAL : ICRUD<Fornecedor>
    {
        public Response Insert(Fornecedor item)
        {
            throw new NotImplementedException();
        }

        public Response Update(Fornecedor item)
        {
            throw new NotImplementedException();
        }
        public Response Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataResponse<Fornecedor> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Fornecedor> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Fornecedor> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}

