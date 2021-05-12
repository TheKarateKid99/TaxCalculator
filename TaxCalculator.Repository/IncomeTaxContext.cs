using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Entities;

namespace TaxCalculator.Repository
{
    public partial class IncomeTaxContext : DbContext
    {
        public IncomeTaxContext()
        {

        }

        public IncomeTaxContext(DbContextOptions<IncomeTaxContext> options)
            : base(options)
        {

        }

        public virtual DbSet<IncomeTax> IncomeTax { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncomeTax>(entity =>
            {
                entity.Property(e => e.Id)
                .IsRequired();

                entity.Property(e => e.Guid)
                    .IsRequired();

                entity.Property(e => e.CalculatedAmount)
                   .IsRequired();
                entity.Property(e => e.PostalCode)
                .HasMaxLength(6)
                   .IsRequired();

                entity.Property(e => e.CreatedDate)
                .IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
