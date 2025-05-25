using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Acadamy_System.Models
{
        public class Payment
    {


        public int ID { get; set; }
        public int OrderId { get; set; }
        public int RegistrationId { get; set; }
        public int ConsultationId { get; set; }

        public string status { get; set; }
      

    }
}
