using Mc2.CrudTest.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Mc2.CrudTest.Infrastructure.EF.Config;

internal sealed class ReadConfiguration : IEntityTypeConfiguration<CustomerReadModel>
{
    public void Configure(EntityTypeBuilder<CustomerReadModel> builder)
    {
        builder.ToTable("Customer");
        builder.HasKey(pl => pl.Id);
    }
}

