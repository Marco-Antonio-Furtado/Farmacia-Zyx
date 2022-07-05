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
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIO_EMAIL"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueEmail();
                }
                if (ex.Message.Contains("UQ_FUNCIONARIO_CPF"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueCpf();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public Response Update(Funcionario item)
        {
            string sql = "UPDATE FUNCIONARIOS SET NOME_FUNCIONARIO = @NOME, RG = @RG, TELEFONE = @TELEFONE, ENDERECO = @ENDERECO, CARGO_ID = @CARGO_ID,ATIVO = @ATIVO, SENHA = @SENHA WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@NOME", item.Nome_Funcionario);
            command.Parameters.AddWithValue("@RG", item.RG);
            command.Parameters.AddWithValue("@TELEFONE", item.Telefone);
            command.Parameters.AddWithValue("@ENDERECO", item.Endereco.ID);
            command.Parameters.AddWithValue("@CARGO_ID", item.Cargo.ID);
            command.Parameters.AddWithValue("@SENHA", item.Senha);
            command.Parameters.AddWithValue("@ATIVO", item.Ativo);
            command.Parameters.AddWithValue("@ID", item.ID);

            try
            {
                DbExecuter dbexecuter = new DbExecuter();
                DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIOS_EMAIL"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueEmail();
                }
                if (ex.Message.Contains("UQ_FUNCIONARIOS_CPF"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueCpf();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
            return ResponseFactory.CreateInstance().CreateSuccessResponse();
        }
        public static SingleResponse<Funcionario> LoginDAL(string email)
        {
            string sql = $"SELECT F.ID,F.SENHA,F.NOME_FUNCIONARIO,CAR.NOME_CARGO,F.ATIVO FROM FUNCIONARIOS F INNER JOIN CARGOS CAR ON F.CARGO_ID = CAR.ID WHERE EMAIL = @EMAIL";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@EMAIL", email);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return DbExecuter.Login(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Funcionario>(null);
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
                DbExecuter.Execute(command);
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return ResponseFactory.CreateInstance().CreateSuccessResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public DataResponse<Funcionario> GetAll()
        {
            string sql = $"SELECT F.ID,F.NOME_FUNCIONARIO,F.CPF,F.RG,F.EMAIL,F.TELEFONE,CAR.NOME_CARGO,F.ATIVO,E.NOME_RUA,E.ID AS E_ID,CID.NOME_CIDADE FROM FUNCIONARIOS F INNER JOIN CARGOS CAR ON F.CARGO_ID = CAR.ID INNER JOIN ENDERECOS E ON F.ENDERECO = E.ID INNER JOIN CIDADES CID ON E.CIDADE_ID = CID.ID";

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
                    e.ID = (int)reader["E_ID"];
                    e.NomeRua = (string)reader["NOME_RUA"];

                    c.Nome_Cidade = (string)reader["NOME_CIDADE"];
                    F.Cargo = cargo;
                    F.Endereco = e;

                    F.Endereco.Cidade = c;

                    funcionarios.Add(F);
                }
                return ResponseFactory.CreateInstance().CreateDataSuccessResponse(funcionarios);
            }

            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateDataFailedResponse<Funcionario>();
            }
            finally
            {
                db.Close();
            }
        }
        public SingleResponse<Funcionario> GetByID(int id)
        {
            string sql = $"SELECT F.NOME_FUNCIONARIO,F.CPF,F.RG,F.EMAIL,F.TELEFONE,CAR.NOME_CARGO,F.ATIVO,E.NOME_RUA,E.ID AS E_ID,CID.NOME_CIDADE FROM FUNCIONARIOS F INNER JOIN CARGOS CAR ON F.CARGO_ID = CAR.ID INNER JOIN ENDERECOS E ON F.ENDERECO = E.ID INNER JOIN CIDADES CID ON E.CIDADE_ID = CID.ID WHERE F.ID = @ID";

            DbConnection db = new DbConnection();
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            db.AttachCommand(command);
            command.CommandText = sql;
            try
            {
                db.Open();
                SqlDataReader reader = command.ExecuteReader();
                    Funcionario Fun = new Funcionario();
                while (reader.Read())
                {
                    Cidade c = new Cidade();
                    Cargo cargo = new Cargo();
                    Endereco e = new Endereco();

                    
                    Fun.Nome_Funcionario = (string)reader["NOME_FUNCIONARIO"];
                    Fun.CPF = (string)reader["CPF"];
                    Fun.RG = (string)reader["RG"];
                    Fun.Email = (string)reader["EMAIL"];
                    Fun.Telefone = (string)reader["TELEFONE"];
                    Fun.Ativo = (bool)reader["ATIVO"];

                    cargo.Nome_Cargo = (string)reader["NOME_CARGO"];
                    e.ID = (int)reader["E_ID"];
                    e.NomeRua = (string)reader["NOME_RUA"];

                    c.Nome_Cidade = (string)reader["NOME_CIDADE"];
                    Fun.Cargo = cargo;
                    Fun.Endereco = e;

                    Fun.Endereco.Cidade = c;

                   
                }
                 return ResponseFactory.CreateInstance().CreateSingleSuccessResponse(Fun);
            }

            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Funcionario>(null);
            }
            finally
            {
                db.Close();
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
                return DbExecuter.GetItem<Funcionario>(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Funcionario>(null);
            }
        }
        public Response Disable(int id)
        {
            string sql = $"UPDATE FUNCIONARIO SET ATIVO = 0 WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
    }
}
