using Mc2.CrudTest.Application.Commands;
using Mc2.CrudTest.Application.Commands.Handlers;
using Mc2.CrudTest.Application.Exceptions;
using Mc2.CrudTest.Application.Services;
using Mc2.CrudTest.Domain.Factories;
using Mc2.CrudTest.Domain.Repositories;
using Mc2.CrudTest.Shared.Abstractions.Commands;
using NSubstitute;
using Shouldly;
using Xunit;

namespace Mc2.CrudTest.AcceptanceTests.Application
{
    public class CreateCustomerTests
    {
        Task Act(CreateCustomer command)
            => _commandHandler.HandleAsync(command);

        [Fact]
        public async Task HandleAsync_Throws_EmailAlreadyUsedException_When_Customer_With_same_Email_Already_Exists()
        {
            var command = new CreateCustomer(
                Guid.NewGuid(),
                Firstname: "Hemen",
                Lastname: "Rohani",
                DateOfBirth: new DateTime(1988, 10, 13),
                PhoneNumber: "+989186646493",
                Email: "hemen.rohani@outlook.com",
                BankAccountNumber: "0123456");
            _readService.ExistsByEmailAsync(command.Email).Returns(true);

            var exception = await Record.ExceptionAsync(() => Act(command));

            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<EmailAlreadyUsedException>();
        }

        [Fact]
        public async Task HandleAsync_Throws_CustomerAlreadyExistsException_When_Customer_With_same_Name_And_DateOfBirth_Already_Exists()
        {
            var command = new CreateCustomer(
                Guid.NewGuid(),
                Firstname: "Hemen",
                Lastname: "Rohani",
                DateOfBirth: new DateTime(1988, 10, 13),
                PhoneNumber: "+989186646493",
                Email: "hemen.rohani@outlook.com",
                BankAccountNumber: "0123456");

            _readService.ExistsByNameAndBithDateAsync(command.Firstname, command.Lastname, command.DateOfBirth).Returns(true);

            var exception = await Record.ExceptionAsync(() => Act(command));

            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<CustomerAlreadyExistsException>();
        }

        #region ARRANGE

        private readonly ICommandHandler<CreateCustomer> _commandHandler;
        private readonly ICustomerRepository _repository;
        private readonly ICustomerReadService _readService;
        private readonly ICustomerFactory _factory;

        public CreateCustomerTests()
        {
            _repository = Substitute.For<ICustomerRepository>();
            _readService = Substitute.For<ICustomerReadService>();
            _factory = Substitute.For<ICustomerFactory>();
            _commandHandler = new CreateCustomerHandler(_repository, _factory, _readService);
        }

        #endregion
    }
}
