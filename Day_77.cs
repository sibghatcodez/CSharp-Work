using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Day71
{

    public class Program
    {
        //public List<string> books = new List<string>();

        static void Main(string[] args) // <- Thread
        {
            //Day 77th
            Countries countries = new Countries("Pakistan");
            countries.AddCountry("Kenya");
            countries.AddCountry("Norway");
            countries.AddCountry("Jamaica");
            countries.AddCountry("Azerbaijan");

            foreach(var country in countries)
            {
                Console.WriteLine(country);
            }










            //Book<object> book_1 = new Book<object>(1, "The Railwaymen", "Michael Jordan");

            //foreach (var item in book_1) { }

            Console.ReadKey();
        }
    }


    public class Countries : IEnumerable, IDisposable
    {
        List<string> countries = new List<string>();

        public Countries(string country) {
            AddCountry(country);
        }
        public void AddCountry(string country) {
            countries.Add(country);
        }
        public void RemoveCountry(string country)
        {
            countries.Remove(country);
        }
        public IEnumerator GetEnumerator()
        {
            return new CountryEnumerator(ref countries);
            //return countries.GetEnumerator();
        }
        void IDisposable.Dispose() {
            countries.Clear();
        }
    }
    public class CountryEnumerator : IEnumerator
    {
        int _index = 0;
        List<string> countryList;

        public CountryEnumerator(ref List<string> country_List)
        {
            countryList = country_List;
        }
        public bool MoveNext()
        {
            _index++;
            return _index < countryList.Count;
        }

        public void Reset()
        {
            _index = 0;
        }

        object IEnumerator.Current => $"Country {_index} - {countryList[_index]}";
    }











    /*public class Book<T> : IEnumerable<T>
    {
        Program prog = new Program();

        private int bookNo { get; set; }
        private string bookName { get; set; }
        private string bookAuthor { get; set; }

        public Book(int bNo, string bName, string bAuthor)
        {
            bookNo = bNo;
            bookName = bookName;
            bookAuthor = bAuthor;
        }

        public IEnumerable<string> GetBookCollection() { 
            return prog.books.AsEnumerable();
        }
        public IEnumerator<string> GetEnumerator()
        {
            return prog.books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }*/
}

