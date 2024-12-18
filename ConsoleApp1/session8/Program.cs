﻿namespace session8;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var lst = new List<int> { 2, 7, 9, 11, 15 };
        //                            0  1  2   3   4
        var target = 26;
        Console.WriteLine("Exercise 1: Find 2 number so that 2 of numbers equal to target");
        if (TwoSum.twoSum(lst, target) == null)
        {
            Console.WriteLine("Can't find target for twoSum");
        }
        else
        {
            var indice = TwoSum.twoSum(lst, target);
            Console.WriteLine($"Indice that equal target: {string.Join(',', indice)}");
        }

        Console.WriteLine("Method 2: Use dictionary");
        if (TwoSum.twoSumDictionary(lst, target) == null)
        {
            Console.WriteLine("Cannot find two numbers that equal to target");
        }
        else
        {
            var indexes1 = TwoSum.twoSumDictionary(lst, target);
            Console.WriteLine($"Indces with 2 numbers that equal to target: {string.Join(',', indexes1)}");
        }

        #region How to save number inside coffee machine

        var number1 = 10;
        var number2 = number1;
        number1 = 30;
        Console.WriteLine($"number1={number1}, number2={number2}");

        #endregion
    }
}