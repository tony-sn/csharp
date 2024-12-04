using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace session11_oop_inheritance;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        #region E1: Classroom management

        // E1: 
        // 1. Class
        // create Classroom to manage class
        // classId
        // className
        // student in class
        // 2. Student
        // studentId
        // studentName
        // age
        // 3. Function
        // add student to class
        // print student info to class
        // find student based on studentId
        
        // class room
        Classroom classroom = new Classroom("C02", "Dotnet02");
        // create menu
        // 1. Add student
        // 2. Show student list
        // 3. Find student based on student Id
        // 4. Exit

        while (true)
        {
            Console.WriteLine("\n------Classrom Management------");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show student list");
            Console.WriteLine("3. Find student with ID");
            Console.WriteLine("4. Exit");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Enter student ID: ");
                    string studentID = Console.ReadLine();
                    Console.WriteLine("Enter student name: ");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("Enter student age: ");
                    int studentAge = Convert.ToInt32(Console.ReadLine());
                    Student student = new Student(studentID, studentName, studentAge); 
                    
                    classroom.addStudent(student);
                    
                    // change student list to Json;
                    var json = JsonConvert.SerializeObject(classroom.students, Formatting.Indented);
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "students.json");

                    File.WriteAllText(filePath, json);
                    Console.WriteLine($"Student list saved to {filePath}");
                    break;
                
                case "2":
                    classroom.showStudents();
                    break;
                    
                case "3":
                    Console.WriteLine("Enter student ID: ");
                    string? studentId = Console.ReadLine();
                    if (studentId == null)
                    {
                        Console.WriteLine("Student ID is required");
                        break;
                    }
                    classroom.findStudentByStudentId(studentId);
                    break;
                
                case "4":
                    // Exit
                    return;
                
                default: 
                    Console.WriteLine("Invalid option. Please enter 1-4");
                    break;
            }
        }

        #endregion
        
        #region E2: Book management
        // 1. Create class Book to manage book
        // bookId
        // bookName
        // author
        // price
        // ----------------
        // 2. Create class Library to manage library book
        // libraryId
        // libraryName
        // book list in the library
        // ----------------
        // 3. Feature
        // Add book to library
        // Show book list in the library
        // Find book by book ID
        // Exit
        Library library = new Library("BR01", "British Library");

        while (true)
        {
            Console.WriteLine("\n------Classrom Management------");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show student list");
            Console.WriteLine("3. Find student with ID");
            Console.WriteLine("4. Exit");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter book ID: ");
                    string bookId = Console.ReadLine();
                    Console.WriteLine("Enter book name: ");
                    string bookName = Console.ReadLine();
                    Console.WriteLine("Enter author: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter book price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Book book = new Book(bookId, bookName, author, price ); 
                    
                    library.addBook(book);
                    
                    // change student list to Json;
                    var jsonBook = JsonConvert.SerializeObject(library.books, Formatting.Indented);
                    string filePath2 = Path.Combine(Directory.GetCurrentDirectory(), "books.json");

                    File.WriteAllText(filePath2, jsonBook);
                    Console.WriteLine($"Book list saved to {filePath2}");
                    break;
                
                case "2":
                    library.displayBooks();
                    break;
                    
                case "3":
                    Console.WriteLine("Enter book ID: ");
                    string? id = Console.ReadLine();
                    if (id == null)
                    {
                        Console.WriteLine("Book ID is required");
                        break;
                    }
                    library.findBookById(id);
                    break;
                
                case "4":
                    // Exit
                    return;
                
                default: 
                    Console.WriteLine("Invalid option. Please enter 1-4");
                    break;
            }
        }
        #endregion

    }
}
