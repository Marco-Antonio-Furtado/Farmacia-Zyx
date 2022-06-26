using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class FornecedorDAL : ICRUD<Fornecedor>
    {
        public Response Insert(Fornecedor fornecedor)
        {
            string sql = $"INSERT INTO FORNECEDORES (RAZAO_SOCIAL,CNPJ,EMAIL,TELEFONE,NOME_CONTATO) VALUES (@RAZAO_SOCIAL,@CNPJ,@EMAIL,@TELEFONE,@NOME_CONTATO)";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.Razao_Social);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.Nome_Contato);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);

            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Fornecedor cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDOR_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FORNECEDOR_CNPJ"))
                {
                    return new Response("CPF já está em uso.", false);
                }
                return new Response("Erro no Sistema contate o administrados", false);
            }
        }
        public Response Update(Fornecedor fornecedor)
        {
            string sql = $"UPDATE FORNECEDOR SET RAZAO_SOCIAL = @RAZAO_SOCIAL,NOME_CONTATO = @NOME_CONTATO,CNPJ = @CNPJ,EMAIL = @EMAIL, TELEFONE = @TELEFONE WHERE ID = @ID";


            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.Razao_Social);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.Nome_Contato);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);


            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);

                //O QUE Q TA ACONTECENDO AQUI??????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????

                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Cliente excluido.", false);
                }
                return new Response("Cliente alterado com sucesso.", true);
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
            string sql = "DELETE FROM FORNECEDOR WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            

            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);

                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Fornecedor excluído com sucesso.", true);
                }
                return new Response("Fornecedor não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDOR_EMAIL"))
                {
                    return new Response("Email já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_FORNECEDOR_CNPJ"))
                {
                    return new Response("CPF já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
        }

        public DataResponse<Fornecedor> GetAll()
        {
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL,ATIVO FROM FORNECEDORES";

            SqlCommand command = new SqlCommand(sql);
            try
            {
                DbExecuter dbExecuter = new DbExecuter();
                return dbExecuter.GetData<Fornecedor>(command);
            }
            catch (Exception ex)
            {
                return new DataResponse<Fornecedor>("Erro Contato o administrador", false, null);
            }

        }

        public SingleResponse<Fornecedor> GetByID(int id)
        {
            string sql = $"SELECT * FROM FORNECEDOR WHERE ID = @ID";

          
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@ID", id);
            
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetItem<Fornecedor>(command);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Fornecedor>("Erro no banco de dados, contate o administrador. \r\n" + ex.Message, false, null);
            }
        }

        public SingleResponse<Fornecedor> GetByEmail(string email)
        {
            string sql = $"SELECT * FROM FORNECEDOR WHERE EMAIL = @EMAIL";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@EMAIL", email);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return dbexecutor.GetItem<Fornecedor>(command);
            }
            catch (Exception)
            {
                return new SingleResponse<Fornecedor>("Erro no banco de dados, contate o administrador.", false, null);
            }
        }
    }
}

