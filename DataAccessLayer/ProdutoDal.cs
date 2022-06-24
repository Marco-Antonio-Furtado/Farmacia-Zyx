using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProdutoDal : ICRUD<Produto>
    {
        internal const string DalDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\AdultMovieLocatorDb.mdf;Integrated Security=True;Connect Timeout=3";
        public Response Insert(Produto item)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO PRODUTOS (NOME,DESCRISCAO,LABORATORIO,VALOR_UNITARIO) VALUES                                 (@NOME,@DESCRISCAO,@LABORATORIO,@VALOR_UNITARIO)";
            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@DESCRISCAO", item.Descriscao);
            command.Parameters.AddWithValue("@LABORATORIO", item.Laboratorio);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.ValorUnitario);


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Produto cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("UQ_Produto_NOME"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("NOME já está em uso.", false);
                }
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public Response Update(Produto item)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE PRODUTOS SET NOME = @NOME, DESCRISCAO = @DESCRISCAO, LABORATORIO = @LABORATORIO, VALOR_UNITARIO = @VALOR_UNITARIO WHERE ID = @ID";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@DESCRISCAO", item.Descriscao);
            command.Parameters.AddWithValue("@LABORATORIO", item.Laboratorio);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.ValorUnitario);

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
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
                if (ex.Message.Contains("UQ_PRODUTO_NOME"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("NOME já está em uso.", false);
                }
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM PRODUTO WHERE ID = @ID";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Produto excluído com sucesso.", true);
                }
                return new Response("Produto não excluído.", false);
            }
            catch (Exception)
            {
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public DataResponse<Produto> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,DESCRISCAO,LABORATORIO,VALOR_UNITARIO FROM PRODUTOS";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Produto produto = new Produto(nome: Convert.ToString(reader["NOME"]),
                                                  descriscao: Convert.ToString(reader["DESCRISCAO"]),
                                                  laboratorio: Convert.ToString(reader["LABORATORIO"]),
                                                  valorunitario: Convert.ToDouble(reader["VALOR_UNITARIO"]));
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    produtos.Add(produto);
                }
                return new DataResponse<Produto>("Produtos selecionados com sucesso!", true, produtos);
            }
            catch (Exception)
            {
                return new DataResponse<Produto>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public SingleResponse<Produto> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,DESCRISCAO,LABORATORIO,VALOR_UNITARIO FROM PRODUTOS WHERE ID = @ID";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    Produto produto = new Produto(nome: Convert.ToString(reader["NOME"]),
                                                 descriscao: Convert.ToString(reader["DESCRISCAO"]),
                                                 laboratorio: Convert.ToString(reader["LABORATORIO"]),
                                                 valorunitario: Convert.ToDouble(reader["VALOR_UNITARIO"]));
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    return new SingleResponse<Produto>("Produto selecionado com sucesso!", true, produto);
                }
                return new SingleResponse<Produto>("Produto não encontrado!", false, null);
            }
            catch (Exception)
            {
                return new SingleResponse<Produto>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public SingleResponse<Produto> GetByEmail(string email)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,DESCRISCAO,LABORATORIO,VALOR_UNITARIO FROM PRODUTOS WHERE EMAIL = @EMAIL";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@EMAIL", email);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    Produto produto = new Produto(nome: Convert.ToString(reader["NOME"]),
                                                 descriscao: Convert.ToString(reader["DESCRISCAO"]),
                                                 laboratorio: Convert.ToString(reader["LABORATORIO"]),
                                                 valorunitario: Convert.ToDouble(reader["VALOR_UNITARIO"]));
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    return new SingleResponse<Produto>("Produto selecionado com sucesso!", true, produto);
                }
                return new SingleResponse<Produto>("Produto não encontrado!", false, null);
            }
            catch (Exception)
            {
                return new SingleResponse<Produto>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
    }
}
