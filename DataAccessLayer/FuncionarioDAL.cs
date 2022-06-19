using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FuncionarioDAL : ICRUD<Funcionario>
    {
        public Response Insert(Funcionario item)
        {
            return new Response("ta no banco", true);
        }

        public Response Update(Funcionario item)
        {
            return new Response("ta uptado banco", true);
        }
        public Response Delete(int id)
        {
            return new Response("ta deletado banco", true);
        }

        public DataResponse<Funcionario> GetAll()
        {
            List<Funcionario> testes = new List<Funcionario>();
            return new DataResponse<Funcionario>("ta getado com sucesso", true, testes);
        }

        public SingleResponse<Funcionario> GetByID(int id)
        {
            return new SingleResponse<Funcionario>("Foi getado do id!", true, null);

        }

        public SingleResponse<Funcionario> GetByEmail(string email)
        {
            return new SingleResponse<Funcionario>("foi quetado do email!", false, null);

        }
    }
}
