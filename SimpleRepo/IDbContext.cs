using System;
using System.Data;

namespace SimpleDbContext
{
    public interface IDbContext
    {
        void SetConnectionString(string connectionString);
        IDbConnection GetConnection();
    }
}
