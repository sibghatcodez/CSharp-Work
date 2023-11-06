using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day 37


            List<int> list = new List<int>() { 12,21,31,32,42 };
            Console.WriteLine(list.ElementAt(2));
            Console.WriteLine(list.ElementAtOrDefault(22));
            //Console.WriteLine(list.Single());

            List<string> list_2 = new List<string> { "One", "Two", "Three" };
            List<string> list_3 = new List<string> { "One", "Three", "Two" };
            Console.WriteLine(list_2.SequenceEqual(list_3)); //false

            var list_4 = list_2.Concat(list_3);
            Console.WriteLine(list_4.Last()); //two

            List<string> list_5 = new List<string>();
            var x = list_5.DefaultIfEmpty("List is empty");
            Console.WriteLine(x.First());

            var range = Enumerable.Range(0, 10);
            Console.WriteLine($"Range length: {range.Count()}"); //10
            foreach (var item in range)
            {
               // Console.WriteLine(item);
            }

            foreach(var unique in list_4.Distinct())
            {
                Console.Write(unique + " "); //one two three
            }

            var list_6 = list_2.Except(list_3); //empty
            Console.WriteLine(list_6.LastOrDefault());

            var list_7 = list_2.Intersect(list_3);
            foreach(var item in list_7)
            {
                //Console.WriteLine(item); //ONE TWO THREE
            }


            Console.ReadKey();
        }
    }
}
