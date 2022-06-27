using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Iten_VendaDal : ICRUD<Item_Venda>
    {
        internal string DalDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\AdultMovieLocatorDb.mdf;Integrated Security=True;Connect Timeout=3";
        public Response InsertList(List<Item_Venda> item)
        {
            return new Response("nao imprementado", true);
            //string sql = $"INSERT INTO ITEM_Venda (DATA,PRODUTO,NOME_CLIENTE,NOME_FUNCIONARIO,FORMA_PAGAMENTO,QUANTIDADE,PRECO_UNITARIO,VALOR_TOTAL) VALUES(@DATA,@PRODUTO,@NOME_CLIENTE,@NOME_FUNCIONARIO,@FORMA_PAGAMENTO,@QUANTIDADE,@PRECO_UNITARIO,@VALOR_TOTAL)";
            //string connectionString = DalDirectory;

            //SqlConnection connection = new SqlConnection(connectionString);

            //SqlCommand command = new SqlCommand(sql, connection);
            //command.Parameters.AddWithValue("@DATA", item.Data);
            //command.Parameters.AddWithValue("@PRODUTO", item.Produto);
            //command.Parameters.AddWithValue("@NOME_CLIENTE", item.NomeCliente);
            //command.Parameters.AddWithValue("@NOME_FUNCIONARIO", item.NomeFuncionario);
            //command.Parameters.AddWithValue("@FORMA_PAGAMENTO", item.FormaPagamento);
            //command.Parameters.AddWithValue("@QUANTIDADE", item.Quantidade);
            //command.Parameters.AddWithValue("@PRECO_UNITARIO", item.PrecoUnitario);
            //command.Parameters.AddWithValue("@VALOR_TOTAL", item.ValorTotal);
            //try
            //{
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    return new Response("Venda cadastradada com sucesso.", true);
            //}
            //catch (Exception)
            //{
            //    return new Response("Erro no banco de dados, contate o administrador.", false);
            //}
            //finally
            //{
            //    connection.Dispose();
            //}
        }
        public Response Insert(Item_Venda item)
        {
            string sql = $"INSERT INTO ITEM_Venda (DATA,PRODUTO,NOME_CLIENTE,NOME_FUNCIONARIO,FORMA_PAGAMENTO,QUANTIDADE,PRECO_UNITARIO,VALOR_TOTAL) VALUES(@DATA,@PRODUTO,@NOME_CLIENTE,@NOME_FUNCIONARIO,@FORMA_PAGAMENTO,@QUANTIDADE,@PRECO_UNITARIO,@VALOR_TOTAL)";
            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@DATA", item.Data);
            command.Parameters.AddWithValue("@PRODUTO", item.IDProduto);
            command.Parameters.AddWithValue("@NOME_CLIENTE", item.IDNomeCliente);
            command.Parameters.AddWithValue("@NOME_FUNCIONARIO", item.IDNomeFuncionario);
            command.Parameters.AddWithValue("@FORMA_PAGAMENTO", item.FormaPagamento);
            command.Parameters.AddWithValue("@QUANTIDADE", item.Quantidade);
            command.Parameters.AddWithValue("@PRECO_UNITARIO", item.PrecoUnitario);
            command.Parameters.AddWithValue("@VALOR_TOTAL", item.ValorTotal);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Venda cadastradada com sucesso.", true);
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
        public Response Update(Item_Venda item)
        {
            string sql = $"UPDATE ITEM_VENDA SET DATA = @DATA, PRODUTO = @PRODUTO, NOME_CLIENTE = @NOME_CLIENTE, NOME_FUNCIONARIO = @NOME_FUNCIONARIO, FORMA_PAGAMENTO = @FORMA_PAGAMENTO, QUANTIDADE = @QUANTIDADE, PRECO_UNITARIO = @PRECO_UNITARIO, VALOR_TOTAL = @VALOR_TOTAL WHERE ID = @ID";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@DATA", item.Data);
            command.Parameters.AddWithValue("@PRODUTO", item.IDProduto);
            command.Parameters.AddWithValue("@NOME_CLIENTE", item.IDNomeCliente);
            command.Parameters.AddWithValue("@NOME_FUNCIONARIO", item.IDNomeFuncionario);
            command.Parameters.AddWithValue("@FORMA_PAGAMENTO", item.FormaPagamento);
            command.Parameters.AddWithValue("@QUANTIDADE", item.Quantidade);
            command.Parameters.AddWithValue("@PRECO_UNITARIO", item.PrecoUnitario);
            command.Parameters.AddWithValue("@VALOR_TOTAL", item.ValorTotal);
            command.Parameters.AddWithValue("@ID", item.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Venda excluido.", false);
                }
                return new Response("Venda alterado com sucesso.", true);
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
        public Response Delete(int id)
        {
            string sql = "DELETE FROM ITEM_VENDA WHERE ID = @ID";

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
                    return new Response("Venda excluída com sucesso.", true);
                }
                return new Response("Venda não excluído.", false);
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

        public DataResponse<Item_Venda> GetAll()
        {
            string sql = $"SELECT ID,DATA,PRODUTO,NOME_CLIENTE,NOME_FUNCIONARIO,FORMA_PAGAMENTO,QUANTIDADE,PRECO_UNITARIO,VALOR_TOTAL";

            string connectionString = DalDirectory;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Item_Venda> ListaVendas = new List<Item_Venda>();
                while (reader.Read())
                {
                    Item_Venda Item_Venda = new Item_Venda(data: Convert.ToDateTime(reader["DATA"]),
                                                           produto: Convert.ToString(reader["PRODUTO"]),
                                                           nomeCliente: Convert.ToString(reader["NOME_CLIENTE"]),
                                                           quantidade: Convert.ToInt32(reader["QUANTIDADE"]),
                                                           precoUnitario: Convert.ToInt32(reader["PRECO_UNITARIO"]),
                                                           valorTotal: Convert.ToDouble(reader["VALOR_TOTAL"]),
                                                           formaPagamento: Convert.ToString(reader["FORMA_PAGAMENTO"]),
                                                           nomeFuncionario: Convert.ToString(reader["NOME_CLIENTE"]));

                    Item_Venda.ID = Convert.ToInt32(reader["ID"]);

                    ListaVendas.Add(Item_Venda);
                }
                return new DataResponse<Item_Venda>("Vendas selecionadas com sucesso!", true, ListaVendas);
            }
            catch (Exception)
            {
                return new DataResponse<Item_Venda>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<Item_Venda> GetByID(int id)
        {
            string sql = $"SELECT ID,DATA,PRODUTO,NOME_CLIENTE,NOME_FUNCIONARIO,FORMA_PAGAMENTO,QUANTIDADE,PRECO_UNITARIO,VALOR_TOTAL WHERE ID = @ID";

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
                    Item_Venda Item_Venda = new Item_Venda(data: Convert.ToDateTime(reader["DATA"]),
                                                            produto: Convert.ToString(reader["PRODUTO"]),
                                                            nomeCliente: Convert.ToString(reader["NOME_CLIENTE"]),
                                                            quantidade: Convert.ToInt32(reader["QUANTIDADE"]),
                                                            precoUnitario: Convert.ToInt32(reader["PRECO_UNITARIO"]),
                                                            valorTotal: Convert.ToDouble(reader["VALOR_TOTAL"]),
                                                            formaPagamento: Convert.ToString(reader["FORMA_PAGAMENTO"]),
                                                            nomeFuncionario: Convert.ToString(reader["NOME_CLIENTE"]));
                    Item_Venda.ID = Convert.ToInt32(reader["ID"]);
                    return new SingleResponse<Item_Venda>("Venda selecionado com sucesso!", true, Item_Venda);
                }
                return new SingleResponse<Item_Venda>("Venda não encontrado!", false, null);
            }
            catch (Exception)
            {
                return new SingleResponse<Item_Venda>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<Item_Venda> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Response Disable(int id)
        {
            throw new NotImplementedException();
        }
    }
}
