// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

// while
// for
// do...while
// print 1 to n (input)
// S1: init loop
// S2: loop condition (for stopping)
// S3: change loop condition

#region
// Console.WriteLine("Please enter a number:");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// int count = 0;
//
// while (count <= formatNumber)
// {
//     Console.WriteLine(count);
//     count++; // count = count + 1
// }

// input n from keyboard. print out 1 -> n
// S = 1 + 2 + 3 + ... + n;

// Console.WriteLine("Please enter a number:");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int sum = 0;
// while (count <= number)
// {
//     sum += count; // sum = sum + count
//     count++; // count = count + 1 or count +=1, change to break loop
// }
// Console.WriteLine($"The sum from 1 to n is: {sum}");

// find n!
// int num = Convert.ToInt32(Console.ReadLine());
// // 5! => 120
// int count = 1;
// int factorial = 1;
// while (count <= num)
// {
//     factorial *= count;
//     count++;
// }
// Console.WriteLine($"Factorial of number {num} is {factorial}");

int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= 10)
{
    Console.WriteLine($"{count} x {number} = {count*number}");
    count++;
}
#endregion