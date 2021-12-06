using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminWindow;

namespace ConnectToDatabase
{
    public class SystemUser : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

      
        private string username;
        private string userPassword;
        private string userRole;
        


        //======================
        //PUBLIC PROPERTIES
        //======================
       

       
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (value != "")
                {
                    username = value;
                }
                else
                {
                    Exception ex = new Exception("Value for Username rejected.");
                    throw ex;
                }
            }
        }

        public string UserPassword
        {
            get
            {
                return userPassword;
            }
            set
            {
                if (value != "")
                {
                    userPassword = value;
                }
                else
                {
                    Exception ex = new Exception("Value for UserPassword rejected.");
                    throw ex;
                }
            }
        }

        public string UserRole
        {
            get
            {
                return userRole;
            }
            set
            {
                if (value != "")
                {
                    userRole = value;
                }
                else
                {
                    Exception ex = new Exception("Value for UserRole rejected.");
                    throw ex;
                }
            }
        }


        //======================
        //CONSTRUCTORS
        //======================

        public SystemUser()
        {

        }

        //======================
        //OVERRIDES
        //======================

        //override public bool ValidateProperties()
        //{
        //    if (invoiceID == 0)
        //    {
        //        return false;
        //    }
        //    if (amount == 0)
        //    {
        //        return false;
        //    }
        //    if (dateIssued == "")
        //    {
        //        return false;
        //    }
        //    if (datePaid == "")
        //    {
        //        return false;
        //    }
        //    if (invoiceStatus == "")
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        override public string GenerateQueryString()
        {
            return username + "|" + userPassword + "|" + userRole;
        }

        public string GenerateCommaDelimitedString()
        {
            return "'" + username + "'" + ", " + userPassword + ", " + userRole;
        }

    }
}
