using Entities;
using Entities.Propriedades;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class wFPhelperDAL 
    {
        public string GetData()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\banco\BancoFarmaciaZYX.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public DataResponse<Cidade> GetAllCidade(int id)
        {
            string sql = $"SELECT ID,NOME,ID_ESTADO FROM CIDADES WHERE ID_ESTADO = @ID";

            string connectionString = GetData();    
    
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cidade> Cidades = new List<Cidade>();
                while (reader.Read())
                {
                    Cidade Cidade = new(nome: Convert.ToString(reader["NOME"]));
                    Cidade.ID = Convert.ToInt32(reader["ID"]);
                    Cidade.ID_ESTADO = Convert.ToInt32(reader["ID_ESTADO"]);
                    Cidades.Add(Cidade);
                }
                return new DataResponse<Cidade>("Cidades selecionados com sucesso!", true, Cidades);
            }
            catch (Exception)
            {
                return new DataResponse<Cidade>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Estado> GetAllEstado()
        {
            string sql = $"SELECT ID,NOME,UF FROM ESTADOS";

            string connectionString = GetData();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Estado> Estados = new List<Estado>();
                while (reader.Read())
                {
                    Estado estado = new(nome: Convert.ToString(reader["NOME"]),
                                        uF: Convert.ToString(reader["UF"]));
                    estado.ID = Convert.ToInt32(reader["ID"]);


                    Estados.Add(estado);
                }
                return new DataResponse<Estado>("Cidades selecionados com sucesso!", true, Estados);
            }
            catch (Exception)
            {
                return new DataResponse<Estado>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}

