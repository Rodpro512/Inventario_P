using Microsoft.Data.SqlClient;

namespace Inventario_P.Context
{ 
    public class Context
    {
        private readonly string connectionString;
        public Context()
        {
            connectionString = "server=PROYECTO15\\SQL_NICOLAS;database=Inventario;integrated security=TRUE; TrustServerCertificate=True";
        }

        public SqlConnection CloseConnection()
        {
            var con = new SqlConnection(connectionString);
            con.Close();
            return con;
        }
        public SqlConnection OpenConnection()
        {
            var con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
    }
}