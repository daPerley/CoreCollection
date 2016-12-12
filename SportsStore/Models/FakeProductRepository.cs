using System.Collections.Generic;

namespace SportsStore.Models
{
    public class FakeProductRepository /*  IProductRepository */
    {
        public IEnumerable<Product> Products => new List<Product> {
             new Product { Name = "Football", Price = 250 },
             new Product { Name = "Surf board", Price = 1790 },
             new Product { Name = "Running shoes", Price = 950 }
         };
    }
}
