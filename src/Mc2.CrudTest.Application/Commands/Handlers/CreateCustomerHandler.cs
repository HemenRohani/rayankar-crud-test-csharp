using Mc2.CrudTest.Application.Exceptions;
using Mc2.CrudTest.Application.Services;
using Mc2.CrudTest.Domain.Factories;
using Mc2.CrudTest.Domain.Repositories;
using Mc2.CrudTest.Domain.ValueObjects;
using Mc2.CrudTest.Shared.Abstractions.Commands;


namespace Mc2.CrudTest.Application.Commands.Handlers;

public class CreateCustomerHandler : ICommandHandler<CreateCustomer>
{
    private readonly ICustomerRepository _repository;
    private readonly ICustomerFactory _factory;
    private readonly ICustomerReadService _readService;



    public CreateCustomerHandler(ICustomerRepository repository, ICustomerFactory factory, ICustomerReadService readService)
    {
        _repository = repository;
        _factory = factory;
        _readService = readService;
    }

    public async Task HandleAsync(CreateCustomer command)
    {
        var (id, firstname, lastname, dateOfBirth, phoneNumber, email, bankAccountNumber) = command;


        if (await _readService.ExistsAsync(firstname, lastname, dateOfBirth))
        {
            throw new CustomerAlreadyExistsException(firstname, lastname, dateOfBirth);
        }


        var Customer = _factory.Create(id, firstname, lastname, dateOfBirth, phoneNumber, email, bankAccountNumber);

        await _repository.AddAsync(Customer);
    }
}

