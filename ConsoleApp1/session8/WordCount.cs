class WortCount
{
    public static Dictionary<string, int> wordCount(List<string> words)
    {
        Dictionary<string, int> count = new Dictionary<string, int>();
        // Method 1: loop for and index
        for (int i = 0; i < words.Count; i++)
        {
            if (count.ContainsKey(words[i]))
            {
                count[words[i]]++; // this word appears so many times
            }
            else
            {
                count[words[i]] = 1; // this word list is unique
            }
        }

        // Method 2: based on item
        foreach (string word in words)
        {
            if (count.ContainsKey(word))
            {
                count[word]++;
            }
            else
            {
                count[word] = 1;
            }
        }

        return count;
    }
}