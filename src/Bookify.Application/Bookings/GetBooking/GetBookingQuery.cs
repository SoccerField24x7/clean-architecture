namespace Bookify.Application.Bookings.GetBooking;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Application.Abstractions.Messaging;

public record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;
