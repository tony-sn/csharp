public class Product
{
    public string id;
    public string productName;
    public double price;
    public int quantity;

    public void readInfo()
    {
        Console.WriteLine("Enter product id: ");
        id = Console.ReadLine();
        Console.WriteLine("Enter product name: ");
        productName = Console.ReadLine();
        Console.WriteLine("Enter product price: ");
        price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter quantity: ");
        quantity = Convert.ToInt32(Console.ReadLine());
    }

    public void displayInfo()
    {
        Console.WriteLine($"Product ID: {id}");
        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Product Price: {price}");
        Console.WriteLine($"Product Quantity: {quantity}");
    }
}