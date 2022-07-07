using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// Classe que realiza as operacoes de banco de dados do Cargo
    /// </summary>
    public class CargoDAL
    {
        public DataResponse<Cargo> GetAll()
        {
            string sql = $"SELECT ID,NOME_CARGO,ATIVO FROM CARGOS";

            SqlCommand command = new(sql);
            try
            {
                DbExecuter dbExecuter = new();
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

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbExecuter = new();
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

            SqlCommand command = new(sql);

            command.Parameters.AddWithValue("@NOME", item.Nome_Cargo);
            try
            {
                DbExecuter dbexecutor = new();
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
