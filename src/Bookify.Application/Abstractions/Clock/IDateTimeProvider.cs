namespace Bookify.Application.Abstractions.Clock;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
