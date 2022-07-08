using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// Classe que realiza as operacoes de banco de dados do Endereco
    /// </summary>
    public class EnderecoDAL : ICRUD<Endereco>
    {

        public Response Insert(Endereco item)
        {
            string sql = $"INSERT INTO ENDERECOS (CEP, NOME_RUA, NUMERO_CASA, CIDADE_ID, ESTADO_ID) VALUES (@CEP, @NOME_RUA, @NUMERO_CASA, @CIDADE_ID, @ESTADO_ID); SELECT SCOPE_IDENTITY()";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@CEP", item.CEP);
            command.Parameters.AddWithValue("@NOME_RUA", item.NomeRua);
            command.Parameters.AddWithValue("@NUMERO_CASA", item.NumeroCasa);
            command.Parameters.AddWithValue("@CIDADE_ID", item.CidadeID);
            command.Parameters.AddWithValue("@ESTADO_ID", item.EstadoID);
            try
            {
                DbExecuter dbexecutor = new();
                item.ID = DbExecuter.ExecuteScalar(command);
                return new Response("Endereco cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_ENDERECO_CIDADE"))
                {
                    return new Response("Cidade deve ser uma chave estrangeira", false);
                }
                return new Response("Erro no banco de dados" + "\r\n" + "contate o administrador", false);
            }

        }
        public Response Update(Endereco item)
        {
            string sql = $"UPDATE ENDERECOS SET NOME_RUA = @NOME_RUA, CEP = @CEP, NUMERO_CASA = @NUMERO_CASA, CIDADE_ID = @CIDADE_ID, ESTADO_ID = @ESTADO_ID WHERE ID = @ID";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@CEP", item.CEP);
            command.Parameters.AddWithValue("@NOME_RUA", item.NomeRua);
            command.Parameters.AddWithValue("@NUMERO_CASA", item.NumeroCasa);
            command.Parameters.AddWithValue("@CIDADE_ID", item.CidadeID);
            command.Parameters.AddWithValue("@ESTADO_ID", item.EstadoID);
            command.Parameters.AddWithValue("@ID", item.ID);
            try
            {

                DbExecuter dbexecutor = new();
                DbExecuter.Execute(command);
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {

                return new Response(ex.Message, false);

            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM ENDERECO WHERE ID = @ID";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                
                DbExecuter.Execute(command);

                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Endereco excluído com sucesso.", true);
                }
                return new Response("Endereco não excluído.", false);
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("FK_ENDERECOS_FUNCIONARIOS"))
                {
                    return ResponseFactory.CreateInstance().CreateFailedForeignEndereco();
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
        }
        public DataResponse<Endereco> GetAll()
        {
            string sql = $"SELECT CEP,NOME_RUA,NUMERO_CASA,CIDADE_ID,ESTADO_ID FROM ENDERECOS";
            SqlCommand command = new(sql);
            try
            {
                DbExecuter dbExecuter = new();
                return DbExecuter.GetData<Endereco>(command);
            }
            catch (Exception)
            {
                return new DataResponse<Endereco>("Erro no banco de dados, contate o administrador", false, null);
            }
        }
        public SingleResponse<Endereco> GetByID(int id)
        {

            string query = $"SELECT CEP,NOME_RUA,NUMERO_CASA,CIDADE_ID,ESTADO_ID FROM ENDERECO WHERE ID = @ID";
            SqlCommand command = new(query);

            DbExecuter dbExecuter = new();
            command.Parameters.AddWithValue("@ID", id);
            try
            {
               return DbExecuter.GetItem<Endereco>(command);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Endereco>("Erro no banco de dados, contate o administrador. \r\n" + ex.Message, false, null);
            }
        }
    }
}
