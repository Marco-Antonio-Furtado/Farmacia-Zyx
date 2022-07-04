using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    internal class DbConnection
    {
        private SqlConnection conn;

        public DbConnection()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\MARCO-ZYX\BancoFarmaciaZYX.mdf;Integrated Security=True;Connect Timeout=30");
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
