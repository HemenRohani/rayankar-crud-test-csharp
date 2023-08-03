using LivingDoc.Dtos;
using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Domain.Exception;
using Mc2.CrudTest.Domain.Factories;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mc2.CrudTest.AcceptanceTests.Domain
{
    public class CustomerTests
    {
        private readonly ICustomerFactory _factory;
        public CustomerTests()
        {
            _factory = new CustomerFactory();
        }

        [Fact]
        public void Throws_InvalidCustomerPhoneNumberException_For_Invalid_PhoneNumber()
        {
            //ARRANGE
            //ACT
            var exception = Record.Exception(() => _factory.Create(
                Guid.NewGuid(),
                firstname: "Hemen",
                lastname: "Rohani",
                dateOfBirth: new DateTime(1988, 10, 13),
                phoneNumber: "9186646493",
                email: "hemen.rohani@outlook.com",
                bankAccountNumber: "0123456"));

            //ASSERT
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCustomerPhoneNumberException>();
        }

        [Fact]
        public void Throws_CustomerIdException_For_Null_Id()
        {
            //ARRANGE
            //ACT
            var exception = Record.Exception(() => _factory.Create(
                Guid.Empty,
                firstname: "Hemen",
                lastname: "Rohani",
                dateOfBirth: new DateTime(1988, 10, 13),
                phoneNumber: "+989186646493",
                email: "hemen.rohani@outlook.com",
                bankAccountNumber: "0123456"));

            //ASSERT
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<CustomerIdException>();
        }
    }
}
