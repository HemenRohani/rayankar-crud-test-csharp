﻿using Mc2.CrudTest.Infrastructure.EF.Config;
using Mc2.CrudTest.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Mc2.CrudTest.Infrastructure.EF.Contexts
{
    internal sealed class ReadDbContext : DbContext
    {
        public DbSet<CustomerReadModel> Customer { get; set; }



        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Mc2CrudTest");

            var configuration = new ReadConfiguration();
            modelBuilder.ApplyConfiguration<CustomerReadModel>(configuration);
        }
    }
}
