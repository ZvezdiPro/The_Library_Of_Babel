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
        private bool canTakeBooks;
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

        public bool CanTakeBooks
        {
            get { return canTakeBooks; }
            set { canTakeBooks = value; }
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
            CanTakeBooks = true;
            TakenBooks = takenb;
            TakenBooksArchive = takenbArch;
        }

        public void TakeBook(Book book)
        {
            takenBooks.Add(book);
            takenBooksArchive.Add(book);
            book.IsTaken = true;
        }

        public void Return(Book book)
        {
            if (takenBooks.Contains(book))
            {
                takenBooks.Remove(book);
                book.IsTaken = false;
            }
            else
            {
                Console.WriteLine("This book is not in the reader");
            }
        }
    }
}
