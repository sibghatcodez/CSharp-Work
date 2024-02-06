using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day_13
{
    internal class Program
    {
        enum Vars : int
        {
            a = 10,
            b = 20,
            c = 50
        }
        enum Col
        {
            RED = ConsoleColor.Red,
            GREEN = ConsoleColor.Green
        }

        public static void Main(string[] args)
        {
            //day 12th

            //int? a = 1;
            //Console.WriteLine($"-> {a??10}");
            //Console.WriteLine(((int) Vars.a + (int) Vars.b )/ 2);


            //Game - Guess The Number.
            Random rand = new Random();
            short numberToGuess = (short)rand.Next(1, 10);
            short tries = 3;

            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine(string.Format("\n\n\t\tWelcome {0}! You have to guess a number between 1-10", playerName));
            Console.WriteLine($"\t\tYou have {tries} tries to guess! \n \n \n");


            Console.WriteLine("\t\t\t\t\t>> Tell us your first guess!");
            Console.Write("\t\t\t\t\t>> Guess: ");
            int playerGuess = int.Parse(Console.ReadLine());
            if(IsGuessed(playerGuess, numberToGuess))
            {
                Console.ForegroundColor = (ConsoleColor)Col.GREEN;
                Console.WriteLine("\t\t\t\t !!! -> Congrats you guessed it right! <- !!!");
                Console.ResetColor();
            } else
            {
                tries--;
                CheckTries(tries, numberToGuess);
            }



            Console.ReadKey();
        }
        static void CheckTries(int tries, int numberToGuess)
        {
            if (tries > 0)
            {
                Console.ForegroundColor = (ConsoleColor)Col.RED;
                Console.WriteLine($"\t\t\tWrong Guess! You only have {tries} left");
                Console.ResetColor();
                Console.Write("\t\t\t\t\t>> Guess: ");
                int playerGuess = int.Parse(Console.ReadLine());
                if (IsGuessed(playerGuess, numberToGuess))
                {
                    Console.ForegroundColor = (ConsoleColor)Col.GREEN;
                    Console.WriteLine("\t\t\t\t !!! -> Congrats you guessed it right! <- !!!");
                    Console.ResetColor();
                }
                else
                {
                    tries--;
                    CheckTries(tries, numberToGuess);
                }
            }
            else
            {
                Console.ForegroundColor = (ConsoleColor)Col.RED;
                Console.WriteLine("\t\t\tTries limit exceeded! You lost....");
                Console.ResetColor();
            }
        }
        static bool IsGuessed(int playerGuess, int numberToGuess)
        {
            if (playerGuess != numberToGuess)
                return false;
            else return true;
        }
    }
}
