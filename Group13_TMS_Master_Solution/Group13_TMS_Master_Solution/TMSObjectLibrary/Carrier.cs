//
// FILE          : Carrier.cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file contains the Carrier class
//
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSObjectLibrary
{
    public class Carrier : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

        private string carrierName;
        private ObservableCollection<Depot> depots;
        private float ftlRate;
        private float ltlRate;
        private float reefCharge;
        private ObservableCollection<Orders> orders;

        //======================
        //PUBLIC PROPERTIES
        //======================

        /// <summary>
        /// 
        /// </summary>
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
            }
        }

        public ObservableCollection<Depot> Depots
        {
            get
            {
                return depots;
            }
            set
            {
                depots = value;
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

            }
        }

        public ObservableCollection<Orders> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
            }
        }

        //======================
        //CONSTRUCTORS
        //======================

        public Carrier()
        {
            objectType = "carrier";
            carrierName = "Unknown";
            depots = new ObservableCollection<Depot>();
            ftlRate = 0;
            ltlRate = 0;
            reefCharge = 0;
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
            return carrierName+"|"+ftlRate+"|"+ltlRate+"|"+reefCharge;
        }

        public string GenerateCommaDelimitedString()
        {
            //check strings for characters that would possibly be misinterpreted as control characters by MySQL

            string name = carrierName;
            if (name.Contains('\'') == true)
            {
                name = name.Replace("\'", "\\\'");
            }

            //return a string that can be used in a MySQL query to specify the values for an INSERT statement
            return "'" + name + "'" + ", " + ftlRate + ", " + ltlRate + ", " + reefCharge;
        }
    }
}
