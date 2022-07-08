using Entities;
using Entities.Propriedades;
using Entities.viewmodel;
using Shared;
using System.Data.SqlClient;
using System.Transactions;

namespace DataAccessLayer
{
    /// <summary>
    /// Classe que realiza as operacoes de banco de dados do Da saida de produtos
    /// </summary>
    public class SaidaDAL : ITransacaoProdutos<Saida, SaidaViewModel>
    {
        public SingleResponse<Saida> EfetuarTransacao(Saida transacao)
        {

            string sql1 = $"INSERT INTO SAIDAS (DATA_SAIDA,CLIENTES_ID,VALOR,FUNCIONARIOS_ID,FORMA_PAGAMENTO)" +
                       $" VALUES (@DATA,@CLIENTES_ID,@PRECO,@FUNCIONARIOS_ID,@FORMA_PAGAMENTO); SELECT SCOPE_IDENTITY()";

            SqlCommand commInsertSaida = new(sql1);
            commInsertSaida.Parameters.AddWithValue("@DATA", transacao.Data);
            commInsertSaida.Parameters.AddWithValue("@CLIENTES_ID", transacao.Cliente.ID);
            commInsertSaida.Parameters.AddWithValue("@FUNCIONARIOS_ID", transacao.IDFuncionario.ID);
            commInsertSaida.Parameters.AddWithValue("@PRECO", transacao.ValorTotal);
            commInsertSaida.Parameters.AddWithValue("@FORMA_PAGAMENTO", transacao.Forma_Pagamento);

            string sql2 = $"UPDATE CLIENTES SET PROGRAMA_FIDELIDADE = @PROGRAMA_FIDELIDADE WHERE ID = @CLIENTE_ID";


            SqlCommand commUpdateProgramaFidelidade = new(sql2);
            commUpdateProgramaFidelidade.Parameters.AddWithValue("@PROGRAMA_FIDELIDADE", transacao.Cliente.Programa_Fidelidade);
            commUpdateProgramaFidelidade.Parameters.AddWithValue("@CLIENTE_ID", transacao.Cliente.ID);

            using (TransactionScope scope = new())
            {
                try
                {
                    transacao.ID = DbExecuter.ExecuteScalar(commInsertSaida);
                    DbExecuter.Execute(commUpdateProgramaFidelidade);
                    foreach (var item in transacao.Items)
                    {
                        string sql3 = "INSERT INTO PRODUTOS_SAIDAS (SAIDA_ID,PRODUTOS_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@ENTRADA_ID,@PRODUTOS_ID,@QUANTIDADE,@VALOR_UNITARIO)";

                        SqlCommand commInsertProdutosSaida = new(sql3);
                        commInsertProdutosSaida.Parameters.AddWithValue("@ENTRADA_ID", transacao.ID);
                        commInsertProdutosSaida.Parameters.AddWithValue("@PRODUTOS_ID", item.IDProduto.ID);
                        commInsertProdutosSaida.Parameters.AddWithValue("@QUANTIDADE", item.Qtd);
                        commInsertProdutosSaida.Parameters.AddWithValue("@VALOR_UNITARIO", item.Preco);
                        Response response = DbExecuter.Execute(commInsertProdutosSaida);
                        if (!response.HasSuccess)
                        {
                            return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Saida>(null);
                        }
                    }
                    scope.Complete();
                    return ResponseFactory.CreateInstance().CreateSingleSuccessResponse(transacao);
                }
                catch (Exception)
                {
                    return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Saida>(null);
                }
            }
        }

        public SingleResponse<Saida> GetByID(int id)
        {
            string sql = $"SELECT ID,DATA_SAIDA,PRODUTO,CLIENTES_ID,QUANTIDADE,VALOR_UNITARIO,VALOR_TOTAL FROM SAIDAS WHERE ID = @ID";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbExecuter = new();
                return DbExecuter.GetItem<Saida>(command);
            }
            catch (Exception)
            {
                return new SingleResponse<Saida>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }

        public DataResponse<SaidaViewModel> LerTransacoes(DateTime inicio, DateTime fim)
        {
            string sql = $"SELECT PS.SAIDA_ID, P.NOME_PRODUTO, P.VALOR_UNITARIO, PS.QUANTIDADE,S.FORMA_PAGAMENTO, C.NOME_CLIENTE, S.VALOR, S.DATA_SAIDA, F.NOME_FUNCIONARIO FROM PRODUTOS_SAIDAS PS INNER JOIN SAIDAS S ON PS.SAIDA_ID = S.ID INNER JOIN PRODUTOS P ON PS.PRODUTOS_ID = P.ID INNER JOIN CLIENTES C ON S.CLIENTES_ID = C.ID INNER JOIN FUNCIONARIOS F ON S.FUNCIONARIOS_ID = F.ID WHERE DATA_SAIDA BETWEEN @inicio AND @fim";

            DbConnection db = new();
            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@inicio", inicio);
            command.Parameters.AddWithValue("@fim", fim);
            db.AttachCommand(command);
            command.CommandText = sql;
            try
            {
                db.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<SaidaViewModel> saidas = new();
                while (reader.Read())
                {
                    SaidaViewModel svm = new()
                    {
                        
                        NOME_FUNCIONARIO = Convert.ToString(reader["NOME_FUNCIONARIO"]),
                        SAIDA_ID = Convert.ToInt32(reader["SAIDA_ID"]),
                        NOME_PRODUTO = Convert.ToString(reader["NOME_PRODUTO"]),
                        VALOR_UNITARIO = Convert.ToDouble(reader["VALOR_UNITARIO"]),
                        Quantidade = Convert.ToDouble(reader["QUANTIDADE"]),
                        FORMA_PAGAMENTO = Convert.ToString(reader["FORMA_PAGAMENTO"]),
                        NOME_CLIENTE = Convert.ToString(reader["NOME_CLIENTE"]),
                        VALOR = Convert.ToDouble(reader["VALOR"]),
                        DATA_SAIDA = Convert.ToDateTime(reader["DATA_SAIDA"])
                    };
                    saidas.Add(svm);
                }
                return ResponseFactory.CreateInstance().CreateDataSuccessResponse(saidas);
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateDataFailedResponse<SaidaViewModel>();
            }
        }

        public DataResponse<SaidaViewModel> GetAll()
        {
            string sql = $"SELECT PS.SAIDA_ID, P.NOME_PRODUTO, P.VALOR_UNITARIO, PS.QUANTIDADE,S.FORMA_PAGAMENTO, C.NOME_CLIENTE, S.VALOR, S.DATA_SAIDA, F.NOME_FUNCIONARIO FROM PRODUTOS_SAIDAS PS INNER JOIN SAIDAS S ON PS.SAIDA_ID = S.ID INNER JOIN PRODUTOS P ON PS.PRODUTOS_ID = P.ID INNER JOIN CLIENTES C ON S.CLIENTES_ID = C.ID INNER JOIN FUNCIONARIOS F ON S.FUNCIONARIOS_ID = F.ID ";

            SqlCommand command = new(sql);
            try
            {
                DbExecuter dbexecutor = new();
                return DbExecuter.GetData<SaidaViewModel>(command);
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateDataFailedResponse<SaidaViewModel>();
            }
        }
    }
}
