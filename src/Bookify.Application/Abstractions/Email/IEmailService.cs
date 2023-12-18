namespace Bookify.Application.Abstractions.Email;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Users;

public interface IEmailService
{
    Task SendAsync(Email recipient, string subject, string body);
}
