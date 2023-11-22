using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Day 49
            //File I/O

            string path = "E:notebook.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fs);
            using (StreamWriter streamWriter = new StreamWriter(fs)) {
            streamWriter.WriteLine("Hi. it's Sibghat.");
            var notebook = streamReader.ReadLine();
           // Console.WriteLine(notebook);
            };


            // Serialization and Deserialization
            //i think its a advanced topic i dont think i can learn it so easily..
            Console.ReadKey();
        }
    }
}
