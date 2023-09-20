using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task: Write a C# program to multiply the corresponding elements of two integer arrays.
            //Status: Passed
            //int[] array_1 = { 1, 2, 3, 10};
            //int[] array_2 = { 3, 2, 1, 10};

           // for(int i=0; i<array_1.Length; i++)
            {
             //   Console.Write(array_1[i] * array_2[i] + ", ");
            }


            //Task: Write a C# program to create a string of four copies, taking the last four characters from a given string.
            //If the given string is less than 4, return the original one.
            //Status: Passed;

            //Console.Write("Write your shit: ");
            //string str = Console.ReadLine();
            //string str_4 = str.Length > 3 ? str.Substring(str.Length - 4) : str;
            //Console.WriteLine(str_4);

            //Task: Write a C# program to check if a given positive number is a multiple of 3 or 7.

            //Console.WriteLine("Enter your number!:-> ");
            //int givenNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(givenNumber % 3 == 0 || givenNumber % 7 == 0);



            //Task: Write a C# program to check if "HP" appears at the second position in a string and return the string without "HP".
            //Status: FAILED <</333;
            //Console.WriteLine("Enter a sentence? yes pls UwU:- ");
            //string sentence = Console.ReadLine();
            //Console.WriteLine(sentence.Substring(1, 2).Equals("HP") ? sentence.Remove(1,2) : sentence);


            //Task: Write a C# program to get a string of two characters from a given string.
            //The first and second characters of the given string must be "P" and "H", so PHP will be "PH".
            //Status: passed YAYYY

            //Console.WriteLine("Enter a lang you hate: ");
            //string L_Lang = Console.ReadLine();
            //Console.WriteLine(L_Lang.Substring(0,2).Equals("PH") ? L_Lang.Substring(0,2) : L_Lang );
            


            //Task: Write a C# program to find the largest and lowest values from three integer values.
            //Status: Passed!! 

            //Console.Write("Enter 1st num: ");
            //int num_1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter 2nd num: ");
            //int num_2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter 3rd num: ");
            //int num_3 = int.Parse(Console.ReadLine());

           //int largestValue = num_1 > num_2 ? num_1 > num_3 ? num_1: num_3 : num_2 > num_3 ? num_2 : num_3;
            //int lowestValue = num_1 < num_2 ? num_1 < num_3 ? num_1 : num_3 : num_2 < num_3 ? num_2 : num_3;

            //Console.WriteLine("Largest int: " + largestValue);
            //Console.WriteLine("Lowest int:  " + lowestValue);


            Console.ReadKey();
        }
    }
}
