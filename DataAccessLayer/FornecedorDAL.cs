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
    public class FornecedorDAL : ICRUD<Fornecedor>
    {
        internal const string DalDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\AdultMovieLocatorDb.mdf;Integrated Security=True;Connect Timeout=3";
        public Response Insert(Fornecedor fornecedor)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO FORNECEDOR (RAZAOSOCIAL,CNPJ,EMAIL,TELEFONE,NOMERESPONSAVEL) VALUES (@RAZAOSOCIAL,@NOMERESPONSAVEL,@CNPJ,@EMAIL,,@TELEFONE)";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", fornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@NOMERESPONSAVEL", fornecedor.NomeResponsavel);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);


            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Fornecedor cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDOR_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FORNECEDOR_CNPJ"))
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
    

        public Response Update(Fornecedor fornecedor)
    {
        //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
        //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
        //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
        string sql = $"UPDATE FORNECEDOR SET RAZAOSOCIAL = @RAZAOSOCIAL,NOMERESPONSAVEL = @NOMERESPONSAVEL,CNPJ = @CNPJ,EMAIL = @EMAIL, TELEFONE = @TELEFONE WHERE ID = @ID";

        string connectionString = DalDirectory;

        //ADO.NET 
        SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RAZAOSOCIAL", fornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@NOMERESPONSAVEL", fornecedor.NomeResponsavel);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);

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
            if (ex.Message.Contains("UQ_FORNECEDOR_EMAIL"))
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
            string sql = "DELETE FROM FORNECEDOR WHERE ID = @ID";

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
                    return new Response("Fornecedor excluído com sucesso.", true);
                }
                return new Response("Fornecedor não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDOR_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FORNECEDOR_CNPJ"))
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

        public DataResponse<Fornecedor> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,RAZAOSOCIAL,,NOMERESPONSAVEL,CNPJ,EMAIL,TELEFONE FROM FORNECEDOR";

            string connectionString = DalDirectory;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Fornecedor fornecedor = new Fornecedor(telefone: Convert.ToString(reader["TELEFONE"]),
                                                           cNPJ: Convert.ToString(reader["CNPJ"]),
                                                           nomeResponsavel: Convert.ToString(reader["NOME_RESPONSAVEL"]),
                                                           razaoSocial: Convert.ToString(reader["RAZAO_SOCIAL"]),
                                                           email: Convert.ToString(reader["EMAIL"]));
                    fornecedor.ID = Convert.ToInt32(reader["ID"]);
                    
                    fornecedores.Add(fornecedor);
                }
                return new DataResponse<Fornecedor>("fornecedor selecionados com sucesso!", true, fornecedores);
            }
            catch (Exception ex)
            {
                return new DataResponse<Fornecedor>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }

        }

        public SingleResponse<Fornecedor> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT RAZAOSOCIAL,CNPJ,EMAIL,TELEFONE,NOMERESPONSAVEL FROM FORNECEDOR WHERE ID = @ID";

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

                    Fornecedor fornecedor = new Fornecedor(telefone: Convert.ToString(reader["TELEFONE"]),
                                                           cNPJ: Convert.ToString(reader["CNPJ"]),
                                                           nomeResponsavel: Convert.ToString(reader["NOME_RESPONSAVEL"]),
                                                           razaoSocial: Convert.ToString(reader["RAZAO_SOCIAL"]),
                                                           email: Convert.ToString(reader["EMAIL"]));


                    fornecedor.ID = Convert.ToInt32(reader["ID"]);
                    
                    return new SingleResponse<Fornecedor>("fornecedor selecionado com sucesso!", true, fornecedor);
                }
                return new SingleResponse<Fornecedor>("fornecedor não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Fornecedor>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }


        }

        public SingleResponse<Fornecedor> GetByEmail(string email)
        {
            
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT RAZAOSOCIAL,CNPJ,EMAIL,TELEFONE,NOMERESPONSAVEL FROM FORNECEDOR WHERE EMAIL = @EMAIL";

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

                    Fornecedor fornecedor = new Fornecedor(telefone: Convert.ToString(reader["TELEFONE"]),
                                                           cNPJ: Convert.ToString(reader["CNPJ"]),
                                                           nomeResponsavel: Convert.ToString(reader["NOME_RESPONSAVEL"]),
                                                           razaoSocial: Convert.ToString(reader["RAZAO_SOCIAL"]),
                                                           email: Convert.ToString(reader["EMAIL"]));
                    fornecedor.ID = Convert.ToInt32(reader["ID"]);

                    return new SingleResponse<Fornecedor>("fornecedor selecionado com sucesso!", true, fornecedor);
                }
                return new SingleResponse<Fornecedor>("fornecedor não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Fornecedor>("Erro no banco de dados, contate o administrador.", false, null);
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

