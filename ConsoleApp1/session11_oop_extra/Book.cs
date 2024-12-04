class Book
{
    public string BookId { get; set; }
    public string BookName { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public string Topic { get; set; } // Added topic property
    public string Publisher { get; set; } // Added publisher property

    // Constructor
    public Book(string bookId, string bookName, string author, double price, string topic, string publisher)
    {
        BookId = bookId;
        BookName = bookName;
        Author = author;
        Price = price;
        Topic = topic;
        Publisher = publisher;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Book ID: {BookId}, Name: {BookName}, Author: {Author}, Price: {Price}, Topic: {Topic}, Publisher: {Publisher}");
    }
}