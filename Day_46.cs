using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C__Day46
{
    public delegate void Update();

    //Event class ->
    public class UpdateWindow
    {
        //Event
        public event Update UpdateWind;

        public void StartWindowUpdate()
        {
            Console.WriteLine("Windows Update has been started.");
            OnWindowsUpdate();
        }
        protected virtual void OnWindowsUpdate()
        {
            UpdateWind?.Invoke(); //Invoking the event handler.
        }
    }

    //Subscribers Class
    public class Subscriber
    {
        public Subscriber()
        {
            UpdateWindow update = new UpdateWindow();
            update.UpdateWind += OnWindowsUpdate_update;//Subscribing the event handler.
            update.StartWindowUpdate();
        }
        //Event Handler
        public static void OnWindowsUpdate_update()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Windows Update has been finished.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 46
            //Practicing the stuff that i have already learnt.


            //Events and Delegates.
            //UpdateWindow updateWindow = new UpdateWindow();
            //Subscriber sub = new Subscriber();

            // Generics
            Data<string> vegetables = new Data<string>();
            vegetables.AddData("Spinach");
            vegetables.AddData("Broccoli");
            vegetables.AddData("Ladyfinger");

            vegetables.RemoveData("Broccoli");


            //LINQ -> LANGUAGE INTEGRATED QUERY
            Dictionary<int, string> Person = new Dictionary<int, string>()
            {
                {21, "Anwar" }, //Number = age | String = name
                {35, "Asif" },
                {10, "Moosa" }
            };

            //where
                var adults = from person in Person where person.Key >= 18 select person.Value;
                //foreach(var grown in adults) { Console.WriteLine($"Person Name: {grown}"); }

            //OfType
                IList mix = new ArrayList() { };
                mix.Add("COFFEE");
                mix.Add(69);
                mix.Add("TEA");
                var stringStuff = mix.OfType<string>();
                //foreach(var stuff in stringStuff) { Console.WriteLine(stuff); }

            //OrderBy
                List<Profile> profile = new List<Profile>() {};
                profile.Add(new Profile("Sajjad",20,"Tamim")); //2
                profile.Add(new Profile("ASonu", 32, "Khalil")); //3
                profile.Add(new Profile("Fatima", 12, "Faizan")); //1
                profile.Add(new Profile("Haroon", 12, "Faizan")); //1

            var ageResult = from x in profile orderby x.age select x.name;
            //foreach(var item in ageResult) Console.WriteLine(item);

            //ThenBy

                var ageResult2 = profile.OrderBy(x => x.age).ThenBy(x => x.name);
                //foreach(var item in ageResult2) Console.WriteLine(item.name);

            //GroupBy
             var ageGroup = from x in profile group x by x.age;
                foreach (var item in ageGroup)
                {
                  //Console.WriteLine(item.Key);
                   foreach(Profile prof in item)
                    {
                        //.WriteLine(prof.name);
                 }
               }

            Console.ReadKey();
        }
    }
    public class Profile
    {
        public string name { get; set; }
        public int age { get; set; }
        public string fatherName { get; set; }

        public Profile(string n, int a, string f)
        {
            name = n;
            age = a;
            fatherName = f;
        }
    }
    public class Data<T>
    {
        private List<T> data = new List<T>();
        public void AddData(T dat)
        {
            data.Add(dat);
        }
        public void RemoveData(T dat)
        {
            data.Remove(dat);
        }
    }

}
 
