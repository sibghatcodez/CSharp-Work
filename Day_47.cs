using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C__Day47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 47
            //Nullable Types.

            // int x = null; // WRONG

            //both right.
            int? x = null;
            Nullable<int> b = null;

            x = x ?? 10;//if x is null then assign x a value of 10 | "??" is nullCHECKING Operator?yes
            string a = null;
            if(x.HasValue)
            {
               // Console.WriteLine(x);
            } else Console.WriteLine("variable(x) is null");


            //Asynchronous Programming.
            Program obj = new Program();
            //obj.CountDown();
            //Console.WriteLine("Show before the countdown function ends.");
            //it doesnt. that is why we use async programming.
            //obj.CountDownAsync();
            //Console.WriteLine("Show before the countdown function ends.");
            //See? this is why it's(Async) imporant.

            //Interface
            Dog animal_1 = new Dog();
            Horse animal_2 = new Horse();
            //Console.WriteLine(animal_1.AnimalName());
            //Console.WriteLine(animal_2.AnimalName());


            //Arrays 
            string[] fruits = new string[] { "apple", "mango" };
            int[] numbers = new int[] { 100, 200, 300, 200 };

            //Sets
            var set = new HashSet<int>(numbers);
            //foreach (var e in set) { Console.WriteLine(e); } //shud show 200 once.


            //Lists
            List<string> veg = new List<string>() { "SPINACH", "LADYFINGER" };


            //Queues and Stacks
            //Stacks are last in lastOUT
            //Queues are first in firstOUT
            Queue<string> fruitNames = new Queue<string>();
            fruitNames.Enqueue("Apple"); //index=0
            fruitNames.Enqueue("Banana");//index=1
            fruitNames.Enqueue("Mango");//index=1
            fruitNames.Dequeue();
            foreach(var items in fruitNames)
            {
                Console.WriteLine(items); //apple first removed!??
            }
            //SEE YA TOMMORORW.
            Console.ReadKey();
        }
        interface Animal
        {
            // public int DogAge = 12; // i think we cant use fields?
            string AnimalName(); //just method body?
        }
        public class Dog : Animal
        {
            //So i think its just like abstract class.

            public string AnimalName() // but we dont use override unlike abstract class.
            {
                return "Benjamin Netanhayu";
            }
        }

        public class Horse : Animal
        {
            public string AnimalName() //So we can use public keyword here??? CONFUSING ASF
            {
                return "Imam ul Haq";
            }
        }
        public void CountDown()
        {
            Console.WriteLine(">>> 3 <<<");
            Thread.Sleep(1000);
            Console.WriteLine(">>> 2 <<<");
            Thread.Sleep(1000);
            Console.WriteLine(">>> 1 <<<");
            Thread.Sleep(1000);
            Console.WriteLine(">>> GOGOGO! <<<");
        }
        public async Task CountDownAsync()
        {
            Console.WriteLine(">>> 3 <<<");
            await Task.Delay(1000);
            //Thread.Sleep(1000);
            Console.WriteLine(">>> 2 <<<");
            //Thread.Sleep(1000);
            await Task.Delay(1000);
            Console.WriteLine(">>> 1 <<<");
            //Thread.Sleep(1000);
            await Task.Delay(1000);
            Console.WriteLine(">>> GOGOGO! <<<");
        }

    }
}
