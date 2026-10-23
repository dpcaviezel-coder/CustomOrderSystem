namespace CustomerOrderSystem
{
    public class Customer
    {
        public string Name { get; }
        public string Email { get; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine(" Customer Information: ");
            Console.WriteLine(" --------------------- ");
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine($"Customer Email: {Email}");
            Console.WriteLine($" ==================== \n");
        }
    }
}
