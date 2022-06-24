using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class EnderecoDAL : ICRUD<Endereco>
    {

        public Response Insert(Endereco item)
        {
            string sql = $"INSERT INTO ENDERECO (CEP, NOME_RUA, NUMERO_CASA, CIDADE_ID, ESTADO_ID) VALUES (@CEP, @NOME_RUA, @NUMERO_CASA, @CIDADE_ID, @ESTADO_ID)";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@CEP", item.CEP);
            command.Parameters.AddWithValue("@NOME_RUA", item.NomeRua);
            command.Parameters.AddWithValue("@NUMERO_CASA", item.NumeroCasa);
            command.Parameters.AddWithValue("@CIDADE_ID", item.CidadeID);
            command.Parameters.AddWithValue("@ESTADO_ID", item.EstadoID);


            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                dbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_ENDERECO_CIDADE"))
                {
                    return new Response("Cidade deve ser uma chave estrangeira", false);
                }
                else
                {
                    return new Response(ex.Message, false);
                }
            }
            return new Response("Endereco cadastrado com sucesso", true);
        }

        public Response Update(Endereco item)
        {

            string sql = $"UPDATE CLIENTES SET NOME_RUA = @NOME_RUA, CEP = @CEP, NUMERO_CASA = @NUMERO_CASA, CIDADE_ID = @CIDADE_ID, ESTADO_ID = @ESTADO_ID WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@CEP", item.CEP);
            command.Parameters.AddWithValue("@NOME_RUA", item.NomeRua);
            command.Parameters.AddWithValue("@NUMERO_CASA", item.NumeroCasa);
            command.Parameters.AddWithValue("@CIDADE_ID", item.CidadeID);
            command.Parameters.AddWithValue("@ESTADO_ID", item.EstadoID);

            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                dbExecuter.Execute(command);
            }
            catch (Exception ex)
            {

                return new Response(ex.Message, false);

            }
            return new Response("Endereco alterado com sucesso", true);


        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM ENDERECO WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                dbExecuter.Execute(command);

                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Endereco excluído com sucesso.", true);
                }
                return new Response("Endereco não excluído.", false);
            }
            catch (Exception)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
        }

        public DataResponse<Endereco> GetAll()
        {
            string query = $"SELECT * FROM ENDERECOS";
            SqlCommand sql = new SqlCommand(query);
            try
            {
                return new DbExecuter().GetData<Endereco>(sql);
            }
            catch (Exception)
            {
                return new DataResponse<Endereco>("Erro no banco de dados, contate o administrador", false, null);
            }
        }

        public SingleResponse<Endereco> GetByID(int id)
        {

            string query = $"SELECT * FROM ENDERECO WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query);

            DbExecuter dbExecuter = new DbExecuter();
            command.Parameters.AddWithValue("@ID", id);
            try
            {
               return dbExecuter.GetItem<Endereco>(command);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Endereco>("Erro no banco de dados, contate o administrador. \r\n" + ex.Message, false, null);
            }
        }

    }
}
