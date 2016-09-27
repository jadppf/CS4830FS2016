using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static List<Product> products;
        static int nextid;

        static Service1()
        {
            products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
            products.Add(new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            products.Add(new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });
            nextid = 4;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProduct(string sid)
        {
            int id = Convert.ToInt32(sid);
            var product = products.FirstOrDefault((p) => p.Id == id);
            return (product);
        }

        public void AddProduct(string Name, string Category, decimal Price)
        {
            Product product = new Product();
            product.Id = nextid;
            nextid++;
            product.Name = Name;
            product.Category = Category;
            product.Price = Price;

            products.Add(product);
        }
    }
}
