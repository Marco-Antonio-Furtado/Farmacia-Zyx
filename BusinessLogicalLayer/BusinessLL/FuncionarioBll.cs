using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;
using System.Transactions;

namespace BusinessLogicalLayer.BusinessLL
{
    public class FuncionarioBll : ICRUD<Funcionario>
    {
        FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        public Response Insert(Funcionario funcionario)
        {
            Response response = FuncionarioValidator.Validate(funcionario);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
                    EnderecoDAL enderecoDAL = new EnderecoDAL();

                    response = enderecoDAL.Insert(funcionario.Endereco);
                    response = funcionarioDAL.Insert(funcionario);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }//scope.Dispose();
            }
            return response;


        }

        public Response Update(Funcionario item)
        {
            Response resposta = FuncionarioValidator.Validate(item);
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
