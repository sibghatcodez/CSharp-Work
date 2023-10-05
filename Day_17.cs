using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Day17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 17th;

            //Classes / Objects
            //Car corolla = new Car("Toyota Corolla", "Gray");
            //corolla.carName = "ToYoTa CoRoLLA";
            //corolla.getCarProperties();



            // -> Inheritance
            Pakistan pk = new Pakistan();
            Pakistan pk1 = new Pakistan();
            Pakistan pk2 = new Pakistan();
            Pakistan pk3 = new Pakistan();


            Console.ReadKey();
        }
    }


    public class Asia
    {
        public static int Countries = 0;
        public Asia() {
            Countries++;
        }
    }

    public class Pakistan : Asia
    {
        public Pakistan() : base()
        {
            Console.WriteLine(Asia.Countries);
        }
    }
//    public class Car
  //  {
    //    public string carName { get; set; }
      //  public string carCol { get; set; }
      //
        //public Car(string name, string col)
        //{
          // this.carName = name;
           // this.carCol = col;
        //}
        //public void getCarProperties()
        //{
         //   Console.WriteLine("Car model: [{0}] | Car color: [{1}]", carName, carCol);
       // }
    //}
}
