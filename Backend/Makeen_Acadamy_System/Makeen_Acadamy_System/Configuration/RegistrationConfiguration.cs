using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Makeen_Acadamy_System.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Makeen_Acadamy_System.Configuration
{
    public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasKey(r => r.RegistrationId);

            builder.HasOne<Batch>()
                   .WithMany()
                   .HasForeignKey(r => r.BatchId);

            builder.HasOne<Customer>()
                   .WithMany()
                   .HasForeignKey(r => r.CustomerId);
        }
    }
}
