using BusinessLogicalLayer.Verificaçoes;
using Entities;
using Shared;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BusinessLL
{
    public class FornecedorBll : ICRUD<Fornecedor>
    {
        FornecedorDAL fornecedorDAL = new FornecedorDAL();
        FornecedorValidator fornecedorValidate = new FornecedorValidator();

        public Response Insert(Fornecedor item)
        {
            Response resposta = fornecedorValidate.Validate(item);
            if (resposta.HasSuccess)
            {
                return fornecedorDAL.Insert(item);
            }
            else { return resposta; }
        }

        public Response Update(Fornecedor item)
        {
            Response Resposta = fornecedorValidate.Validate(item);
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
