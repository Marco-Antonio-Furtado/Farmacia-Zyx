using BusinessLogicalLayer.Verificaçoes;
using Entities;
using Shared;
using DataAccessLayer;

namespace BusinessLogicalLayer.BusinessLL
{
    public class FornecedorBll : ICRUD<Fornecedor>
    {
        FornecedorDAL fornecedorDAL = new FornecedorDAL();
        public Response Insert(Fornecedor item)
        {
            Response resposta = FornecedorValidator.Validate(item);
            if (resposta.HasSuccess)
            {
                return fornecedorDAL.Insert(item);
            }
            else { return resposta; }
        }
        public Response Update(Fornecedor item)
        {
            Response Resposta = FornecedorValidator.Validate(item);
            if (Resposta.HasSuccess)
            {
                return fornecedorDAL.Update(item);
            }
            else { return Resposta; }
        }
        public Response Delete(int id)
        {
            return fornecedorDAL.Delete(id);
        }

        public DataResponse<Fornecedor> GetAll()
        {
            return fornecedorDAL.GetAll();
        }

        public SingleResponse<Fornecedor> GetByID(int id)
        {
            return fornecedorDAL.GetByID(id);
        }
        public SingleResponse<Fornecedor> GetByEmail(string email)
        {
            return fornecedorDAL.GetByEmail(email);
        }
    }
}
