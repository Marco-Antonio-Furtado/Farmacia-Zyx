using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class EstadoDAL : ICRUD<Estado>
    {
        internal const string DalDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\AdultMovieLocatorDb.mdf;Integrated Security=True;Connect Timeout=3";
        public Response Insert(Estado item)
        {
            string sql = $"INSERT INTO ESTADO (NOME,UF) VALUES (@NOME,@UF)";
            string connectionString = DalDirectory;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@UF", item.UF);


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Estado cadastrado com sucesso.", true);
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
        public Response Update(Estado item)
        {
            string sql = $"UPDATE ESTADO SET NOME = @NOME,UF = @UF WHERE ID = @ID";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@UF", item.UF);
            command.Parameters.AddWithValue("@ID", item.ID);

            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Estado excluido.", false);
                }
                return new Response("Estado alterado com sucesso.", true);
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
            string sql = "DELETE FROM ESTADO WHERE ID = @ID";

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
                    return new Response("Estado excluído com sucesso.", true);
                }
                return new Response("Estado não excluído.", false);
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
        public DataResponse<Estado> GetAll()
        {

            string sql = $"SELECT ID,NOME,UF FROM ESTADO";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Estado> Estados = new List<Estado>();
                while (reader.Read())
                {
                    Estado Estado = new Estado(nome: Convert.ToString(reader["NOME"]),  
                                               uF: Convert.ToString(reader["UF"]));
                    
                    Estado.ID = Convert.ToInt32(reader["ID"]);
                    Estados.Add(Estado);
                }
                return new DataResponse<Estado>("Estados selecionados com sucesso!", true, Estados);
            }
            catch (Exception ex)
            {
                return new DataResponse<Estado>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Estado> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
        public SingleResponse<Estado> GetByID(int id)
        {

            string sql = $"SELECT ID FROM ESTADOS WHERE ID = @ID";

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
                    Estado Estado = new Estado(nome: Convert.ToString(reader["NOME"]),
                                               uF: Convert.ToString(reader["UF"]));
                    return new SingleResponse<Estado>("Cliente selecionado com sucesso!", true, Estado);
                }
                return new SingleResponse<Estado>("Cliente não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Estado>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
