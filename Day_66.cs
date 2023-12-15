using System;
using System.Text.Json;
using System.IO;
using System.Security.Principal;
using System.Runtime.Remoting;
using System.Collections.Generic;
using System.Linq;

namespace C__Day65
{
    internal class Program
    {
        public static string userName;
        public static int userAge;
        public static string userProfession;
        public static string filePath = "E:accounts.json";
        public static List<Account> accounts = new List<Account>();
        public static bool processCompleted = true;

        static void Main(string[] args)
        {
            LoadAccounts();


            do
            {
                Console.WriteLine("\n\t\t\tPress A to Add Account Or Press S to Search Account ");
                Console.WriteLine("\t\t\tPress D to Delete Account Or Press C to delete all accounts");

                var keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.A)
                {
                    accounts.Add(AskUser());
                    SaveAccount(accounts);
                }
                else if (keyPressed.Key == ConsoleKey.S)
                {
                    SearchAccount();
                } 
                else if (keyPressed.Key == ConsoleKey.D)
                {
                    DeleteAccount();
                } else if (keyPressed.Key == ConsoleKey.C)
                {
                   // accounts.Clear();
                    //Console.WriteLine("\n\t\t\t Account List has been cleared");
                    //File.WriteAllText(filePath, "");
                }
            } while (processCompleted);

            SaveAccount(accounts);



            Console.ReadKey();
        }

        public static void SearchAccount()
        {
            Console.Write("Enter account name you want to search: \t");
            string searchedAccount = Console.ReadLine();
            bool accountFound = false;
            int accountsWithSameName = 0;
            List<Account> ListOfAccounts = new List<Account>();


            foreach (Account account in accounts)
            {
                if (account.Name == searchedAccount) accountsWithSameName++;
            }

                foreach (Account account in  accounts)
            {
                if(accountsWithSameName == 0) {
                if (account.Name == searchedAccount)
                {
                    Console.WriteLine("\tAccount Found! Details ->");
                    var details = "\t\tName: " + account.Name + "| Profession: " + account.Profession + "| Age:" + account.Age;
                    Console.WriteLine(details);
                    processCompleted = true;
                    accountFound = true;
                    }
                } else if (accountsWithSameName > 0)
                {
                    if (account.Name == searchedAccount)
                    {
                        ListOfAccounts.Add(account);
                    }
                    var dataToShow = ListOfAccounts.OrderBy(user => user.Age);
                    foreach(var item in dataToShow)
                    {
                        Console.WriteLine("\tAccount Found! Details ->");
                        var details = "\t\tName: " + item.Name + "| Profession: " + item.Profession + "| Age:" + item.Age;
                        Console.WriteLine(details);
                        processCompleted = true;
                        accountFound = true;
                    }
                }
            }
            if (!accountFound)
            {
                Console.WriteLine("Error 404: Account not found.");
                processCompleted = true;
            }
        }
        public static void DeleteAccount()
        {
            Console.Write("Enter account name you want to delete: \t");
            string searchedAccount = Console.ReadLine();
            bool accountFound = false;

            foreach (Account account in accounts)
            {
                if (account.Name == searchedAccount)
                {
                    Console.WriteLine("\tAccount Deleted!");
                    accounts.Remove(account);
                    processCompleted = true;
                    accountFound = true;
                    break;
                }
            }
            if (!accountFound)
            {
                Console.WriteLine("Error 404: Account not found.");
                processCompleted = true;
            }
        }
        public static Account AskUser()
        {
            Console.Write("\tName: ");
            userName = Console.ReadLine();

            Console.Write("\tProfession: ");
            userProfession = Console.ReadLine();

            Console.Write("\tAge: ");
            userAge = int.Parse(Console.ReadLine());

            processCompleted = true;
            Console.WriteLine("Account saved successfully.");

            return new Account()
            {
                Name = userName,
                Profession = userProfession,
                Age = userAge,
            };
        }

        public static void SaveAccount(List<Account> accountList)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };


            string jsonString = JsonSerializer.Serialize(accounts, options);
            File.WriteAllText(filePath, jsonString);
        }


        public static void LoadAccounts()
        {
            if(File.Exists(filePath)) {
            var fileContent = File.ReadAllText(filePath);
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            List<Account> jsonData = JsonSerializer.Deserialize<List<Account>>(fileContent, options);
            foreach(var item in jsonData)
                {
                    accounts.Add(item);
                }
            }
        }
    }

    public class Account
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Age { get; set; }
    }


}
