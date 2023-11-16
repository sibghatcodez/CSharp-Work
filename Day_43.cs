using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 43
            //Dictionary & ...


            var stuff = new Dictionary<int, string>()
            {
                {1, "Jam"},
                {2, "Mountain" },
                {3, "Cycle" },
                {4, "Grave"},
                {5, "Erik Satie" }
            };
            Dictionary<int, string> fruits = new Dictionary<int, string>();
            fruits.Add(230, "Apple");
            fruits.Add(500, "Cherry");
            fruits.Add(60, "Banana");
            fruits.Add(100, "Dates");
            if (fruits.ContainsKey(545))
            {
                Console.WriteLine(fruits[535]);
            }
            else Console.WriteLine("Key not found error 69;");
            string keyval;
            if(fruits.TryGetValue(1002, out keyval))
            {
                Console.WriteLine(keyval);
            } else Console.WriteLine("Key not found error 69;");


            //foreach(var fruit in fruits) { Console.WriteLine($"Fruit: {fruit.Value} | Fruit Price: {fruit.Key}"); }

            foreach (var item in stuff)
            {
                //Console.WriteLine($"Key: {item.Key} - Item: {stuff.ElementAt(item.Key).Value}");
            }
            //Console.WriteLine(stuff[5]); // Erik satie shud be printed



            string[] vegs = new string[] { "Carrot","Potato","Tomato","Carrot" };
            Console.ReadKey();
        }
    }
}
