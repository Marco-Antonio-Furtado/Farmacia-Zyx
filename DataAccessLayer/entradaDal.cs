using DataAccessLayer;
using Entities.Propriedades;
using Shared;
using System.Data.SqlClient;
using System.Transactions;
namespace Entities
{
    public class EntradaDal : ITransacaoProdutos<Entrada>
    {
        public SingleResponse<Entrada> EfetuarTransacao(Entrada transacao)
        {
            string sql = $"INSERT INTO ENTRADAS (DATA_ENTRADA,FORNECEDORES_ID,PRECO,FUNCIONARIOS_ID)" +
                      $" VALUES (@DATA,@FORNECEDORES_ID,@PRECO,@FUNCIONARIOS_ID); SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@DATA", transacao.Data);
            command.Parameters.AddWithValue("@FORNECEDORES_ID", transacao.IDFornecedor);
            command.Parameters.AddWithValue("@FUNCIONARIOS_ID", transacao.IDFuncionario);
            command.Parameters.AddWithValue("@PRECO", transacao.ValorTotal);
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    DbExecuter dbExecuter = new DbExecuter();
                    transacao.ID = DbExecuter.ExecuteScalar(command);

                    foreach (var item in transacao.Items)
                    {
                        string sql1 = "INSERT INTO PRODUTOS_ENTRADAS (ENTRADA_ID,PRODUTOS_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@ENTRADA_ID,@PRODUTOS_ID,@QUANTIDADE,@VALOR_UNITARIO)";

                        SqlCommand command1 = new SqlCommand(sql1);
                        command1.Parameters.AddWithValue("@ENTRADA_ID", transacao.ID);
                        command1.Parameters.AddWithValue("@PRODUTOS_ID", item.IDProduto);
                        command1.Parameters.AddWithValue("@QUANTIDADE", item.Qtd);
                        command1.Parameters.AddWithValue("@VALOR_UNITARIO", item.Preco);
                        Response response = DbExecuter.Execute(command1);
                        if (!response.HasSuccess)
                        {
                            return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Entrada>(null);
                        }
                    }
                    scope.Complete();
                    return ResponseFactory.CreateInstance().CreateSingleSuccessResponse(transacao);
                }
                catch (Exception ex)
                {
                    return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Entrada>(null);
                }
            }//scope.Dispose();
        }
        public SingleResponse<Entrada> GetByID(int id)
        {
            string sql = $"SELECT ID,DATA,PRODUTO,FORNECEDOR,QUANTIDADE,PRECO_UNITARIO,VALOR_TOTAL FROM Entrada WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                return DbExecuter.GetItem<Entrada>(command);
            }
            catch (Exception)
            {
                return new SingleResponse<Entrada>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }
        public DataResponse<Entrada> LerTransacoes(DateTime inicio, DateTime fim)
        {

            string sql = $"SELECT ID,PRODUTO,DATA,FORNECEDOR,FORMA_PAGAMENTO,PRECO_UNITARIO,QUANTIDADE,VALOR_TOTAL,NOME_FUNCIONARIO FROM Entrada where data between @inicio and @fim";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@inicio", inicio);
            command.Parameters.AddWithValue("@fim", fim);
            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                return DbExecuter.GetData<Entrada>(command);
            }
            catch (Exception)
            {
                return new DataResponse<Entrada>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }


    }
}
