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
    public class Iten_CompraDal : ICRUD<Item_Compra>
    {
        internal string DalDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\AdultMovieLocatorDb.mdf;Integrated Security=True;Connect Timeout=3";
        public Response Insert(Item_Compra item)
        {
            string sql = $"INSERT INTO ITEM_COMPRA (DATA_COMPRA,PRODUTO_COMPRA,FORNECEDOR,QUANTIDADE,PRECO_UNITARIO,VALOR_TOTAL) VALUES                                 (@DATA_COMPRA,@PRODUTO_COMPRA,@FORNECEDOR,@QUANTIDADE,@PRECO_UNITARIO,@VALOR_TOTAL)";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@DATA_COMPRA", item.DataCompra);
            command.Parameters.AddWithValue("@PRODUTO_COMPRA", item.ProdutoCompra);
            command.Parameters.AddWithValue("@FORNECEDOR", item.Fornecedor);
            command.Parameters.AddWithValue("@QUANTIDADE", item.Quantidade);
            command.Parameters.AddWithValue("@PRECO_UNITARIO", item.PrecoUnitario);
            command.Parameters.AddWithValue("@VALOR_TOTAL", item.ValorTotal);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Compra cadastradada com sucesso.", true);
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

        public Response Update(Item_Compra item)
        {
            string sql = $"UPDATE ITEM_COMPRA SET DATA_COMPRA = @DATA_COMPRA, PRODUTO_COMPRA = @PRODUTO_COMPRA, FORNECEDOR = @FORNECEDOR, QUANTIDADE = @QUANTIDADE, PRECO_UNITARIO = @PRECO_UNITARIO, VALOR_TOTAL = @VALOR_TOTAL WHERE ID = @ID";
            
            string connectionString = DalDirectory;
            
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", item.DataCompra);
            command.Parameters.AddWithValue("@CPF", item.ProdutoCompra);
            command.Parameters.AddWithValue("@RG", item.Fornecedor);
            command.Parameters.AddWithValue("@EMAIL", item.Quantidade);
            command.Parameters.AddWithValue("@TELEFONE1", item.PrecoUnitario);
            command.Parameters.AddWithValue("@TELEFONE2", item.ValorTotal);
            command.Parameters.AddWithValue("@ID", item.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Compra excluido.", false);
                }
                return new Response("Compra alterado com sucesso.", true);
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
            string sql = "DELETE FROM ITEM_COMPRA WHERE ID = @ID";

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
                    return new Response("Compra excluído com sucesso.", true);
                }
                return new Response("Compra não excluído.", false);
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

        public DataResponse<Item_Compra> GetAll()
        {
            string sql = $"SELECT ID,DATA_COMPRA,PRODUTO_COMPRA,FORNECEDOR,QUANTIDADE,PRECO_UNITARIO,VALOR_TOTAL FROM ITEM_COMPRA";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Item_Compra> ListaCompras = new List<Item_Compra>();
                while (reader.Read())
                {
                    Item_Compra Item_Compra = new Item_Compra(dataCompra: Convert.ToDateTime(reader["DATA_COMPRA"]),
                                                              produtoCompra : Convert.ToString(reader["PRODUTO_COMPRA"]),
                                                              fornecedor : Convert.ToString(reader["FORNECEDOR"]),
                                                              quantidade : Convert.ToInt32(reader["QUANTIDADE"]),
                                                              precoUnitario : Convert.ToInt32(reader["PRECO_UNITARIO"]),
                                                              valorTotal : Convert.ToDouble(reader["VALOR_TOTAL"]));
                    Item_Compra.ID = Convert.ToInt32(reader["ID"]);

                    ListaCompras.Add(Item_Compra);
                }
                return new DataResponse<Item_Compra>("Compras selecionadas com sucesso!", true, ListaCompras);
            }
            catch (Exception ex)
            {
                return new DataResponse<Item_Compra>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<Item_Compra> GetByID(int id)
        {
            string sql = $"SELECT ID,DATA_COMPRA,PRODUTO_COMPRA,FORNECEDOR,QUANTIDADE,PRECO_UNITARIO,VALOR_TOTAL FROM ITEM_COMPRA WHERE ID = @ID";

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
                    Item_Compra Item_Compra = new Item_Compra(dataCompra: Convert.ToDateTime(reader["DATA_COMPRA"]),
                                                              produtoCompra: Convert.ToString(reader["PRODUTO_COMPRA"]),
                                                              fornecedor: Convert.ToString(reader["FORNECEDOR"]),
                                                              quantidade: Convert.ToInt32(reader["QUANTIDADE"]),
                                                              precoUnitario: Convert.ToInt32(reader["PRECO_UNITARIO"]),
                                                              valorTotal: Convert.ToDouble(reader["VALOR_TOTAL"]));
                    Item_Compra.ID = Convert.ToInt32(reader["ID"]);
                    return new SingleResponse<Item_Compra>("Compra selecionado com sucesso!", true, Item_Compra);
                }
                return new SingleResponse<Item_Compra>("Compra não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Item_Compra>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<Item_Compra> GetByEmail(string email)
        {
            string sql = $"SELECT ID,DATA_COMPRA,PRODUTO_COMPRA,FORNECEDOR,QUANTIDADE,PRECO_UNITARIO,VALOR_TOTAL FROM ITEM_COMPRA WHERE EMAIL = @EMAIL";

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
                    Item_Compra Item_Compra = new Item_Compra(dataCompra: Convert.ToDateTime(reader["DATA_COMPRA"]),
                                                              produtoCompra: Convert.ToString(reader["PRODUTO_COMPRA"]),
                                                              fornecedor: Convert.ToString(reader["FORNECEDOR"]),
                                                              quantidade: Convert.ToInt32(reader["QUANTIDADE"]),
                                                              precoUnitario: Convert.ToInt32(reader["PRECO_UNITARIO"]),
                                                              valorTotal: Convert.ToDouble(reader["VALOR_TOTAL"]));
                    Item_Compra.ID = Convert.ToInt32(reader["ID"]);
                    return new SingleResponse<Item_Compra>("Compra selecionado com sucesso!", true, Item_Compra);
                }
                return new SingleResponse<Item_Compra>("Compra não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Item_Compra>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
