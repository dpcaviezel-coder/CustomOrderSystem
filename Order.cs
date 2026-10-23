namespace CustomerOrderSystem
{
    public class Order
    {
        public Customer Customer { get; private set; }
        public Product Product { get; private set; }

        public Order(Customer customer, Product product)
        {
            Customer = customer;
            Product = product;
        }
    }

}
