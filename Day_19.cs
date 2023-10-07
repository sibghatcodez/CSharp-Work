using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day 19th

            //Polymorphism
            Library lib = new Library();
            lib.BookName();

            Book book_1 = new Book("100 hands of Hamburger");
            book_1.BookName();

            Console.ReadKey();
        }
    }

    public class Library
    {
        public virtual void BookName()
        {
            Console.WriteLine("The book name is \"59 sons of henry\" ");
        }
    }
    public class Book : Library
    {
        public string bookName;
        public Book(string bookName)
        {
            this.bookName = bookName;
        }
        public override void BookName()
        {
            Console.WriteLine($"The book name is \"{bookName}\"");
        }
    }
}
