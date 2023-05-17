using Mc2.CrudTest.Shared.Abstractions.Commands;

namespace Mc2.CrudTest.Application.Commands;

public record CreateCustomer(
    Guid Id,
    string Firstname,
    string Lastname,
    DateTime DateOfBirth,
    string PhoneNumber,
    string Email,
    string BankAccountNumber) : ICommand;