using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>
            {
                ["Milk"] = 30.49m,
                ["Pelmeni"] = 110.6m,
                ["Sossage"]=60.99m,
                ["Rice"]=35.8m,
                ["Fruit Cake"]=120.99m,
                ["Orange"] = 50.8m,
                ["Red fish"]=199m,
                ["Chicken"]=90m,
                ["Mango"]=133.7m,
            };

            var lower100price = from p in products
                                where p.Value < 100m
                                select p;
            Console.WriteLine("Products with the price less than 100");
            foreach (var product in lower100price)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            var more100price = from p in products
                                where p.Value > 100m
                                select p;
            Console.WriteLine("Products with the price more than 100");
            foreach (var product in more100price)
            {
                Console.WriteLine(product);
            }

            Console.ReadLine();
        }
    }
}
