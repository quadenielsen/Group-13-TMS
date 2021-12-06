using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User.Users.Maintenance
{
    public class ValidateUser
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string email;

        public ValidateUser()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            dateOfBirth = DateTime.Now;
            email = string.Empty;
        }

        static public bool ValidateCredentials(string fName, string lName, string dob, string Email)
        {
            bool validityStatus = true;

            if (!Regex.IsMatch(fName, @"^[a-zA-Z0-9]+$"))
            {
                validityStatus = false;
            }
            if (!Regex.IsMatch(lName, @"^[a-zA-Z0-9]+$"))
            {
                validityStatus = false;
            }

            return validityStatus;
        }
    }
}
