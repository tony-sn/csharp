internal class Library
{
    public List<Book> books;
    public string libraryId;
    public string libraryName;


    // 2. Create class Library to manage library book
    // libraryId
    // libraryName
    // book list in the library

    // constructor
    public Library(string libraryId, string libraryName)
    {
        this.libraryId = libraryId;
        this.libraryName = libraryName;
        books = new List<Book>();
    }

    public void addBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book with id {book.bookId} added to library {libraryName}");
    }


    public void displayBooks()
    {
        Console.WriteLine($"\n ----Books in library {libraryName} ----");
        foreach (var book in books) book.DisplayInfo();
    }

    // find method based on student ID
    public void findBookById(string bookId)
    {
        // 1. use foreach
        foreach (var book in books)
            if (book.bookId == bookId)
            {
                book.DisplayInfo();
                return;
            }

        // catch not found
        Console.WriteLine($"Book with ID {bookId} not found in library {libraryName}");
    }
}