using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day31
{
    public class Employee
    {
        List<Employee> employees;
        public Employee()
        {
            employees.Add({ "Dept": "A" })
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Day 31.
            //Generics

            Generizz<int> obj = new Generizz<int>();
            obj.SwapMethod(10, 50);

            MainMethod();
            
            Console.ReadKey();
        }
        static void MainMethod()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = list.FindAll(x => x % 2 == 0);

            foreach (int number in evenNumbers)
            {
                Console.Write(number + " ");
            }
        }

    }


    public class Generizz<T>
    {

        public void SwapMethod(T x, T y)
        {
            T z = x;
            x = y;
            y = z;
            Console.WriteLine($"{x} {y}");
        }
    }
}
