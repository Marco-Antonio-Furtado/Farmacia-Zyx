using Entities;
using Entities.Propriedades;
using Shared;
using System.Data.SqlClient;
using System.Transactions;

namespace DataAccessLayer
{
    public class SaidaDAL : ITransacaoProdutos<Saida>
    {
        private ProdutoDal produtoDAL = new ProdutoDal();

        public SingleResponse<Saida> EfetuarTransacao(Saida transacao)
        {


            string sql = $"INSERT INTO SAIDAS (DATA_SAIDA,CLIENTES_ID,VALOR,FUNCIONARIOS_ID,FORMA_PAGAMENTO)" +
                      $" VALUES (@DATA,@CLIENTES_ID,@PRECO,@FUNCIONARIOS_ID,@FORMA_PAGAMENTO); SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@DATA", transacao.Data);
            command.Parameters.AddWithValue("@CLIENTES_ID", transacao.IDCliente.ID);
            command.Parameters.AddWithValue("@FUNCIONARIOS_ID", transacao.IDFuncionario.ID);
            command.Parameters.AddWithValue("@PRECO", transacao.ValorTotal);
            command.Parameters.AddWithValue("@FORMA_PAGAMENTO", transacao.Forma_Pagamento);

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    DbExecuter dbExecuter = new DbExecuter();
                    transacao.ID = DbExecuter.ExecuteScalar(command);

                    foreach (var item in transacao.Items)
                    {
                        string sql1 = "INSERT INTO PRODUTOS_SAIDAS (SAIDA_ID,PRODUTOS_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@ENTRADA_ID,@PRODUTOS_ID,@QUANTIDADE,@VALOR_UNITARIO)";

                        SqlCommand command1 = new SqlCommand(sql1);
                        command1.Parameters.AddWithValue("@ENTRADA_ID", transacao.ID);
                        command1.Parameters.AddWithValue("@PRODUTOS_ID", item.IDProduto.ID);
                        command1.Parameters.AddWithValue("@QUANTIDADE", item.Qtd);
                        command1.Parameters.AddWithValue("@VALOR_UNITARIO", item.Preco);
                        Response response = DbExecuter.Execute(command1);
                        if (!response.HasSuccess)
                        {
                            return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Saida>(null);
                        }
                    }
                    scope.Complete();
                    return ResponseFactory.CreateInstance().CreateSingleSuccessResponse(transacao);
                }
                catch (Exception ex)
                {
                    return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Saida>(null);
                }
            }
        }

        public SingleResponse<Saida> GetByID(int id)
        {
            string sql = $"SELECT ID,DATA_SAIDA,PRODUTO,CLIENTES_ID,QUANTIDADE,VALOR_UNITARIO,VALOR_TOTAL FROM SAIDAS WHERE ID = @ID";

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

        public DataResponse<Saida> LerTransacoes(DateTime inicio, DateTime fim)
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
    }
}
