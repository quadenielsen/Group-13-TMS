using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDatabase
{
    public class Carrier : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

        private int carrierID;
        private string carrierName;
        private float ftlRate;
        private float ltlRate;
        private float reefCharge;

        //======================
        //PUBLIC PROPERTIES
        //======================

        public int CarrierID { get { return carrierID; } }
        public string CarrierName 
        {
            get
            {
                return carrierName;
            }
            set
            {
                if (value != "")
                {
                    carrierName = value;
                }
                else
                {
                    Exception ex = new Exception("Value for CarrierName rejected.");
                    throw ex;
                }
            }
        }
        public float FTLRate
        {
            get
            {
                return ftlRate;
            }
            set
            {
                if (value >= 0)
                {
                    ftlRate = value;
                }
                else
                {
                    Exception ex = new Exception("Value for FTLRate rejected.");
                    throw ex;
                }
            }
        }
        public float LTLRate
        {
            get
            {
                return ltlRate;
            }
            set
            {
                if (value >= 0)
                {
                    ltlRate = value;
                }
                else
                {
                    Exception ex = new Exception("Value for LTLRate rejected.");
                    throw ex;
                }
            }
        }
        public float ReefCharge
        {
            get
            {
                return reefCharge;
            }
            set
            {
                if (value >= 0)
                {
                    reefCharge = value;
                }
                else
                {
                    Exception ex = new Exception("Value for carrierName rejected.");
                    throw ex;
                }
            }
        }

        //======================
        //CONSTRUCTORS
        //======================

        public Carrier()
        {
            objectType = "carrier";
            carrierID = -1;
            carrierName = "Unknown";
            ftlRate = -1;
            ltlRate = -1;
            reefCharge = -1;
        }

        public Carrier(int carrierID)
        {
            objectType = "carrier";
            this.carrierID = carrierID;
        }

        //======================
        //OVERRIDES
        //======================

        override public bool ValidateProperties()
        {
            if (carrierName == "Unknown" || carrierName == "")
            {
                return false;
            }
            if (carrierID <= 0)
            {
                return false;
            }
            if (ftlRate <= 0)
            {
                return false;
            }
            if (ltlRate <= 0)
            {
                return false;
            }
            if (reefCharge <= 0)
            {
                return false;
            }
            return true;
        }

        override public string GenerateQueryString()
        {
            return carrierID+"|"+carrierName+"|"+ftlRate+"|"+ltlRate+"|"+reefCharge+"|";
        }
    }
}
