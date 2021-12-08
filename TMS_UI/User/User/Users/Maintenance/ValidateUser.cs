//
// FILE          : ValidateUser.cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file contains the ValidateUser class
//
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
        static public bool ValidateCredentials(string UserName, string PassWord)
        {
            bool validityStatus = true;

            if (!Regex.IsMatch(UserName, @"^[a-zA-Z0-9]+$"))
            {
                validityStatus = false;
            }

            if (!Regex.IsMatch(PassWord, @"^[a-zA-Z0-9]+$"))
            {
                validityStatus = false;
            }

            return validityStatus;
        }
    }
}
