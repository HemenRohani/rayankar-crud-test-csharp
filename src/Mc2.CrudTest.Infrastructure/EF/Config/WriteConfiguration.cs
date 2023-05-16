using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Mc2.CrudTest.Infrastructure.EF.Config;

internal sealed class WriteConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(pl => pl.Id);

        builder
            .Property(pl => pl.Id)
            .HasConversion(id => id.Value, id => new CustomerId(id));

        builder.ToTable("Customer");
    }
}

