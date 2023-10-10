using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace C__Day22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 22
            //-> -> Abstraction
            //-> -> Encapsulation
            //  BankAccount acc = new BankAccount(1, "Haji Aman", 10000);
            // acc.Withdraw(9000);
            //acc.Deposit(69);
            //acc.accDetails();


            Product p = new Product(100, "Juicer Machine", 6912);
            p.ProductDetails();
            Console.ReadKey();
        }
    }

    public class Product
    {
        private int productID;
        private string productName;
        private int productPrice;
        public Product(int pID, string pName, int pPrice)
        {
            ProductID = pID;
            ProductName = pName;
            ProductPrice = pPrice;
        }
        public int ProductID
        {
            get { return productID; }
            set { productID = value;  }
        }
        public string ProductName
        {
            get { return productName;  }
            set { productName = value; }
        }
        public int ProductPrice
        {
            get { return productPrice;  }
            set { productPrice = value; }
        }

        public void ProductDetails()
        {
            Console.WriteLine($"Product ID: {productID} | Product Name: {productName} - Product Cost: {productPrice}");
        }
    }










    public class BankAccount
    {
        private int accNumber;
        private string accHolder;
        private int accBalance;

        public BankAccount(int num, string name, int bal)
        {
            AccNum = num;
            AccHolder = name;
            AccBalance = bal;
        }
        public void accDetails()
        {
            Console.WriteLine($"Acc ID: {AccNum} - Acc Holder: {AccHolder} | Acc Balance: {AccBalance}");
        }

        public int AccNum { 
        get { return accNumber; }
        set { accNumber = value; }
        }
        public string AccHolder
        {
            get { return accHolder; }
            set { accHolder = value; }
        }
        public int AccBalance
        {
            get { return accBalance; }
            set { accBalance = value; }
        }
        public void Withdraw(int amount)
        {
            AccBalance -= amount;
        }
        public void Deposit(int amount)
        {
            AccBalance += amount;
        }
    }
}
