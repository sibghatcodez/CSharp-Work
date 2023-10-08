using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day 20th.

            //Polymorphism.
            //Donkey d = new Donkey();
            //d.AnimalSound();

            //Animal a = new Animal();
            // a.AnimalSound();





            //Abstraction-
            Banana ban = new Banana("Banana", 202);

            Console.ReadKey();
        }
        public abstract class Fruits
        {
            public Fruits(string Fruit, int Price)
            {
                Console.WriteLine($"{Fruit} price is: {Price}");
            }

            public abstract void FruitTaste();
        }
        public class Banana : Fruits
        {
            public Banana(string Fruit, int Price) : base(Fruit, Price) { }
            public override void FruitTaste()
            {
                Console.WriteLine("Fruit taste is nice^^");
            }
        }














        public class Animal //Parent Class.
        {
            public virtual void AnimalSound()
            {
                Console.WriteLine($"The animal says bye");
            }
        }
        public class Donkey : Animal //Child class
        {
            public override void AnimalSound()
            {
                Console.WriteLine("The donkey says hi");
            }
        }
    }
}
