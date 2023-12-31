namespace Bookify.Domain.Users;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Domain.Abstractions;
using Bookify.Domain.Users.Events;

public sealed class User : Entity
{
    public User(Guid id, FirstName firstName, LastName lastName, Email email)
        :base(id)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    private User()
    {}

    public FirstName FirstName { get; private set; }

    public LastName LastName { get; private set; }

    public Email Email { get; private set; }

    public static User Create(FirstName firstName, LastName lastName, Email email)
    {
        var user = new User(Guid.NewGuid(), firstName, lastName, email);

        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));

        return user;
    }
}
