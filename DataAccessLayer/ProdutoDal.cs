using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProdutoDal : ICRUD<Produto>
    {
        public Response Insert(Produto item)
        {
            return new Response("ta no banco",true);
        }

        public Response Update(Produto item)
        {
            return new Response("ta uptado do banco", true);
        }
        public Response Delete(int id)
        {
            return new Response("ta deletado banco", true);
        }

        public DataResponse<Produto> GetAll()
        {
            List<Produto> testes = new List<Produto>();
            return new DataResponse<Produto>("ta getado com sucesso", true, testes);
        }

        public SingleResponse<Produto> GetByID(int id)
        {
            return new SingleResponse<Produto>("Foi getado do id!", true, null);
        }

        public SingleResponse<Produto> GetByEmail(string email)
        {
            return new SingleResponse<Produto>("Foi getado do email!", true, null);
        }
    }
}
