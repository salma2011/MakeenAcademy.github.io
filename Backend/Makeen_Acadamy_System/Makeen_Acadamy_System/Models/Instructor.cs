using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Acadamy_System.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }  // ✅ هذا هو المفتاح الأساسي
        public string InstructorName { get; set; }

        public Instructor() { } // EF Core يحتاج هذا الكونستركتر

        public Instructor(int instructorId, string instructorName)
        {
            InstructorID = instructorId;
            InstructorName = instructorName;
        }
    }
}