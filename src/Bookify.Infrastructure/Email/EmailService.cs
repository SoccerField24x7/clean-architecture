namespace Bookify.Infrastructure.Email;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Application.Abstractions.Email;

internal sealed class EmailService : IEmailService
{
    public Task SendAsync(Domain.Users.Email recipient, string subject, string body)
    {
        return Task.CompletedTask;
    }
}
