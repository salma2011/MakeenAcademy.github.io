using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Acadamy_System.Models
{
    internal class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public char Gender { get; set; }

        public Customer(int id, string firstName, string lastName, string email, string phonrNumber, char gender)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phonrNumber;
            Gender = gender;
        }
    }
}
