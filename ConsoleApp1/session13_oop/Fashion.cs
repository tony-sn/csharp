internal class Fashion : Product
{
    private string size;

    public Fashion(
        int productId,
        string productName,
        double price,
        string description,
        string size
    ) : base(productId, productName, price, description)
    {
        Size = size;
    }

    public string Size
    {
        get => size;
        set
        {
            List<string> validSizes = new() { "S", "M", "L", "XL", "XXL" };
            if (string.IsNullOrWhiteSpace(value) || !validSizes.Contains(value))
                throw new ArgumentException("Size must contain valid sizes");

            size = value;
        }
    }

    public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine($"Product Size: {Size}");
    }
}