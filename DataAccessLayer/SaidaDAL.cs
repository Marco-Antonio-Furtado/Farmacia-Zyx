using Entities;
using Entities.Propriedades;
using Shared;
using System.Data.SqlClient;
using System.Transactions;

namespace DataAccessLayer
{
    public class SaidaDAL : IEntradaProdutos
    {
        public DataResponse<Saida> LerSaidas(DateTime inicio, DateTime fim)
        {
            string sql = $"SELECT ID,PRODUTO,DATA,FORNECEDOR,FORMA_PAGAMENTO,PRECO_UNITARIO,QUANTIDADE,VALOR_TOTAL,NOME_FUNCIONARIO FROM Entrada where data between @inicio and @fim";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@inicio", inicio);
            command.Parameters.AddWithValue("@fim", fim);
            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                return DbExecuter.GetData<Saida>(command);
            }
            catch (Exception)
            {
                return new DataResponse<Saida>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }

        public SingleResponse<Saida> GetByID(int id)
        {
            string sql = $"SELECT ID,DATA,PRODUTO,FORNECEDOR,QUANTIDADE,PRECO_UNITARIO,VALOR_TOTAL FROM Entrada WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                return DbExecuter.GetItem<Saida>(command);
            }
            catch (Exception)
            {
                return new SingleResponse<Saida>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }
        public Response EfetuarSaida(Saida saida)
        {
            string sql = $"INSERT INTO SAIDAS (DATA_SAIDA,CLIENTES_ID,VALOR,FUNCIONARIOS_ID)" +
                       $" VALUES (@DATA_SAIDA,@CLIENTES_ID,@VALOR,@FUNCIONARIOS_ID); SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@DATA_SAIDA", saida.Data);
            command.Parameters.AddWithValue("@CLIENTES_ID", saida.IDNomeCliente);
            command.Parameters.AddWithValue("@FUNCIONARIOS_ID", saida.IDNomeFuncionario);
            command.Parameters.AddWithValue("@VALOR", saida.ValorTotal);
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    DbExecuter dbExecuter = new DbExecuter();
                    saida.ID = DbExecuter.ExecuteScalar(command);

                    foreach (var item in saida.Items)
                    {
                        string sql1 = "INSERT INTO PRODUTOS_SAIDAS (SAIDA_ID,PRODUTOS_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@SAIDA_ID,@PRODUTOS_ID,@QUANTIDADE,@VALOR_UNITARIO)";

                        SqlCommand command1 = new SqlCommand(sql1);
                        command1.Parameters.AddWithValue("@SAIDA_ID", saida.ID);
                        command1.Parameters.AddWithValue("@PRODUTOS_ID", item.IDProduto);
                        command1.Parameters.AddWithValue("@QUANTIDADE", item.Qtd);
                        command1.Parameters.AddWithValue("@VALOR_UNITARIO", item.Preco);
                        Response response = DbExecuter.Execute(command1);
                        if (!response.HasSuccess)
                        {
                            return new Response("", false);
                        }
                    }
                    scope.Complete();
                    return ResponseFactory.CreateInstance().CreateSuccessResponse();
                }
                catch (Exception ex)
                {
                    return new Response(ex.Message, false);
                }
            }//scope.Dispose();
        }
    }
}
