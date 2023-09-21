using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace C__Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 5th of Learning C#



            //Task: Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.
            //Status: Passed;


            //Console.Write("Enter a number: ");
            // int num_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number again: ");
            //int num_2 = Convert.ToInt32(Console.ReadLine());

            //int value = 20;

            //num_1 = num_1 - value;
            //num_2 = num_2 - value;

            //Console.WriteLine("The nearest number is: " + (num_1>num_2 ? num_2 + value : num_1+value).ToString());


            //Task: Write a C# program to create a string where the first 4 characters are in lower case.
            //If the string is less than 4 letters, make the whole string in upper case.
            //Status: Partially passed;

            //        Console.Write("Write a word: ");
            //          string word = Console.ReadLine();

            //            string filteredWord;

            //if(word.Length > 3)
            //{
            //   filteredWord = word.Substring(0, 3).ToLower() + word.Substring(3);
            //} else { filteredWord = word.ToUpper();  }
            //Console.WriteLine(filteredWord);



            //Task: Write a C# program to check if a given string starts with "w" and is immediately followed by two "ww".
            //Status: failed(i hate failing)


            //Console.WriteLine("Write gibberish: ");
            //string gib = Console.ReadLine();

            //if(gib.Length > 1)
           // {
                //if(gib.StartsWith("w"))
                //{
                   // if (gib.Remove(1).ToString() == "w") Console.WriteLine("it is followed by w");
                 //   else Console.WriteLine("it isnt.");
               // }
            //}
            Console.ReadKey();
        }
    }
}
