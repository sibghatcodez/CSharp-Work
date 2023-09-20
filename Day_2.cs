using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day2 - C# - ToDo List.

           // List<string> todoList = new List<string>();

            //Console.Write("Add a task to do: ");
            //string userList = Console.ReadLine();

            //todoList.Add(userList);

           // getTasks(todoList);



            // Task - 2:



            List<int> Contacts = new List<int>();

            Console.Write("Add a contact no: ");
            int contactNo = int.Parse(Console.ReadLine()); //variable nmames should be easy to understand.... :v
            Contacts.Add(contactNo);

            Console.WriteLine("\n\n\nViewing total contacts!");
            foreach(int cont in Contacts)
            {
                Console.WriteLine(cont);
            }


            Console.Write("\n\nType contact to view: ");
            int viewCont = int.Parse(Console.ReadLine());

            Console.WriteLine(Contacts.Contains(viewCont) ? "Contact found!" : "Contact not found :/");

            Console.Write("\n\nType contact to delete: ");
            int delCont = int.Parse(Console.ReadLine());

            if(Contacts.Contains(delCont)) {
                Console.WriteLine("Contact deleted!");
            } else { Console.WriteLine("Contact not found :/ anyway ily."); }






            Console.ReadKey();
        }












        public static void getTasks(List<string> todoList)
        {
            Console.WriteLine("\n\n\nViewing total tasks: Tasks Count: " + todoList.Count); // \n means = one line gap or NEW LINE!
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine("Task - [" + i + "] -> " + todoList[i]);
            }
        }


        // This is it for this task
        //Because i haven't learnt Classes yet so....
        //i will do it any other day! INSHALLAH!

    }
}
