//
// FILE          : Shipment.cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file contains the Shipment Class
//
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSObjectLibrary
{
    public class Shipment : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================
        private int depotID;
        private int orderID;
        //private ObservableCollection<Depot> depots;
        private string shipmentStatus;
        private int shipmentQuantity;
       



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
                    Exception ex = new Exception("Value for depotID rejected.");
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

       
        public string ShipmentStatus
        {
            get
            {
                return shipmentStatus;
            }
            set
            {
                if (value != "")
                {
                    shipmentStatus = value;
                }
                else
                {
                    Exception ex = new Exception("Value for ShipmentStatus rejected.");
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
       
       
        //======================
        //CONSTRUCTORS
        //======================

        public Shipment()
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
            return depotID + "|" + orderID + "|" + shipmentStatus + "|" + shipmentQuantity;
        }

        public string GenerateCommaDelimitedString()
        {
            return "'" + depotID + "'" + ", " + orderID + ", " + shipmentStatus + ", " + shipmentQuantity;
        }

    }
}
