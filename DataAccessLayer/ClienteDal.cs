﻿using Shared;
using System.Data.SqlClient;
using Entities;



namespace DataAccessLayer
{
    public class ClienteDAL : ICRUD<Cliente>
    {
        string DalDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\AdultMovieLocatorDb.mdf;Integrated Security=True;Connect Timeout=3";
        
        public Response Insert(Cliente cliente)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO CLIENTES (NOME,CPF,EMAIL,TELEFONE) VALUES (@NOME,@CPF,@EMAIL,@TELEFONE)";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE1", cliente.Telefone1);

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Cliente cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("CPF já está em uso.", false);
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

        public Response Update(Cliente cliente)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE CLIENTES SET NOME = @NOME, EMAIL = @EMAIL, TELEFONE = @TELEFONE WHERE ID = @ID";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE1", cliente.Telefone1);
            command.Parameters.AddWithValue("@ID", cliente.ID);

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
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
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
            string sql = "DELETE FROM CLIENTES WHERE ID = @ID";

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
                    return new Response("Cliente excluído com sucesso.", true);
                }
                return new Response("Cliente não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("CPF já está em uso.", false);
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

        public DataResponse<Cliente> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,CPF,EMAIL,TELEFONE FROM CLIENTES";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.Telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    cliente.Telefone2 = Convert.ToString(reader["TELEFONE2"]);

                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    clientes.Add(cliente);
                }
                return new DataResponse<Cliente>("Clientes selecionados com sucesso!", true, clientes);
            }
            catch (Exception ex)
            {
                return new DataResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Cliente> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME,CPF,EMAIL,TELEFONE FROM CLIENTES WHERE ID = @ID";

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
                    Cliente cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.Telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    return new SingleResponse<Cliente>("Cliente selecionado com sucesso!", true, cliente);
                }
                return new SingleResponse<Cliente>("Cliente não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public SingleResponse<Cliente> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}