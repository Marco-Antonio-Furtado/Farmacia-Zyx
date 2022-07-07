using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;
using System.Transactions;

namespace BusinessLogicalLayer.BusinessLL
{
    /// <summary>
    /// Meio para ligar o banco de dados de Funcionario com a tela 
    /// e fazendo sua regras de negocios onde no caso de Funcionario Sao validacoes
    /// o insert e o uptade tem o TransactionScope de endereco junto pois nao pode haver um endereco sem funcionario 
    /// </summary>
    public class FuncionarioBll : ICRUD<Funcionario>
    {
        FuncionarioDAL funcionarioDAL = new();
        EnderecoDAL enderecoDAL = new();
        public Response Insert(Funcionario funcionario)
        {
            Response response = FuncionarioValidator.Validate(funcionario);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new())
                {
                    response = enderecoDAL.Insert(funcionario.Endereco);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    funcionario.Senha = HashSenha.ComputeSha256Hash(funcionario.Senha);
                    response = funcionarioDAL.Insert(funcionario);

                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }
            }
            return response;
        }
        public Response Update(Funcionario funcionario)
        {
            Response response = FuncionarioValidator.Validate(funcionario);
            if (response.HasSuccess)
            {
                {
                    using (TransactionScope scope = new())
                    {
                        EnderecoDAL enderecoDAL = new();

                        response = enderecoDAL.Update(funcionario.Endereco);
                        funcionario.Senha = HashSenha.ComputeSha256Hash(funcionario.Senha);

                        if (!response.HasSuccess)
                        {
                            return response;
                        }
                        response = funcionarioDAL.Update(funcionario);

                        if (!response.HasSuccess)
                        {
                            return response;
                        }
                        scope.Complete();
                    }
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
        public SingleResponse<Funcionario> GetByID(int id)
        {
            return funcionarioDAL.GetByID(id);
        }
        public Response LoginBLL(string email, string senha)
        {
            SingleResponse<Funcionario> response = FuncionarioDAL.LoginDAL(email);
            if (response.Item.Ativo == false)
            {
                return new Response("NOME_FUNCIONARIO Desabilitado", false);
            }
            if (response.Item.Senha == HashSenha.ComputeSha256Hash(senha))
            {
                SystemParameters.Logar(response.Item);
                return new Response("login Certo", true);
            }
            else return new Response("login errado", false);
        }
        public Response Disable(int FunID)
        {
            return funcionarioDAL.Disable(FunID);
        }
    }
}
