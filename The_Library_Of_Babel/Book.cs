﻿using System;
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
    }
}