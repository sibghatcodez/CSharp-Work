using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace C__Day40
{
    internal class Program
    {
        static Task Main(string[] args)
        {
            //Day 40
            //message();
            //message2();
            Console.ReadKey();

            LList<string> newList = new LList<string>();
            newList.l.Add("Kofee");
            newList.l.Add("Epple");
            newList.l.Add("Mengo");
            newList.ShowList();

            return Task.CompletedTask;
        }
        class LList<T>
        {
            public List<T> l;

            public void ShowList()
            {
                foreach(var item in l)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static async Task<int> Number()
        {
            await Task.Delay(2000);
            return 100 * 20;
        }
        static async void message()
        {
            Console.WriteLine("receiving message...");
            await Task.Delay(3000);
            Console.WriteLine("Message received!");
        }
        static void message2()
        {
            Console.WriteLine("receiving message... 2");
            Console.WriteLine("Message received! 2");
        }
    }
}
