namespace Bookify.Infrastructure.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Bookify.Domain.Apartments;
using Bookify.Domain.Bookings;
using Microsoft.EntityFrameworkCore;

internal sealed class BookingRepository : Repository<Booking>, IBookingRepository
{
    private static BookingStatus[] ActiveBookingStatuses =
    {
        BookingStatus.Reserved,
        BookingStatus.Confirmed,
        BookingStatus.Completed
    };

    public BookingRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }

    public async Task<bool> IsOverlappingAsync(Apartment apartment, DateRange duration, CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<Booking>()
            .AnyAsync(x =>
                x.ApartmentId == apartment.Id &&
                x.Duration.Start <= duration.End &&
                x.Duration.End >= duration.Start &&
                ActiveBookingStatuses.Contains(x.Status),
                cancellationToken);
    }
}
