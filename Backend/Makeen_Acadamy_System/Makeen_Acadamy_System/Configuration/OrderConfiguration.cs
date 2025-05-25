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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.ID);
            builder.HasOne<Book>()
                   .WithMany()
                   .HasForeignKey(o => o.BookId);

            builder.HasOne<Customer>()
                   .WithMany()
                   .HasForeignKey(o => o.CustomerId);
        }
    }
}
