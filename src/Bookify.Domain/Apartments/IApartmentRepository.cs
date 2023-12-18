namespace Bookify.Domain.Apartments;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IApartmentRepository
{
    Task<Apartment> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
