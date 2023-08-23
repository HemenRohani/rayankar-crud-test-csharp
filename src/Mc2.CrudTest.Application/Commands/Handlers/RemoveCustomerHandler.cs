using Mc2.CrudTest.Application.Exceptions;
using Mc2.CrudTest.Application.Services;
using Mc2.CrudTest.Domain.Factories;
using Mc2.CrudTest.Domain.Repositories;
using Mc2.CrudTest.Domain.ValueObjects;
using Mc2.CrudTest.Shared.Abstractions.Commands;


namespace Mc2.CrudTest.Application.Commands.Handlers;

public class RemoveCustomerHandler : ICommandHandler<RemoveCustomer>
{
    private readonly ICustomerRepository _repository;



    public RemoveCustomerHandler(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(RemoveCustomer command)
    {
        var customer = await _repository.GetAsync(command.Id);

        if (customer is null)
        {
            throw new CustomerNotFound(command.Id);
        }

        await _repository.DeleteAsync(customer);
    }
}

