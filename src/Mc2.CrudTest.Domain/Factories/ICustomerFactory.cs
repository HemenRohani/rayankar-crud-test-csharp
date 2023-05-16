using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Domain.ValueObjects;

namespace Mc2.CrudTest.Domain.Factories
{
    public interface ICustomerFactory
    {
        Customer Create(CustomerId id,
                    CustomerFirstname firstname,
                    CustomerLastname lastname,
                    CustomerDateOfBirth dateOfBirth,
                    CustomerPhoneNumber phoneNumber,
                    CustomerEmail email,
                    CustomerBankAccountNumber bankAccountNumber);
    }
}
