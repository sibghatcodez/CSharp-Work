using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day_35.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 35th
            List<Sale_1> list_A = new List<Sale_1> { };
            list_A.Add(new Sale_1(1, "Apple", 25000));
            list_A.Add(new Sale_1(2, "banana", 75000));
            list_A.Add(new Sale_1(3, "Kela", 65000));
            list_A.Add(new Sale_1(4, "narangi", 55000));
            list_A.Add(new Sale_1(5, "Soof", 15000));
            List<Sale_2> list_B = new List<Sale_2> { };
            list_B.Add(new Sale_2(1, "banana", 5000));
            list_B.Add(new Sale_2(2, "Kela", 7000));
            list_B.Add(new Sale_2(3, "narangi", 6000));
            list_B.Add(new Sale_2(4, "Soof", 5500));
            list_B.Add(new Sale_2(5, "Apple", 1500));

            //var result = from a in list_A join b in list_B on a.productName equals b.productName select new {productSale = a.productSale + b.productSale, };
            //foreach (var item in result) { Console.WriteLine(item.productSale+"\n"); }

            var val = list_A.Join(list_B,
                a => a.productID,
                b => b.productID,
                (a,b) => new {productSale = a.productSale + b.productSale, productName = a.productName, productID = b.productID});
            foreach(var item in val) { Console.WriteLine("ID: " + item.productID + " SALE: " +item.productSale ); Console.WriteLine(); }

            Console.ReadKey();
        }
        public class Sale_1
        {
            public int productID;
            public string productName;
            public int productSale;
            public Sale_1(int id, string name, int sale)
            {
                productID = id;
                productName = name;
                productSale = sale;
            }
        }
        public class Sale_2
        {
            public int productID;
            public string productName;
            public int productSale;
            public Sale_2(int id, string name, int sale)
            {
                productID = id;
                productName = name;
                productSale = sale;
            }
        }
    }
}
