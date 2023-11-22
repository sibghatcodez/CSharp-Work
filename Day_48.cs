using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C__Day48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 48
            //Sets
                List<string> ListOfVegetables = new List<string>() { "Spinach", "Broccoli", "Ladyfinger", "Broccoli" };
                //I added Broccolli twice. idk if i spell that right.. xD
                var aSet = new HashSet<string>(ListOfVegetables);
                //foreach(var item in aSet) { Console.Write(item+" "); } // It shud show Broccoli once.

            //Queue and Stack
            //A queue is FIFO i guess (firstInFirstOut)
            //A stack is LIFO i guess (lastInFirstOut)

                //Queue
                Queue<string> Queue = new Queue<string>();
                Queue.Enqueue("Potato"); //Should be removed first.
                Queue.Enqueue("Tomato"); //Should be removed second
                Queue.Enqueue("Onion");
                //If we use Dequeue, the first obj in list will be removed.
                Queue.Dequeue();
                Queue.Dequeue();
                //foreach (var item in Queue) { Console.Write(item + " "); } 

            //Stack
                Stack<string> Stack = new Stack<string>();
                Stack.Push("Potato");
                Stack.Push("Tomato"); //Should be removed second.
                Stack.Push("Onion"); //Should be removed first.
                Stack.Pop();
                Stack.Pop();
                //foreach (var item in Stack) { Console.Write(item + " "); }

            //Dictionary
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(1, "Potato"); //1 is key, 2nd is value.
                dict.Add(2, "Tomato");
                dict.Add(3, "Onion");
            // to print Potato we will have to put the key of it.
            //Console.WriteLine(dict.ElementAt(0)); //1 is index not key....

            //I was streaming, and it got cut off meanwhile i wrote all the code.
            //continuting again for the 2nd time..


            //File I/O
            string path = "file.txt";
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(file);
            StreamReader streamReader = new StreamReader(file);
            string text = "hello world. its me! your own sibghat.";
            streamWriter.Write(path, text);
            var whatDidYouRead = streamReader.ReadToEnd();
            Console.WriteLine(whatDidYouRead);


            Console.ReadKey();
        }
    }
}
