public class Exercise1
{
    public static int countSumGreater50(List<int> numbers)
    {
        // OUTPUT
        // list numbers > 50
        var sum = 0;
        foreach (var number in numbers)
            if (number >= 50)
                sum += number;

        return sum;
    }
}