using Entities;
using Shared;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class LaboratorioDAL : ICRUD<Laboratorio>
    {
        public Response Insert(Laboratorio item)
        {
            string sql = $"INSERT INTO LABORATORIOS (RAZAO_SOCIAL,CNPJ,EMAIL,TELEFONE,NOME_CONTATO) VALUES (@RAZAO_SOCIAL,@CNPJ,@EMAIL,@TELEFONE,@NOME_CONTATO)";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", item.Razao_Social);
            command.Parameters.AddWithValue("@NOME_CONTATO", item.Nome_Contato);
            command.Parameters.AddWithValue("@CNPJ", item.CNPJ);
            command.Parameters.AddWithValue("@EMAIL", item.Email);
            command.Parameters.AddWithValue("@TELEFONE", item.Telefone);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_LABORATORIOS_EMAIL"))
                {
                    return ResponseFactory.CreateInstance().CreateFailedUniqueEmail();
                }
                if (ex.Message.Contains("UQ_LABORATORIOS_CNPJ"))
                {
                    return ResponseFactory.CreateInstance().CreateFailedUniqueCnpj();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public Response Disable(int iDCLiente)
        {
            string sql = $"UPDATE LABORATORIOS SET ATIVO = 0 WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@ID", iDCLiente);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public Response Update(Laboratorio item)
        {
            string sql = $"UPDATE LABORATORIOS SET RAZAO_SOCIAL = @RAZAO_SOCIAL,NOME_CONTATO = @NOME_CONTATO,CNPJ = @CNPJ,EMAIL = @EMAIL, TELEFONE = @TELEFONE, ATIVO = @ATIVO WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", item.ID);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", item.Razao_Social);
            command.Parameters.AddWithValue("@NOME_CONTATO", item.Nome_Contato);
            command.Parameters.AddWithValue("@CNPJ", item.CNPJ);
            command.Parameters.AddWithValue("@EMAIL", item.Email);
            command.Parameters.AddWithValue("@TELEFONE", item.Telefone);
            command.Parameters.AddWithValue("@ATIVO", item.Ativo);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                DbExecuter.Execute(command);
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_LABORATORIOS_EMAIL"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueEmail();
                }
                if (ex.Message.Contains("UQ_LABORATORIOS_CNPJ"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueCnpj();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM LABORATORIOS WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter.Execute(command);
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_PRODUTO_LABORATORIO"))
                {
                    return ResponseFactory.CreateInstance().CreateFailedForeignProdutoLab();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public DataResponse<Laboratorio> GetAll()
        {
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,EMAIL,TELEFONE,NOME_CONTATO,ATIVO FROM LABORATORIOS";

            SqlCommand command = new SqlCommand(sql);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return DbExecuter.GetData<Laboratorio>(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateDataFailedResponse<Laboratorio>();
            }
        }

        public SingleResponse<Laboratorio> GetByID(int id)
        {
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,EMAIL,TELEFONE,NOME_CONTATO,ATIVO FROM LABORATORIOS WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return DbExecuter.GetItem<Laboratorio>(command);
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Laboratorio>(null);
            }
        }
    }
}
