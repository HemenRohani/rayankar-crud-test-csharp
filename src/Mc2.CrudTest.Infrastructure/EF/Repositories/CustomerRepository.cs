using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Domain.Repositories;
using Mc2.CrudTest.Domain.ValueObjects;
using Mc2.CrudTest.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Mc2.CrudTest.Infrastructure.EF.Repositories;

internal sealed class CustomerRepository : ICustomerRepository
{
    private readonly DbSet<Customer> _customer;
    private readonly WriteDbContext _writeDbContext;

    public CustomerRepository(WriteDbContext writeDbContext)
    {
        _customer = writeDbContext.Customers;
        _writeDbContext = writeDbContext;
    }

    public Task<Customer> GetAsync(CustomerId id)
        => _customer.SingleOrDefaultAsync(pl => pl.Id == id);

    public async Task AddAsync(Customer customer)
    {
        await _customer.AddAsync(customer);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Customer customer)
    {
        _customer.Update(customer);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Customer customer)
    {
        _customer.Remove(customer);
        await _writeDbContext.SaveChangesAsync();
    }
}

