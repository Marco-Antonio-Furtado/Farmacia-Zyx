using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class FuncionarioBll : ICRUD<Funcionario>
    {
        FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
        FuncionarioValidator funcionarioValidator = new FuncionarioValidator();

        public Response Insert(Funcionario item)
        {
            Response resposta = funcionarioValidator.Validate(item);
            if (resposta.HasSuccess)
            {
                return funcionarioDAL.Insert(item);
            }
            else { return resposta; }
        }

        public Response Update(Funcionario item)
        {
            Response resposta = funcionarioValidator.Validate(item);
            if (resposta.HasSuccess)
            {
                return funcionarioDAL.Update(item);
            }
            else { return resposta; }
        }
        public Response Delete(int id)
        {
            return funcionarioDAL.Delete(id);
        }

        public DataResponse<Funcionario> GetAll()
        {
            return funcionarioDAL.GetAll();
        }

        public SingleResponse<Funcionario> GetByEmail(string email)
        {
            return funcionarioDAL.GetByEmail(email);

        }
        public SingleResponse<Funcionario> GetByID(int id)
        {
            return funcionarioDAL.GetByID(id);

        }

    }
}
