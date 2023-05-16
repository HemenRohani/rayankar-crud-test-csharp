using Mc2.CrudTest.Shared.Abstractions.Commands;

namespace Mc2.CrudTest.Application.Commands;

public record RemoveCustomer(Guid Id) : ICommand;