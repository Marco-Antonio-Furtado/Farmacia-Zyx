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
                dbexecutor.Execute(command);
                return new Response("Laboratorio cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_LABORATORIOS_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_LABORATORIOS_CNPJ"))
                {
                    return new Response("CNPJ já está em uso.", false);
                }
                return new Response("Erro no Sistema contate o administrados", false);
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
                dbexecutor.Execute(command);
                return new Response("Laboratorio Alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                return new Response("Erro no banco de dados" + "\r\n" + "contate o administrador", false);
            }
        }
        public Response Update(Laboratorio item)
        {
            string sql = $"UPDATE LABORATORIOS SET RAZAO_SOCIAL = @RAZAO_SOCIAL,NOME_CONTATO = @NOME_CONTATO,CNPJ = @CNPJ,EMAIL = @EMAIL, TELEFONE = @TELEFONE WHERE ID = @ID";

            

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", item.ID);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", item.Razao_Social);
            command.Parameters.AddWithValue("@NOME_CONTATO", item.Nome_Contato);
            command.Parameters.AddWithValue("@CNPJ", item.CNPJ);
            command.Parameters.AddWithValue("@EMAIL", item.Email);
            command.Parameters.AddWithValue("@TELEFONE", item.Telefone);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Cliente Alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDOR_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM LABORATORIOS WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Laboratorio Excluido com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_PRODUTO_LABORATORIO"))
                {
                    return new Response("Voce nao pode Apagar um Laborario vinculado a um produto", false);
                }
                return new Response("Erro no Sistema contate o administrados", false);
            }
        }
        public DataResponse<Laboratorio> GetAll()
        {
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,EMAIL,TELEFONE,NOME_CONTATO,ATIVO FROM LABORATORIOS";

            SqlCommand command = new SqlCommand(sql);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetData<Laboratorio>(command);
            }
            catch (Exception ex)
            {
                return new DataResponse<Laboratorio>(ex.Message, false, null);
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
                return dbexecutor.GetItem<Laboratorio>(command);
            }
            catch (Exception)
            {
                return new SingleResponse<Laboratorio>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }
    }
}
