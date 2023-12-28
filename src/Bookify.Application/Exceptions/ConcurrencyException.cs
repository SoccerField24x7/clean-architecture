namespace Bookify.Application.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ConcurrencyException : Exception
{
    public ConcurrencyException(string message, Exception innerException)
        :base(message, innerException)
    {}
}
