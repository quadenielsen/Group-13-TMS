using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSObjectLibrary
{
    public class Invoice : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

        private int invoiceID;
        //private ObservableCollection<>; //not sure what to put here
        private float amount;
        private string dateIssued;
        private string datePaid;
        private string invoiceStatus;

        //======================
        //PUBLIC PROPERTIES
        //======================
        public int InvoiceID
        {
            get
            {
                return invoiceID;
            }
            set
            {
                if (value != 0)
                {
                    invoiceID = value;
                }
                else
                {
                    Exception ex = new Exception("Value for InvoiceID rejected.");
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

        public float Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value >= 0)
                {
                    amount = value;
                }
                else
                {
                    Exception ex = new Exception("Value for Amount rejected.");
                    throw ex;
                }
            }
        }
        public string DateIssued
        {
            get
            {
                return dateIssued;
            }
            set
            {
                if (value != "")
                {
                    dateIssued = value;
                }
                else
                {
                    Exception ex = new Exception("Value for DateIssued rejected.");
                    throw ex;
                }
            }
        }
        public string DatePaid
        {
            get
            {
                return datePaid;
            }
            set
            {
                if (value != "")
                {
                    dateIssued = value;
                }
                else
                {
                    Exception ex = new Exception("Value for DatePaid rejected.");
                    throw ex;
                }
            }
        }
        public string InvoiceStatus
        {
            get
            {
                return invoiceStatus;
            }
            set
            {
                if (value != "")
                {
                    invoiceStatus = value;
                }
                else
                {
                    Exception ex = new Exception("Value for invoiceStatus rejected.");
                    throw ex;
                }
            }
        }
        //======================
        //CONSTRUCTORS
        //======================

        public Invoice()
        {
        
        }

        public Invoice(int invoiceID, float amount, string dateIssued, string datePaid, string invoiceStatus)
        {
            this.invoiceID = invoiceID;
            this.amount = amount;
            this.dateIssued = dateIssued;
            this.datePaid = datePaid;
            this.invoiceStatus = invoiceStatus;
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
            return invoiceID + "|" + amount + "|" + dateIssued + "|" + datePaid + "|" + invoiceStatus;
        }

        public string GenerateCommaDelimitedString()
        {
            return "'" + invoiceID + "'" + ", " + amount + ", " + dateIssued + ", " + datePaid + ", " + invoiceStatus;
        }

    }
}
