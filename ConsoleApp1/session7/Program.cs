// See https://aka.ms/new-console-template for more information

using session7;

internal class Program
{
    private static void Main(string[] args)
    {
        #region
        List<int>numbers = new List<int>();
        Console.WriteLine("Enter the numbers you want to add: ");
        string? n = Console.ReadLine();
        int format = Convert.ToInt32(n);
        for (int i = 0; i < format; i++)
        {
            
            Console.WriteLine($"Please enter a number from index {i + 1}");
            int number = Convert.ToInt32(Console.ReadLine());
            numbers.Add(number);
        }

        Console.WriteLine("List of indices: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.Write(String.Join(",", numbers));

        numbers.Sort();
        Console.Write("Sorted List: ");
        Console.Write(String.Join(",", numbers));

        numbers.Reverse();
        Console.Write("Reversed List: ");
        Console.Write(String.Join(",", numbers));

        
        #endregion
        
        #region extra exercise 1

        List<int> newNumbers = new List<int>{ 50, 10, 51, 33, 100};
        int? sum = Exercise1.countSumGreater50(newNumbers);
        Console.WriteLine($"sum of all number that greater than 50 is {sum}");
        #endregion
        
        #region extra exercise 2 Find max number
        // S1: find any number in the list to become max
        // S2: loop through list from index 1 and compare with max
        // S3: if number > max, max = number
        // S4: else, continue
        List<int> newList = new List<int>{ 50, 10, 22, 33, 100};
        int? max = Exercise2.findMax(newList);
        Console.WriteLine($"max of all number from new list is {max}");
        #endregion
        
        #region exercise 3 find all string starting with 'm'

        List<string> lstString = new List<string> { "banana", "mango", "Kiwi", "orange" };
        List<string> results = Exercise3.findAllStartM(lstString);
        Console.WriteLine("All strings starting with 'm':");
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }

        #endregion
        
        #region exercise 4 list unique numbers

        List<int> lstNumbers = new List<int> { 1, 1, 1, 3, 3, 4, 5, 6, 6 };
        List<int> lstResult = Exercise4.uniqueNumbers(lstNumbers);
        Console.WriteLine($"All unique numbers are {lstResult}");
        foreach (int result in lstResult)
        {
            Console.WriteLine(result);
        }
        #endregion
        
        #region Dictionary in Collection

        Dictionary<string, string> dic = new Dictionary<string, string>();
        // add key-value into dic
        dic.Add("Alice", "test"); // Adding "Alice" -> "test"
        dic["Donald"] = "Trump"; // Adding "Donald" -> "Trump"
        
        // loop through dic
        foreach (KeyValuePair<string, string> pointer in dic)
        {
            // pointer: key-value
            Console.WriteLine($"{pointer.Key}: {pointer.Value}");
        }
        // Alice: test
        // Donald: Trump
        
        // only key
        Console.WriteLine("Dictionary contains key: ");
        foreach (string str in dic.Keys)
        {
            Console.WriteLine(str);
        }
        // Alice
        // Donald
        
        // Method 2:
        for (int i = 0; i < dic.Keys.Count; i++)
        {
            Console.WriteLine(dic.Keys.ElementAt(i));
        }
        
        // update value for dic
        dic["Alice"] = "Wonderland"; // Updating "Alice" -> "Wonderland"
        Console.WriteLine("Dict after update: ");
        foreach (KeyValuePair<string, string> pointer in dic)
        {
            Console.WriteLine($"Surname: {pointer.Key}, Name: {pointer.Value}");
        } 
        // Surname: Alice, Name: Wonderland
        // Surname: Donald, Name: Trump
        
        // remove key-value from dic
        dic.Remove("Alice"); // Removing the key "Alice"
        Console.WriteLine("Dict after delete: ");
        foreach (KeyValuePair<string, string> pointer in dic)
        {
            Console.WriteLine($"Surname: {pointer.Key}, Name: {pointer.Value}");
        }
        // Surname: Donald, Name: Trump
        #endregion
    }
}