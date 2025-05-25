using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Makeen_Acadamy_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Makeen_Acadamy_System.Configuration
{
    public class ConsultationConfiguration : IEntityTypeConfiguration<Consultation>
    {
        public void Configure(EntityTypeBuilder<Consultation> builder)
        {
            builder.HasKey(c => c.ConsultationId);
            builder.Property(c => c.InstName).HasMaxLength(100);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.Purpose).HasMaxLength(200);

            builder.HasOne<Customer>()
                   .WithMany()
                   .HasForeignKey(c => c.CustomerId);

            builder.HasOne<Instructor>()
                   .WithMany()
                   .HasForeignKey(c => c.InstuctorId);
        }
    }
}