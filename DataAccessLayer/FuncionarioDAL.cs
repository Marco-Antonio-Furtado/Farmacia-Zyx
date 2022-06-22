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
    public class FuncionarioDAL : ICRUD<Funcionario>
    {
        internal string DalDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\AdultMovieLocatorDb.mdf;Integrated Security=True;Connect Timeout=3";
        public Response Insert(Funcionario item)
        {
            string sql = $"INSERT INTO FUNCIONARIO (NOME,CPF,RG,EMAIL,TELEFONE1,ENDERECO,SENHA) VALUES                                 (@NOME,@CPF,@RG,@EMAIL,@TELEFONE1,@ENDERECO,@SENHA)";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@CPF", item.CPF);
            command.Parameters.AddWithValue("@RG", item.RG);
            command.Parameters.AddWithValue("@EMAIL", item.Email);
            command.Parameters.AddWithValue("@TELEFONE1", item.Telefone1);
            command.Parameters.AddWithValue("@ENDERECO", item.Endereco);
            command.Parameters.AddWithValue("@SENHA", item.Senha);


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Funcionario cadastrado com sucesso.", true);
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
            finally
            {
                connection.Dispose();
            }
        }

        public Response Update(Funcionario item)
        {
            return new Response("ta uptado banco", true);
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM FUNCIONARIO WHERE ID = @ID";

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
                    return new Response("Funcionario excluído com sucesso.", true);
                }
                return new Response("Funcionario não excluído.", false);
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

        public DataResponse<Funcionario> GetAll()
        {
            List<Funcionario> testes = new List<Funcionario>();
            return new DataResponse<Funcionario>("ta getado com sucesso", true, testes);
        }

        public SingleResponse<Funcionario> GetByID(int id)
        {
            return new SingleResponse<Funcionario>("foi quetado do email!", false, null);
            //string sql = $"SELECT NOME,CPF,RG,EMAIL,TELEFONE FROM FUNCIONARIO WHERE ID = @ID";

            //string connectionString = DalDirectory;

            //SqlConnection connection = new SqlConnection(connectionString);

            //SqlCommand command = new SqlCommand(sql, connection);
            //command.Parameters.AddWithValue("@ID", id);
            //try
            //{
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        Funcionario Funcionario = new Funcionario(nome: Convert.ToString(reader["NOME"]),
            //                                                  cPF: Convert.ToString(reader["CPF"]),
            //                                                  rG: Convert.ToString(reader["RG"]),
            //                                                  telefone1: Convert.ToString(reader["TELEFONE1"]),
            //                                                  endereco: Convert.ToString(reader["ENDERECO"]),
            //                                                  senha: Convert.ToString(reader["SENHA"]),
            //                                                  email: Convert.ToString(reader["EMAIL"]));
            //        Funcionario.ID = Convert.ToInt32(reader["ID"]);

            //        return new SingleResponse<Funcionario>("Funcionario selecionado com sucesso!", true, Funcionario);
            //    }
            //    return new SingleResponse<Funcionario>("fornecedor não encontrado!", false, null);
            //}
            //catch (Exception ex)
            //{
            //    return new SingleResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            //}
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            //finally
            //{
            //    Fecha a conexão
            //    connection.Dispose();
            //}

        }

        public SingleResponse<Funcionario> GetByEmail(string email)
        {
            return new SingleResponse<Funcionario>("foi quetado do email!", false, null);

        }

    }
}
