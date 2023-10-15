
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day_26
{


    public delegate void Notify();

    public class Subscriber
    {
        public static void EventHandler()
        {
            Console.WriteLine("Process COMPLETED!");
        }
    }


    internal class Program
    {
        public event Notify ProcessCompleted; //event

        public void StartProcess()
        {
            Console.WriteLine("Starting process...");
            OnProcessCompleted();

        }
        public void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }


        /*   public delegate int Number(int x);

           public static int n = 10;
           public static int Add(int x)
           {
               n = n + x;
               return n;
           }
           public static int Mul(int x)
           {
               n = n * x;
               return n;
           } */



        static void Main(string[] args)
        {
            //Day 26th
            //Events and delegates.
            Program obj = new Program();
            obj.ProcessCompleted += Subscriber.EventHandler;
            obj.StartProcess();

            /*Number addNum = Add;
            Console.WriteLine(addNum(10)); // 20

            Number mulNum = Mul;
            Console.WriteLine(mulNum(10)); // 200 */

            Console.ReadKey();
        }
    }
}
