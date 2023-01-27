using System;

namespace ElasticCollectionLibrary
{
    public class FetchProductsDLL
    {
        public static void GetAllProductItems()
        {
            Console.WriteLine("ID -- NAME -- QUANTITY -- PRICE -- CATEGORY -- ORDERCOUNT\n");
            foreach (var item in ElasticCollection.AddProductItems())
            {
                Console.WriteLine($"{item.id} -- {item.Name} -- {item.Quantity} -- {item.Price} -- {item.Category} -- {item.OrderCount}\n");
            }
        }


        public static void GetSpecificProductProperties()
        {
            try
            {
                Console.WriteLine("Specify number of product properties to show: ");
                int numberOfProperties = int.Parse(Console.ReadLine());

                List<string> properties = new List<string>(numberOfProperties);


                for(int i = 0; i < numberOfProperties; i++)
                {
                    Console.WriteLine("Enter property: ");
                    string? property = Console.ReadLine();

                    properties.Add(property);
                }

                
                
                

            }
            catch
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Something went horribly wrong!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
