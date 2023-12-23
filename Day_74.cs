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
    public interface ILocationMsg
    {
        string LocMsg();
    }
    public struct Location : ILocationMsg
    {
        public string country { get; set; }
        public string city { get; set; }

        public Location(string ctr, string ct)
        {
            country = ctr;
            city = ct;
        }
        public string LocMsg()
        {
            //return country + ", " + city; //bad
            return $"{country}, {city}"; //good
        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Location location { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args) // <- Thread
        {
            //Day 74th


            /*Action<string, int> act = (name, age) => 
            {
                Console.WriteLine("Name: {0} | Age: {1}",name,age);
            };
            act("Renshaw", 15);*/

            int a = 100;
            addVal(ref a);
            Console.WriteLine(a);
            //Func<int, int> refKeyword = reference => reference + 1;
            //refKeyword(ref a);

            Person p1 = new Person()
            {
                name = "Anwar",
                age = 20,
                location = new Location("Pakistan", "Hyderabad")
            };

            Console.WriteLine("User Name: {0} | User Age: {1} | User Location: {2}", p1.name, p1.age, p1.location.LocMsg());


            Console.ReadKey();
        }
        static void addVal(ref int a)
        {
            a = 10;
        }

        /*static async void Announce()
        {
            await Task.Delay(5000);
            Console.WriteLine("hi");
        }*/


    }
}

