using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day24
{
    internal class Program
    {
        // private string user; //field
        //private int userAge; //field

        //        public string User { get { return user;  } set {  user = value; } } //property
        //      public int UserAge { get { return userAge; } set { userAge = value; } } //property
        //    public void userDetails() { // method / function
        //      Console.WriteLine($"User Name: {User} - | User Age: {UserAge}"); 
        // }



        public static int n = 50;

        delegate void MyDelegate(string msg);
        delegate int Calculate(int num);

        public static int Sub(int num)
        {
            n = num - n;
            return n;
        }
        public static int Mul(int num)
        {
            n = num * n;
            return n;
        }
        public static int getNum()
        {
            return n;
        }

        static void Main(string[] args) //main method/function
        {
            //day 24th.

            MyDelegate del = Console.WriteLine;
            del("sss");

            Console.WriteLine(Sub(10)); // 10 - 50 => -40
            Calculate a = new Calculate(Mul);
            a(10);
            Console.WriteLine(""+getNum()); // 10 * 50 => 500





















            //   Program p = new Program{ User = "Abdul", UserAge = 21 }; //class instance , object initializing
            // p.userDetails(); //using class method

            Console.ReadKey();
        }
    }
}
