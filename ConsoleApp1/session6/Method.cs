namespace session6;

public class Method
{
    public static bool checkPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i < Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    ///  This function will print a right-align asterisk triangle 
    /// </summary>
    /// <param name="height">first param: height type int</param>
    public static void printTriangleStar(int height)
    {
        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
            Console.Write("* "); 
            }
            Console.WriteLine();
        }
    }
    
}