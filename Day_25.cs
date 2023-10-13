using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day25
{
    internal class Program
    {
        // public delegate void Calc(int a, int b);

        //public void Add(int a, int b)
        //{
        //  Console.WriteLine($"{a} + {b} = {a + b}");
        //}
        //public void Sub(int a, int b)
        //{
        //Console.WriteLine($"{a} - {b} = {a - b}");
        //}
        //public void Mul(int a, int b)
        //{
        //Console.WriteLine($"{a} * {b} = {a * b}");
        //}
        //public void Div(int a, int b)
        //{
        //Console.WriteLine($"{a} / {b} = {a / b}");
        //}
        public delegate double TempConverter(int a);
        public double FtoC(int a) { return (a - 32) * 5 / 9; }
        public double CtoF(int a) { return (a * 9 / 5) + 32; }

        static void Main(string[] args)
        {
            //Day 25th
            Program obj = new Program();


            Console.WriteLine("What's the temp of your room?");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine("Want the output in fahrenheit or celcius? (f or c)");
            char choice = Console.ReadLine().ToLower()[0];

            TempConverter temperature;
            switch (choice)
            {
                case 'f':
                    temperature = obj.FtoC;
                    Console.WriteLine(temperature(temp));
                    break;
                case 'c':
                    temperature = obj.CtoF;
                    Console.WriteLine(temperature(temp));
                    break;
            }

            





            //Program instance = new Program();
            //Calc add = new Calc(instance.Add);
            //Calc sub = new Calc(instance.Sub);
            //Calc mul = new Calc(instance.Mul);
            //Calc div = new Calc(instance.Div);

            //add(100, 200); // 300
            //sub(200, 100); // 100
            //mul(20, 10); // 200
            //div(400, 2); // 200




            Console.ReadKey();
        }
    }
}
