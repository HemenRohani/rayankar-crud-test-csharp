using Mc2.CrudTest.Application.Services;
using Mc2.CrudTest.Infrastructure.EF.Contexts;
using Mc2.CrudTest.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Mc2.CrudTest.Infrastructure.EF.Services;
internal sealed class CustomerReadService : ICustomerReadService
{
    private readonly DbSet<CustomerReadModel> _Customer;

    public CustomerReadService(ReadDbContext context)
        => _Customer = context.Customer;

    public Task<bool> ExistsByEmailAsync(string email)
        => _Customer.AnyAsync(pl => pl.Email == email);

    public Task<bool> ExistsByNameAndBithDateAsync(string firstname, string lastname, DateOnly dateOfBirth)
        => _Customer.AnyAsync(pl => pl.Firstname == firstname && pl.Lastname == lastname && pl.DateOfBirth == dateOfBirth);

}
