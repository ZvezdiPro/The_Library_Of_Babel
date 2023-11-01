﻿using System;
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

            Random rng = new Random();
            
            readers.Add(new Reader("Pavel", "Lyubomudrov", "pavel.lyubomudrov@mudrost.now", new LibraryCard(rng.Next(1000000000, int.MaxValue), new DateTime(2023, 10, 1)), new List<Book>(), new List<Book>()));
            readers.Add(new Reader("Aneliya", "Ivanova", "aneliya.ivanova@mudrost.now", new LibraryCard(rng.Next(1000000000, int.MaxValue), new DateTime(2023, 6, 15)), new List<Book>(), new List<Book>()));
            readers.Add(new Reader("Olivia", "Williams", "olivia.williams@mudrost.now", new LibraryCard(rng.Next(1000000000, int.MaxValue), new DateTime(2023, 8, 12)), new List<Book>(), new List<Book>()));

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
                    Reader newReader = AddReader();
                    readers.Add(newReader);
                    break;
                case 3:
                    Console.WriteLine("Command syntax: [Reader], [Book]");
                    string[] command = Console.ReadLine().Split(' ');
                    foreach (Reader reader in readers)
                    {
                        if (reader.FirstName == command[0])
                        {
                            foreach (Book bookToTake in books)
                            {
                                if (bookToTake.Title == command[1])
                                {
                                    reader.TakeBook(bookToTake);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                case 4:
                    Console.Write("Enter the title of the book: ");
                    string bookTitle = Console.ReadLine();
                    foreach (Book book in books)
                    {
                        if (book.Title == bookTitle)
                        {
                            Console.WriteLine(book);
                            break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid command number");
                    break;
            }
        }

        public static Book AddBook()
        {
            Console.WriteLine("Adding a new book:");
            Console.Write("  Title of the book: ");
            string title = Console.ReadLine();
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

            Book book = new Book(title, genre, authorList, publisher, publishingYear, false);
            return book;
        }

        private static Reader AddReader()
        {
            Console.WriteLine("Adding a new reader:");
            Console.Write("  First name of the reader: ");
            string firstName = Console.ReadLine();
            Console.Write("  Last name of the reader: ");
            string lastName = Console.ReadLine();
            Console.Write("  Email of the reader: ");
            string email = Console.ReadLine();

            Random rng = new Random();
            Reader newReader = new Reader(firstName, lastName, email, new LibraryCard(rng.Next(1000000000, int.MaxValue), DateTime.Today), new List<Book>(), new List<Book>());
            return newReader;
        }
    }
}
