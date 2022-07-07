using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    /// <summary>
    /// Meio para ligar o banco de dados de Clientes com a tela 
    /// e fazendo sua regras de negocios onde no caso de cliente Sao validacoes
    /// </summary>
    public class ClienteBll : ICRUD<Cliente>
    {
        private ClienteDAL clienteDAL = new();
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
        public Response Disable(int iDCLiente)
        {
            return clienteDAL.Disable(iDCLiente);
        }
    }
}
