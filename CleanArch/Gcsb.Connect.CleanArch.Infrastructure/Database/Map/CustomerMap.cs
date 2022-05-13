using Gcsb.Connect.CleanArch.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcsb.Connect.CleanArch.Infrastructure.Database.Map
{
    public class CustomerMap : IEntityTypeConfiguration<CustomerInfra>
    {
        public void Configure(EntityTypeBuilder<CustomerInfra> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
            builder.Property(c => c.BirthDate).HasMaxLength(10).IsRequired();
            builder.Property(c => c.Rg).HasMaxLength(9).IsRequired();
            builder.Property(c => c.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(c => c.Address).HasMaxLength(100).IsRequired();
        }
    }
}
