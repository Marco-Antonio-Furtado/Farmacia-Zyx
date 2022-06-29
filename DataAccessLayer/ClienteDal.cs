﻿using Shared;
using System.Data.SqlClient;
using Entities;



namespace DataAccessLayer
{
    public class ClienteDAL : ICRUD<Cliente>
    {
        public Response Insert(Cliente cliente)
        {
            string sql = $"INSERT INTO CLIENTES (NOME_CLIENTE,CPF,RG,EMAIL,TELEFONE,TELEFONE2,ATIVO) VALUES (@NOME_CLIENTE,@CPF,@RG,@EMAIL,@TELEFONE,@TELEFONE2,@ATIVO)";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.AddWithValue("@NOME_CLIENTE", cliente.Nome_Cliente);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", cliente.Telefone2);
            command.Parameters.AddWithValue("@ATIVO", cliente.Ativo);

            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueEmail();
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueCpf();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
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
                return DbExecuter.Execute(command);               
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public Response Update(Cliente cliente)
        {
            string sql = $"UPDATE CLIENTES SET NOME_CLIENTE = @NOME_CLIENTE, CPF = @CPF, RG = @RG, EMAIL = @EMAIL, TELEFONE = @TELEFONE, TELEFONE2 = @TELEFONE2,ATIVO = @ATIVO WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@NOME_CLIENTE", cliente.Nome_Cliente);
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
                return DbExecuter.Execute(command);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueEmail();
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    ResponseFactory.CreateInstance().CreateFailedUniqueCpf();
                }
                return ResponseFactory.CreateInstance().CreateFailedResponse();
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
                return DbExecuter.Execute(command);
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }
        public DataResponse<Cliente> GetAll()
        {
            string sql = $"SELECT ID,NOME_CLIENTE,CPF,RG,EMAIL,TELEFONE,TELEFONE2,ATIVO,PROGRAMA_FIDELIDADE FROM CLIENTES";

            SqlCommand command = new SqlCommand(sql);
            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                return DbExecuter.GetData<Cliente>(command);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateDataFailedResponse<Cliente>();
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
                return DbExecuter.GetItem<Cliente>(command);
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Cliente>(null);

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
                return DbExecuter.GetItem<Cliente>(command);
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Cliente>(null);

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
                return DbExecuter.GetItem<Cliente>(command);
            }
            catch (Exception)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<Cliente>(null);

            }
        }
    }
}