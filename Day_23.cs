using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day 23rd
            Library library = new Library();

            // Create some books and patrons
            Book book1 = new Book { Title = "Book 1", Author = "Author 1", ISBN = 123456789, IsAvailable = true };
            Book book2 = new Book { Title = "Book 2", Author = "Author 2", ISBN = 987654321, IsAvailable = true };
            Book book3 = new Book { Title = "Book 2", Author = "Author 2", ISBN = 987654321, IsAvailable = true };

            Patron patron1 = new Patron { PatronName = "Patron 1", PatronID = 1001, BorrowedBooks = new List<string>() };

            // Add books and patrons to the library
            library.addBook(book1);
            library.addBook(book2);
            library.addPatron(patron1);

            LibraryTransaction transaction = new Concrete(library);

            transaction.PerformTransaction();

            Book bookToCheck = book3;
            transaction.CheckBook(bookToCheck);


            // -> Abstraction | Encapsulation
            Console.ReadKey();
        }
    }


    public class Book
    {
        private string title;
        private string author;
        private long isbn;
        private bool isAvailable;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public long ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }
    }

    public class Patron
    {
        private string patronName;
        private long patronID;
        private List<string> borrowedBooks;

        public string PatronName
        {
            get { return patronName; }
            set { patronName = value;  }
        }
        public long PatronID
        {
            get { return patronID; }
            set { patronID = value; }
        }
        public List<string> BorrowedBooks
        {
            get { return borrowedBooks; }
            set { borrowedBooks = value; }
        }
    }

    public class Library
    {
       private List<Book> books = new List<Book> { };
       private List<Patron> patrons = new List<Patron> { };

        public void addBook(Book bookName)
        {
            books.Add(bookName);
        }
        public void removeBook(Book bookName)
        {
            books.Remove(bookName);
        }
        public void addPatron(Patron patronName)
        {
            patrons.Add(patronName);
        }
        public void removePatron(Patron patronName)
        {
            patrons.Remove(patronName);
        }
        public bool IsBookAvailable(Book book)
        {
            return books.Contains(book);
        }
    }

    public abstract class LibraryTransaction
    {
        protected Library lib;
        public LibraryTransaction(Library lib)
        {
            this.lib = lib;
        }
        public abstract void PerformTransaction();
        public void CheckBook(Book bookName)
        {
            Console.WriteLine(lib.IsBookAvailable(bookName));
        }
    }
    public class Concrete : LibraryTransaction
    {
        public Concrete(Library lib) : base(lib)
        {
        }
        public override void PerformTransaction()
        {
            Console.WriteLine("performing a transaction.");
        }
    }
}
