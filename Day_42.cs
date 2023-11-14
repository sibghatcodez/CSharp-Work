using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 42

            //Interface
            Fruits apple = new Fruits("Apple");
            Fruits guava = new Fruits("Guava");
            apple.FruitName();
            guava.FruitName();

            IProfile prof = new Profile("Ashar", 20);
            Console.WriteLine(prof.name + " | " + prof.age);
            Console.ReadKey();
        }
    }

    interface IProfile
    {
        string name { get; set; }
        int age { get; set; }

    }
    class Profile  : IProfile
    {
        public Profile(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public string name { get; set; }
        public int age { get; set; }
    }

    interface Fruit
    {
        void FruitName();
    }
    class Fruits : Fruit
    {
        string fruitName { get; set; }
        public Fruits(string fName)
        {
           fruitName = fName;
        }

        public void FruitName()
        {
            Console.WriteLine(fruitName);
        }
    }
}
