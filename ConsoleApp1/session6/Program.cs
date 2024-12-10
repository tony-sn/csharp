// See https://aka.ms/new-console-template for more information

using session6;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // #region prime number
        // Console.WriteLine("Please enter input: ");
        // string? number = Console.ReadLine();
        // int formatNum = Convert.ToInt32(number);
        // bool isPrime = Method.checkPrime(formatNum);
        // if (isPrime == true)
        // {
        //     Console.WriteLine($"The number {formatNum} is prime.");
        // }
        // else
        // {
        //     Console.WriteLine($"The number {formatNum} is not prime.");
        // }
        // #endregion

        #region print star

        Console.WriteLine("Please enter your triangle height: ");
        var height = Convert.ToInt32(Console.ReadLine());
        Method.printTriangleStar(height);

        #endregion

        #region Collection in C#

        // data structure
        // List
        var numbers = new List<int>();
        List<string> names = new() { "Jones", "Tony", "Alby", "Tania", "Morgan" };
        //                              index   0        1      2       3           4
        //                       reverseIndex   ^5      ^4      ^3      ^2          ^1
        Console.WriteLine($"index at 2 is: {names[2]}");
        Console.WriteLine($"index from the end is: {names[^3]}");
        Console.Write(string.Join(", ", names));

        #endregion

        #region print n to get used with List

        Console.WriteLine();
        Console.WriteLine("Please enter n number: ");
        var number = Console.ReadLine();
        var formatNum = Convert.ToInt32(number);
        // create a list have all 
        var listNumbers = new List<int>();
        for (var i = 0; i < formatNum; i++)
        {
            var item = Console.ReadLine();
            var formatItem = Convert.ToInt32(item);
            listNumbers.Insert(i, formatItem);
        }

        Console.WriteLine("all input after getting list numbers!");
        for (var i = 0; i < listNumbers.Count; i++) Console.WriteLine(listNumbers[i]);

        Console.WriteLine("index using foreach");
        foreach (var item in listNumbers) Console.WriteLine(item);

        #endregion
    }
}