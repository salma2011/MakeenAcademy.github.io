using Makeen_Acadamy_System.Models;
using Makeen_Acadamy_System.Models;
using static System.Reflection.Metadata.BlobBuilder;
namespace Makeen_Acadamy_System
{
    internal class Program
    {
         
        // Static lists to hold data for courses, batches, books, customers, and instructors
        static List<Customer> customers = new();
        static List<Instructor> instructors = new();
        static List<Course> courses = new();
        static List<Batch> batches = new();
        static List<Registration> registrations = new();
        static List<Book> books = new();
        static List<Order> orders = new();

        static void Main(string[] args)
        {
            int choice;

            do
            {

                Console.WriteLine("============================================");
                Console.WriteLine(" Welcome to Makeen Academy System");
                Console.WriteLine("============================================\n");
                Console.WriteLine("1. Register New Customer (Student)");
                Console.WriteLine("2. Add New Instructor");
                Console.WriteLine("3. Create New Course");
                Console.WriteLine("4. Create New Batch");
                Console.WriteLine("5. Enroll Customer in a Course");
                Console.WriteLine("6. View All Courses");
                Console.WriteLine("7. View Registrations for a Course");
                Console.WriteLine("8. View Instructor Details");
                Console.WriteLine("9. Add New Book");
                Console.WriteLine("10. View All Books");
                Console.WriteLine("11. Update Book");
                Console.WriteLine("12. Delete Book");
                Console.WriteLine("13. Buy a Book");
                Console.WriteLine("14.  View Orders");
                Console.WriteLine("15. Exit");
                Console.WriteLine("--------------------------------------------\n");
                Console.Write("Enter your choice: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1: RegisterCustomer(); break;
                    case 2: AddInstructor(); break;
                    case 3: CreateCourse(); break;
                    case 4: CreateBatch(); break;
                    case 5: EnrollCustomer(); break;
                    case 6: ViewAllCourses(); break;
                    case 7: ViewRegistrationsForCourse(); break;
                    case 8: ViewInstructorDetails(); break;
                    case 9: AddBook(); break;
                    case 10: ViewBooks(); break;
                    case 11: UpdateBook(); break;
                    case 12: DeleteBook(); break;
                    case 13: BuyBook(); break;
                    case 14: ViewOrders(); break;
                    case 15:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                if (choice != 14)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (choice != 14);
        }


        // Method to register a new customer
        static void RegisterCustomer()
        {
            Console.WriteLine("\n--- Register New Customer ---");
            var cust = new Customer();
            Console.Write("First Name: ");
            cust.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            cust.LastName = Console.ReadLine();
            Console.Write("Email: ");
            cust.Email = Console.ReadLine();
            Console.Write("Phone Number: ");
            cust.PhoneNumber = Console.ReadLine();
            // You might have other fields (Email, Phone, etc.)
            cust.CustomerId = customers.Count + 1;
            customers.Add(cust);
            Console.WriteLine($"Customer #{cust.FirstName} {cust.LastName} egistered successfully.");
        }

        // Method to add a new instructor
        static void AddInstructor()
        {
            Console.WriteLine("\n--- Add New Instructor ---");
            var inst = new Instructor();
            Console.Write("Instructor Name: ");
            inst.InstructorName = Console.ReadLine();
            inst.InstructorID = instructors.Count + 1;
            instructors.Add(inst);
            Console.WriteLine($"Instructor #{inst.InstructorName} added successfully.");
        }

        // Method to create a new course
        static void CreateCourse()
        {
            Console.WriteLine("\n--- Create New Course ---");
            var course = new Course();
            Console.Write("Course Name: ");
            course.Name = Console.ReadLine();
            Console.Write("Course Description: ");
            course.Detalis = Console.ReadLine();
            course.CourseID = courses.Count + 1;
            courses.Add(course);
            Console.WriteLine($"Course #{course.Name} created successfully.");
        }

        // Method to create a new batch
        static void CreateBatch()
        {
            Console.WriteLine("\n--- Create New Batch ---");
            var batch = new Batch();
            Console.Write("Is Available (true/false): ");
            bool.TryParse(Console.ReadLine(), out bool isAvailable);
            batch.isAvilable = isAvailable;
            Console.Write("Start Date (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime startDate);
            batch.StartDate = startDate;
            Console.Write("End Date (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime endDate);
            batch.EndDate = endDate;
            Console.Write("Batch Price: ");
            double.TryParse(Console.ReadLine(), out double price);
            batch.Price = price;
            Console.Write("Course ID: ");
            int.TryParse(Console.ReadLine(), out int courseId);
            batch.CourseId = courseId;
            batch.BatchId = batches.Count + 1;
            batches.Add(batch);
            Console.WriteLine($"Batch #{batch.BatchId} created successfully.");
        }

        // Method to enroll a customer in a course
        static void EnrollCustomer()
        {
            Console.WriteLine("\n--- Enroll Customer in a Course ---");
            Console.Write("Enter Customer ID: ");
            int.TryParse(Console.ReadLine(), out int customerId);
            var customer = customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer == null)
            {
                Console.WriteLine("Customer not found.");
                return;
            }
            Console.Write("Enter Course ID: ");
            int.TryParse(Console.ReadLine(), out int batchId);
            var Batch = batches.FirstOrDefault(b => b.BatchId == batchId);
            if (Batch == null)
            {
                Console.WriteLine("Course not found.");
                return;
            }
            var registration = new Registration
            {
                CustomerId = customerId,
                BatchId = batchId,
            };
            registrations.Add(registration);
            Console.WriteLine($"Customer #{customer.FirstName} {customer.LastName} enrolled in course #{Batch.CourseId} successfully.");
        }


        // Method to view all courses
        static void ViewAllCourses()
        {
            Console.WriteLine("\n--- All Courses ---");
            if (courses.Count == 0)
            {
                Console.WriteLine("No courses available.");
                return;
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"ID: {course.CourseID}, Name: {course.Name}, Details: {course.Detalis}");
            }
        }

        // Method to view registrations for a course
        static void ViewRegistrationsForCourse()
        {
            Console.WriteLine("\n--- Registrations for a Course ---");
            Console.Write("Enter Course ID: ");
            int.TryParse(Console.ReadLine(), out int batchId);
            var registrationsForCourse = registrations.Where(r => r.BatchId == batchId).ToList();
            if (registrationsForCourse.Count() == 0)
            {
                Console.WriteLine("No registrations found for this course.");
                return;
            }
            foreach (var reg in registrationsForCourse)
            {
                var customer = customers.FirstOrDefault(c => c.CustomerId == reg.CustomerId);
                if (customer != null)
                {
                    Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.FirstName} {customer.LastName}");
                }
            }
        }

        // Method to view instructor details
        static void ViewInstructorDetails()
        {
            Console.WriteLine("\n--- Instructor Details ---");
            if (instructors.Count == 0)
            {
                Console.WriteLine("No instructors available.");
                return;
            }
            foreach (var instructor in instructors)
            {
                Console.WriteLine($"ID: {instructor.InstructorID}, Name: {instructor.InstructorName}");
            }
        }

        // Method to add book
        static void AddBook()
        {
            Console.WriteLine("\n--- Add New Book ---");
            var book = new Book();
            book.BookId = books.Count + 1;
            Console.Write("Title: ");
            book.Title = Console.ReadLine();
            Console.Write("Author: ");
            book.Author = Console.ReadLine();
            Console.Write("Details: ");
            book.Details = Console.ReadLine();
            Console.Write("Price: ");
            double.TryParse(Console.ReadLine(), out double price);
            book.Price = price;
            book.Image = null;
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added successfully.");
        }


        // Method to update book
        static void UpdateBook()
        {
            Console.WriteLine("\n--- Update Book ---");
            Console.Write("Enter Book ID to update: ");
            int.TryParse(Console.ReadLine(), out int bookId);
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }
            Console.Write($"New Title (leave blank to keep '{book.Title}'): ");
            string title = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(title))
            {
                book.Title = title;
            }
            Console.Write($"New Author (leave blank to keep '{book.Author}'): ");
            string author = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(author))
            {
                book.Author = author;
            }
            Console.Write($"New Details (leave blank to keep current): ");
            string details = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(details))
            {
                book.Details = details;
            }
            Console.Write("New Price (leave blank to keep current): ");
            string priceInput = Console.ReadLine();
            if (double.TryParse(priceInput, out double newPrice))
            {
                book.Price = newPrice;
            }
            Console.WriteLine("Book updated successfully.");
        }


        // Method to view book
        static void ViewBooks()
        {
            Console.WriteLine("\n--- Book List ---");
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Price: {book.Price:C}");
            }
        }

        // Method to remove book
        static void DeleteBook()
        {
            Console.WriteLine("\n--- Delete Book ---");
            Console.Write("Enter Book ID to delete: ");
            int.TryParse(Console.ReadLine(), out int bookId);
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }
            books.Remove(book);
            Console.WriteLine($"Book '{book.Title}' deleted successfully.");
        }


        // Method to buy a book
        static void BuyBook()
        {
            Console.WriteLine("\n--- Buy a Book ---");
            Console.Write("Enter Book ID to buy: ");
            int.TryParse(Console.ReadLine(), out int bookId);
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }
            Console.WriteLine($"You have bought '{book.Title}' by {book.Author} for {book.Price:C}.");
            // Here you can implement payment logic or further actions
        }


        // Mehthod to view purchase history
        static void ViewOrders()
        {
            Console.WriteLine("\n--- Purchase History ---");
            if (orders.Count == 0)
            {
                Console.WriteLine("No purchases have been made.");
                return;
            }

            foreach (var order in orders)
            {
                var customer = customers.FirstOrDefault(c => c.CustomerId == order.CustomerId);
                var book = books.FirstOrDefault(b => b.BookId == order.BookId);
                Console.WriteLine($"Order #{order.ID}: '{book?.Title}' by {book?.Author} bought by {customer?.FirstName} {customer?.LastName} on {order.Date}");
            }
        }
    }
}



