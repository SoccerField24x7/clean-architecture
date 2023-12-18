namespace Bookify.Domain.Bookings;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public record DateRange
{
    public DateRange()
    {}

    public DateOnly Start { get; init; }
    public DateOnly End { get; init; }

    public int LengthInDays => End.DayNumber - Start.DayNumber;

    public static DateRange Create(DateOnly start, DateOnly end)
    {
        if (start > end)
        {
            throw new ApplicationException("End date precedes start date.");
        }

        return new DateRange
        {
            Start = start,
            End = end
        };
    }
}
