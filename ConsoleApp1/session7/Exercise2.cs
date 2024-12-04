namespace session7;

public class Exercise2
{
    public static int findMax(List<int> numbers)
    {
        int max = numbers.ElementAt(0); // int max = numbers[0]
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;

    }
}