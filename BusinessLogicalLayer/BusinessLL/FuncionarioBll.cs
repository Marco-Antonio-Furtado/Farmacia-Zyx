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
        EnderecoDAL enderecoDAL = new EnderecoDAL();

        public Response Insert(Funcionario funcionario)
        {
            Response response = FuncionarioValidator.Validate(funcionario);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
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
            Response response = FuncionarioValidator.Validate(item);
            if (response.HasSuccess)
            {
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        EnderecoDAL enderecoDAL = new EnderecoDAL();

                        response = enderecoDAL.Update(item.Endereco);
                        response = funcionarioDAL.Update(item);
                        if (!response.HasSuccess)
                        {
                            return response;
                        }
                        scope.Complete();
                    }//scope.Dispose();
                }
                return response;
            }
            else { return response; }
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
