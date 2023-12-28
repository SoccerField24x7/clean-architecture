namespace Bookify.Infrastructure.Data;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Application.Abstractions.Data;
using Npgsql;

public class SqlConnectionFactory : ISqlConnectionFactory
{
    private readonly string _connectionString;

    public SqlConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IDbConnection CreateConnection()
    {
        NpgsqlConnection connection = new(_connectionString);
        connection.Open();

        return connection;
    }
}