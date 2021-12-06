using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminWindow;

namespace ConnectToDatabase
{
    public class IPAddress : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

        private string ipAddress;
        //private ObservableCollection<>; //not sure what to put here
        private string domainName;
        private string permissionStatus;
        private string logPathname;
   
        //======================
        //PUBLIC PROPERTIES
        //======================
        public string IpAddress
        {
            get
            {
                return ipAddress;
            }
            set
            {
                if (value != "")
                {
                    ipAddress = value;
                }
                else
                {
                    Exception ex = new Exception("Value for ipAddress rejected.");
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
        public string DomainName
        {
            get
            {
                return domainName;
            }
            set
            {
                if (value != "")
                {
                    domainName = value;
                }
                else
                {
                    Exception ex = new Exception("Value for DomainName rejected.");
                    throw ex;
                }
            }
        }

        public string PermissionStatus
        {
            get
            {
                return permissionStatus;
            }
            set
            {
                if (value != "")
                {
                    permissionStatus = value;
                }
                else
                {
                    Exception ex = new Exception("Value for PermissionStatus rejected.");
                    throw ex;
                }
            }
        }

        public string LogPathname
        {
            get
            {
                return logPathname;
            }
            set
            {
                if (value != "")
                {
                    logPathname = value;
                }
                else
                {
                    Exception ex = new Exception("Value for LogPathname rejected.");
                    throw ex;
                }
            }
        }


        //======================
        //CONSTRUCTORS
        //======================

        public IPAddress()
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
            return ipAddress + "|" + domainName + "|" + permissionStatus + "|" + logPathname;
        }

        public string GenerateCommaDelimitedString()
        {
            return "'" + ipAddress + "'" + ", " + domainName + ", " + permissionStatus + ", " + logPathname;
        }

    }
}
