using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Library_Of_Babel
{
    internal class Author
    {
		private string firstName;
		private string middleName;
		private string lastName;
        private DateTime dateOfBirth;
        private string description;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
		{
			get { return middleName; }
			set { middleName = value; }
		}
        
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
