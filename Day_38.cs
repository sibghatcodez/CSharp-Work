using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day38

            List<int> listA = new List<int>() { 1,2,3,4,5 };
            List<int> listB = new List<int>() { 1,6, 7, 8, 9 };
            var result = listA.Union(listB);
            // foreach(var item in result) { Console.WriteLine(item); }


            List<string> listC = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            var resultC = listC.Skip(4); //five
            var resultD = listC.SkipWhile(x => x.Length <= 3);

            // foreach(var x in resultC) { Console.WriteLine($"Skip -> {x}"); }
            // foreach (var x in resultD) { Console.WriteLine($"SkipWhile -> {x}"); }

            var resultE = listC.Take(4); //one two three four
            var resultF = listC.TakeWhile(x => x.Length == 3); // one two

            //foreach(var item in resultE) { Console.WriteLine($"TAKE: {item}"); }
            //foreach (var item in resultF) { Console.WriteLine($"TAKEwhile: {item}"); }

            Console.ReadKey();
        }
    }
}
