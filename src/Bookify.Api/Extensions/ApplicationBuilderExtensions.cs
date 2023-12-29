namespace Bookify.Api.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Infrastructure;
using Microsoft.EntityFrameworkCore;

public static class ApplicationBuilderExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        using ApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        dbContext.Database.Migrate();
    }
}
