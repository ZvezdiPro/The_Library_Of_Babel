using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Library_Of_Babel
{
    internal class LibraryCard
    {
		private int number;
		private DateTime expiryDate;

		public int Number
		{
			get { return number; }
			set { number = value; }
		}

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }
    }
}
