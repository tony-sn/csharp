using Newtonsoft.Json;

internal class ProductManager
{
    private readonly string filePath = "products.json";
    private List<Product> products;

    public ProductManager()
    {
        loadData();
    }

    private void loadData()
    {
        if (!File.Exists(filePath))
        {
            products = new List<Product>();
        }
        else
        {
            var json = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }

    private void saveData()
    {
        var json = JsonConvert.SerializeObject(products, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public void addProduct(Product product)
    {
        products.Add(product);
        saveData();
    }

    public void addElectronic()
    {
        Console.WriteLine("Enter product ID: ");
        var productId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter product name: ");
        var productName = Console.ReadLine();
        Console.WriteLine("Enter product price: ");
        var price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter product description: ");
        var description = Console.ReadLine();
        Console.WriteLine("Enter product warranty: ");
        var warranty = Convert.ToInt32(Console.ReadLine());
        var electronic = new Electronic(productId, productName, price, description, warranty);
        addProduct(electronic);
    }

    public void displayAllProducts()
    {
        // desc sort
        // => lambda expression
        products.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
        foreach (Product product in products)
        {
            product.displayInfo();
            Console.WriteLine("=================================");
        }
    }

    public void searchByName(string name)
    {
        Product? product = products.Find(p => p.ProductName.Contains(name));
        if (product == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            product.displayInfo();
        }
    }
}