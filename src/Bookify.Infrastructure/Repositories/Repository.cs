namespace Bookify.Infrastructure.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

internal abstract class Repository<T>
    where T : Entity
{
    protected readonly ApplicationDbContext DbContext;

    protected Repository(ApplicationDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<T?> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default)
    {
        return await DbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
    }

    public void Add(T entity)
    {
        DbContext.Add(entity);
    }
}
