using System;
using MySql.Data.MySqlClient;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Collections;
namespace C__Day80
{
    [Serializable]
    public class Accounts
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Accounts> accounts = new List<Accounts>();


            string connection = "datasource=localhost;port=3306;user=root;password=; database=accounts;";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();


            //creating the table
            string query = "CREATE TABLE IF NOT EXISTS Account(ID INT AUTO_INCREMENT, Name TEXT, Age INT, Department TEXT, PRIMARY KEY (ID))";
            MySqlCommand cmd = new MySqlCommand(query,conn);

            //Doing this to avoid duplicate data.
            cmd.CommandText = "TRUNCATE TABLE Account";
            cmd.ExecuteNonQuery();

           /* query = "INSERT INTO Account(Name,Age,Department) VALUES('Sibghat',21,'IT')";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery(); */


            /* query = "INSERT INTO Account(Name,Age,Department) VALUES('Urooj',131,'DOC')";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery(); */

            //reading file account.json and storing its text
            string fileTxt = File.ReadAllText("E:accounts.json");

            //options?
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };


            //deserializing the data from file 'accounts.json'
            var account = JsonSerializer.Deserialize<List<Accounts>>(fileTxt, options);

            //iterating over List: account
            foreach (Accounts item in account)
            {
                accounts.Add(item);
                string newQuery = $"INSERT INTO Account(Name,Age,Department) VALUES('{item.Name}','{item.Age}', '{item.Department}')";
                cmd.CommandText = newQuery;
                cmd.ExecuteNonQuery();
            }


            query = "SELECT * FROM Account";
            cmd.CommandText = query;
            MySqlDataReader mySqlData;
            mySqlData = cmd.ExecuteReader();
            while(mySqlData.Read())
            {
                //string info = $"Name: {mySqlData.GetString(1)} | Age: {mySqlData.GetInt64(2)} | Department: {mySqlData.GetString(3)}";
                string info = $"ID: {mySqlData[0]} | Name: {mySqlData[1]} | Age: {mySqlData[2]} | Department: {mySqlData[3]}";
                Console.WriteLine(info);
            }


            conn.Close();

            Console.ReadKey();
        }
    }
}
