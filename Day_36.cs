using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Data> list = new List<Data> {};
            list.Add(new Data("Asghar", 20));
            list.Add(new Data("Dani", 10));
            list.Add(new Data("Isaac", 42));
            list.Add(new Data("LLama", 31));

            var isEveryoneMinnow = list.All(a => a.age < 18);
            var isAnyoneMinnow = list.Any(a => a.age < 18);
            //Console.WriteLine(isEveryoneMinnow);
            //Console.WriteLine(isAnyoneMinnow);
            var checkName = list.Contains(new Data("Asghar", 20));
            Console.WriteLine(checkName);

            List<string> fruits = new List<string> {"Apple", "Guava", "Grapes", "Melon" };
            var x = fruits.Aggregate((a,b) => a + " and " + b);
            Console.WriteLine(x);

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var y = numbers.Average();
            Console.WriteLine(y);

            var z = numbers.Sum((a) => a);
            Console.WriteLine(z);  // 55

            var zz = numbers.Max();
            Console.WriteLine(zz); // 10?

            Console.ReadKey();
        }
    }
    public class Data
    {
        public string name { get; set; }
        public int age { get; set; }
        public Data(string n, int a)
        {
            name = n;
            age = a;
        }
    }
}
