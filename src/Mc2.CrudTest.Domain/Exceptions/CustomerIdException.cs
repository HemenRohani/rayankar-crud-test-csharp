using Mc2.CrudTest.Shared.Abstractions.Exceptions;

namespace Mc2.CrudTest.Domain.Exception;

public class CustomerIdException : CustomerException
{
    public CustomerIdException() : base("Customer ID cannot be empty.")
    {
    }
}