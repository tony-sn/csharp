internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Lesson 1: Eng-Viet dictionary");
        TuDienAnhViet.process();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Lesson 2: Word counts in a paragraph");
        WordCount.process();
    }
}