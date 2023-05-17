using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mc2.CrudTest.Infrastructure.EF.Config;

internal sealed class WriteConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(pl => pl.Id);

        builder
            .Property(pl => pl.Id)
            .HasConversion(id => id.Value, id => new CustomerId(id));

        builder
            .Property(typeof(CustomerFirstname), "_firstname")
            .HasConversion(new ValueConverter<CustomerFirstname, string>(pln => pln.Value, pln => new CustomerFirstname(pln)))
            .HasColumnName("Firstname");

        builder
            .Property(typeof(CustomerLastname), "_lastname")
            .HasConversion(new ValueConverter<CustomerLastname, string>(pln => pln.Value, pln => new CustomerLastname(pln)))
            .HasColumnName("Lastname");

        builder
            .Property(typeof(CustomerDateOfBirth), "_dateOfBirth")
            .HasConversion(new ValueConverter<CustomerDateOfBirth, DateTime>(pln => pln.Value, pln => new CustomerDateOfBirth(pln)))
            .HasColumnName("DateOfBirth");

        builder
            .Property(typeof(CustomerPhoneNumber), "_phoneNumber")
            .HasConversion(new ValueConverter<CustomerPhoneNumber, string>(pln => pln.Value, pln => new CustomerPhoneNumber(pln)))
            .HasColumnName("PhoneNumber");

        builder
            .Property(typeof(CustomerEmail), "_email")
            .HasConversion(new ValueConverter<CustomerEmail, string>(pln => pln.Value, pln => new CustomerEmail(pln)))
            .HasColumnName("Email");

        builder
            .Property(typeof(CustomerBankAccountNumber), "_bankAccountNumber")
            .HasConversion(new ValueConverter<CustomerBankAccountNumber, string>(pln => pln.Value, pln => new CustomerBankAccountNumber(pln)))
            .HasColumnName("BankAccountNumber");

        builder.ToTable("Customer");
    }
}

