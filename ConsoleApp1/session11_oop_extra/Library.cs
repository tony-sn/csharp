using System.IO;
using Newtonsoft.Json;

class Library
{
    public string LibraryId { get; set; }
    public string LibraryName { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();

    // Constructor
    public Library(string libraryId, string libraryName)
    {
        LibraryId = libraryId;
        LibraryName = libraryName;
    }

    // Add a book to the library
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Book with ID {book.BookId} added to the library {LibraryName}.");
    }

    // Display all books in the library
    public void DisplayBooks()
    {
        Console.WriteLine($"\n--- Books in Library: {LibraryName} ---");
        foreach (var book in Books)
        {
            book.DisplayInfo();
        }
    }

    // Find a book by ID
    public void FindBookById(string bookId)
    {
        var book = Books.Find(b => b.BookId == bookId);
        if (book != null)
        {
            book.DisplayInfo();
        }
        else
        {
            Console.WriteLine($"Book with ID {bookId} not found in the library {LibraryName}.");
        }
    }

    // Save book list to a JSON file
    public void SaveBooksToJson(string filePath)
    {
        var json = JsonConvert.SerializeObject(Books, Formatting.Indented);
        File.WriteAllText(filePath, json);
        Console.WriteLine($"Books have been saved to {filePath}.");
    }

    // Load book list from a JSON file
    public void LoadBooksFromJson(string filePath)
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            Books = JsonConvert.DeserializeObject<List<Book>>(json) ?? new List<Book>();
            Console.WriteLine($"Books have been loaded from {filePath}.");
        }
        else
        {
            Console.WriteLine($"File {filePath} does not exist.");
        }
    }
}