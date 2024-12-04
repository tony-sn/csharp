internal class WordCount
{
    public static void process()
    {
        Console.WriteLine("Please enter the word you want to count: ");
        var text = Console.ReadLine();

        // Step 1: divide words
        string[] words = text.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Step 2: look at session 8
        Dictionary<string, int> wordCounts = new();
        foreach (var word in words)
        {
            var lowerWord = word.ToLower();
            if (wordCounts.ContainsKey(lowerWord))
                wordCounts[lowerWord]++;
            else
                wordCounts[lowerWord] = 1;
        }

        Console.WriteLine("Number of appearance of each word:");
        foreach (KeyValuePair<string, int> pointer in wordCounts) Console.WriteLine($"{pointer.Key}: {pointer.Value}");
    }
}