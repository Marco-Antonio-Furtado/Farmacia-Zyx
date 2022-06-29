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
internal class DbConnection
{
    private SqlConnection conn;

    public DbConnection()
    {
        conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\banco\BancoFarmaciaZYX.mdf;Integrated Security=True;Connect Timeout=5");
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
