using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Acadamy_System.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }  
        public string InstructorName { get; set; }

        public Instructor() { }

        public Instructor(int instructorId, string instructorName)
        {
            InstructorID = instructorId;
            InstructorName = instructorName;
        }
    }
}