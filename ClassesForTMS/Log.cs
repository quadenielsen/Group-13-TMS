using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminWindow;

namespace ConnectToDatabase
{
    public class Log : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

        private int logID;
        //private ObservableCollection<Depot> depots;
        private string directoryPathname;
        private string logCreationDate;
        private string lastUpdated;
        private string logPathname;


        //======================
        //PUBLIC PROPERTIES
        //======================
        public int LogID
        {
            get
            {
                return logID;
            }
            set
            {
                if (value != 0)
                {
                    logID = value;
                }
                else
                {
                    Exception ex = new Exception("Value for logID rejected.");
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
        public string DirectoryPathname
        {
            get
            {
                return directoryPathname;
            }
            set
            {
                if (value != "")
                {
                    directoryPathname = value;
                }
                else
                {
                    Exception ex = new Exception("Value for DirectoryPathname rejected.");
                    throw ex;
                }
            }
        }

        public string LogCreationDate
        {
            get
            {
                return logCreationDate;
            }
            set
            {
                if (value != "")
                {
                    logCreationDate = value;
                }
                else
                {
                    Exception ex = new Exception("Value for LogCreationDate rejected.");
                    throw ex;
                }
            }
        }

        public string LastUpdated
        {
            get
            {
                return lastUpdated;
            }
            set
            {
                if (value != "")
                {
                    lastUpdated = value;
                }
                else
                {
                    Exception ex = new Exception("Value for LastUpdated rejected.");
                    throw ex;
                }
            }
        }


        //======================
        //CONSTRUCTORS
        //======================

        public Log()
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
            return logID + "|" + directoryPathname + "|" + logCreationDate + "|" + lastUpdated + "|" + logPathname;
        }

        public string GenerateCommaDelimitedString()
        {
            return "'" + logID + "'" + ", " + directoryPathname + ", " + logCreationDate + ", " + lastUpdated + ", " + logPathname;
        }

    }
}
