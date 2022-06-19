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
    public class ClienteBll : ICRUD<Cliente>
    {
        private ClienteDAL clienteDAL = new ClienteDAL();
        public Response Insert(Cliente item)
        {
            ClienteValidator clienteValidator = new ClienteValidator();
            Response resposta = clienteValidator.Validate(item);
            if (resposta.HasSuccess)
            {
                clienteDAL.Insert(item);
            }
                return resposta;
        }

        public Response Update(Cliente item)
        {
            throw new NotImplementedException();
        }
        public Response Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataResponse<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }
        public SingleResponse<Cliente> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Cliente> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
