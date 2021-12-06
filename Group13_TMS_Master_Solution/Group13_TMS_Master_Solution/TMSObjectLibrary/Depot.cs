﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSObjectLibrary
{
    public class Depot : TMSObject
    {
        private string carrierName;
        private int cityID;
        private string cityName;
        private int ftlAvailability;
        private int ltlAvailability;

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
        public int CityID
        {
            get
            {
                return cityID;
            }
            set
            {
                if (value >= 0)
                {
                    cityID = value;
                }
            }
        }
        public string CityName
        {
            get
            {
                return cityName;
            }
            set
            {
                if (value != "")
                {
                    cityName = value;
                }
            }
        }
        public int FTLAvailability
        {
            get
            {
                return ftlAvailability;
            }
            set
            {
                if (value >= 0)
                {
                    ftlAvailability = value;
                }

            }
        }
        public int LTLAvailability
        {
            get
            {
                return ltlAvailability;
            }
            set
            {
                if (value >= 0)
                {
                    ltlAvailability = value;
                }

            }
        }


        public Depot()
        {
            objectType = "depot";
            carrierName = "Unknown";
            cityID = -1;
            cityName = "Unknown";
            ftlAvailability = 0;
            ltlAvailability = 0;
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
            return "'" + name + "'" + ", " + cityID + ", " + ftlAvailability + ", " + ltlAvailability;
        }
    }
}