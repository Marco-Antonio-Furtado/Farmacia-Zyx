using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LaboratorioDAL : ICRUD<Laboratorio>
    {
        public Response Insert(Laboratorio item)
        {
            string sql = $"INSERT INTO LABORATORIOS (NOME,CNPJ) VALUES (@NOME,@CNPJ)";

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", item.CNPJ);

            try
            {
                DbExecuter dbexecutor = new DbExecuter();
                dbexecutor.Execute(command);
                return new Response("Laboratório cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_LABORATORIOS_NOME"))
                {
                    return new Response("Nome informado já está em uso.", false);
                }
                if (ex.Message.Contains("UQ_LABORATORIOS_CNPJ"))
                {
                    return new Response("CNPJ informado já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
        }

        public Response Update(Laboratorio item)
        {
            throw new NotImplementedException();
        }
        public Response Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataResponse<Laboratorio> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Laboratorio> GetByID(int id)
        {
            throw new NotImplementedException();
        }

    }
}
