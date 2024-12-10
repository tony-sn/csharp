internal class Person
{
    public string dob;
    public string email;
    public string gender;
    public string ID;
    public string name;

    public Person(string ID, string name, string dob, string gender, string email)
    {
        this.ID = ID;
        this.name = name;
        this.dob = dob;
        this.gender = gender;
        this.email = email;
    }

    public virtual void printInfo()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"DOB: {dob}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Email: {email}");
    }
}