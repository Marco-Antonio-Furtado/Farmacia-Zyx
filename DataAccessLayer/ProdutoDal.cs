using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProdutoDal : ICRUD<Produto>
    {
        public Response Insert(Produto item)
        {
            string sql = $"INSERT INTO PRODUTOS (NOME,DESCRICAO,ID_LABORATORIO,VALOR_UNITARIO) VALUES (@NOME,@DESCRICAO,@ID_LABORATORIO,@VALOR_UNITARIO)";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", item.Descricao);
            command.Parameters.AddWithValue("@ID_LABORATORIO", item.ID_Laboratorio);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.Valor_Unitario);


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

            string sql = $"UPDATE PRODUTOS SET NOME = @NOME, DESCRICAO = @DESCRICAO, LABORATORIO = @LABORATORIO, VALOR_UNITARIO = @VALOR_UNITARIO WHERE ID = @ID";
       

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", item.Descricao);
            command.Parameters.AddWithValue("@LABORATORIO", item.ID_Laboratorio);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.Valor_Unitario);

            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);

                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Cliente excluido.", false);
                }
                return new Response("Cliente alterado com sucesso.", true);
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
        public Response Delete(int id)
        {
            string sql = "DELETE FROM PRODUTO WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);

            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);

                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Produto excluído com sucesso.", true);
                }
                return new Response("Produto não excluído.", false);
            }
            catch (Exception)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
        }

        public DataResponse<Produto> GetAll()
        {
            string sql = $"SELECT ID,NOME,DESCRICAO,VALOR_UNITARIO,VALOR_VENDA,ID_LABORATORIO,QUANTIA_ESTOQUE,ATIVO FROM PRODUTOS";

            SqlCommand command = new SqlCommand(sql);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetData<Produto>(command);
            }
            catch (Exception ex)
            {
                return new DataResponse<Produto>(ex.Message, false, null);
            }
        }

        public SingleResponse<Produto> GetByID(int id)
        {
          
            string sql = $"SELECT * FROM PRODUTOS WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);

            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetItem<Produto>(command);
            }
            catch (Exception)
            {
                return new SingleResponse<Produto>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }
    }
}
