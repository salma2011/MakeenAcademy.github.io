using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Acadamy_System.Models
{
    internal class Consultation
    {
        public Consultation(int consultationId, string instName, string description, string purpose)
        {
            ConsultationId = consultationId;
            InstName = instName;
            Description = description;
            Purpose = purpose;
        }

        public int ConsultationId { get; set; }
        public string InstName { get; set; }
        public string Description  { get; set; }
        public string Purpose { get; set; }


    }
}
