using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Day45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 45
            //Queues and Stacks

            //Stack ->
            Stack st = new Stack();
            st.Push("Protein");
            st.Push("Carbs");
            foreach(var items in st)
            {
            //    Console.Write(items + " ");
            }
            st.Pop(); //should remove "Carbs"
            Console.WriteLine(" ");
            foreach (var items in st)
            {
               // Console.Write(items + " ");
            }


            Queue que = new Queue();
            que.Enqueue("Chai");
            que.Enqueue("Paratha");
            que.Enqueue("Anda");
            var queCount = que.Count;
            // while(que.Count > 0) { Console.WriteLine(que.Dequeue()); }



            //REPEAT ->
            //// ----------------------------------------- \\\\

            //Error Handling
            Console.WriteLine("Enter a number");
            int x;
            try
            {
                //x = int.Parse(Console.ReadLine());
               // Console.WriteLine(x);
            }
            catch (FormatException fe)
            {
               // Console.WriteLine(fe.Message);
            } finally
            {
                //Console.WriteLine("meow");
            }

            //Classes and Objects
            //Inheritance 
            //Polymorphism
            //Meow_2 meow = new Meow_2("WWWOEM");
            //Meow meo = new Meow("AA");

            Corolla car1 = new Corolla("Corolla");
            //car1.CarName();



            BODMAS bodmas = new BODMAS();
            //bodmas.BODMAS_Main();

            Process process = new Process();
            process.StartProcess();
            EventHandle eHandle = new EventHandle();


            Console.ReadKey();
        }
    }
    //EVENTS WITH DELEGATES
    public delegate void Notify();

    public class Process
    {
        public event Notify ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("Process Started");
            onProcessCompleted();
        }
        public void onProcessCompleted()
        {
            ProcessCompleted?.Invoke(); //invokes the event handler.
        }
    }
    public class EventHandle
    {
        public EventHandle()
        {
            EventStuff();
        }
        public void EventStuff()
        {
            Process aprocess = new Process();
            aprocess.ProcessCompleted += Eventhandler;
        }

        public static void Eventhandler()
        {
            Console.WriteLine("Process has been finished / completed! ");
        }
    }


        //DELEGATES
    public delegate int add(int a, int b);
    public class BODMAS
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        
        public void BODMAS_Main()
        {
            add addition = new add(BODMAS.Addition);
            Console.WriteLine(addition(10,220));

            //SYNTAX: <delegateName> <anyName> = new <delegName>(static method w same signature)
            //anyName(parameters)
        }
    }

    public abstract class Car
    {
        public abstract void CarName();
    }
    public class Corolla : Car
    {
        private string carName; // field
        public string car_Name //property
        {
            get
            {
                return carName;
            } set
            {
                carName = value;
            }
        }

        public Corolla(string carNamee)
        {
            carName = carNamee;
        }
        public override void CarName()
        {
            Console.WriteLine(carName);
        }
    }

    class Meow
    {
        public Meow(string meow)
        {
            Console.WriteLine("Meow Class: " + meow);
        }
    }
    class Meow_2 : Meow
    {
        public Meow_2(string meow) : base(meow)
        {
            Console.WriteLine("Meow_2 Class: " + meow);
        }
    }
}
