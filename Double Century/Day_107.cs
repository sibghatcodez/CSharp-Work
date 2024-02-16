using System;

namespace nmspc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fibonacci(1);
        }

        public static int Fibonacci(int n)
        {
            if (n < 300)
            {
                Console.Write(n + " ");
                return Fibonacci(n + n);
            }
            else return 0;
        }
    }
}
