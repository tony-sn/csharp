internal class Electronic : Product
{
    private int warranty;

    public Electronic(
        int productId,
        string productName,
        double price,
        string description,
        int warranty
    ) : base(productId, productName, price, description)
    {
        Warranty = warranty;
    }

    public int Warranty
    {
        get => warranty;
        set
        {
            if (value < 0) throw new ArgumentException("Warranty must be greater than 0");
            ;
        }
    }

    public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine($"Warranty: {Warranty}");
    }
}