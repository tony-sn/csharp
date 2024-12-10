// See https://aka.ms/new-console-template for more information

using exercise2;

internal class Program
{
    private static void Main(string[] args)
    {
        #region exercise1

        var IstNumber = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        var sum = IstNumber.Sum();
        Console.WriteLine("Sum of all numbers in the array: " + sum);

        #endregion

        #region exercise2

        var nums = new List<int> { 2, 7, 11, 15 };
        var target = 9;
        var result = Method.TwoSum(nums, target);
        Console.WriteLine("Indices for target sum: [" + string.Join(", ", result) + "]");

        #endregion

        #region exercise3

        var nums2 = new List<int> { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
        var result2 = Method.RemoveDuplicates(nums2);
        Console.WriteLine($"New array after remove: {result2} ");

        #endregion

        #region exercise 4

        var nums3 = new List<int> { 1, 1, 1, 2, 2, 3 };
        var k = 2;
        var topKFrequent = Method.GetTopKFrequent(nums3, k);

        Console.WriteLine("Top K frequent numbers: [" + string.Join(", ", topKFrequent) + "]");

        #endregion

        #region exercise5

        var prices = new List<int> { 7, 1, 5, 3, 6, 4 };
        var maxProfit = Method.MaxProfit(prices);
        Console.WriteLine("Maximum profit: " + maxProfit);

        #endregion
    }
}