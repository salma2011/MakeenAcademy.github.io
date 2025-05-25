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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);
            builder.Property(b => b.Title).HasMaxLength(200).IsRequired();
            builder.Property(b => b.Author).HasMaxLength(100).IsRequired();
            builder.Property(b => b.Details).HasMaxLength(500);
            builder.Property(b => b.Price).HasColumnType("decimal(10,2)");
        }
    }
}