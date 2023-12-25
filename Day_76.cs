using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
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
            //Day 76th
            Fruits fruits = new Fruits();
            foreach(string item in fruits)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }

        public class Fruits : IEnumerable
        {
            public List<string> fruits = new List<string>()
            {
                "Apple", "Banana", "Cherry", "Dragonfruit"
            };

            IEnumerator<string> GetEnumerator()
            {
                return new FruitsEnumenator(fruits);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
        public class FruitsEnumenator : IEnumerator<string>
        {
            public List<string> _fruits = new List<string>();
            private int currentIndex = -1;


            public FruitsEnumenator(List<string> fruitsArray)
            {
                _fruits = fruitsArray;
            }


            public string Current => _fruits[currentIndex];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                currentIndex += 1;
                return currentIndex < _fruits.Count;
            }
            public void Reset()
            {
                currentIndex = -1;
            }
            public void Dispose()
            {
                // Dispose resources if needed
            }
        }

    }
}

