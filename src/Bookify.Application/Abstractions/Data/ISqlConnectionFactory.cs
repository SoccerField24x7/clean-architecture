namespace Bookify.Application.Abstractions.Data;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

public interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}
