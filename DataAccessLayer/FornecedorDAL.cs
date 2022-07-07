using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// Classe que realiza as operacoes de banco de dados do Fornecedor
    /// </summary>
    public class FornecedorDAL : ICRUD<Fornecedor>
    {
        public Response Insert(Fornecedor fornecedor)
        {
            string sql = $"INSERT INTO FORNECEDORES (RAZAO_SOCIAL,CNPJ,EMAIL,TELEFONE,NOME_CONTATO,ATIVO) VALUES (@RAZAO_SOCIAL,@CNPJ,@EMAIL,@TELEFONE,@NOME_CONTATO,@ATIVO)";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.Razao_Social);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.Nome_Contato);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);
            command.Parameters.AddWithValue("@ATIVO", fornecedor.Ativo);
            try
            {
                DbExecuter dbexecutor = new();
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDOR_EMAIL"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueEmail();
                }
                if (ex.Message.Contains("UQ_FORNECEDOR_CNPJ"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueCnpj();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public Response Disable(int iDCLiente)
        {
            string sql = $"UPDATE FORNECEDORES SET ATIVO = 0 WHERE ID = @ID";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", iDCLiente);
            try
            {
                DbExecuter dbexecutor = new();
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public Response Update(Fornecedor fornecedor)
        {
            string sql = $"UPDATE FORNECEDORES SET RAZAO_SOCIAL = @RAZAO_SOCIAL,NOME_CONTATO = @NOME_CONTATO,CNPJ = @CNPJ,EMAIL = @EMAIL, TELEFONE = @TELEFONE,ATIVO = @ATIVO WHERE ID = @ID";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.Razao_Social);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.Nome_Contato);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);
            command.Parameters.AddWithValue("@ID", fornecedor.ID);
            command.Parameters.AddWithValue("@ATIVO", fornecedor.Ativo);
            try
            {
                DbExecuter dbexecutor = new();
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDOR_EMAIL"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueEmail();
                }
                if (ex.Message.Contains("UQ_FORNECEDOR_CNPJ"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueCnpj();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM FORNECEDORES WHERE ID = @ID";

            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new();
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public DataResponse<Fornecedor> GetAll()
        {
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL,ATIVO FROM FORNECEDORES";

            SqlCommand command = new(sql);
            try
            {
                DbExecuter dbExecuter = new();
                return DbExecuter.GetData<Fornecedor>(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateDataFailedResponse<Fornecedor>();
            }

        }
        public SingleResponse<Fornecedor> GetByID(int id)
        {
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL,ATIVO FROM FORNECEDORES WHERE ID = @ID";
          
            SqlCommand command = new(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new();
                return DbExecuter.GetItem<Fornecedor>(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Fornecedor>(null);
            }
        }
    }
}

