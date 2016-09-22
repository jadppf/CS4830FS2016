using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using swaggertest;
using Newtonsoft.Json;

namespace SwagTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsClient client = new swaggertest.ProductsClient();
            var task = client.GetAllProductsAsync();
            var products = task.Result;
            foreach (var product in products)
            {
                Console.WriteLine("Id={0}, Name={1}, Category={3}, Price={2}", product.Id, product.Name, product.Price, product.Category);
            }
            Console.WriteLine("");

            var task2 = client.GetProductAsync(1);
            Product product1 = JsonConvert.DeserializeObject<Product>(task2.Result.ToString());
            Console.WriteLine("Id={0}, Name={1}, Category={3}, Price={2}", product1.Id, product1.Name, product1.Price, product1.Category);
            Console.WriteLine("");

            Console.WriteLine("Hit enter to continue....");
            Console.ReadLine();
        }
    }
}
