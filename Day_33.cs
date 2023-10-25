using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 33
            // LINQ

            List<Fruit> fruits = new List<Fruit>();
            Fruit fruit1 = new Fruit("Apple", 200);
            Fruit fruit2 = new Fruit("Guava", 100);
            Fruit fruit3 = new Fruit("Cherry", 500);
            Fruit fruit4 = new Fruit("Watermelon", 60);

            fruits.Add(fruit1);
            fruits.Add(fruit2);
            fruits.Add(fruit3);
            fruits.Add(fruit4);

            //keyword - where
            var cheapFruit = from x in fruits where x.fruitPrice >= 100 select x.fruitName;
            foreach(var item in cheapFruit) { Console.WriteLine(item); }

            //keyword - oftype
            IList list = new ArrayList(); // i have not learnt about Interfaces so...
            //that is why im trying to avoid but this one time.

            list.Add("Juice");
            list.Add(100);
            list.Add("Dad");
            list.Add(200);

            var getList = from x in list.OfType<string>() select x;
            foreach(var item in getList) { Console.WriteLine(item); }

            //keyword - OrderBy
            var getFruits = from x in fruits orderby x.fruitName select x.fruitName;
            foreach(var item in getFruits) { Console.WriteLine(item); } //apple, cherry, guava, watermelon

     //thats it for today!\\
            Console.ReadKey();

        }
    }
    class Fruit
    {
        public string fruitName { get; set; }
        public int fruitPrice { get; set; }

        public Fruit(string name, int price)
        {
            fruitName = name;
            fruitPrice = price;
        }
    }
}

