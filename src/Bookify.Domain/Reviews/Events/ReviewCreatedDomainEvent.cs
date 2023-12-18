namespace Bookify.Domain.Reviews.Events;

using Bookify.Domain.Abstractions;

public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;