using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Library_Of_Babel
{
    internal class Book
    {
		private string title;
		private string genre;
		private List<Author> authors;
		private string publisher;
		private int yearOfPublishing;
        private bool isTaken;

        
        public string Title
		{
			get { return title; }
			set { title = value; }
		}

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public List<Author> Authors
        {
            get { return authors; }
            set { authors = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int YearOfPublishing
        {
            get { return yearOfPublishing; }
            set { yearOfPublishing = value; }
        }

        public bool IsTaken
        {
            get { return isTaken; }
            set { isTaken = value; }
        }

        public Book(string title, string genre, List<Author> authors, string publisher, int yearOfPublishing, bool isTaken)
        {
            Title = title;
            Genre = genre;
            Authors = authors;
            Publisher = publisher;
            YearOfPublishing = yearOfPublishing;
            IsTaken = isTaken;
        }

        public override string ToString()
        {
            string output = $"{Title} {Genre}";
            foreach (Author author in Authors) 
            {
                output = string.Concat(output, $"{author.FirstName} {author.LastName}");
            }
            output = string.Concat(output, publisher, yearOfPublishing);
            return output;
        }
    }
}
