using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp2
{
    internal class Program
    {
        public static string textToWrite = "This keyboard sucks even tho it's expensive and shit.";
        public static string textWritten = null;
        public static long startTime;
        public static long endTime;
        public static int words;
        public static DateTime dt = DateTime.Now;
        public static int seconds;

        static void Main(string[] args)
        {
            Console.WriteLine($"You have to write the following text in minimum time.\n {textToWrite}");
            Console.WriteLine("PRESS ENTER WHEN YOU ARE READY!");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine("The game will start in: " + i);
                    Thread.Sleep(1000);
                }
                Console.Clear();
                StartCounting();
            }

            Console.ReadKey();
        }
        public static void StartCounting()
        {
            startTime = DateTime.Now.Second;

            Console.WriteLine(textToWrite, Console.ForegroundColor = ConsoleColor.White);
            try {
                textWritten = Console.ReadLine();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.WriteLine("Write again: ");
                textWritten = Console.ReadLine();
            }
            endTime = DateTime.Now.Second;
            ProduceResult();
        }
        public static void ProduceResult()
        {
            int seconds = (int) startTime > endTime ? (int)(startTime - endTime) : (int)(endTime - startTime);
            int words = WordsChecker();
            double wordsPerMinute = (double)words / seconds * 60;
            //print result.
            Console.WriteLine($"Words: {words} - Seconds: {seconds} - Words Per Minute: {Math.Ceiling(wordsPerMinute)}");
        }

        public static int WordsChecker()
        {
            int counter = 0;
            foreach(var x in textWritten.Split(' '))
                foreach (var y in textToWrite.Split(' '))
                    counter += x == y ? 1 : 0;
            return counter;
        }
    }
}
