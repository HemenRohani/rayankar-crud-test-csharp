using Mc2.CrudTest.Shared.Abstractions.Exceptions;

namespace Mc2.CrudTest.Application.Exceptions;

public class CustomerAlreadyExistsException : CustomerException
{
    public string Firstname { get; }
    public string Lastname { get; }
    public DateTime DateOfBirth { get; }

    public CustomerAlreadyExistsException(string firstname, string lastname, DateTime dateOfBirth)
        : base($"Customer with (Firstname :'{firstname}', Lastname : '{lastname}', DateOfBirth : '{dateOfBirth}') already exists.")
    {
        Firstname = firstname;
        Lastname = lastname;
        DateOfBirth = dateOfBirth;
    }
}
