using System;
using Microsoft.Extensions.Configuration;


namespace SimpleDbContext.AspNetCore
{
    public class DbContextBuilder
    {
        IDbContext _context;
        IConfiguration _config;
        public DbContextBuilder(IDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public DbContextBuilder UseConnectionString(string connectionString)
        {
            _context.SetConnectionString(connectionString);
            return this;
        }


        public DbContextBuilder UseConnectionStringName(string connectionStringName)
        {
            return UseConnectionString(_config.GetConnectionString(connectionStringName));
        }
    }
}
