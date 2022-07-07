using Entities;
using Shared;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DataAccessLayer
{
    /// <summary>
    /// classe que facilita e deixa automatico a maioria das funcoes do dal
    /// </summary>
    internal class DbExecuter
    {
        /// <summary>
        /// Executa o db conection e executa o comando retornando o ID do banco gerado
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        internal static int ExecuteScalar(SqlCommand command)
        {
            DbConnection conn = new();
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
        /// <summary>
        /// metodo que executa o dbconection e executa o comando retornando apenas o boleano se a operacao foi bem sucedida ou nao 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        internal static Response Execute(SqlCommand command)
        {
            DbConnection conn = new();
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

        /// <summary>
        /// metodo que Executa o db conection devolve uma lista de dados da classe que a invocou
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        /// <returns></returns>
        internal static DataResponse<T> GetData<T>(SqlCommand command)
        {
            DbConnection conn = new();

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

        /// <summary>
        /// metodo que Executa o db conection devolve um item de dado da classe que a invocou
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        /// <returns></returns>
        internal static SingleResponse<T> GetItem<T>(SqlCommand command)
        {
            DbConnection conn = new();

            try
            {
                conn.AttachCommand(command);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new();
                dt.Load(reader);
                return ResponseFactory.CreateInstance().CreateSingleSuccessResponse(dt.Rows[0].ToItem<T>());
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// metodo que lê no banco o usuario que esta tentando logar e traz os dados do funcionario
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        internal static SingleResponse<Funcionario> Login(SqlCommand command)
        {
            DbConnection conn = new();
            try
            {
                conn.AttachCommand(command);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Funcionario f = new();
                Cargo C = new();  
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
        /// <summary>
        /// metodo que inicializa a classe que a chamou e povoa a mesma com itens do banco de dados
        /// com as propriedades da mesma que a invocou (Comparando os nomes das duas)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
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

        /// <summary>
        /// metodo que inicializa a classe que a chamou e povoa a mesma com itens do banco de dados
        /// com as propriedades da mesma que a invocou (Comparando os nomes das duas)
        /// depois para cada iten no banco que ele chamou,
        /// adiciona em uma lista de itens retornando assim uma lista de itens da classe que o invocou 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<T> ToTable<T>(this DataTable dt)
        {
            List<T> items = new();

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


