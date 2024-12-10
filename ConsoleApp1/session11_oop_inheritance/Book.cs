internal class Book
{
    public string author;
    public string bookId;
    public string bookName;
    public double price;

    // 1. Create class Book to manage book
    // bookId
    // bookName
    // author
    // price
    public Book(string bookId, string bookName, string author, double price)
    {
        this.bookId = bookId;
        this.bookName = bookName;
        this.author = author;
        this.price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book ID: {bookId}, Book Name: {bookName}, Author: {author}, Price: {price}");
    }
}