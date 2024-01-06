using System.Data.SqlClient;

namespace DatingProgram.Data
{
    internal class DataBase
    {
        public SqlConnection Connection => sqlConnection;

        private SqlConnection sqlConnection;
        
        public DataBase(string path)
        {
            sqlConnection = new SqlConnection(path);
        }

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void CloseConnection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }
    }
}
