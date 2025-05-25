using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Acadamy_System.Models
{
    internal class Instuctor
    {
        public Instuctor(int instructorId, string instructorName)
        {
            InstuctorID = instructorId;
            InstuctorName = instructorName;
        }

        public int InstuctorID { get; set; }
        public string InstuctorName { get; set; }


    }
}
