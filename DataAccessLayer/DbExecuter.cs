using Entities;
using Shared;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DataAccessLayer
{
    internal class DbExecuter
    {
        internal static int ExecuteScalar(SqlCommand command)
        {
            DbConnection conn = new DbConnection();
            try
            {
                conn.AttachCommand(command);
                conn.Open();
                int ID = Convert.ToInt32(command.ExecuteScalar());
                return ID;
            }
            finally
            {
                conn.Close();
            }
        }
        internal static Response Execute(SqlCommand command)
        {
            DbConnection conn = new DbConnection();
            try
            {
                conn.AttachCommand(command);
                conn.Open();
                command.ExecuteNonQuery();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            finally
            {
                conn.Close();
            }
        }
        internal static DataResponse<T> GetData<T>(SqlCommand command)
        {
            DbConnection conn = new DbConnection();

            try
            {
                conn.AttachCommand(command);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new();
                dt.Load(reader);
                return ResponseFactory.CreateInstance().CreateDataSuccessResponse(dt.ToTable<T>());

            }
            finally
            {
                conn.Close();
            }
        }
        internal static SingleResponse<T> GetItem<T>(SqlCommand command)
        {
            DbConnection conn = new DbConnection();

            try
            {
                conn.AttachCommand(command);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return ResponseFactory.CreateInstance().CreateSingleSuccessResponse(dt.Rows[0].ToItem<T>());
            }
            finally
            {
                conn.Close();
            }
        }

        internal static SingleResponse<Funcionario> Login(SqlCommand command)
        {
            DbConnection conn = new DbConnection();
            try
            {
                conn.AttachCommand(command);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Funcionario f = new Funcionario();
                Cargo C = new Cargo();  
                if (reader.Read())
                {
                    f.ID = Convert.ToInt32(reader["ID"]);
                    C.Nome_Cargo = Convert.ToString(reader["NOME_CARGO"]);
                    f.Cargo = C;
                    f.Senha = Convert.ToString(reader["SENHA"]);
                    f.Nome_Funcionario = Convert.ToString(reader["NOME_FUNCIONARIO"]);
                    f.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                }
                return ResponseFactory.CreateInstance().CreateSingleSuccessResponse<Funcionario>(f);
            }
            finally
            {
                conn.Close();
            }
        } 
}
    internal static class SqlExtensions
    {
        public static T ToItem<T>(this DataRow item)
        {
            PropertyInfo[] propriedades = typeof(T).GetProperties();
            T t = Activator.CreateInstance<T>();

            foreach (var prop in propriedades)
            {
                prop.SetValue(t, item[prop.Name]);
            }
            return t;
        }

        public static List<T> ToTable<T>(this DataTable dt)
        {
            List<T> items = new List<T>();

            PropertyInfo[] propriedades = typeof(T).GetProperties();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow registro = dt.Rows[i];
                T t = Activator.CreateInstance<T>();
                //
                foreach (PropertyInfo propriedade in propriedades)
                {
                    propriedade.SetValue(t, dt.Rows[i][propriedade.Name]);
                }
                items.Add(t);
            }
            return items;
        }
    }
}


