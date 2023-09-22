using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day 6th of learning c#

            //Task: 47. Write a C# program to compute the sum of all the elements of an array of integers.
            //Status: ezily passed

            //int[] ints = { 10, 20, 30, 40, 50 };
            //int sum  = 0;
            //foreach (var item in ints)
            //{
            //   sum += item;
            //}
            //Console.WriteLine(sum);


            //Task: Write a C# program that checks if the first element and the last element of an array of integers are equal. The array length is 1 or more
            //Status: passed

            //int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };

            //Console.WriteLine(array1[0] == array1[array1.Length-1]); // false
            //Console.WriteLine(array2[0] == array2[array2.Length-1]); // true

            //Task: 50. Write a C# program to rotate an array (length 3) of integers in the left direction.
            //Status: Passed

            //int[] array3 = { 1, 2, 3 } ;
            //int dash = array3[0];
            //array3[0] = array3[1];
            //array3[1] = array3[2];
            //array3[2] = dash;
            //foreach (var item in array3)
            // {
            //    Console.Write(item);
            // }


            //Task: Write a C# program to get the largest value between the first and last element of an array (length 3) of integers.
            //Status: failed


            //int[] array4 = { 1, 2, 3 };

            //for(int i = 0; i < array4.Length; i++)
            //{
            //}


            //Task: Write a C# program to check if an array contains an odd number.
            //Status: passed

            //int[] array5 = { 1, 2, 3, 4 };

            //foreach(var i in array5)
            //{
            //  if( i % 2 != 0)
            //{
            //  Console.WriteLine("true");
            //} else Console.WriteLine("false");
            //}

            //Task: Write a C# program to get the century of a year.
            //Status: Passed!
            //Console.WriteLine("Enter a year: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //string saal = year.ToString();

            //if(saal.Length > 2)
            //{
            //  Console.WriteLine($"Current century is: {saal[0]}{saal[1]}00");
            // }


            //Task: Write a C# program to check if a given string is a palindrome or not.
            //Status:  Passed!:)


            //Console.WriteLine("Enter a word you like:> ");
            //string word = Console.ReadLine();
            //int j = word.Length;
            //bool isWordPalindrome = false;

            //for (int i = 0; i < word.Length; i++)
            //{
                //j--;
                //if (word[i] == word[j])
                //{
                 //   isWordPalindrome = true;
                //} else
                //{
                  //  isWordPalindrome = false;
                //    break;
              //  }
            //}

            //Console.WriteLine(isWordPalindrome);
            Console.ReadKey(); //Important asf
        }
    }
}
