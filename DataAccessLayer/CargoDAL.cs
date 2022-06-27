using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CargoDAL : ICRUD<Cargo>
    {
        public Response Delete(int id)
        {
            string sql = "DELETE FROM CARGOS WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Cargo Excluido com sucesso.", true);
            }
            catch (Exception)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
        }
        public DataResponse<Cargo> GetAll()
        {
            string sql = $"SELECT ID,NOME FROM CARGOS";

            SqlCommand command = new SqlCommand(sql);
            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                return dbExecuter.GetData<Cargo>(command);
            }
            catch (Exception ex)
            {
                return new DataResponse<Cargo>(ex.Message, false, null);
            }
        }
        public SingleResponse<Cargo> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME FROM CARGOS WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                return dbExecuter.GetItem<Cargo>(command);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Cargo>("Erro no banco de dados" + "\r\n" + "contate o administrador", false, null);
            }
        }
        public Response Insert(Cargo item)
        {
            string sql = $"INSERT INTO CARGOS (NOME) VALUES (@NOME)";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@NOME", item.Nome);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Cargo cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CARGOS_NOME"))
                {
                    return new Response("Nome Esta em uso", false);
                }
                return new Response("Erro no banco de dados" + "\r\n" + "contate o administrador", false);
            }
        }

        public Response Update(Cargo item)
        {
            string sql = $"UPDATE CARGO SET NOME = @NOME WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Cargo Alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CARGOS_NOME"))
                {
                    return new Response("Nome Esta em uso", false);
                }
                return new Response("Erro no banco de dados" + "\r\n" + "contate o administrador", false);
            }
        }
    }
    
}
