using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 34
            //Keywords covered: Order By - where - Of type.

            //keyword -> then by
            Student std1 = new Student("Kamran", 21);
            Student std2 = new Student("Khalid", 65);
            Student std3 = new Student("Moosa", 17);
            Student std4 = new Student("Moosa", 54);
            List<Student> students = new List<Student>();
            students.Add(std1); students.Add(std2); students.Add(std3); students.Add(std4);

            //var aged = from a in students orderby a.age select a;
            //foreach(var item in aged) { Console.WriteLine(item.name); }

            var abc = students.OrderBy(x => x.name).ThenBy(x => x.age); //Moosa kamran khalid moosa
            foreach(var item in abc) { Console.WriteLine(item.name); }




            Fruit fr1 = new Fruit("Apple", 1000);
            Fruit fr2 = new Fruit("Cherry", 2000);
            Fruit fr3 = new Fruit("Banana", 1000);
            Fruit fr4 = new Fruit("Guava", 2000);
            List<Fruit> fruits = new List<Fruit>();
            fruits.Add(fr1); fruits.Add(fr2); fruits.Add(fr3); fruits.Add(fr4);

            //var groupedFruit = fruits.GroupBy(x => x.price);
            var groupedFruit = fruits.ToLookup(x => x.price);
            foreach (var item in groupedFruit) {
                Console.WriteLine("Item Price: {0}", item.Key);
                foreach (Fruit name in item)
                {
                    Console.WriteLine(name.name);
                }

            }


            Console.ReadKey();
        }
    }
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public Student(string name, int age)
        {
            this.name = name;

            this.age = age;

        }
    }
    public class Fruit
    {
        public string name { get; set; }
        public int price { get; set; }
        public Fruit(string name, int price)
        {
            this.name = name;

            this.price = price;

        }
    }
}
