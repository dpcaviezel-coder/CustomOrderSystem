namespace CustomerOrderSystem
{
    public class Product
    {
        public string ProductName { get; }
        public double Price { get; }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }   

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Information:");
            Console.WriteLine($"-------------------");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: ${Price:C}");
            Console.WriteLine($"===================");
        }
    }
}
