using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Acadamy_System.Models
{
    public class Book
    {
    

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; }
    }
}
