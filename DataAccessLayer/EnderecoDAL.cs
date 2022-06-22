using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EnderecoDAL : ICRUD<Endereco>
    {
        internal const string DalDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\AdultMovieLocatorDb.mdf;Integrated Security=True;Connect Timeout=3";
        public Response Insert(Endereco item)
        {
            string sql = $"INSERT INTO ENDERECO (RUA,BAIRRO,CEP,NUMERO,COMPLEMENTO,PONTO_REFERENCIA,CIDADE,ESTADO) VALUES (@RUA,@BAIRRO,@CEP,@NUMERO,@COMPLEMENTO,@PONTO_REFERENCIA,@CIDADE,@ESTADO)";

            string connectionString = DalDirectory;
          
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RUA", item.Rua);
            command.Parameters.AddWithValue("@BAIRRO", item.Bairro);
            command.Parameters.AddWithValue("@CEP", item.CEP);
            command.Parameters.AddWithValue("@NUMERO", item.Numero);
            command.Parameters.AddWithValue("@COMPLEMENTO", item.Complemento);
            command.Parameters.AddWithValue("@PONTO_REFERENCIA", item.PontoReferencia);
            command.Parameters.AddWithValue("@CIDADE", item.Cidade);
            command.Parameters.AddWithValue("@ESTADO", item.Estado);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Endereço cadastrado com sucesso.", true);
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

        public Response Update(Endereco item)
        {

            string sql = $"UPDATE CLIENTES SET RUA = @RUA, BAIRRO = @BAIRRO, CEP = @CEP, NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO, PONTO_REFERENCIA, CIDADE = @CIDADE, ESTADO = @ESTADO WHERE ID = @ID";
            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RUA", item.Rua);
            command.Parameters.AddWithValue("@BAIRRO", item.Bairro);
            command.Parameters.AddWithValue("@CEP", item.CEP);
            command.Parameters.AddWithValue("@NUMERO", item.Numero);
            command.Parameters.AddWithValue("@COMPLEMENTO", item.Complemento);
            command.Parameters.AddWithValue("@PONTO_REFERENCIA", item.PontoReferencia);
            command.Parameters.AddWithValue("@CIDADE", item.Cidade);
            command.Parameters.AddWithValue("@ESTADO", item.Estado);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Endereco excluido.", false);
                }
                return new Response("Endereco alterado com sucesso.", true);
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
            string sql = "DELETE FROM ENDERECO WHERE ID = @ID";

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
                    return new Response("Endereco excluído com sucesso.", true);
                }
                return new Response("Endereco não excluído.", false);
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

        public DataResponse<Endereco> GetAll()
        {

            string sql = $"SELECT RUA,BAIRRO,CEP,NUMERO,COMPLEMENTO,PONTO_REFERENCIA,CIDADE,ESTADO FROM ENDERECO";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Endereco> Enderecos = new List<Endereco>();
                while (reader.Read())
                {
                    Endereco Endereco = new Endereco(rua: Convert.ToString(reader["RUA"]),
                                                     bairro: Convert.ToString(reader["BAIRRO"]),
                                                     cEP: Convert.ToString(reader["CEP"]),
                                                     numero: Convert.ToString(reader["NUMERO"]),
                                                     cidade: Convert.ToString(reader["CIDADE"]),
                                                     estado: Convert.ToString(reader["ESTADO"]),
                                                     complemento: Convert.ToString(reader["COMPLEMENTO"]),
                                                     pontoReferencia: Convert.ToString(reader["PONTO_REFERENCIA"]));
                    Endereco.ID = Convert.ToInt32(reader["ID"]);
                    Enderecos.Add(Endereco);
                }
                return new DataResponse<Endereco>("Enderecos selecionados com sucesso!", true, Enderecos);
            }
            catch (Exception ex)
            {
                return new DataResponse<Endereco>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<Endereco> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Endereco> GetByID(int id)
        {

            string sql = $"SELECT RUA,BAIRRO,CEP,NUMERO,COMPLEMENTO,PONTO_REFERENCIA,CIDADE,ESTADO FROM ENDERECO WHERE ID = @ID";

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
                    Endereco Endereco = new Endereco(rua: Convert.ToString(reader["RUA"]),
                                                     bairro: Convert.ToString(reader["BAIRRO"]),
                                                     cEP: Convert.ToString(reader["CEP"]),
                                                     numero: Convert.ToString(reader["NUMERO"]),
                                                     cidade: Convert.ToString(reader["CIDADE"]),
                                                     estado: Convert.ToString(reader["ESTADO"]),
                                                     complemento: Convert.ToString(reader["COMPLEMENTO"]),
                                                     pontoReferencia: Convert.ToString(reader["PONTO_REFERENCIA"]));
                    Endereco.ID = Convert.ToInt32(reader["ID"]);
                    return new SingleResponse<Endereco>("Endereco selecionado com sucesso!", true, Endereco);
                }
                return new SingleResponse<Endereco>("Endereco não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Endereco>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

    }
}
