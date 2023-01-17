using System;//Default APIs
using Entities;//For the Entity class
using Repository;//Repo class
using SampleConApp; //Utilities

namespace Entities
{
    class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public int BookStock { get; set; } = 10;

        public void ShallowCopy(Book copy)
        {
            this.BookId = copy.BookId;
            this.BookStock = copy.BookStock;
            this.BookTitle = copy.BookTitle;
            this.Price = copy.Price;
            this.Publisher = copy.Publisher;
            this.Author = copy.Author;
        }

        public Book DeepCopy(Book copy)
        {
            Book book = new Book();
            book.ShallowCopy(copy);
            return book;
        }
    }
}
//datatype [] identifier = new datatype[size]
namespace Repository
{
    class BookRepository
    {
        private Book[] _books = null;
        private readonly int _size = 0;
        public BookRepository(int size)
        {
            _size = size;
            _books = new Book[_size];
        }

        public Book AddNewBook(Book book)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] == null)
                {
                    _books[i] = book.DeepCopy(book);
                    return book;//To exit
                }
            }
            return null;
        }

        public Book UpdateBook(Book book)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] != null && _books[i].BookId == book.BookId)
                {
                    _books[i].ShallowCopy(book);
                    return book;//To exit
                }
            }
            throw new Exception("No book found to update");
        }

        public void RemoveBook(int id)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] != null && _books[i].BookId == id)
                {
                    _books[i] = null;
                    return;//To exit
                }
            }
            throw new Exception("No book found to remove");
        }

        public Book[] FindByAuthor(string author)
        {
            int count = 0;
            foreach (Book book in _books)
            {
                if (book != null && book.Author.Contains(author))
                {
                    count += 1;
                }
            }
            Book[] books = new Book[count];
            count = 0;
            foreach (Book book in _books)
            {
                if (book != null && book.Author.Contains(author))
                {
                    books[count] = book.DeepCopy(book);
                    count += 1;
                }
            }
            return books;
        }

        public Book[] FindByTitle(string title)
        {
            int count = 0;
            foreach (Book book in _books)
            {
                if (book != null && book.BookTitle.Contains(title))
                {
                    count += 1;
                }
            }
            Book[] books = new Book[count];
            count = 0;
            foreach (Book book in _books)
            {
                if (book != null && book.BookTitle.Contains(title))
                {
                    books[count] = book.DeepCopy(book);
                    count += 1;
                }
            }
            return books;
        }
    }
}

namespace UILayer
{
    class UIComponent
    {
        public const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~BOOK STORE MANAGER SOFTWARE~~~~~~~~~~~~~~~~~~~\nTO ADD NEW BOOK------------------------>PRESS 1\nTO UPDATE EXISTING BOOK---------------->PRESS 2\nTO FIND BOOK BY AUTHOR----------------->PRESS 3\nTO FIND BOOK BY TITLE------------------>PRESS 4\nTO DELETE BOOK------------------------->PRESS 5\nPS: ANY OTHER KEY IS CONSIDERED AS EXIT.....................................";

        private static BookRepository repo;

        private static void displayBook(Book bk)
        {
            Console.WriteLine($" Book Title: {bk.BookTitle} \nBook Price: {bk.Price} \nBook Author {bk.Author}\nStock: {bk.BookStock}");
            Console.WriteLine("--------------------------------------------");
        }
        public static void Run()
        {
            int size = Utilites.GetNumber("Enter the no of Books U need for the Store");
            repo = new BookRepository(size);
            bool processing = true;
            do
            {
                string choice = Utilites.Prompt(menu);
                processing = processMenu(choice);
            } while (processing);
            Console.WriteLine("Thanks for Using our Application!!!");
        }

        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    AddNewBookHelper();
                    break;
                case "2":
                    UpdateBookHeler();
                    break;
                case "3":
                    FindByAuthorHelper();
                    break;
                case "4":
                case "5":
                    RemoveBookHelper();
                    break;
                default:
                    return false;
            }
            return true;
        }

        private static void RemoveBookHelper()
        {
            try
            {
                int id = Utilites.GetNumber("Enter The ID of Book to deleted");
                repo.RemoveBook(id);
                Console.WriteLine("The Book Is Deleted SucessFully");
            }
            catch (Exception ex)
            {

                Console.WriteLine(  ex.Message);
            }
        }

        private static void FindByAuthorHelper()
        {
            try
            {
                string author = Utilites.Prompt("Enter The Author Name To Find The Book");
               Book[] bk= repo.FindByAuthor(author);
                if (bk.Length == 0)
                {
                    Console.WriteLine("No Book fund");
                }
                foreach (Book item in bk)
                {
                    displayBook(item);
                }
              
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void UpdateBookHeler()
        {
            int id = Utilites.GetNumber("Enter The Id of the Book To Be Update");
            string name = Utilites.Prompt("Enter the New Title Of the Book");
            int price = Utilites.GetNumber("Enter  the New price Of the Book");
            string publisher = Utilites.Prompt("Enter the  New Name of the Publisher");
            string author = Utilites.Prompt("Enter the  New Name of the author");
            Book book = new Book { BookId = id,  BookTitle = name, Price = price, Publisher = publisher, Author = author };
            displayBook(    repo.UpdateBook(book));
            Console.WriteLine("The Book is Update Sucessfully");
            Utilites.Prompt("Press Enter to clear the Screen");
            Console.Clear();
           
        }

        private static void AddNewBookHelper()
        {
            int id = Utilites.GetNumber("Enter the ID of the Account");
            
            string name = Utilites.Prompt("Enter the Name of the Book");
            int price = Utilites.GetNumber("Enter the price");
            string publisher = Utilites.Prompt("Enter the Name of the Publisher");
            string author = Utilites.Prompt("Enter the Name of the author");
            Book book = new Book { BookId = id, BookTitle = name, Price = price, Publisher = publisher, Author = author };
            displayBook( repo.AddNewBook(book));
           
            Console.WriteLine("The Book Is Added Suucessfuuly");
            Utilites.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }
    }
}

namespace TestingApp
{
    using Repository;
    using SampleConApp;
    using System;


    class App
    {
        static void Main(string[] args)
        {
            UILayer.UIComponent.Run();
        }
    }
}
