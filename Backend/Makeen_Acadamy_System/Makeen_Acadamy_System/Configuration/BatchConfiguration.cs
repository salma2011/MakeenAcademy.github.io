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
    public class BatchConfiguration : IEntityTypeConfiguration<Batch>
    {
        public void Configure(EntityTypeBuilder<Batch> builder)
        {
            builder.HasKey(b => b.BatchId);

            builder.Property(b => b.Price).HasColumnType("decimal(10,2)");
            builder.Property(b => b.isAvilable).IsRequired();
            builder.Property(b => b.StartDate).IsRequired();
            builder.Property(b => b.EndDate).IsRequired();

            builder.HasOne<Course>()
                   .WithMany()
                   .HasForeignKey(b => b.CourseId);
        }
    }

}