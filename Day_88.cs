using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C__Day88
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day88
            /*(int, int, string) x = (1, 100, "2");
            Console.WriteLine(x.Item1+x.Item2);


            x.Item1 = 2;
            Console.WriteLine(x.Item1 + x.Item2);

            var tuple = Tuple.Create(Tuple.Create(1, 2, 3, 4, 5), Tuple.Create(6, 7, 8,9,10));
            Console.WriteLine(tuple.Item1.Item1 + tuple.Item2.Item1);*/

            var z = ValueTuple.Create(1, 2, 3, 4, 5);

            ITuple a = Tuple.Create(1,2);
            ITuple b = ValueTuple.Create(1, 2);

            for (int i = 1; i <= 10; i++) Count(i);
            Func<int, int, int> multiply = (num,num2) => num * num2;
            Console.WriteLine(multiply(10,20));


            Console.ReadKey();
        }
        static void Count(int cd) => Console.WriteLine(cd);
    }
}
