using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task: Write a C# program to check if a given number is present in an array of numbers.
            //Status: passed

            //Console.WriteLine("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach(var i in array)
            //{
            //if(num == i)
            //{
            //    Console.WriteLine($"{num} is present!");
            //  }
            //}


            //Task: Write a C# Sharp program to multiply all elements of a given array of numbers by array length.
            //Status: Passed!

            //int[] array1 = { 1, 2, 3, 4, 5 };
            //foreach(var item in array1)
            //{
            //  Console.Write(item*array1.Length + "\t"); // \t = tab
            // }

            //Task: Write a C# Sharp program to find the minimum value from two numbers given to you, represented as a string
            //Status: Passed!

            //string num_1 = "20";
            //string num_2 = "10";

            //int num_3 = Convert.ToInt32(num_1);
            //int num_4 = Convert.ToInt32(num_2);

            //Console.WriteLine(string.Format("The minimum value is: {0}", num_3 > num_4 ? num_4 : num_3));

            //Task: Write a C# Sharp program to create a coded string from a given string, using a specified formula.
            //Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
            //Status: UNFINISHED

            //P=9 - T=0 - S-1 - H=6 = A=8

            Console.WriteLine("Write a word? yes pls:> ");
            string word = Console.ReadLine();
            int i = 0;
            foreach(var str in word)
            {
                i++;
                Console.WriteLine(str[i]);
            } //unfinished due to internet breakout XD

            Console.ReadKey();// i always forget this LOL HAHAHA dumbass ME :v
        }
    }
}
