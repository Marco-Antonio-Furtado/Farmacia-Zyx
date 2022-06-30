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

        public Response LoginBLL(string email,string senha)
        {
            SingleResponse<Funcionario> response = FuncionarioDAL.LoginDAL(email);
            if(response.Item.Ativo == false)
            {
                return new Response("Funcionario Desabilitado", false);
            }
            if (response.Item.Senha == senha)
            {
                SystemParameters.Logar(response.Item);
                return new Response("login Certo", true);
            }
            else return new Response("login errado", false);
        }

        public Response Disable(int iDCLiente)
        {
            return funcionarioDAL.Disable(iDCLiente);
        }
    }
}
