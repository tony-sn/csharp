internal class TwoSum
{
    public static List<int> twoSum(List<int> lst, int target)
    {
        for (var i = 0; i < lst.Count - 1; i++)
        for (var j = i + 1; j < lst.Count; j++)
            if (lst[i] + lst[j] == target)
                return new List<int> { i, j };

        return null;
    }

    public static List<int> twoSumDictionary(List<int> lst, int target)
    {
        // use Dictionary to mark each number in lst
        // key - save value of each index in Dictionary
        // value - save index
        var seenNumbers = new Dictionary<int, int>();
        for (var i = 0; i < lst.Count; i++)
        {
            var completion = target - lst[i];
            if (seenNumbers.ContainsKey(completion)) return new List<int> { seenNumbers[completion], i };

            // if completion not in that dic -> add to dic to mark
            seenNumbers.Add(lst[i], i);
        }

        return null;
    }
}