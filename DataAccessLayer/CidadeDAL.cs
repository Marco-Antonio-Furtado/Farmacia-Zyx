using Entities;
using Entities.Propriedades;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CidadeDAL : ICRUD<Cidade>
    {
        internal const string DalDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\AdultMovieLocatorDb.mdf;Integrated Security=True;Connect Timeout=3";
        public Response Insert(Cidade item)
        {
            string sql = $"INSERT INTO CIDADES (NOME) VALUES (@NOME)";
            string connectionString = DalDirectory;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", item.Nome);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Cidade cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public Response Update(Cidade item)
        {
            string sql = $"UPDATE CIDADE SET NOME = @NOME WHERE ID = @ID";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@ID", item.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Cidade excluido.", false);
                }
                return new Response("Cidade alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM CIDADE WHERE ID = @ID";

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
                    return new Response("Cidade excluído com sucesso.", true);
                }
                return new Response("Cidade não excluído.", false);
            }
            catch (Exception ex)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<Cidade> GetAll()
        {

            string sql = $"SELECT ID,NOME FROM CIDADE";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cidade> Cidades = new List<Cidade>();
                while (reader.Read())
                {
                    Cidade Cidade = new(nome: Convert.ToString(reader["NOME"]));
                    Cidade.ID = Convert.ToInt32(reader["ID"]);
                    Cidades.Add(Cidade);
                }
                return new DataResponse<Cidade>("Cidades selecionados com sucesso!", true, Cidades);
            }
            catch (Exception ex)
            {
                return new DataResponse<Cidade>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Cidade> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
        public SingleResponse<Cidade> GetByID(int id)
        {

            string sql = $"SELECT ID FROM CIDADES WHERE ID = @ID";

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
                    Cidade Cidade = new Cidade(nome: Convert.ToString(reader["NOME"]));
                    Cidade.ID = Convert.ToInt32(reader["ID"]);
                    return new SingleResponse<Cidade>("Cliente selecionado com sucesso!", true, Cidade);
                }
                return new SingleResponse<Cidade>("Cliente não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Cidade>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
