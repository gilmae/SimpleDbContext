using System.Data;
using MySql.Data.MySqlClient;


namespace SimpleDbContext.Mysql
{
    public class MySqlContext : IDbContext
    {
        string _connectionString;
        public IDbConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        public void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
