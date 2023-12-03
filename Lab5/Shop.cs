using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Shop : ISearchable
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Order> Orders { get; set; } = new List<Order>();

        public void AddUser(User user) => Users.Add(user);

        public void AddProduct(Product product) => Products.Add(product);

        public Order CreateOrder(User user, List<Product> products, List<int> numbers)
        {
            var order = new Order
            {
                User = user,
                Products = products,
                Numbers = numbers,
                Status = "..."
            };

            Orders.Add(order);
            user.PurchaseHistory.Add(order);

            return order;
        }

        public List<Product> SearchByPrice(double maxPrice) => Products.Where(product => product.Price <= maxPrice).ToList();

        public List<Product> SearchByCategory(string category) => Products.Where(product => product.Category == category).ToList();

        public List<Product> SearchByRating(double minRating)
        {
            throw new NotImplementedException();
        }
    }
}
