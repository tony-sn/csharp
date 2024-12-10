internal class Product
{
    private string description;
    

    private double price;

    // exception
    // 5 most common mistake
    // 1. logic and argument (ArgumentException, ...)
    // 2. data format (FormatException, ...)
    // 3. System error
    // 4. I/O and network


    private string productName;

    public Product(int productId, string productName, double price, string description)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        Description = description;
    }

    public int ProductId { get; set; }

    public string ProductName
    {
        get => productName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Product name must not be empty");

            productName = value;
        }
    }

    public double Price
    {
        get => price;
        set
        {
            if (value < 0) throw new ArgumentException("Price must be greater than 0");
            price = value;
        }
    }

    public string Description
    {
        get => description;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Description must not be empty");
        }
    }


    /// <summary>
    ///     static method won't use attribute of object
    ///     static method don't need to construct obj
    ///     Example: Product.sum(1,2);
    ///     ELSE, if don't use static, need to create obj
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int sum(int a, int b)
    {
        return a + b;
    }

    // Product (parent class)
    // productId: int
    // productName: string
    // price: double
    // description: string

    public virtual void displayInfo()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Description: {Description}");
    }
}