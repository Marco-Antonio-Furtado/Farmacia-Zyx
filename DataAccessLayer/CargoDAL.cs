using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CargoDAL : ICRUD<Cargo>
    {
        public Response Delete(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Response Insert(Cargo item)
        {
            throw new NotImplementedException();
        }

        public Response Update(Cargo item)
        {
            throw new NotImplementedException();
        }
    }
}
