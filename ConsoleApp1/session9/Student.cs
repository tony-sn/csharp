public class Student
{
    public string name;
    public int age;
    public string gender;
    public string email;

    public void importInfo()
    {
        Console.WriteLine("Enter the name of the student:");
        name = Console.ReadLine();
        Console.WriteLine("Enter the age of the student:");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the gender of the student:");
        gender = Console.ReadLine();
        Console.WriteLine("Enter the email of the student:");
        email = Console.ReadLine();
    }

    public void exportInfo()
    {
        Console.WriteLine("Student Information : ");
        Console.WriteLine($"name: {name}");
        Console.WriteLine($"age: {age}");
        Console.WriteLine($"gender: {gender}");
        Console.WriteLine($"email: {email}");
    }
    
}