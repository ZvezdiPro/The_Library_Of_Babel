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
    }
}
