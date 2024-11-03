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
        int height = Convert.ToInt32(Console.ReadLine());
        Method.printTriangleStar(height);
        #endregion
    }
}