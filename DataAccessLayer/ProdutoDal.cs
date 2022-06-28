using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProdutoDal : ICRUD<Produto>
    {
        public Response Insert(Produto item)
        {
            string sql = $"INSERT INTO PRODUTOS (NOME_PRODUTO,DESCRICAO,ID_LABORATORIO,VALOR_UNITARIO,VALOR_VENDA) VALUES (@NOME_PRODUTO,@DESCRICAO,@ID_LABORATORIO,@VALOR_UNITARIO,@VALOR_VENDA)";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@NOME_PRODUTO", item.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", item.Descricao);
            command.Parameters.AddWithValue("@ID_LABORATORIO", item.ID_Laboratorio.ID);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.Valor_Unitario);
            command.Parameters.AddWithValue("@VALOR_VENDA", item.Valor_Venda);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Produto cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("UQ_PRODUTO_NOME"))
                {
                    return new Response("NOME já está em uso.", false);
                }
                return new Response(ex.Message.ToString(), false);
            }
        }

        public Response Update(Produto item)
        {
            string sql = $"UPDATE PRODUTOS SET NOME_PRODUTO = @NOME_PRODUTO, DESCRICAO = @DESCRICAO, ID_LABORATORIO = @ID_LABORATORIO, VALOR_UNITARIO = @VALOR_UNITARIO,VALOR_VENDA = @VALOR_VENDA WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@NOME_PRODUTO", item.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", item.Descricao);
            command.Parameters.AddWithValue("@ID_LABORATORIO", item.ID_Laboratorio.ID);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.Valor_Unitario);
            command.Parameters.AddWithValue("@VALOR_VENDA", item.Valor_Venda);
            command.Parameters.AddWithValue("@ID", item.ID);

            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Produto Alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_PRODUTO_NOME"))
                {
                    return new Response("NOME já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
        }

        public Response Disable(int iDCLiente)
        {
            string sql = $"UPDATE PRODUTOS SET ATIVO = 0 WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@ID", iDCLiente);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Produto Alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                return new Response("Erro no banco de dados" + "\r\n" + "contate o administrador", false);
            }
        }

        public Response Delete(int id)
        {
            string sql = "DELETE FROM PRODUTOS WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Produto Excluido com sucesso.", true);
            }
            catch (Exception ex)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
        }

        public DataResponse<Produto> GetAll()
        {
            string sql = $"SELECT P.ID,P.NOME_PRODUTO,P.DESCRICAO,P.VALOR_UNITARIO,P.VALOR_VENDA,P.QUANTIA_ESTOQUE,P.ATIVO, L.RAZAO_SOCIAL FROM PRODUTOS P INNER JOIN LABORATORIOS L ON P.ID_LABORATORIO = L.ID";

            DbConnection db = new DbConnection();
            SqlCommand command = new SqlCommand(sql);
            db.AttachCommand(command);
            command.CommandText = sql;
            try
            {
                db.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                while (reader.Read())
                {
                    Laboratorio l = new Laboratorio();
                    Produto p = new Produto()
                    {
                        ID = (int)reader["ID"],
                        Nome = (string)reader["NOME_PRODUTO"],
                        Descricao = (string)reader["DESCRICAO"],
                        Valor_Unitario = (double)reader["VALOR_UNITARIO"],
                        Valor_Venda = (double)reader["VALOR_VENDA"],
                        Quantia_Estoque = (int)reader["QUANTIA_ESTOQUE"],
                        Ativo = (bool)reader["ATIVO"]
                    };
                    l.Razao_Social = (string)reader["RAZAO_SOCIAL"];
                        p.ID_Laboratorio = l;
                    produtos.Add(p);
                }
                DataResponse<Produto> response = new DataResponse<Produto>("DADOS SELECIONADOS COM SUCESSO", true, produtos);
                return response;
            }
            catch (Exception ex)
            {
                return new DataResponse<Produto>(ex.Message, false, null);
            }
        }

        public SingleResponse<Produto> GetByID(int id)
        {
            string sql = $"SELECT P.ID,P.NOME_PRODUTO,P.DESCRICAO,P.VALOR_UNITARIO,P.VALOR_VENDA,P.QUANTIA_ESTOQUE,P.ATIVO, L.RAZAO_SOCIAL FROM PRODUTOS P INNER JOIN LABORATORIOS L ON P.ID_LABORATORIO = L.ID";

            DbConnection db = new DbConnection();
            SqlCommand command = new SqlCommand(sql);
            db.AttachCommand(command);
            command.CommandText = sql;
            Produto p = new Produto();
            try
            {
                db.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Laboratorio l = new Laboratorio();
                    p.ID = (int)reader["ID"];
                    p.Nome = (string)reader["NOME_PRODUTO"];
                    p.Descricao = (string)reader["DESCRICAO"];
                    p.Valor_Unitario = (double)reader["VALOR_UNITARIO"];
                    p.Valor_Venda = (double)reader["VALOR_VENDA"];
                    p.Quantia_Estoque = (int)reader["QUANTIA_ESTOQUE"];
                    p.Ativo = (bool)reader["ATIVO"];
                    l.Razao_Social = (string)reader["RAZAO_SOCIAL"];
                    p.ID_Laboratorio = l;
                }
                SingleResponse<Produto> response = new SingleResponse<Produto>("DADOS SELECIONADOS COM SUCESSO", true, p);
                return response;
            }
            catch (Exception ex)
            {
                return new SingleResponse<Produto>(ex.Message, false, null);
            }
        }
    }
}
