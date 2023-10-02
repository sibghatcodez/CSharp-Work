using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Day_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 14th
            //Access Modifiers

            //string[] accessModifiers = new string[] { "public", "private", "protected", "internal" };
            //Console.WriteLine(string.Format("Any statement with {0} keyword can be called/used anywhere.\n Any statement with {1} keyword can be used only in the class its declared. \n Any statement with {2} keyword can only be used in the class where it(STATEMENT) is inherited from or declared in. \n Any statement with {3} keyword can only be used inside its namespace only.", accessModifiers[0], accessModifiers[1], accessModifiers[2], accessModifiers[3]));

            //Public - keyword
           // Console.WriteLine(Dog.dogName); // public
            //Console.WriteLine(Dog.dogName2); // error due to protection level 'private'
            //Console.WriteLine(Dog.dogName3); //error due to protection lvl 'protected'

            
            Console.ReadKey();
        }
    }


    //internal class Dog
    //{
    //    public static string dogName = "Abu Lulu";
  //      private static string dogName2 = "Tom";
//        protected static string dogName3 = "Ajeeb";

        //public static string GetDogName2()
        //{
         //   return dogName2;
       // }

      //  protected static string GetDogName3()
    //    {
  //          return dogName3;
//        }

        //void printin()
        //{
       //     Console.WriteLine(dogName);
     //   }
   // }
}
