internal class FictionBook : Book
{
    // Constructor
    public FictionBook(string bookId, string bookName, string author, double price, string topic, string publisher,
        string genre, int year)
        : base(bookId, bookName, author, price, topic, publisher)
    {
        Genre = genre;
        Year = year;
    }

    public string Genre { get; set; } // Added genre property
    public int Year { get; set; } // Added year property

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"Fiction Book ID: {BookId}, Name: {BookName}, Author: {Author}, Price: {Price}, Topic: {Topic}, Publisher: {Publisher}, Genre: {Genre}, Year: {Year}");
    }
}