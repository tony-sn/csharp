// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region basic math
int add = 5 + 10;
Console.WriteLine($"5 + 10 = {add}");

int minus = 1231231 - 34546;
Console.WriteLine($"1231231 - 34546 = {minus}");

double divide = 5 / 2;
Console.WriteLine($"5 / 2 = {divide}");

#endregion

#region numeric types

int plus = 0;
plus += 10;

Console.WriteLine($"plus = {plus}");

#endregion

#region casting types with convert
Console.WriteLine("Please enter a number");
string number = Console.ReadLine();

int convertNumber = Convert.ToInt32(number);
int sum = convertNumber + add;

Console.WriteLine($"sum value = {sum}");
#endregion

#region BMI calculation
// INPUT
// height and weight from keyboard
Console.WriteLine("Please enter your height (m): ");
string height = Console.ReadLine();
double formatH = Convert.ToDouble(height);

Console.WriteLine("Please enter your weight (kg): ");
string weight = Console.ReadLine();
double formatW = Convert.ToDouble(weight);

// OUTPUT
// bmi number
double bmi = 0.0;

// PROCESS
// bmi = w / h * h
bmi = formatW / (formatH * formatH);
Console.WriteLine($"BMI = {bmi}");
#endregion
