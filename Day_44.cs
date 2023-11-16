using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 44th
            //Dictionary & Sets.
            //Structs

            Dictionary<int, string> workout = new Dictionary<int, string>()
            {
                {12,"Lunges" },
                {20, "Push Ups" },
                {13, "Pull Ups"}
            };
            foreach(var item in workout)
            {
              //  Console.WriteLine($"Reps: {item.Key} | Workout: {item.Value}"); ;
            }


            string[] fruits = new string[] { "Apple", "Kela", "Soof", "Kela", "Angoor" };

            var set = new HashSet<string>(fruits);
            // var set_2 = set.ToArray();
            //Console.WriteLine(string.Join("|", set));
            foreach (var f in set)
            {
            //    Console.WriteLine(f);
            }
            abc strct = new abc(10,2,0);
            Console.WriteLine(strct.y * strct.x);

            Console.ReadKey();
        }
    }

    struct abc
    {
        public int x;
        public int y;
        public int z;

        public abc(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

    }
}
