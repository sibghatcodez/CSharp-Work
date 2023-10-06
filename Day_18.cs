using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Day18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day 18th.


            //Inheritance
            //Car ford = new Car("ford");
            // Console.WriteLine(ford.getVehName());


            MyBankAcc bankAcc_1 = new MyBankAcc(1, "Sibghat", 6950);
            MyBankAcc bankAcc_2 = new MyBankAcc(2, "Anna", 0);
            Console.WriteLine(bankAcc_1.getBankInfo());
            Console.WriteLine(bankAcc_2.getBankInfo());
            Console.ReadKey();
        }
    }

    public class BankAccounts
    {
        public int AccID;
        public string AccOwner;
        public int AccBalance;

        public BankAccounts(int accID, string accOwner, int accBalance)
        {
            AccID = accID;
            AccOwner = accOwner;
            AccBalance = accBalance;
        }
        public string getBankInfo()
        {
            return $"Acc ID: {AccID} - Acc Owner: {AccOwner} | Acc Balance: {AccBalance}";
        }
    }
    public class MyBankAcc : BankAccounts
    {
        public MyBankAcc(int accID, string accOwner, int accBalance) : base(accID, accOwner, accBalance)
        {
        }
    }













    public class Vehicle
    {
        public string vehName;

        public Vehicle(string vName)
        {
            vehName = vName;
        }

        public string getVehName()
        {
            return vehName;
        }
    }

    public class Car : Vehicle
    {
        public string vehNamee;
        public Car(string vehNamee) : base(vehNamee)
        {
            this.vehNamee = vehNamee;
        }
    }
}
