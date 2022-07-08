using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// Classe que realiza as operacoes de banco de dados do Produto
    /// </summary>
    public class ProdutoDal : ICRUD<Produto>
    {
        public Response Insert(Produto item)
        {
            string sql = $"INSERT INTO PRODUTOS (NOME_PRODUTO,DESCRICAO,ID_LABORATORIO,VALOR_UNITARIO,VALOR_VENDA) VALUES (@NOME_PRODUTO,@DESCRICAO,@ID_LABORATORIO,@VALOR_UNITARIO,@VALOR_VENDA)";
             
            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@NOME_PRODUTO", item.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", item.Descricao);
            command.Parameters.AddWithValue("@ID_LABORATORIO", item.ID_Laboratorio.ID);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.Valor_Unitario);
            command.Parameters.AddWithValue("@VALOR_VENDA", item.Valor_Venda);
            try
            {
                DbExecuter dbexecutor = new();
                DbExecuter.Execute(command);
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("UQ_PRODUTO_NOME"))
                {
                    return ResponseFactory.CreateInstance().CreateFailedUniqueName();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public SingleResponse<Produto> GetByIDEstoque(int iDProduto)
        {
            string sql = $"SELECT QUANTIA_ESTOQUE FROM PRODUTOS WHERE ID = @ID";

            DbConnection db = new();
            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", iDProduto);
            db.AttachCommand(command);
            command.CommandText = sql;
            Produto produto = new();
            try
            {
                db.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    produto.Quantia_Estoque = (double)reader["QUANTIA_ESTOQUE"];
                }
                return ResponseFactory.CreateInstance().CreateSingleSuccessResponse(produto);
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Produto>(null);
            }
        }
        public Response Update(Produto item)
        {
            string sql = $"UPDATE PRODUTOS SET NOME_PRODUTO = @NOME_PRODUTO, DESCRICAO = @DESCRICAO, ID_LABORATORIO = @ID_LABORATORIO, VALOR_UNITARIO = @VALOR_UNITARIO,VALOR_VENDA = @VALOR_VENDA,ATIVO = @ATIVO WHERE ID = @ID";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@NOME_PRODUTO", item.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", item.Descricao);
            command.Parameters.AddWithValue("@ID_LABORATORIO", item.ID_Laboratorio.ID);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.Valor_Unitario);
            command.Parameters.AddWithValue("@VALOR_VENDA", item.Valor_Venda);
            command.Parameters.AddWithValue("@ID", item.ID);
            command.Parameters.AddWithValue("@ATIVO", item.Ativo);
            try
            {
                DbExecuter dbexecutor = new();
                DbExecuter.Execute(command);
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_PRODUTO_NOME"))
                {
                    return ResponseFactory.CreateInstance().CreateFailedUniqueName();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public  Response SetEstoque(double quantidade,int id)
        {
            string sql = "UPDATE PRODUTOS SET QUANTIA_ESTOQUE = @QUANTIA_ESTOQUE WHERE ID = @ID";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@QUANTIA_ESTOQUE", quantidade);
            try
            {
                DbExecuter dbexecutor = new();
                DbExecuter.Execute(command);
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public Response Disable(int iDCLiente)
        {
            string sql = $"UPDATE PRODUTOS SET ATIVO = 0 WHERE ID = @ID";

            SqlCommand command = new(sql);

            command.Parameters.AddWithValue("@ID", iDCLiente);
            try
            {
                DbExecuter dbexecutor = new();
                DbExecuter.Execute(command);
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM PRODUTOS WHERE ID = @ID";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new();
                DbExecuter.Execute(command);
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public DataResponse<Produto> GetAll()
        {
            string sql = $"SELECT P.ID,P.NOME_PRODUTO,P.DESCRICAO,P.VALOR_UNITARIO,P.VALOR_VENDA,P.QUANTIA_ESTOQUE,P.ATIVO, L.RAZAO_SOCIAL ,L.ID AS L_ID FROM PRODUTOS P INNER JOIN LABORATORIOS L ON P.ID_LABORATORIO = L.ID";

            DbConnection db = new();
            SqlCommand command = new(sql);
            db.AttachCommand(command);
            command.CommandText = sql;
            try
            {
                db.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new();
                while (reader.Read())
                {
                    Laboratorio l = new();
                    Produto p = new()
                    {
                        ID = (int)reader["ID"],
                        Nome = (string)reader["NOME_PRODUTO"],
                        Descricao = (string)reader["DESCRICAO"],
                        Valor_Unitario = (double)reader["VALOR_UNITARIO"],
                        Valor_Venda = (double)reader["VALOR_VENDA"],
                        Quantia_Estoque = (double)reader["QUANTIA_ESTOQUE"],
                        Ativo = (bool)reader["ATIVO"]
                    };
                    l.Razao_Social = (string)reader["RAZAO_SOCIAL"];
                    l.ID = (int)reader["L_ID"];
                        p.ID_Laboratorio = l;
                    produtos.Add(p);
                }
                return ResponseFactory.CreateInstance().CreateDataSuccessResponse(produtos);


            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateDataFailedResponse<Produto>();
            }
        }
        public SingleResponse<Produto> GetByID(int id)
        {
            string sql = $"SELECT P.ID AS P_ID," +
                $"                P.NOME_PRODUTO,P.DESCRICAO,P.VALOR_UNITARIO,P.VALOR_VENDA,P.QUANTIA_ESTOQUE,P.ATIVO, L.RAZAO_SOCIAL,L.ID AS L_ID FROM PRODUTOS P INNER JOIN LABORATORIOS L ON P.ID_LABORATORIO = L.ID WHERE P.ID = @ID";

            DbConnection db = new();
            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", id);
            db.AttachCommand(command);
            command.CommandText = sql;
            Produto p = new();
            try
            {
                db.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Laboratorio l = new();
                    p.ID = (int)reader["P_ID"];
                    p.Nome = (string)reader["NOME_PRODUTO"];
                    p.Descricao = (string)reader["DESCRICAO"];
                    p.Valor_Unitario = (double)reader["VALOR_UNITARIO"];
                    p.Valor_Venda = (double)reader["VALOR_VENDA"];
                    p.Quantia_Estoque = (double)reader["QUANTIA_ESTOQUE"];
                    p.Ativo = (bool)reader["ATIVO"];
                    l.Razao_Social = (string)reader["RAZAO_SOCIAL"];
                    p.ID_Laboratorio = l;
                    p.ID_Laboratorio.ID = (int)reader["L_ID"];
                }
                return ResponseFactory.CreateInstance().CreateSingleSuccessResponse(p);
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Produto>(null);
            }
        }
    }
}
