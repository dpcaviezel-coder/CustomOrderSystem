namespace CustomerOrderSystem
{
    public class OrderManager
    {
        private readonly List<Customer> customers = new();
        public readonly List<Product> products = new();
        public List<Order> orders = new();


        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void PlaceOrder(
        Customer customer,
        Product product)
        {
            customers.Add(customer);

            products.Add(product);

            orders.Add(
                new Order(customer, product));
        }

        public void DisplayOrders()
        {
            Console.WriteLine("=== Orders ===");

            foreach (Order order in orders)
            {
                Console.WriteLine($"{order.Customer.Name} -> {order.Product.ProductName}");
            }
        }
    }
}
