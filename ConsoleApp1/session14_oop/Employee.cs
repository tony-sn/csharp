internal class Employee
{
    public int EmployeeId { get; set; }
    private string name;
    protected double BaseSalary { get; set; }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Product name must not be empty");

            name = value;
        }
    }

    protected Employee(string name,int employeeId,double baseSalary)
    {
        Name = name;
        EmployeeId = employeeId;
        BaseSalary = baseSalary;
    }
    
    public
}