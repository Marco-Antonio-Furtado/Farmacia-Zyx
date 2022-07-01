using DataAccessLayer;
using Entities.Propriedades;
using Entities.viewmodel;
using Shared;
using System.Data.SqlClient;
using System.Transactions;
namespace Entities
{
    public class EntradaDal : ITransacaoProdutos<Entrada, EntradaViewModel>
    {
        public SingleResponse<Entrada> EfetuarTransacao(Entrada transacao)
        {
            string sql = $"INSERT INTO ENTRADAS (DATA_ENTRADA,FORNECEDORES_ID,PRECO,FUNCIONARIOS_ID,FORMA_PAGAMENTO)" +
                      $" VALUES (@DATA,@FORNECEDORES_ID,@PRECO,@FUNCIONARIOS_ID,@FORMA_PAGAMENTO); SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@DATA", transacao.Data);
            command.Parameters.AddWithValue("@FORNECEDORES_ID", transacao.IDFornecedor.ID);
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
                        string sql1 = "INSERT INTO PRODUTOS_ENTRADAS (ENTRADA_ID,PRODUTOS_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@ENTRADA_ID,@PRODUTOS_ID,@QUANTIDADE,@VALOR_UNITARIO)";

                        SqlCommand command1 = new SqlCommand(sql1);
                        command1.Parameters.AddWithValue("@ENTRADA_ID", transacao.ID);
                        command1.Parameters.AddWithValue("@PRODUTOS_ID", item.IDProduto.ID);
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

        //NAO TA CERTO ESSE METOEDO DE BAIXO
        public DataResponse<EntradaViewModel> LerTransacoes(DateTime inicio, DateTime fim)
        {
            string sql = $"SELECT PE.QUANTIDADE,PE.VALOR_UNITARIO,PE.PRODUTOS_ID,PE.ENTRADA_ID,E.ID," +
                $"E.FORNECEDORES_ID,E.PRECO,E.FUNCIONARIOS_ID,E.DATA_ENTRADA,E.FORMA_PAGAMENTO,P.ID AS P_ID," +
                $"P.NOME_PRODUTO,FO.RAZAO_SOCIAL,FU.NOME_FUNCIONARIO FROM PRODUTOS_ENTRADAS PE " +
                $"INNER JOIN ENTRADAS E ON PE.ENTRADA_ID = E.ID " +
                $"INNER JOIN PRODUTOS P ON PE.PRODUTOS_ID = P.ID " +
                $"INNER JOIN FORNECEDORES FO ON E.FORNECEDORES_ID = FO.ID " +
                $"INNER JOIN FUNCIONARIOS FU ON E.FUNCIONARIOS_ID = FU.ID " +
                $"WHERE DATA_ENTRADA BETWEEN @inicio AND @fim";

            DbConnection db = new DbConnection();

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@inicio", inicio);
            command.Parameters.AddWithValue("@fim", fim);
            db.AttachCommand(command);
            command.CommandText = sql;
            try
            {
                
                 db.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<EntradaViewModel> entradas = new List<EntradaViewModel>();
                while (reader.Read())
                {


                }
                return ResponseFactory.CreateInstance().CreateDataSuccessResponse(entradas);
            }
            catch (Exception ex)
            {
                return new DataResponse<EntradaViewModel>("Erro no banco de dados, contate o administrador.", false, null);
            }
        
        }
                

    }
}


