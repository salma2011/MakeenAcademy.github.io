using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Acadamy_System.Models
{
    public class Consultation
    {
      

        public int ConsultationId { get; set; }
        public string InstName { get; set; }
        public string Description  { get; set; }
        public string Purpose { get; set; }

        public int CustomerId { get; set; }

        public int InstuctorId { get; set; }


    }
}
