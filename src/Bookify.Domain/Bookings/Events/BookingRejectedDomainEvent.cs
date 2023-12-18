namespace Bookify.Domain.Bookings.Events;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Domain.Abstractions;

public sealed record BookingRejectedDomainEvent(Guid bookingId) : IDomainEvent;