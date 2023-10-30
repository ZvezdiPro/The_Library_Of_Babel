using System;
using System.Collections.Generic;

namespace The_Library_Of_Babel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            List<Reader> readers = new List<Reader>();
            List<Author> authors = new List<Author>();

            books.Add(new Book("Alice in the wonderland", "fantasy", new List<Author>(), "Macmillan", 2015, false));
            books.Add(new Book("Alice Through the Looking-Glass", "fantasy", new List<Author>(), "Macmillan", 2016, false));
            books.Add(new Book("Harry Potter and the Philosopher's Stone", "fantasy", new List<Author>(), "Bloomsbury", 1997, false));
            books.Add(new Book("Harry Potter and the Chamber of Secrets", "fantasy", new List<Author>(), "Bloomsbury", 1998, false));
            books.Add(new Book("Harry Potter and the Prisoner of Azkaban", "fantasy", new List<Author>(), "Bloomsbury", 1999, false));
            books.Add(new Book("Harry Potter and the Goblet of Fire", "fantasy", new List<Author>(), "Bloomsbury", 2000, false));
            books.Add(new Book("Harry Potter and the Order of the Phoenix", "fantasy", new List<Author>(), "Bloomsbury", 2003, false));
            books.Add(new Book("Harry Potter and the Half-Blood Prince", "fantasy", new List<Author>(), "Bloomsbury", 2005, false));
            books.Add(new Book("Harry Potter and the Deathly Hallows", "fantasy", new List<Author>(), "Bloomsbury", 2007, false));
            books.Add(new Book("The Art of War", "strategy", new List<Author>(), "Arcturus Publishing", 2014, false));

            Console.WriteLine("WELCOME TO THE LIBRARY OF BABEL\n");
            Console.WriteLine("List of commands:");

            Console.WriteLine("[1] Add a book");
            Console.WriteLine("[2] Add a reader");
            Console.WriteLine("[3] Take a book");
            Console.WriteLine("[4] Display a book's archive");
            Console.WriteLine("[5] Display a reader's archive\n");

            Console.Write("Enter the code of your command: ");

            int n = int.Parse(Console.ReadLine());

            switch(n) 
            { 
                case 1:
                    Book newBook = AddBook();
                    books.Add(newBook);
                    break;
                case 2: 
                    
                    break;
                case 3:
                    Console.WriteLine("Command syntax: [Reader] takes [Book]");
                    string[] command = Console.ReadLine().Split(' ');
                    break;
                case 4:
                    Console.WriteLine("Enter the name of the book: ");
                    string book = Console.ReadLine();

                    break;
                default:
                    Console.WriteLine("Please enter a valid command number");
                    break;
            }
        }

        public static Book AddBook()
        {
            Console.WriteLine("Adding a new book:");
            Console.Write("  Name of the book: ");
            string name = Console.ReadLine();
            Console.Write("  Genre of the book: ");
            string genre = Console.ReadLine();
            Console.Write("  Author(s) of the book (At least two names): ");
            string[] authorsNames = Console.ReadLine().Split(", ");
            Console.Write("  Publisher of the book: ");
            string publisher = Console.ReadLine();
            Console.Write("  Year of publishing of the book: ");
            int publishingYear = int.Parse(Console.ReadLine());

            List<Author> authorList = new List<Author>();

            foreach (string authorsName in authorsNames)
            {
                string[] names = authorsName.Split(' ');
                Author bookAuthor = null;
                if (names.Length == 2)
                { bookAuthor = new Author(names[0], names[1]); }
                else if (names.Length == 3)
                { bookAuthor = new Author(names[0], names[1], names[2]); }
                authorList.Add(bookAuthor);
            }

            Book book = new Book(name, genre, authorList, publisher, publishingYear, false);
            return book;
        }
    }
}
