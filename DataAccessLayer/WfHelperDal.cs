using Entities;
using Entities.Propriedades;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// Classe que ajuda o WfPresentationlayer que retorna os dados da cidade e estado 
    /// </summary>
    public class WfHelperDal 
    {
        public DataResponse<Cidade> GetAllCidade(int id)
        {
            string sql = $"SELECT ID,NOME_CIDADE,ID_ESTADO FROM CIDADES WHERE ID_ESTADO = @ID";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new();
                return DbExecuter.GetData<Cidade>(command);
            }
            catch (Exception ex)
            {
                return new DataResponse<Cidade>(ex.Message, false, null);
            }
        }
        public DataResponse<Estado> GetAllEstado()
        {
            string sql = $"SELECT ID,NOME_ESTADO,UF FROM ESTADOS";

            SqlCommand command = new(sql);
            try
            {
                DbExecuter dbexecutor = new();
                return DbExecuter.GetData<Estado>(command);
            }
            catch (Exception ex)
            {
                return new DataResponse<Estado>(ex.Message, false, null);
            }
        }
    }
}

