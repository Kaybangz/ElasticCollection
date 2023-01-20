using ElasticCollectionLibrary.Model;
using System.Collections.Generic;


namespace ElasticCollectionLibrary.DB
{
    public class Datastore
    {
        

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { ID = 1, Name = "Dell xps", Quantity = 30, Price = 1500, Category = "PC's", OrderCount = 1000 });

            products.Add(new Product { ID = 2, Name = "Ergonomic chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 });

            products.Add(new Product { ID = 1, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 });

            return products;
        }
    }
}
