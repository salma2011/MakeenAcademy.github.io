using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Makeen_Acadamy_System.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Makeen_Acadamy_System.Context
{
    internal class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=Makeendatabase;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Batch> Batchs { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Registration> Registrations{ get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders{ get; set; }

        
    }

}
