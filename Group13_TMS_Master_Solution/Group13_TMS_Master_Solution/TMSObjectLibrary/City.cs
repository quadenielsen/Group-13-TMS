using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSObjectLibrary
{
    public class City : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

        private int cityID;
        //private ObservableCollection<>; //not sure what to put here
        private string cityName;
        private string cityProvince;
        private string cityCountry;
        private int? kilometersToNextCityEast;
        private float? timeToNextCityEast;
        private int? nextCityEastID;
        private int? nextCityWestID;
        private string nextCityEastName;
        private string nextCityWestName;

        //======================
        //PUBLIC PROPERTIES
        //======================
        public int CityID
        {
            get
            {
                return cityID;
            }
            set
            {
                if (value != 0)
                {
                    cityID = value;
                }
                else
                {
                    Exception ex = new Exception("Value for CityID rejected.");
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
                else
                {
                    Exception ex = new Exception("Value for CityName rejected.");
                    throw ex;
                }
            }
        }

        public string CityProvince
        {
            get
            {
                return cityProvince;
            }
            set
            {
                if (value != "")
                {
                    cityProvince = value;
                }
                else
                {
                    Exception ex = new Exception("Value for CityProvince rejected.");
                    throw ex;
                }
            }
        }

        public string CityCountry
        {
            get
            {
                return cityCountry;
            }
            set
            {
                if (value != "")
                {
                    cityCountry = value;
                }
                else
                {
                    Exception ex = new Exception("Value for CityCountry rejected.");
                    throw ex;
                }
            }
        }

        public int? KilometersToNextCityEast
        {
            get
            {
                return kilometersToNextCityEast;
            }
            set
            {
                if (value != 0)
                {
                    kilometersToNextCityEast = value;
                }
                else
                {
                    Exception ex = new Exception("Value for KilometersToNextCityEast rejected.");
                    throw ex;
                }
            }
        }

        public float? TimeToNextCityEast
        {
            get
            {
                return timeToNextCityEast;
            }
            set
            {
                if (value != 0)
                {
                    timeToNextCityEast = value;
                }
                else
                {
                    Exception ex = new Exception("Value for timeToNextCityEast rejected.");
                    throw ex;
                }
            }
        }

        public int? NextCityEastID
        {
            get
            {
                return nextCityEastID;
            }
            set
            {
                nextCityEastID = value;
            }
        }

        public int? NextCityWestID
        {
            get
            {
                return nextCityWestID;
            }
            set
            {
                nextCityWestID = value;
            }
        }


        public string NextCityEastName
        {
            get
            {
                return nextCityEastName;
            }
            set
            {
                nextCityEastName = value;
            }
        }

        public string NextCityWestName
        {
            get
            {
                return nextCityWestName;
            }
            set
            {
                nextCityWestName = value;
            }
        }
        //======================
        //CONSTRUCTORS
        //======================

        public City()
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
            return cityID + "|" + cityName + "|" + cityProvince + "|" + cityCountry + "|" + kilometersToNextCityEast + "|" + timeToNextCityEast + "|" + timeToNextCityEast + "|" + nextCityEastID + "|" + nextCityWestID;
        }

        public string GenerateCommaDelimitedString()
        {
            return  cityID + ", '" + cityName + "', '" + cityProvince + "', '" + cityCountry + "', " + kilometersToNextCityEast + ", " + timeToNextCityEast + ", " + nextCityEastID + ", " + nextCityWestID;
        }

    }
}
