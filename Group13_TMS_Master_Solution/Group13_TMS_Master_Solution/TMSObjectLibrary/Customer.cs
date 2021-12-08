//
// FILE          : Customer.cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file contains the Customer Class
//
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSObjectLibrary
{
    public class Customer : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

        private int customerID;
        //private ObservableCollection<>; //not sure what to put here
        private string customerName;
        private string customerAddress;
        private string customerCity;
        private string customerState;
        private string customerCountry;
        private string customerPostalCode;
       

        //======================
        //PUBLIC PROPERTIES
        //======================
        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                if (value != 0)
                {
                    customerID = value;
                }
                else
                {
                    Exception ex = new Exception("Value for customerID rejected.");
                    throw ex;
                }
            }
        }

        //public ObservableCollection<> 
        //{
        //    get
        //    {
        //        return ;
        //    }
        //    set
        //    {
        //         = value;
        //    }
        //}
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                if (value != "")
                {
                    customerName = value;
                }
                else
                {
                    Exception ex = new Exception("Value for CustomerName rejected.");
                    throw ex;
                }
            }
        }

        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                if (value != "")
                {
                    customerAddress = value;
                }
                else
                {
                    Exception ex = new Exception("Value for CustomerAddress rejected.");
                    throw ex;
                }
            }
        }

        public string CustomerCity
        {
            get
            {
                return customerCity;
            }
            set
            {
                if (value != "")
                {
                    customerCity = value;
                }
                else
                {
                    Exception ex = new Exception("Value for CustomerCity rejected.");
                    throw ex;
                }
            }
        }

        public string CustomerState
        {
            get
            {
                return customerState;
            }
            set
            {
                if (value != "")
                {
                    customerState = value;
                }
                else
                {
                    Exception ex = new Exception("Value for CustomerState rejected.");
                    throw ex;
                }
            }
        }

        public string CustomerCountry
        {
            get
            {
                return customerCountry;
            }
            set
            {
                if (value != "")
                {
                    customerCountry = value;
                }
                else
                {
                    Exception ex = new Exception("Value for CustomerCountry rejected.");
                    throw ex;
                }
            }
        }

        public string CustomerPostalCode
        {
            get
            {
                return customerPostalCode;
            }
            set
            {
                if (value != "")
                {
                    customerPostalCode = value;
                }
                else
                {
                    Exception ex = new Exception("Value for CustomerPostalCode rejected.");
                    throw ex;
                }
            }
        }


        //======================
        //CONSTRUCTORS
        //======================

        public Customer()
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
            return customerID + "|" + customerName + "|" + customerAddress + "|" + customerCity + "|" + customerState + "|" + customerCountry + "|" + customerPostalCode;
        }

        public string GenerateCommaDelimitedString()
        {
            return "'" + customerID + "'" + ", " + customerName + ", " + customerAddress + ", " + customerCity + ", " + customerState + ", " + customerCountry + ", " + customerPostalCode;
        }

    }
}
