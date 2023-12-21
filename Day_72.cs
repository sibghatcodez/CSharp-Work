using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Day71
{
    internal class Program
    {
        static void Main(string[] args) // <- Thread
        {
            // Multithreading and Parallel Programming
            //Day 72nd
            Stopwatch stopwatch = new Stopwatch();


            stopwatch.Start();

            /*Parallel.Invoke(
                 () => CalculateFibonacciAsync(1),
                 () => CalculateFibonacciAsync(1),
                 () => CalculateFibonacciAsync(1),
                 () => CalculateFibonacciAsync(1)
                 );*/ //880ms

            /*Thread thread_1 = new Thread(() => CalculateFibonacciAsync(1));
            Thread thread_2 = new Thread(() => CalculateFibonacciAsync(1));
            Thread thread_3 = new Thread(() => CalculateFibonacciAsync(1));
            Thread thread_4 = new Thread(() => CalculateFibonacciAsync(1));

            thread_1.Start();
            thread_2.Start();
            thread_3.Start();
            thread_4.Start();*/ //61ms


            CalculateFibonacciAsync(1);
            CalculateFibonacciAsync(1);
            CalculateFibonacciAsync(1);
            CalculateFibonacciAsync(1); //40ms


            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);


            Console.ReadKey();
        }

        /* static void CountDown()
         {
              Parallel.For(0, 5000, cd => {
                Debug.WriteLine(cd);
             });
         }*/
        static long CalculateFibonacciSync(int n)
        {
            if (n <= 1)
                return n;
            else
                return CalculateFibonacciSync(n - 1) + CalculateFibonacciSync(n - 2);
        }

        static async Task<long> CalculateFibonacciAsync(int n)
        {
            return await Task.Run(() => CalculateFibonacciSync(n));
        }

    }
}

