using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Day71
{

    public class Program
    {
        static void Main(string[] args) // <- Thread
        {
            //Day 78th



            /*foreach(var item in fruits())
            {
                Console.WriteLine(item);
            }*/
            //Console.WriteLine(fruits());

            List<char> charItems = new List<char>()
            {
                'A', 'B', 'C', 'D'
            };
            int index = 0;
            if(CharMethod(ref charItems)) //0, 'A'=0 | BCD
            {
                index++;
                charItems.RemoveAt(index);

                CharMethod(ref charItems);
            }


            Console.ReadKey();
        }
        static bool CharMethod(ref List<char> charItems)
        {
            bool isItemFound = false;
            int temp_Index = 0;

            foreach (var item in GetChars(charItems[temp_Index])) // item1=a | item2=b|..cde
            {
                if (item.Equals(charItems[temp_Index]))
                {
                    isItemFound = true;
                    Console.WriteLine($"Item found! {item} ");
                    break;
                }
                else
                {
                    isItemFound = false;
                }
                temp_Index++;
            }
            return isItemFound;
        }


        static IEnumerable<char> GetChars(char val) //val = 'A'
        {
            List<char> chars = new List<char>()
            {
                'A', 'B', 'C', 'D', 'E'
            };

            char charVal = val;

            if (chars.Contains(charVal))
            {
                foreach (var c in chars)
                {
                    yield return c;
                }
            }
            else yield break;
        }






        static IEnumerable fruits()
        {
            IDictionary<int, string> fruit = new Dictionary<int, string>();
           /* List<int> frui = new List<int>();
            frui.Add(523325);
            frui.Add(523325);
            frui.Add(523325);*/

            fruit.Add(150, "Banana");
            fruit.Add(250, "Mango");
            fruit.Add(350, "Cherry");
            string val;
            if(fruit.TryGetValue(150, out val))
            {
                 yield return val;
            } else
            {
                yield break;
            }
        }
    }
}

