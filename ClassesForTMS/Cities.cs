using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminWindow;

namespace ConnectToDatabase
{
    public class Cities : TMSObject
    {

        //======================
        //PRIVATE MEMBERS
        //======================

        private int cityID;
        //private ObservableCollection<>; //not sure what to put here
        private string cityName;
        private string cityProvince;
        private string cityCountry;
        private int kilometersToNextCityEast;
        private int timeToNextCityEast;
        private string nextCityEast;
        private string nextCityWest;

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

        public int KilometersToNextCityEast
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

        public int TimeToNextCityEast
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

        public string NextCityEast
        {
            get
            {
                return nextCityEast;
            }
            set
            {
                if (value != "")
                {
                    nextCityEast = value;
                }
                else
                {
                    Exception ex = new Exception("Value for NextCityEast rejected.");
                    throw ex;
                }
            }
        }

        public string NextCityWest
        {
            get
            {
                return nextCityWest;
            }
            set
            {
                if (value != "")
                {
                    nextCityWest = value;
                }
                else
                {
                    Exception ex = new Exception("Value for NextCityWest rejected.");
                    throw ex;
                }
            }
        }
        //======================
        //CONSTRUCTORS
        //======================

        public Cities()
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
            return cityID + "|" + cityName + "|" + cityProvince + "|" + cityCountry + "|" + kilometersToNextCityEast + "|" + timeToNextCityEast + "|" + timeToNextCityEast + "|" + nextCityEast + "|" + nextCityWest;
        }

        public string GenerateCommaDelimitedString()
        {
            return "'" + cityID + "'" + ", " + cityName + ", " + cityProvince + ", " + cityCountry + ", " + kilometersToNextCityEast + ", " + timeToNextCityEast + ", " + nextCityEast + ", " + nextCityWest;
        }

    }
}
