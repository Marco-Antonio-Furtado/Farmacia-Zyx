using BusinessLogicalLayer.RegrasValidacao;
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
        private ClienteValidator clienteValidator = new ClienteValidator();
        private ClienteDAL clienteDAL = new ClienteDAL();
        public Response Insert(Cliente item)
        {
            Response resposta = clienteValidator.Validate(item);
            if (resposta.HasSuccess)
            {
                clienteDAL.Insert(item);
            }
                return resposta;
        }

        public Response Update(Cliente item)
        {
            Response resposta = clienteValidator.Validate(item);
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
