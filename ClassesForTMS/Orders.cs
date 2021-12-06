using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminWindow;

namespace ConnectToDatabase
{
    public class Orders : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

        private int orderID;
        //private ObservableCollection<Depot> depots;
        private string orderSubmissionDate;
        private string orderCompleteDate;
        private string orderStatus;
        private string jobType;
        private string quantity;
        private string originCity;
        private string destinationCity;
        private string vanType;
        


        //======================
        //PUBLIC PROPERTIES
        //======================
        public int OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                if (value != 0)
                {
                    orderID = value;
                }
                else
                {
                    Exception ex = new Exception("Value for orderID rejected.");
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
        public string OrderSubmissionDate
        {
            get
            {
                return orderSubmissionDate;
            }
            set
            {
                if (value != "")
                {
                    orderSubmissionDate = value;
                }
                else
                {
                    Exception ex = new Exception("Value for OrderSubmissionDate rejected.");
                    throw ex;
                }
            }
        }

        public string OrderCompleteDate
        {
            get
            {
                return orderCompleteDate;
            }
            set
            {
                if (value != "")
                {
                    orderCompleteDate = value;
                }
                else
                {
                    Exception ex = new Exception("Value for OrderCompleteDate rejected.");
                    throw ex;
                }
            }
        }

        public string OrderStatus
        {
            get
            {
                return orderStatus;
            }
            set
            {
                if (value != "")
                {
                    orderStatus = value;
                }
                else
                {
                    Exception ex = new Exception("Value for OrderStatus rejected.");
                    throw ex;
                }
            }
        }

        public string JobType
        {
            get
            {
                return jobType;
            }
            set
            {
                if (value != "")
                {
                    jobType = value;
                }
                else
                {
                    Exception ex = new Exception("Value for JobType rejected.");
                    throw ex;
                }
            }
        }
        public string Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value != "")
                {
                    quantity = value;
                }
                else
                {
                    Exception ex = new Exception("Value for Quantity rejected.");
                    throw ex;
                }
            }
        }
        public string OriginCity
        {
            get
            {
                return originCity;
            }
            set
            {
                if (value != "")
                {
                    originCity = value;
                }
                else
                {
                    Exception ex = new Exception("Value for OriginCity rejected.");
                    throw ex;
                }
            }
        }
        public string DestinationCity
        {
            get
            {
                return destinationCity;
            }
            set
            {
                if (value != "")
                {
                    destinationCity = value;
                }
                else
                {
                    Exception ex = new Exception("Value for DestinationCity rejected.");
                    throw ex;
                }
            }
        }
        public string VanType
        {
            get
            {
                return vanType;
            }
            set
            {
                if (value != "")
                {
                    vanType = value;
                }
                else
                {
                    Exception ex = new Exception("Value for VanType rejected.");
                    throw ex;
                }
            }
        }

        //======================
        //CONSTRUCTORS
        //======================

        public Orders()
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
            return orderID + "|" + orderSubmissionDate + "|" + orderCompleteDate + "|" + orderStatus + "|" + jobType + "|" + quantity + "|" + originCity + "|" + originCity + "|" + destinationCity + "|" + vanType;
        }

        public string GenerateCommaDelimitedString()
        {
            return "'" + orderID + "'" + ", " + orderSubmissionDate + ", " + orderCompleteDate + ", " + orderStatus + ", " + jobType + ", " + quantity + ", " + originCity;
        }

    }
}
