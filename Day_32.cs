using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Day32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day 32

            //LINQ - 
            List<Person> ppl = new List<Person> {
            new Person { Name =  "Shabana", Age = 19 },
            new Person { Name =  "Shehrish", Age = 91 },
            new Person { Name =  "Sanam", Age = 46 },
            new Person { Name =  "Shabnam", Age = 25 }
            };

            var result = from Person in ppl where Person.Age > 20 select Person.Name;
            foreach(var res in result)
            {
             //   Console.WriteLine(res);
            }
            Generix<string> genObj = new Generix<string>();
            genObj.list = new List<string> { };
            List<string> aList = new List<string> { "Apple", "Banana", "Mango", "Guava" };
            foreach(var l in aList)
            {
                genObj.list.Add(l);
            }
            var check = from item in genObj.list where item.Contains("g") select item;
            foreach(var i in check)
            {
                Console.WriteLine(i); //shud print guava n mango
            }

            Console.ReadKey();
        }
    }
    class Generix<T>
    {
        public List<T> list;
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
