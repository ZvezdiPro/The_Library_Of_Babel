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
    }
}
