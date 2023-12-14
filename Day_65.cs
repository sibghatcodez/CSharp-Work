using System;
using System.Text.Json;
using System.IO;
using System.Security.Principal;
using System.Runtime.Remoting;
using System.Collections.Generic;

namespace C__Day65
{
    internal class Program
    {
        public static string userName;
        public static int userAge;
        public static string userProfession;
        public static string filePath = "E:accounts.json";
        public static List<Account> accounts = new List<Account>();

        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            userName = Console.ReadLine();

            Console.WriteLine("Profession: ");
            userProfession = Console.ReadLine();

            Console.WriteLine("Age: ");
            userAge = int.Parse(Console.ReadLine());

            Account acc = new Account(userName, userProfession, userAge);
            accounts.Add(acc);
            SaveAccount(accounts);



            Console.ReadKey();
        }


        public static void SaveAccount(List<Account> accountList)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };


            string jsonString = JsonSerializer.Serialize(accounts, options);
            Console.WriteLine(jsonString);
            File.WriteAllText(filePath,jsonString);
            Console.WriteLine("Account saved successfully.");
        }
    }

    public class Account
    {
        public string Name;
        public string Profession;
        public int Age;


        public Account(string name, string profession, int age)
        {
            Name = name;
            Profession = profession;
            Age = age;
        }
    }


}
