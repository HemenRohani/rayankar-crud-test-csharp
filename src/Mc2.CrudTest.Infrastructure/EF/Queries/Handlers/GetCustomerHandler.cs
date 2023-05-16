
using Mc2.CrudTest.Application.DTO;
using Mc2.CrudTest.Application.Queries;
using Mc2.CrudTest.Domain.Repositories;
using Mc2.CrudTest.Infrastructure.EF.Contexts;
using Mc2.CrudTest.Infrastructure.EF.Models;
using Mc2.CrudTest.Infrastructure.EF.Queries;
using Mc2.CrudTest.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace Mc2.CrudTest.Application.Queries.Handlers
{
    internal sealed class GetCustomerHandler : IQueryHandler<GetCustomer, CustomerDto>
    {
        private readonly DbSet<CustomerReadModel> _Customers;

        public GetCustomerHandler(ReadDbContext context)
            => _Customers = context.Customer;

        public Task<CustomerDto> HandleAsync(GetCustomer query)
            => _Customers
                .Where(pl => pl.Id == query.Id)
                .Select(pl => pl.AsDto())
                .AsNoTracking()
                .SingleOrDefaultAsync();
    }
}
