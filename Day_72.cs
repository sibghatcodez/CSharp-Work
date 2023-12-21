using System;
using System.Collections.Generic;
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
            //Day 71st


            Thread.CurrentThread.Name = "MainThread";

            Thread thread_1 = new Thread(Countdown)
            {
                Name = "CountdownThread"
            };
            thread_1.Start();

            Thread thread_2 = new Thread(Months)
            {
                Name = "MonthsThread"
            };
            thread_2.Start();
            
            Console.WriteLine(Thread.CurrentThread.Name + " Ended.");


            Console.ReadKey();
        }


        static async void Countdown()
        {
            Console.WriteLine("\t\tThread started." + Thread.CurrentThread.Name);

            for (int i = 0; i < 20; i++) {
            //await Task.Delay(1000);
                Thread.Sleep(1000);
            Console.WriteLine(i);
            }

            Console.WriteLine("\t\tThread ended." + Thread.CurrentThread.Name);
        }

        static async void Months()
        {
            string[] months = new string[]
            {
                "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec"
            };
            Console.WriteLine("\t\tThread Started." + Thread.CurrentThread.Name);
            foreach (string month in months)
            {
                //await Task.Delay(2000);
                Thread.Sleep(1000);
                Console.WriteLine(month);
            }
            Console.WriteLine("\t\tThread ended." + Thread.CurrentThread.Name);
        }
    }
}
