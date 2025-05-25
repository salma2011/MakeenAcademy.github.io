using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Acadamy_System.Models
{
    internal class Registration
    {
        public Registration(int registrationId)
        {
            RegistrationId = registrationId;
        }

        public int RegistrationId { get; set; }
        
    }
}
