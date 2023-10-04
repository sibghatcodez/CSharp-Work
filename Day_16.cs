using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 16th


            //try
            // {
            // int age = Convert.ToInt32(Console.ReadLine());
            //   Console.WriteLine(age);
            //} catch (Exception e)
            // {
            //  Console.WriteLine(e.Message);
            //}




            //-----------------------------------------------\\
            //-----------------------------------------------\\
            //-----------------------------------------------\\



            //Task: Learn Objects & Classes

            Dog dog_1 = new Dog("Bangwaa", "Pink");
            Dog dog_2 = new Dog("Kinu", "Orange");
            Dog dog_3 = new Dog(null,"Purple");

            dog_1.Name = "Jalpari";
            Console.WriteLine(dog_1.Name);
            Console.WriteLine(dog_1.Color);
            dog_1.BARK();
            Console.WriteLine(dog_2.Name);
            Console.WriteLine(dog_2.Color);
            dog_2.BARK();
            Console.WriteLine(dog_3.Name);
            Console.WriteLine(dog_3.Color);
            dog_3.BARK();

            Console.WriteLine(Dog.totalDogs);

            Console.ReadKey();
        }
    }

    public class Dog
    {
        private string name;
        private string color;
        public static int totalDogs = 0;

        public Dog(string name, string color)
        {
            this.name = name ?? "Unnamed Dawg";
            this.color = color;
            totalDogs++;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public void BARK()
        {
            Console.WriteLine("{0} said BHAUUU\n",name);
        }
    }
}
