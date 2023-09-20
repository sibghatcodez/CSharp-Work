using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBankAccount myBankAccount = new MyBankAccount();
            myBankAccount.AccountNumber = 1;
            myBankAccount.AccountBalance = 69000;
            myBankAccount.AccountHolderName = "Sanaullah";
            // myBankAccount.Deposit(1000);
            myBankAccount.Withdraw(6000);
            //  myBankAccount.ViewAccount(); // viewing the acc details :v
            //lets add more stuff




            Contacts contact_1 = new Contacts(911, "yahu");
            Contacts contact_2 = new Contacts(912, "yaha");
            Contacts contact_3 = new Contacts(913, "yahi");
            Contacts contact_4 = new Contacts(914, "yaho");
            Contacts.ViewContacts();

            Console.ReadKey();
        }
    }



    public class Contacts
    {
        public int number;
        public string name;
        public static string TotalContacts;
        public Contacts(int number, string name)
        {
            this.number = number;
            this.name = name;
            TotalContacts += name + " - " + number + "\n";
        }
        public static void ViewContacts()
        {
                Console.WriteLine("Viewing the list of contacts");
            foreach (var contact in TotalContacts)
            {
                Console.Write(contact);
            }
        }
    }













    public class MyBankAccount
    {
        public int AccountNumber;
        public string AccountHolderName;
        public int AccountBalance;

        public void MyAccountNumber(int num) {
            AccountNumber = num;
        }
        public void MyAccountNumber(string name)
        {
            AccountHolderName = name;
        }
        public void MyAccountBalance(int balance)
        {
            AccountBalance = balance;
        }
        public void Deposit(int value)
        {
            AccountBalance += value;
        }
        public void Withdraw(int value)
        {
            AccountBalance -= value;
        }

        public void ViewAccount()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Holder's Name: " + AccountHolderName);
            Console.WriteLine("Account's Balance: " + AccountBalance);
        }
    }
}
