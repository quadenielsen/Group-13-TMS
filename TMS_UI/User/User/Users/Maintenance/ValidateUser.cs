using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace User.Users.Maintenance
{
    public class ValidateUser
    {

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

            DateTime date;
            if(!DateTime.TryParse(dob, out date))
            {
                validityStatus = false;
            }

            var foo = new EmailAddressAttribute();
            if (!foo.IsValid(Email))
            {
                validityStatus = false;
            }

            return validityStatus;
        }
    }
}
