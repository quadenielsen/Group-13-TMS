using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSObjectLibrary
{
    public class Trips : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

        private int depotID;
        private int orderID;
        //private ObservableCollection<>; //not sure what to put here
        private string tripStatus;
        private int shipmentQuantity;
        private int timeToCompleteShipment;

        //======================
        //PUBLIC PROPERTIES
        //======================
        public int DepotID
        {
            get
            {
                return depotID;
            }
            set
            {
                if (value != 0)
                {
                    depotID = value;
                }
                else
                {
                    Exception ex = new Exception("Value for DepotID rejected.");
                    throw ex;
                }
            }
        }
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
                    Exception ex = new Exception("Value for OrderID rejected.");
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
        public string TripStatus
        {
            get
            {
                return tripStatus;
            }
            set
            {
                if (value != "")
                {
                    tripStatus = value;
                }
                else
                {
                    Exception ex = new Exception("Value for TripStatus rejected.");
                    throw ex;
                }
            }
        }
        public int ShipmentQuantity
        {
            get
            {
                return shipmentQuantity;
            }
            set
            {
                if (value != 0)
                {
                    shipmentQuantity = value;
                }
                else
                {
                    Exception ex = new Exception("Value for ShipmentQuantity rejected.");
                    throw ex;
                }
            }
        }
        public int TimeToCompleteShipment
        {
            get
            {
                return timeToCompleteShipment;
            }
            set
            {
                if (value != 0)
                {
                    timeToCompleteShipment = value;
                }
                else
                {
                    Exception ex = new Exception("Value for TimeToCompleteShipment rejected.");
                    throw ex;
                }
            }
        }



        //======================
        //CONSTRUCTORS
        //======================

        public Trips()
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
            return depotID + "|" + orderID + "|" + tripStatus + "|" + shipmentQuantity + "|" + timeToCompleteShipment;
        }

        public string GenerateCommaDelimitedString()
        {
            return "'" + depotID + "'" + ", " + orderID + ", " + tripStatus + ", " + shipmentQuantity + ", " + timeToCompleteShipment;
        }

    }
}
