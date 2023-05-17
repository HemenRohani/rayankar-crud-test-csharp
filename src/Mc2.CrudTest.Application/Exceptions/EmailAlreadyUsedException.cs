using Mc2.CrudTest.Shared.Abstractions.Exceptions;

namespace Mc2.CrudTest.Application.Exceptions;

public class EmailAlreadyUsedException : CustomerException
{
    public string Email { get; }

    public EmailAlreadyUsedException(string email)
        : base($"Email '{email}' already used.")
    {
        Email = email;
    }
}
