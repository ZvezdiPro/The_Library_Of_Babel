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
            Console.WriteLine("[3] Take a book\n");

            Console.Write("Enter the code of your command: ");
            int n = int.Parse(Console.ReadLine());
        }
    }
}
