using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Acadamy_System.Models
{
    internal class Book
    {
        public Book(int bookId, string title, string author, string details, double price, byte[] image)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Details = details;
            Price = price;
            Image = image;
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; }
    }
}
