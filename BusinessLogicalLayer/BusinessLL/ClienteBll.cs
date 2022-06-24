using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class ClienteBll : ICRUD<Cliente>
    {
        private ClienteValidator clienteValidator = new ClienteValidator();
        private ClienteDAL clienteDAL = new ClienteDAL();
        public Response Insert(Cliente item)
        {
            Response resposta = ClienteValidator.Validate(item);
            if (resposta.HasSuccess)
            {
                return clienteDAL.Insert(item);
            }
            else { return resposta; }
        }
        public Response Update(Cliente item)
        {
            Response resposta = ClienteValidator.Validate(item);
            if(resposta.HasSuccess)
            {
                return clienteDAL.Update(item);
            }
            else { return resposta; }
        }
        public Response Delete(int id)
        {
            return clienteDAL.Delete(id);
        }

        public DataResponse<Cliente> GetAll()
        {
            return clienteDAL.GetAll(); 
        }
        public SingleResponse<Cliente> GetByID(int id)
        {
            return clienteDAL.GetByID(id);
        }

        public SingleResponse<Cliente> GetByEmail(string email)
        {
            return clienteDAL.GetByEmail(email);
        }
        public SingleResponse<Cliente> GetByCPF(string cpf)
        {
            return clienteDAL.GetByCPF(cpf);
        }
    }
}
