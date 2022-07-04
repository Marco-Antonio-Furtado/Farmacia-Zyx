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
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("FK_FUNCIONARIOS_CARGO"))
                {
                    return ResponseFactory.CreateInstance().CreateFailedForeignCargo();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public DataResponse<Cargo> GetAll()
        {
            string sql = $"SELECT ID,NOME_CARGO,ATIVO FROM CARGOS";

            SqlCommand command = new SqlCommand(sql);
            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                return DbExecuter.GetData<Cargo>(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateDataFailedResponse<Cargo>();

            }
        }
        public SingleResponse<Cargo> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME_CARGO FROM CARGOS WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                return DbExecuter.GetItem<Cargo>(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Cargo>(null);

            }
        }
        public Response Insert(Cargo item)
        {
            string sql = $"INSERT INTO CARGOS (NOME) VALUES (@NOME)";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@NOME", item.Nome_Cargo);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CARGOS_NOME"))
                {
                    return ResponseFactory.CreateInstance().CreateFailedUniqueName();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }

        public Response Update(Cargo item)
        {
            string sql = $"UPDATE CARGO SET NOME = @NOME WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@NOME", item.Nome_Cargo);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CARGOS_NOME"))
                {
                    return ResponseFactory.CreateInstance().CreateFailedUniqueName();

                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();

            }
        }
    }
    
}
