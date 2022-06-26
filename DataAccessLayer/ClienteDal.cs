using Shared;
using System.Data.SqlClient;
using Entities;



namespace DataAccessLayer
{
    public class ClienteDAL : ICRUD<Cliente>
    {
        internal const string DalDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\banco\BancoFarmaciaZYX.mdf;Integrated Security=True;Connect Timeout=30";

        public Response Insert(Cliente cliente)
        {
            string sql = $"INSERT INTO CLIENTES (NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2) VALUES (@NOME,@CPF,@RG,@EMAIL,@TELEFONE,@TELEFONE2)";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", cliente.Telefone2);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Cliente cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    return new Response("CPF já está em uso.", false);
                }
                return new Response(ex.Message, false);
            }
        }
        public Response Update(Cliente cliente)
        {

            string sql = $"UPDATE CLIENTES SET NOME = @NOME, CPF = @CPF, RG = @RG, EMAIL = @EMAIL, TELEFONE = @TELEFONE, TELEFONE2 = @TELEFONE2 WHERE ID = @ID";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", cliente.Telefone2);
            command.Parameters.AddWithValue("@ID", cliente.ID);


            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Cliente excluido.", false);
                }
                return new Response("Cliente alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    return new Response("Cpf já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Delete(int id)
        {
            string sql = "DELETE FROM CLIENTES WHERE ID = @ID";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Cliente excluído com sucesso.", true);
                }
                return new Response("Cliente não excluído.", false);
            }
            catch (Exception)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Cliente> GetAll()
        {

            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2,ATIVO FROM CLIENTES";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente(nome: Convert.ToString(reader["NOME"]),
                                                  cPF: Convert.ToString(reader["CPF"]),
                                                  rG: Convert.ToString(reader["RG"]),
                                                  email: Convert.ToString(reader["EMAIL"]),
                                                  telefone: Convert.ToString(reader["TELEFONE"]),
                                                  telefone2: Convert.ToString(reader["TELEFONE2"]));
                    cliente.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    clientes.Add(cliente);
                }
                return new DataResponse<Cliente>("Clientes selecionados com sucesso!", true, clientes);
            }
            catch (Exception)
            {
                return new DataResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Cliente> GetByID(int id)
        {

            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2 FROM CLIENTES WHERE ID = @ID";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cliente cliente = new Cliente(nome: Convert.ToString(reader["NOME"]),
                                                  cPF: Convert.ToString(reader["CPF"]),
                                                  rG: Convert.ToString(reader["RG"]),
                                                  email: Convert.ToString(reader["EMAIL"]),
                                                  telefone: Convert.ToString(reader["TELEFONE"]),
                                                  telefone2: Convert.ToString(reader["TELEFONE2"]));
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    return new SingleResponse<Cliente>("Cliente selecionado com sucesso!", true, cliente);
                }
                return new SingleResponse<Cliente>("Cliente não encontrado!", false, null);
            }
            catch (Exception)
            {
                return new SingleResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<Cliente> GetByEmail(string email)
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2 FROM CLIENTES WHERE EMAIL = @EMAIL";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@EMAIL", email);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cliente cliente = new Cliente(nome: Convert.ToString(reader["NOME"]),
                                                  cPF: Convert.ToString(reader["CPF"]),
                                                  rG: Convert.ToString(reader["RG"]),
                                                  email: Convert.ToString(reader["EMAIL"]),
                                                  telefone: Convert.ToString(reader["TELEFONE"]),
                                                  telefone2: Convert.ToString(reader["TELEFONE2"]));
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    return new SingleResponse<Cliente>("Cliente selecionado com sucesso!", true, cliente);
                }
                return new SingleResponse<Cliente>("Cliente não encontrado!", false, null);
            }
            catch (Exception)
            {
                return new SingleResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Cliente> GetByCPF(string cpf)
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2 FROM CLIENTES WHERE CPF = @CPF";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CPF", cpf);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    Cliente cliente = new Cliente(nome: Convert.ToString(reader["NOME"]),
                                                  cPF: Convert.ToString(reader["CPF"]),
                                                  rG: Convert.ToString(reader["RG"]),
                                                  email: Convert.ToString(reader["EMAIL"]),
                                                  telefone: Convert.ToString(reader["TELEFONE"]),
                                                  telefone2: Convert.ToString(reader["TELEFONE2"]));
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    return new SingleResponse<Cliente>("Cliente selecionado com sucesso!", true, cliente);
                }
                return new SingleResponse<Cliente>("Cliente não encontrado!", false, null);
            }
            catch (Exception)
            {
                return new SingleResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {

                connection.Dispose();
            }
        }
    }
}