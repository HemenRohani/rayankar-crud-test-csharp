using Mc2.CrudTest.Shared.Abstractions.Exceptions;

namespace Mc2.CrudTest.Domain.Exception;

public class InvalidCustomerPhoneNumberException : CustomerException
{
    public InvalidCustomerPhoneNumberException() : base("Customer PhoneNumber is invalid.")
    {
    }
}