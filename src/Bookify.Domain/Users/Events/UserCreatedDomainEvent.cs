namespace Bookify.Domain.Users.Events;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Domain.Abstractions;

public record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
