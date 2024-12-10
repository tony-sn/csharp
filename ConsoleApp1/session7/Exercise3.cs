internal class Exercise3
{
    public static List<string> findAllStartM(List<string> lstString)
    {
        List<string> results = new();
        foreach (var str in lstString)
            if (str.Contains("m"))
                results.Add(str);

        return results;
    }
}