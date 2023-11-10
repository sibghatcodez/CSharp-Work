using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 39

            Nullable<int> a = null; //same
            int? b = 100; //same
            //Console.WriteLine(b);
            //b = null;
            //Console.WriteLine(b);

            //Console.WriteLine(b);

            //Nullable<string> c = null; //Invalid
            string c = null;
            //Console.WriteLine(c);
            c = "aaaa";
            //Console.WriteLine(c);


            //Console.WriteLine(a.HasValue); //false
            //Console.WriteLine(b.HasValue);//true

            Nullable<short> x = null;
            Nullable<long> y = null;
            Nullable<double> z = null;
            //x = 10; y = 10000000000; z = 10.100;
            x = x ?? 10;
            //Console.WriteLine(x); //10
            //Console.WriteLine(x.HasValue + " - " + y.HasValue + " - " + z.HasValue);

            //var aaa; //invalid
            //dynamic bbb;//valid

            //dynamic zzz = "Alighar";
            //Console.WriteLine(zzz.GetType());

            dynamic rand = 100;
            rand = "10xxdkid";

            var rand_2 = 100;
            // rand_2 = "200xxkid"; //Invalid

            Console.WriteLine(rand.GetType());
            Console.ReadKey();
        }
    }
}
