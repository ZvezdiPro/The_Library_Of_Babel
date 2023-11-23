using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Library_Of_Babel
{
    internal class Reader
    {
		private string firstName;
		private string lastName;
		private string phoneNumber;
		private string emailAddress;
        private LibraryCard libraryCard;
        private List<Book> takenBooks;
        private List<Book> takenBooksArchive;

        
        public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public LibraryCard LibraryCard
        {
            get { return libraryCard; }
            set { libraryCard = value; }
        }

        public List<Book> TakenBooks
        {
            get { return takenBooks; }
            set { takenBooks = value; }
        }

        public List<Book> TakenBooksArchive
        {
            get { return takenBooksArchive; }
            set { takenBooksArchive = value; }
        }


        public Reader(string firstName, string lastName, string emailAddress, LibraryCard lc, List<Book> takenb, List<Book> takenbArch) 
        { 
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            LibraryCard = lc;
            TakenBooks = takenb;
            TakenBooksArchive = takenbArch;
        }

        public void TakeBook(Book book)
        {
            if (takenBooks.Count < 3 && book.IsTaken == false && LibraryCard.ExpiryDate >= DateTime.Today)
            {
                takenBooks.Add(book);
                takenBooksArchive.Add(book);
                Console.WriteLine($"{firstName} {lastName} took {book.Title}!");
                book.IsTaken = true;
            }
            else if (takenBooks.Count < 3 && book.IsTaken == false && LibraryCard.ExpiryDate < DateTime.Today)
            {
                Console.WriteLine("The reader's library card is no longer valid!");
            }
            else if (takenBooks.Count < 3 && book.IsTaken == true && LibraryCard.ExpiryDate > DateTime.Today)
            {
                Console.WriteLine("The book has been taken by another reader!");
            }
            else if (takenBooks.Count >= 3 && book.IsTaken == false && LibraryCard.ExpiryDate > DateTime.Today)
            {
                Console.WriteLine("The reader cannot take any more books!");
            }
        }

        public void Return(Book book)
        {
            if (takenBooks.Contains(book))
            {
                takenBooks.Remove(book);
                Console.WriteLine($"{firstName} {lastName} returned {book.Title}!");
                book.IsTaken = false;
            }
            else
            {
                Console.WriteLine("This book is not in the reader!");
            }
        }

        public override string ToString()
        {
            string output = $"{firstName} {lastName}\nPhone number: {phoneNumber}\nE-mail address: {emailAddress}\n{string.Join("\n", takenBooksArchive.Select(book => book.Title))}\n";
            return output;
        }
    }
}
