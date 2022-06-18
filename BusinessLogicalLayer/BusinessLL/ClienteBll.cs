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
        public Response Insert(Cliente item)
        {
            ClienteValidator clienteValidator = new ClienteValidator();
            return clienteValidator.Validate(item);








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
