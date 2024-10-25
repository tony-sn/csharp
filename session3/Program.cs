// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region
//input
// milktea price
// % discount
Console.WriteLine("Please enter the price of milktea and discount percentage");
string price = Console.ReadLine();
string discount = Console.ReadLine();

//output
int disPrice;
int askPrice;

// process
int formatPrice = Convert.ToInt32(price);
int formatDiscount = Convert.ToInt32(discount);
disPrice = formatPrice * formatDiscount / 100;
askPrice = formatPrice - disPrice;

Console.WriteLine($"discount price is: {disPrice}");
Console.WriteLine($"ask price is: {askPrice}");

#endregion

#region if-else statement
// int from keyboard
// input
string? number = Console.ReadLine();
int formatNumber = Convert.ToInt32(number);

if (formatNumber % 2 == 0)
{
    Console.WriteLine($"{number} is Even number");
}
else
{
    Console.WriteLine($"{number} is Odd number");
}

#endregion

#region
int day = 5;
if (day != 0)
{
    Console.WriteLine("Monday");
}

#endregion

#region
// nhập điểm trung bình của học sinh. Xuất ra học lực của học sinh đó
// >=9: Xuất sắc
// 8 <= điểm < 9: giỏi
// 6.5 <= điểm < 8: khá
// 5 <= điểm <6.5: trung bình
// 3.5 <= điểm < 5: yếu
// quá kém

string? gpa = Console.ReadLine();
double formatGpa = Convert.ToDouble(gpa);
if (formatGpa >= 9)
{
    Console.WriteLine("Xuất sắc");
}
else if (formatGpa >= 8)
{
    Console.WriteLine("Giỏi");
}
else if (formatGpa >= 6.5)
{
    Console.WriteLine("Khá");
}
else if (formatGpa >= 5)
{
    Console.WriteLine("Trung bình");
}
else if (formatGpa >= 3.5)
{
    Console.WriteLine("Yếu");
}
else
{
    Console.WriteLine("Quá kém");
}

#endregion

#region 987
// input
// a number with 3 digits

// output
// sum of digits

//process
// user input
// if number > 1000 or number < 100
// count the sum of digits
// else
// print "invalid number"

// Input: A number with 3 digits
Console.WriteLine("Please enter a number:");
string? lookingNum = Console.ReadLine();

// Check if the input is not null
if (lookingNum != null)
{
    // Attempt to convert the string to an integer
    if (int.TryParse(lookingNum, out int ln))
    {
        // Check if the number is between 100 and 999 (i.e., 3 digits)
        if (ln >= 100 && ln < 1000)
        {
            int sum = 0;

            // Calculate the sum of the digits
            sum += ln / 100;         // Hundreds place
            sum += (ln / 10) % 10;   // Tens place
            sum += ln % 10;          // Units place

            Console.WriteLine($"Sum of digits is: {sum}");
        }
        else
        {
            Console.WriteLine("Invalid number. Please enter a 3-digit number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}
else
{
    Console.WriteLine("No input provided.");
}
#endregion