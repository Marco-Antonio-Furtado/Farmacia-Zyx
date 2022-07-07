using System.Data;
using System.Data.SqlClient;
using static System.Environment;

namespace DataAccessLayer
{
   

    /// <summary>
    /// classe que auxilia as operacoes do dal 
    /// </summary>
    internal class DbConnection
    {
        /// <summary>
        /// Caminho para banco de dados
        /// </summary>
        private SqlConnection conn;

        public DbConnection()
        {
            conn = new
                SqlConnection(@$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={FileLocator.GetInstance().GetPath()}\BancoFarmaciaZYX.mdf;Integrated Security=True;Connect Timeout=30");
        }
        /// <summary>
        /// Metodo que abre a conexao com o banco de dados
        /// </summary>
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        /// <summary>
        /// metodo que fecha a conexao
        /// </summary>
        public void Close()
        {
            conn.Dispose();
        }
        /// <summary>
        /// metodo que insere o comando do dal na conection
        /// </summary>
        /// <param name="command"></param>
        public void AttachCommand(SqlCommand command)
        {
            command.Connection = this.conn;
        }
    }
}
