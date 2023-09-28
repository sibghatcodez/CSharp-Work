using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day 10th!

            //Task: Write a C# Sharp program to remove all non-letter characters from a given string.
            //Status: failed

            //        string str = "Camero*on Gr=een^_^"; //OP SHUD BE -> Cameroon Green
            //          string chars = "( ) ` ~ ! @ # $ % ^ & * - + = | \\ { } [ ] : ; \" ' < > , . ? / _ .";
            //            string[] nonLetter = chars.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //for(int i = 0; i < str.Length; i++) { 
            //foreach(var item in nonLetter)
            //{
            //if(item == str[i].ToString())
            //{
            //      str = str.Replace(str[i], ' ');
            //    }
            //  }
            //}
            //str = str.Replace(" ", "");
            //Console.WriteLine(str);
            //for(int i = 0; i < str.Length; i++)
            //{
            //foreach(var character in nonLetter)
            //{
            //if (str[i].ToString() == character)
            //{
            //      str.Substring(i, str.Length-1 <= i+1 ? i+1 : 0);
            //    }
            //  }
            //}
            //Console.WriteLine(str);



            //Task: Write a C# Sharp program to get the index number of all lower case letters in a given string.
            //Status: passed

            //string str_2 = "Ertughrul Ghazi";
            //string lowerCaseIndex = "";


            //            for(int i = 0; i < str_2.Length; i++)
            //          {
            //            if (str_2[i] == 'a' || str_2[i] == 'b' || str_2[i] == 'c' || str_2[i] == 'd' || str_2[i] == 'e' || str_2[i] == 'f' || str_2[i] == 'g' || str_2[i] == 'h' || str_2[i] == 'i' || str_2[i] == 'j' || str_2[i] == 'k' || str_2[i] == 'l' || str_2[i] == 'm' || str_2[i] == 'n' || str_2[i] == 'o' || str_2[i] == 'p' || str_2[i] == 'q' || str_2[i] == 'r' || str_2[i] == 's' || str_2[i] == 't' || str_2[i] == 'u' || str_2[i] == 'v' || str_2[i] == 'w' || str_2[i] == 'x' || str_2[i] == 'y' || str_2[i] == 'z')
            //          {
            //            lowerCaseIndex += i;
            //      }
            // }
            // Console.WriteLine(lowerCaseIndex);
            //cleanest code  XDD





            //Task: Write a C# Sharp program to reverse a Boolean value
            //Status: 

            //bool trueOrFalse = false;
            //trueOrFalse = trueOrFalse ? false : true;
            //Console.WriteLine(trueOrFalse); // prints true!


            Console.ReadKey();
        }
    }
}
