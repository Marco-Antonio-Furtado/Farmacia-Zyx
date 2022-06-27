using Entities;
using Shared;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class FuncionarioDAL : ICRUD<Funcionario>
    {
        public Response Insert(Funcionario item)
        {
            string sql = $"INSERT INTO FUNCIONARIOS (NOME,CPF,RG,EMAIL,TELEFONE,ENDERECO,CARGO_ID,SENHA) VALUES (@NOME,@CPF,@RG,@EMAIL,@TELEFONE,@ENDERECO,@CARGO_ID,@SENHA)";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@CPF", item.CPF);
            command.Parameters.AddWithValue("@RG", item.RG);
            command.Parameters.AddWithValue("@EMAIL", item.Email);
            command.Parameters.AddWithValue("@TELEFONE", item.Telefone);
            command.Parameters.AddWithValue("@ENDERECO", item.Endereco.ID);
            command.Parameters.AddWithValue("@CARGO_ID", item.Cargo.ID);
            command.Parameters.AddWithValue("@SENHA", item.Senha);

            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                dbExecuter.Execute(command);
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIO_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIO_CPF"))
                {
                    return new Response("CPF já está em uso.", false);
                }
                return new Response(ex.Message, false);
            }
        }

        public Response Update(Funcionario item)
        {
            string sql = "UPDATE FUNCIONARIOS SET NOME = @NOME, CPF = @CPF, RG = @RG, EMAIL = @EMAIL, TELEFONE = @TELEFONE, ENDERECO = @ENDERECO, CARGO_ID = @CARGO_ID, SENHA = @SENHA";
            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@CPF", item.CPF);
            command.Parameters.AddWithValue("@RG", item.RG);
            command.Parameters.AddWithValue("@EMAIL", item.Email);
            command.Parameters.AddWithValue("@TELEFONE", item.Telefone);
            command.Parameters.AddWithValue("@ENDERECO", item.Endereco);
            command.Parameters.AddWithValue("@CARGO_ID", item.Cargo);
            command.Parameters.AddWithValue("@SENHA", item.Senha);

            try
            {
                DbExecuter dbexecuter = new DbExecuter();
                dbexecuter.Execute(command);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("UQ_FUNCIONARIO_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIO_CPF"))
                {
                    return new Response("CPF já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            return new Response("Funcionario alterado com sucesso", true);


        }

        public string LoginDAL(string email, string senha)
        {
            string sql = $"SELECT SENHA FROM FUNCIONARIOS WHERE EMAIL = @EMAIL";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@EMAIL", email);
            command.Parameters.AddWithValue("@SENHA", senha);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.lOGIN(command);
            }
            catch (Exception)
            {
                return "deu ruim";
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM FUNCIONARIOS WHERE ID = @ID";
            DbExecuter dbexecuter = new DbExecuter();

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);

            try
            {
                dbexecuter.Execute(command);
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Funcionario excluído com sucesso.", true);
                }
                return new Response("Funcionario não excluído.", false);
            }
            catch (Exception)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
        }
        public DataResponse<Funcionario> GetAll()
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,ENDERECO,CARGO_ID,ATIVO,SENHA FROM FUNCIONARIOS";
            SqlCommand command = new SqlCommand(sql);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetData<Funcionario>(command);
            }
            catch (Exception ex)
            {
                return new DataResponse<Funcionario>(ex.Message, false, null);
            }
        }

        public SingleResponse<Funcionario> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,ENDERECO,CARGO_ID,ATIVO,SENHA FROM FUNCIONARIOS WHERE ID = @ID";
            
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetItem<Funcionario>(command);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Funcionario>(ex.Message, false, null);
            }
        }

        public SingleResponse<Funcionario> GetByEmail(string email)
        {
            string query = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,ENDERECO,CARGO_ID,ATIVO,SENHA FROM FUNCIONARIO WHERE EMAIL = @EMAIL";
            
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@EMAIL", email);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetItem<Funcionario>(command);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Funcionario>(ex.Message, false, null);
            }
        }
    }
}
