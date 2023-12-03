namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product { Name = "Milk", Price = 12, Description = "10 ml", Category = "Food" };
            var product2 = new Product { Name = "Bread", Price = 300, Description = "kilogram", Category = "Books" };

            var user1 = new User { Username = "neshchasnij", Password = "password" };

            var shop = new Shop();
            shop.AddProduct(product1);
            shop.AddProduct(product2);
            shop.AddUser(user1);

            var order = shop.CreateOrder(user1, new List<Product> { product1, product2 }, new List<int> { 2, 1 });

            Console.WriteLine($"Order Status: {order.Status}");
            Console.WriteLine($"Total Cost: ${order.TotalCost}");
            Console.WriteLine("Products:");
            for (int i = 0; i < order.Products.Count; i++)
            {
                Console.WriteLine($"{order.Products[i].Name} - Quantity: {order.Numbers[i]}");
            }
        }
    }
}