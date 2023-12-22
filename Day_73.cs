using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Day71
{
    internal class Program
    {
        static void Main(string[] args) // <- Thread
        {
            //Day 73nd = exercises.



            string filePath = "E:file.txt";
            string filePathNew = "E:newfile.txt";
            FileStream file = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream newFile = new FileStream(filePathNew, FileMode.OpenOrCreate, FileAccess.ReadWrite);


            /*
            //Q: 1 - SOLVED
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine("Line 1");
                sw.WriteLine("Line 2");
            }

            string fileRead = File.ReadAllText(filePath);
            Console.WriteLine(fileRead);

            */







            //Q: 2 -  solved.
            /*
            file.Close();
            File.AppendAllText(filePath, "appended text");
 */


            /*
            //Q: 3 - Solved
            file.CopyTo(newFile);
            newFile.Close();
            */




            //Q: 4 - SOLVED
            /*using(StreamReader sr = new StreamReader(file))
            {
                string fileReadTxt = sr.ReadLine();
                Console.WriteLine(fileReadTxt);

            }  
            /*

            //Q: 5 - SOLVED
            //numbers to print using recursion
            /*Console.Write("Enter total numbers to print: \t");
            int numToPrint = int.Parse(Console.ReadLine());
            printNum(1,numToPrint);*/



            Console.ReadKey();
        }

        /*static int printNum(int n, int cond)
        {
            if (n <= cond)
            {
                Console.WriteLine(n);
                return printNum(n + 1, cond);
            }
            else return 0;
        }
            */




    }
}

