using System;
using System.Collections.Generic;

namespace Lab3_
{
    class Program
    {
        static void Main(string[] args)
        {
            var list_obj = new List<Obj>
            {
                new Obj("Obj1",1),
                new Obj("Obj2",2),
                new Obj("Obj3",3),
                new Obj("Obj4",4),
                new Obj("Obj5",5),
                new Obj("Obj6",6),
            };

            Console.WriteLine("Enter Id of the Obj");
            int Id = int.Parse(Console.ReadLine());
            findbyId(Id, list_obj);

            Console.ReadLine();
        }

        static void findbyId(int Id, List<Obj>temp)
        {
            bool noObj = true;
            foreach (var item in temp)
            {
                if (Id == item.Id)
                {
                    Console.WriteLine("Object with Id " + Id + " " + item.Name);
                    noObj = false;
                }
            }
            if (noObj == true)
                Console.WriteLine("No Obj with such Id");
        }
    }
    class Obj
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Obj(string name,int Id)
        {
            Name = name;
            this.Id = Id;
        }
    }

}
