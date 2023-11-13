using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C__Day41
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Day 41
            //Asynchronous Programming

            //Console.WriteLine("Countdown started.");
            //Countdown(); //We usin asynchronous progr'ing here, and it doesnt stops the program.
            //Countdown2(); //this shiit ruins the program 
            //Console.WriteLine("Countdown finished.");

            //var what = await Anything();
            //await Console.Out.WriteLineAsync(what);
            //Console.WriteLine(what);


            var res1 = await Number_1();
            var res2 = await Number_2();

            Console.WriteLine(string.Format("RESULT FROM METHOD 1: {0}", res1));
            Console.WriteLine(string.Format("RESULT FROM METHOD 2: {0}", res2));


            Console.ReadKey();
        }
        static async Task<int> Number_1()
        {
            Console.WriteLine("Number1 Method CALLED");
            await Task.Delay(2000);
            return 10;
        }
        static async Task<int> Number_2()
        {
            Console.WriteLine("Number2 Method CALLED");
            await Task.Delay(2000);
            return 20;
        }


        static async Task<string> Anything()
        {
            await Task.Delay(3000);
            return "Free Palestine.";
        }
        static async void Countdown()
        {
            await Task.Delay(1000); //1000ms = 1second
            await Console.Out.WriteLineAsync(">> 1 <<");
            await Task.Delay(1000); //1000ms = 1second
            await Console.Out.WriteLineAsync(">> 2 <<");
            await Task.Delay(1000); //1000ms = 1second
            await Console.Out.WriteLineAsync(">> 3 <<");
        }
        static void Countdown2()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine(">> 1 <<");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine(">> 2 <<");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine(">> 3 <<");
        }
    }
}
