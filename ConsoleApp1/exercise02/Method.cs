
using System.Globalization;

namespace exercise2;

public class Method
{
public static List<int> TwoSum(List<int> nums, int target)
{
    Dictionary<int, int> map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Count; i++)
    {
        int complement = target - nums[i];
        if (map.ContainsKey(complement))
        {
            return new List<int> { map[complement], i };
        }

        map[nums[i]] = i;
    }

    return new List<int>();

}

public static int RemoveDuplicates(List<int> nums)
{
    int index = 1;
    for (int i = 1; i < nums.Count; i++)
    {
        if (nums[i] != nums[i - 1])
        {
            nums[index++] = nums[i];
        }
    }

    return index;
}

public static List<int> GetTopKFrequent(List<int> nums, int k)
{
    Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
    foreach (int num in nums)
    {
        if (frequencyMap.ContainsKey(num))
        {
            frequencyMap[num]++;
        }
        else
        {
            frequencyMap[num] = 1;
        }
    }

    return frequencyMap.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToList();
}

public static int MaxProfit(List<int> prices)
{
    int minPrice = int.MaxValue;
    int maxProfit = 0;
    foreach (int price in prices)
    {
        if (price < minPrice)
        {
            minPrice = price;
        } else if (price - minPrice > maxProfit)
        {
            maxProfit = price - minPrice;
        }
    }
    return maxProfit;
}
}