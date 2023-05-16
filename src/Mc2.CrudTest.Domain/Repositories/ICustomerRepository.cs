using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Domain.ValueObjects;


namespace Mc2.CrudTest.Domain.Repositories;
public interface ICustomerRepository
{
    Task<Customer> GetAsync(CustomerId id);
    Task AddAsync(Customer customer);
    Task UpdateAsync(Customer customer);
    Task DeleteAsync(Customer customer);
}

