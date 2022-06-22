using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class DbExecuter
    {
        public Response Execute(SqlCommand command)
        {
            DbConnection conn = new DbConnection();
            try
            {
                conn.AttachCommand(command);
                conn.Open();
                command.ExecuteNonQuery();
                return new Response("Comando executado com sucesso", true);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataResponse<T> GetData<T>(SqlCommand command)
        {
            DbConnection conn = new DbConnection();

            try
            {
                conn.AttachCommand(command);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataResponse<T> response = new DataResponse<T>("Comando executado com sucesso", true, dt.ToTable<T>());
                return response;
            }
            finally
            {
                conn.Close();

            }
        }
    }


    internal static class SqlExtensions
    {
        public static List<T> ToTable<T>(this DataTable dt)
        {
            List<T> items = new List<T>();

            PropertyInfo[] propriedades = typeof(T).GetProperties();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow registro = dt.Rows[i];
                T t = Activator.CreateInstance<T>();

                foreach (PropertyInfo propriedade in propriedades)
                {
                    propriedade.SetValue(t, dt.Rows[i][propriedade.Name]);
                }
                items.Add(t);
            }
            return items;
        }
    }



    internal class DbConnection
    {
        private SqlConnection conn;

        public DbConnection()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\FarmaciaZyx.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void Close()
        {
            conn.Dispose();
        }

        public void AttachCommand(SqlCommand command)
        {
            command.Connection = this.conn;
        }

    }
}
//-------------------------------------------------------------------------------------------------
//Exemplo de uso:
//public DataResponse<Cliente> GetAll()
//    {
//        string sql = $"SELECT ID,NOME,CPF,RG,TELEFONE_UM," +
//            $"TELEFONE_DOIS,EMAIL,PONTOS,ATIVO FROM CLIENTES";


//        SqlCommand command = new SqlCommand(sql);
//        try
//        {
//            return new DbExecuter().GetData<Cliente>(command);
//        }
//        catch (Exception ex)
//        {
//            return new DataResponse<Cliente>("Erro no banco de dados, contate  administrador", false, null);
//        }
//    }
//}
