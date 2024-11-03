// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        int result = countSum(10, 11);
        Console.WriteLine($"sum of 10 and 11 is {result}");
        
        Console.WriteLine("Please enter a number >= 2: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= number; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
        
        Console.WriteLine("Mời bạn nhập một số: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int originalNumber = number3;
        int reverseNumber = getReverseNumber(number3); 
            
        if (reverseNumber == originalNumber)
        {
            Console.WriteLine($"Số {originalNumber} là số đối xứng");
        } else {
            Console.WriteLine($"Số {originalNumber} không là số đối xứng");
        }
    }

    private static int getReverseNumber(int number)
    {
        int reverseNumber = 0;
        while(number > 0){
            int lastDigit = number % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            number = number / 10;
        }

        return reverseNumber;

    }
    private static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    } 

    private static int countSum(int a, int b)
    {
       return a + b;
    }
}

// #region print out number from 2 to n
// // INPUT
// // number from keyboard
// Console.WriteLine("Please enter a number > 2: ");
// int nInput = Convert.ToInt32(Console.ReadLine());
//
// // OUTPUT
// // all prime numbers from 2 to n
//
// // PROCESS
// // request user input
// // convert to int
// // if number 
//
// Console.WriteLine("Numbers from 2 to " + nInput + ":");
// for (int i = 2; i <= nInput; i++)
// {
//     Console.Write(i + " ");
// }
//
// Console.WriteLine("\n\nPrime numbers from 2 to " + nInput + ":");
// for (int i = 2; i <= nInput; i++)
// {
//     bool isPrime = true;
//
//     for (int j = 2; j <= Math.Sqrt(i); j++)
//     {
//         if (i % j == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
//
//     if (isPrime)
//     {
//         Console.Write(i + " ");
//     }
// }
//
// #endregion
//
// #region print out this triangle
// //     *
// //    * *
// //   *   *
// //  *     *
// // *********
//
// int rows = 5; // Number of rows for the triangle
//
// Console.WriteLine(" ");
// Console.WriteLine("Exercise 2");
// for (int i = 1; i <= rows; i++)
// {
//     // Print leading spaces
//     for (int j = 1; j <= rows - i; j++)
//     {
//         Console.Write(" ");
//     }
//
//     // Print stars and spaces inside the triangle
//     for (int j = 1; j <= (2 * i - 1); j++)
//     {
//         if (i == rows || j == 1 || j == (2 * i - 1))
//         {
//             Console.Write("*");
//         }
//         else
//         {
//             Console.Write(" ");
//         }
//     }
//
//     Console.WriteLine();
// }
// #endregion
//
//
// #region
// Console.WriteLine("\n\nExercise 3");
// Console.Write("Enter a number: ");
// string input = Console.ReadLine();
//
// bool isValid = true;
// int length = input.Length;
// int mid = length / 2;
//
// // Check if the left half is strictly increasing from 1
// for (int i = 0; i < mid; i++)
// {
//     if (input[i] - '0' != i + 1)
//     {
//         isValid = false;
//         break;
//     }
// }
//
// // Check if the right half mirrors the left half
// for (int i = 0; i < mid; i++)
// {
//     if (input[length - 1 - i] != input[i])
//     {
//         isValid = false;
//         break;
//     }
// }
//
// if (isValid)
// {
//     Console.WriteLine($"{input} matches the required palindrome pattern.");
// }
// else
// {
//     Console.WriteLine($"{input} does not match the required palindrome pattern.");
// }
// #endregion