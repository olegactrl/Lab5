using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface ISearchable
    {
        List<Product> SearchByPrice(double maxPrice);
        List<Product> SearchByCategory(string category);
        List<Product> SearchByRating(double minRating);
    }
}
