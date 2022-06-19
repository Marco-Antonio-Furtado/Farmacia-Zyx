using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FornecedorDAL : ICRUD<Fornecedor>
    {
        public Response Insert(Fornecedor item)
        {
            return new Response("ta no banco", true);
        }

        public Response Update(Fornecedor item)
        {
            return new Response("ta uptado banco", true);

        }
        public Response Delete(int id)
        {
            return new Response("ta deletado banco", true);

        }

        public DataResponse<Fornecedor> GetAll()
        {
            List<Fornecedor> testes = new List<Fornecedor>();
            return new DataResponse<Fornecedor>("ta getado com sucesso", true, testes);

        }

        public SingleResponse<Fornecedor> GetByID(int id)
        {
            return new SingleResponse<Fornecedor>("Foi getado do id!", true, null);

        }

        public SingleResponse<Fornecedor> GetByEmail(string email)
        {
            return new SingleResponse<Fornecedor>("foi quetado do email!", false, null);

        }
    }
}

