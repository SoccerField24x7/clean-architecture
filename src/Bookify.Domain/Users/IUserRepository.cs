namespace Bookify.Domain.Users;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    void Add(User user);
}
