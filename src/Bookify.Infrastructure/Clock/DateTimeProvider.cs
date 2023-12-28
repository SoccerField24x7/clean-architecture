namespace Bookify.Infrastructure.Clock;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Application.Abstractions.Clock;
public sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
