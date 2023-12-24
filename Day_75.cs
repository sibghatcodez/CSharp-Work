using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Day71
{

    public class trig
    {
        public int cos { get; set; }
        public int sin { get; set; }
        public int tan {get; set; }

        public trig(int COS, int SIN, int TAN)
        {
            cos = COS;
            sin = SIN;
            tan = TAN;
        }
    }


    internal class Program
    {
        public static Func<int, int, int> Add = (num1, num2) => num1 + num2;
        public int Msg() { return Add(10, 20);  }



        static void Main(string[] args) // <- Thread
        {
            //Day 75th
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Program prog = new Program();
            Console.WriteLine(prog.Msg());
            Process pc = Process.GetCurrentProcess();
            Console.WriteLine(pc.PrivateMemorySize64);
            sw.Stop();
            /*trig obj = new trig(1,2,3);
            trig obj2 = obj with { sin = 1000 };*/

            // makeArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            Console.ReadKey();
        }

       /* static void makeArray(params int[] array)
        {
            int[] numbers = new int[array.Length];
            for(int i = 0; i <  array.Length; i++)
            {
                numbers[i] = array[i];
            }

            List<int> evenNumbers = new List<int>();
            foreach(int num in array)
            {
                if (num % 2 == 0) evenNumbers.Add(num);
            }
            foreach(int nums in evenNumbers) Console.WriteLine(nums);

        }*/

    }
}

