namespace Bookify.Api.Controllers.Bookings;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public sealed record ReserveBookingRequest
(
    Guid ApartmentId,
    Guid UserId,
    DateOnly StartDate,
    DateOnly EndDate);

