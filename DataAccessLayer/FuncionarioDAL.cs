using Entities;
using Entities.Propriedades;
using Shared;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class FuncionarioDAL : ICRUD<Funcionario>
    {
        public Response Insert(Funcionario item)
        {
            string sql = $"INSERT INTO FUNCIONARIOS (NOME_FUNCIONARIO,CPF,RG,EMAIL,TELEFONE,ENDERECO,CARGO_ID,SENHA) VALUES (@NOME,@CPF,@RG,@EMAIL,@TELEFONE,@ENDERECO,@CARGO_ID,@SENHA)";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@NOME", item.Nome_Funcionario);
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
            string sql = "UPDATE FUNCIONARIOS SET NOME_FUNCIONARIO = @NOME, CPF = @CPF, RG = @RG, EMAIL = @EMAIL, TELEFONE = @TELEFONE, ENDERECO = @ENDERECO, CARGO_ID = @CARGO_ID, SENHA = @SENHA";
            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@NOME", item.Nome_Funcionario);
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

        public SingleResponse<Funcionario> LoginDAL(string email)
        {
            string sql = $"SELECT F.SENHA,F.NOME_FUNCIONARIO,CAR.NOME_CARGO FROM FUNCIONARIOS F INNER JOIN CARGOS CAR ON F.CARGO_ID = CAR.ID WHERE EMAIL = @EMAIL";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@EMAIL", email);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.lOGIN(command);
            }
            catch (Exception ex )
            {
                return new SingleResponse<Funcionario>(ex.Message, false, null);
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
            string sql = $"SELECT F.ID,F.NOME_FUNCIONARIO,F.CPF,F.RG,F.EMAIL,F.TELEFONE,CAR.NOME_CARGO,F.ATIVO,E.NOME_RUA,CID.NOME_CIDADE FROM FUNCIONARIOS F INNER JOIN CARGOS CAR ON F.CARGO_ID = CAR.ID INNER JOIN ENDERECOS E ON F.ENDERECO = E.ID INNER JOIN CIDADES CID ON E.CIDADE_ID = CID.ID";

            DbConnection db = new DbConnection();
            SqlCommand command = new SqlCommand(sql);
            db.AttachCommand(command);
            command.CommandText = sql;
            try
            {
                db.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();
                while (reader.Read())
                {
                    Cidade c = new Cidade();
                    Funcionario F = new Funcionario();
                    Cargo cargo = new Cargo();
                    Endereco e = new Endereco();

                    F.ID = (int)reader["ID"];
                    F.Nome_Funcionario = (string)reader["NOME_FUNCIONARIO"];
                    F.CPF = (string)reader["CPF"];
                    F.RG = (string)reader["RG"];
                    F.Email = (string)reader["EMAIL"];
                    F.Telefone = (string)reader["TELEFONE"];
                    F.Ativo = (bool)reader["ATIVO"];
                    
                    cargo.Nome_Cargo = (string)reader["NOME_CARGO"];
                    
                    e.NomeRua = (string)reader["NOME_RUA"];
                    
                    c.Nome_Cidade = (string)reader["NOME_CIDADE"];
                    F.Cargo = cargo;
                    F.Endereco = e;

                    F.Endereco.Cidade = c;

                    funcionarios.Add(F);
                }
                DataResponse<Funcionario> response = new DataResponse<Funcionario>("DADOS SELECIONADOS COM SUCESSO", true, funcionarios);
                return response;
            }

            catch (Exception ex)
            {
                return new DataResponse<Funcionario>(ex.Message, false, null);
            }
            finally
            {
                db.Close();
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

        public Response Disable(int id)
        {
            throw new NotImplementedException();
        }
    }
}
