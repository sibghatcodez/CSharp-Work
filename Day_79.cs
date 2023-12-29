using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace C__Day79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 79th

            //connection info..
            string cs = "server=localhost;user=root;database=sakila;port=3306;password=sibghat";
            var con = new MySqlConnection(cs);
                con.Open();
                var cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DROP TABLE IF EXISTS cars";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS cars(id INTEGER PRIMARY KEY AUTO_INCREMENT,\r\n name TEXT, price INT)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',10000)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO cars(name, price) VALUES('BMW',20000)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Corolla',100)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Deluxo',15435435)";

                string sqlCmd = "SELECT * FROM cars";
                cmd.CommandText = sqlCmd;
                MySqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Console.WriteLine($"ID={0} | Name={1} | Price={2}",dr.GetInt32(0),dr.GetString(1), dr.GetInt32(2));
            }


            Console.WriteLine("Table cars is created!!");













            /* MySqlConnection conn = new MySqlConnection(connStr); //connection class ig
             try
             {
                 Console.WriteLine("Connecting to MySQL...");
                 conn.Open();

                 //SQL Query to execute
                 //selecting only first 10 rows for demo
                 //string sql = "select * from sakila.actor limit 0,10;";
                 var sql = "SELECT VERSION()";
                 MySqlCommand cmd = new MySqlCommand(sql, conn);
                 MySqlDataReader rdr = cmd.ExecuteReader();
                 //read the data
                 while (rdr.Read())
                 {
                     //  Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2]);
                     Console.WriteLine(rdr);
                 }
                 rdr.Close();
             }
             catch (Exception err)
             {
                 Console.WriteLine(err.Message.ToString());
             }

             conn.Close();
             Console.WriteLine("Connection Closed. Press any key to exit...");*/




            Console.Read();
        }
    }
}
