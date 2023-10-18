using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Day29
{


    public class Product
    {
        public string Name { get; set; }
        public int StockLevel { get; set; }
    }
    public class StockManager
    {
        public delegate void StockLevelChangedDelegate(int stockLvl);
        public event StockLevelChangedDelegate StockLevelChanged;
        public event StockLevelChangedDelegate StockLevelNotChanged;
        public void Subscribe(StockSubscribe sub)
        {
            StockLevelChanged += sub.HandleStockLevelChange;
            StockLevelNotChanged += sub.HandleStockLevelNotChange;
        }
        public void UpdateStockLevel(int newStockLevel, int oldStockLevel)
        {
            if(newStockLevel != oldStockLevel)
                StockLevelChanged?.Invoke(newStockLevel);
            else
                StockLevelNotChanged?.Invoke(newStockLevel);
        }
    }
    public class StockSubscribe
    {
        public void HandleStockLevelChange(int newStockLevel)
        {
            Console.WriteLine("The stock has been updated!");
            Console.WriteLine($"Upated level: {newStockLevel}");
        }
        public void HandleStockLevelNotChange(int newStockLevel)
        {
            Console.WriteLine("The stock level is same! hence not updated.");
        }
    }
    internal class Program
    {
        public static int newStockLvl = 102;
        static void Main(string[] args)
        {
            //day 29th
            StockManager obj = new StockManager();
            StockSubscribe sub = new StockSubscribe();
            Product prod = new Product { Name = "Rizzler", StockLevel = 100 };
            obj.Subscribe(sub);
            obj.UpdateStockLevel(newStockLvl, prod.StockLevel);

            /*LoginSystem obj = new LoginSystem();
            UserSubscriber subClass = new UserSubscriber("Nawazuddin");
            obj.Subscribe(subClass);
            obj.SimulateLogin(subClass.userName);
            obj.SimulateLogout(subClass.userName);*/


            Console.ReadKey();
        }
    }



    /*public class LoginSystem
    {
        public delegate void UserActionDelegate(string msg);
        public event UserActionDelegate UserLoggedIn;
        public event UserActionDelegate UserLoggedOut;

        public void SimulateLogin(string user)
        {
            UserLoggedIn?.Invoke(user);
        }
        public void SimulateLogout(string user)
        {
            UserLoggedOut?.Invoke(user);
        }
        public void Subscribe(UserSubscriber sub)
        {
            UserLoggedIn += sub.HandleUserLogin;
            UserLoggedOut += sub.HandleUserLogout;
        }

    }
    public class UserSubscriber
    {
        public string userName;
        public UserSubscriber(string name)
        {
            userName = name;
        }
        public void HandleUserLogin(string msg)
        {
            Console.WriteLine(msg + " Logged in!");
        }
        public void HandleUserLogout(string msg)
        {
            Console.WriteLine(msg + " Logged out!");
        }
    }*/
}
