class Exercise4
{
    public static List<int> uniqueNumbers(List<int> numbers)
    {
        List<int> results = new List<int>();
        results.Add(numbers.ElementAt(0));
        for (int i = 1; i < numbers.Count; i++)
        {
            if (results.Contains(i) == false)
            {
                results.Add(i);
            }

            if (numbers[i] != numbers[i - 1])
            {
                results.Add(i);
            }
            
        }

        return results;
    }
}