internal class TextBook : Book
{
    public string grade;
    public string subject;

    public TextBook(string bookId, string bookName, string author, double price, string subject, string grade) : base(
        bookId, bookName, author, price)
    {
        this.subject = subject;
        this.grade = grade;
    }

    public override void displayInfo()
    {
        base.DisplayInfo($"Subject: {subject}, Grade: {grade}");
    }
}