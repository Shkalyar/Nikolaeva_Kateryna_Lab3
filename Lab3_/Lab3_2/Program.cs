using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> products = new Dictionary<int, string>();
            products.Add(1, "Milk");
            products.Add(2, "Apple");
            products.Add(3, "Milk");
            products.Add(4, "Juice");
            products.Add(6, "Eggs");
            products.Add(7, "Milk");
            products.Add(8, "Juice");


            var result = from p in products
                         group p by p.Value into g
                         where g.Count() > 1
                         select g;


            foreach (var r in result)
            {
                var sameValue = (from p in r
                                 select p.Key + "").ToArray();


                Console.WriteLine("Ключi {0} мають однакове значення {1}",
                                  string.Join(",", sameValue), r.Key);
            }

            Console.ReadLine();
        }
    }
}
