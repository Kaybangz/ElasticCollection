using System;
using System.Dynamic;
using System.Collections.Generic;

namespace ElasticCollectionLibrary
{
    public class ElasticCollection
    {
        public static List<dynamic> AddProductItems()
        {
            dynamic Products = new List<dynamic>();

            dynamic item1 = new ExpandoObject();
            item1.id = 1;
            item1.Name = "Dell xps";
            item1.Quantity = 30;
            item1.Price = 1500;
            item1.Category = "PC's";
            item1.OrderCount = 1000;

            dynamic item2 = new ExpandoObject();
            item2.id = 2;
            item2.Name = "Ergonomic chair";
            item2.Quantity = 200;
            item2.Price = 1500;
            item2.Category = "Chairs";
            item2.OrderCount = 4000;

            dynamic item3 = new ExpandoObject();
            item3.id = 3;
            item3.Name = "Table";
            item3.Quantity = 500;
            item3.Price = 250;
            item3.Category = "Tables";
            item3.OrderCount = 3000;


            Products.Add(item1);
            Products.Add(item2);
            Products.Add(item3);

            return Products;
        }


        public static void GetProductItems()
        {
            foreach (var item in AddProductItems())
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void DeleteProductItems(string[] propertiesToDisplay)
        {
            propertiesToDisplay[0] = "Name";
            propertiesToDisplay[1] = "Quantity";
            propertiesToDisplay[2] = "Price";

            if (propertiesToDisplay.Contains("Name"))
            {

            }
        }
    }
}
