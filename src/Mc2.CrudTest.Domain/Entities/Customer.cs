using Mc2.CrudTest.Shared.Abstractions.Domain;
using Mc2.CrudTest.Domain.ValueObjects;

namespace Mc2.CrudTest.Domain.Entities;
public class Customer : AggregateRoot<CustomerId>
{
    public CustomerId Id { get; private set; }
    private CustomerFirstname _firstname;
    private CustomerLastname _lastname;
    private CustomerDateOfBirth _dateOfBirth;
    private CustomerPhoneNumber _phoneNumber;
    private CustomerEmail _email;
    private CustomerBankAccountNumber _bankAccountNumber;

    internal Customer(CustomerId id,
                    CustomerFirstname firstname,
                    CustomerLastname lastname,
                    CustomerDateOfBirth dateOfBirth,
                    CustomerPhoneNumber phoneNumber,
                    CustomerEmail email,
                    CustomerBankAccountNumber bankAccountNumber)
    {
        Id = id;
        _firstname = firstname;
        _lastname = lastname;
        _dateOfBirth = dateOfBirth;
        _phoneNumber = phoneNumber;
        _email = email;
        _bankAccountNumber = bankAccountNumber;
    }

    public Customer()
    {

    }
}