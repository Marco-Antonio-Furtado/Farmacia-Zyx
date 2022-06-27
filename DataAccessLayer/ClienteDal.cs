using Shared;
using System.Data.SqlClient;
using Entities;



namespace DataAccessLayer
{
    public class ClienteDAL : ICRUD<Cliente>
    {
        public Response Insert(Cliente cliente)
        {
            string sql = $"INSERT INTO CLIENTES (NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2) VALUES (@NOME,@CPF,@RG,@EMAIL,@TELEFONE,@TELEFONE2)";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", cliente.Telefone2);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Cliente cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    return new Response("CPF já está em uso.", false);
                }
                return new Response("Erro no banco de dados" + "\r\n" + "contate o administrador", false);
            }
        }

        public Response Disable(int iDCLiente)
        {
            string sql = $"UPDATE CLIENTES SET ATIVO = 0 WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@ID", iDCLiente);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Cliente Alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    return new Response("Cpf já está em uso.", false);
                }
                return new Response("Erro no banco de dados" + "\r\n" + "contate o administrador", false);
            }
        }

        public Response Update(Cliente cliente)
        {
            string sql = $"UPDATE CLIENTES SET NOME = @NOME, CPF = @CPF, RG = @RG, EMAIL = @EMAIL, TELEFONE = @TELEFONE, TELEFONE2 = @TELEFONE2 WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", cliente.Telefone2);
            command.Parameters.AddWithValue("@ID", cliente.ID);
            command.Parameters.AddWithValue("@ATIVO", cliente.Ativo);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Cliente Alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    return new Response("Cpf já está em uso.", false);
                }
                return new Response("Erro no banco de dados" + "\r\n" + "contate o administrador", false);
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM CLIENTES WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Cliente Excluido com sucesso.", true);
            }
            catch (Exception)
            {
                return new Response("Erro no banco de dados" + "\r\n" + "contate o administrador", false);
            }
        }
        public DataResponse<Cliente> GetAll()
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2,ATIVO,PROGRAMA_FIDELIDADE FROM CLIENTES";

            SqlCommand command = new SqlCommand(sql);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetData<Cliente>(command);
            }
            catch (Exception ex)
            {
                return new DataResponse<Cliente>(ex.Message, false, null);
            }
        }
        public SingleResponse<Cliente> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2,PROGRAMA_FIDELIDADE,ATIVO FROM CLIENTES WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetItem<Cliente>(command);
            }
            catch (Exception)
            {
                return new SingleResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }

        public SingleResponse<Cliente> GetByEmail(string email)
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2,PROGRAMA_FIDELIDADE,ATIVO FROM CLIENTES WHERE EMAIL = @EMAIL";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@EMAIL", email);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetItem<Cliente>(command);
            }
            catch (Exception)
            {
                return new SingleResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }
        public SingleResponse<Cliente> GetByCPF(string cpf)
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2,PROGRAMA_FIDELIDADE,ATIVO FROM CLIENTES WHERE CPF = @CPF";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@CPF",cpf);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetItem<Cliente>(command);
            }
            catch (Exception)
            {
                return new SingleResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }
    }
}