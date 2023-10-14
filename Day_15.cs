using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day - 15th

            //Task: Learn Error handling

            try
            {
                Console.WriteLine("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(age);
            } catch(Exception f)
            {
                Console.WriteLine("Age must be integer.");
                throw new Exception("Whoops!");
            }


            Console.ReadKey();
        }
    }
}
