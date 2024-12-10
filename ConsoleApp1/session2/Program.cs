// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

#region basic math

var add = 5 + 10;
Console.WriteLine($"5 + 10 = {add}");

var minus = 1231231 - 34546;
Console.WriteLine($"1231231 - 34546 = {minus}");

double divide = 5 / 2;
Console.WriteLine($"5 / 2 = {divide}");

#endregion

#region numeric types

var plus = 0;
plus += 10;

Console.WriteLine($"plus = {plus}");

#endregion

#region casting types with convert

Console.WriteLine("Please enter a number");
var number = Console.ReadLine();

var convertNumber = Convert.ToInt32(number);
var sum = convertNumber + add;

Console.WriteLine($"sum value = {sum}");

#endregion

#region BMI calculation

// INPUT
// height and weight from keyboard
Console.WriteLine("Please enter your height (m): ");
var height = Console.ReadLine();
var formatH = Convert.ToDouble(height);

Console.WriteLine("Please enter your weight (kg): ");
var weight = Console.ReadLine();
var formatW = Convert.ToDouble(weight);

// OUTPUT
// bmi number
var bmi = 0.0;

// PROCESS
// bmi = w / h * h
bmi = formatW / (formatH * formatH);
Console.WriteLine($"BMI = {bmi}");

#endregion

#region calculate circle dimension

Console.WriteLine("Please enter circle\' radius");
var radius = Console.ReadLine();

#endregion