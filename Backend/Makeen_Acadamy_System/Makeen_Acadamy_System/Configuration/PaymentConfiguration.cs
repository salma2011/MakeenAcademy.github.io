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
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.status).HasMaxLength(50);

            builder.HasOne<Order>()
                   .WithMany()
                   .HasForeignKey(p => p.OrderId);

            builder.HasOne<Registration>()
                   .WithMany()
                   .HasForeignKey(p => p.RegistrationId);

            builder.HasOne<Consultation>()
                   .WithMany()
                   .HasForeignKey(p => p.ConsultationId);
        }
    }
}
