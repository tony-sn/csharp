class Library
{
    public string libraryId;
    public string libraryName;
    public List<Book> books;
    
    
    // 2. Create class Library to manage library book
    // libraryId
    // libraryName
    // book list in the library

    // constructor
    public Library(string libraryId, string libraryName)
    {
            this.libraryId = libraryId;
            this.libraryName = libraryName;
            this.books = new List<Book>();
    }

    public void addBook(Book book)
    {
            books.Add(book);
            Console.WriteLine($"Book with id {book.bookId} added to library {libraryName}");
    }
    
    
    public void displayBooks()
    {
        Console.WriteLine($"\n ----Books in library {libraryName} ----");
        foreach (Book book in books)
        {
            book.DisplayInfo();
        }
    }

    // find method based on student ID
    public void findBookById(string bookId)
    {
        // 1. use foreach
        foreach (Book book in books)
        {
            if (book.bookId == bookId)
            {
                book.DisplayInfo();
                return;
            }
        }
        // catch not found
        Console.WriteLine($"Book with ID {bookId} not found in library {libraryName}");
        
    }
    
    
    
    
}