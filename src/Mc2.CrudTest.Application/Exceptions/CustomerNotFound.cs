using Mc2.CrudTest.Shared.Abstractions.Exceptions;

namespace Mc2.CrudTest.Application.Exceptions;

public class CustomerNotFound : CustomerException
{
    public Guid Id { get; }

    public CustomerNotFound(Guid id) : base($"Customer with ID '{id}' was not found.")
        => Id = id;
}
