using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSObjectLibrary;
using SQLConnectorLibrary;
using System.Configuration;

namespace TMSUserLibrary
{
    public class TMSUser
    {
        /// <summary>
        /// Properties - username, userPassword, userRole, Carriers
        /// </summary>
        protected string username { get; set; }
        protected string userPassword { get; set; }
        protected string userRole { get; set; }
        public ObservableCollection<Carrier> Carriers { get; set; }
        public ObservableCollection<Depot> Depots { get; set; }
        public ObservableCollection<City> Cities { get; set; }

        protected SQLConnector sqlc;

        /// <summary>
        /// Default constructor. 
        /// </summary>
        public TMSUser()
        {
            sqlc = new SQLConnector("localhost", "OMNI_TMS_13", "root", "securepassword!94");
        }

        /// <summary>
        /// Default constructor. 
        /// </summary>
        public TMSUser(string userRole)
        {
            sqlc = new SQLConnector("localhost", "OMNI_TMS_13", "root", "securepassword!94");
            if (userRole == "planner" || userRole == "admin")
            {
                Carriers = FetchCarrierData();
                Depots = FetchDepotData();
                Cities = FetchCityData();
            }
        }

        /// <summary>
        /// Instance constructor that has three parameters.
        /// </summary>
        public TMSUser(string Username, string userPassword, string userRole)
        {
            this.username = username;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }

        /// <summary>
        /// Method Update enables you to update the username and password of an existing User object.
        /// </summary>
        public void Update(string username, string userPassword)
        {
            this.username = username;
            this.userPassword = userPassword;
        }


        /// <summary>
        /// Method CheckLoginCredentials enables you to update the username and password of an existing User object.
        /// </summary> 
        public void CheckLoginCredentials(string username, string userPassword)
        {

        }

        /// <summary>
        /// Method CheckUserType enables you to check what type of user an object is
        /// </summary>
        public string CheckUserType()
        {
            return this.userRole;
        }

        /// <summary>
        /// Method FetchOrderData fetches and orders made by user
        /// </summary>
        public void FetchOrderData()
        {

        }

        /// <summary>
        /// Method FetchCustomerData fetches and orders made by user
        /// </summary>
        public void FetchCustomerData()
        {

        }



        /// <summary>
        /// Method FetchCarrierData fetches carrier data from the database and returns a list of Carrier objects.
        /// Returns null if fetch failed.
        /// </summary>
        public ObservableCollection<Carrier> FetchCarrierData()
        {
            //create a list in which to store the data
            List<List<string>> carrierInfoRetrieved = new List<List<string>>();

            //retrieve the data
            if (sqlc.RetrieveFromColumns("carriers", "carrierName, FTLRate, LTLRate, reefCharge", out carrierInfoRetrieved))
            {
                //get the number of carriers
                int numberofCarriers = carrierInfoRetrieved[0].Count;

                //create a list of carriers
                ObservableCollection<Carrier> carriersFetched = new ObservableCollection<Carrier>();

                try
                {
                    //fill the list with the retrieved data
                    //in the 2D array, the first index represents the column, and the second index represents the row
                    for (int i = 0; i < numberofCarriers; ++i)
                    {
                        Carrier carrier = new Carrier();
                        carrier.CarrierName = carrierInfoRetrieved[0][i];

                        //populate the depot collection of the carrier
                        ObservableCollection<Depot> depots = FetchDepotData();
                        foreach (Depot depot in depots)
                        {
                            if (depot.CarrierName == carrier.CarrierName)
                                carrier.Depots.Add(depot);
                        }
                        carrier.FTLRate = float.Parse(carrierInfoRetrieved[1][i]);
                        carrier.LTLRate = float.Parse(carrierInfoRetrieved[2][i]);
                        carrier.ReefCharge = float.Parse(carrierInfoRetrieved[3][i]);
                        carriersFetched.Add(carrier);
                    }
                }
                catch (Exception ex)
                {
                    Logger logger = new Logger(ConfigurationManager.AppSettings["logpath"]);
                    logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
                }
                return carriersFetched;
            }
            else
            {
                return null;
            }
        }



        /// <summary>
        /// Method FetchCarrierData fetches depot data from the database and returns a list of Depot objects.
        /// Returns null if fetch failed.
        /// </summary>
        public ObservableCollection<Depot> FetchDepotData()
        {
            //create a list in which to store the data
            List<List<string>> depotInfoRetrieved = new List<List<string>>();

            //retrieve the data
            if (sqlc.RetrieveFromColumns("depots", "carrierName, CityID, FTLAvailability, LTLAvailability", out depotInfoRetrieved))
            {
                //get the number of carriers
                int numberofDepots = depotInfoRetrieved[0].Count;

                //create a list of carriers
                ObservableCollection<Depot> depotsFetched = new ObservableCollection<Depot>();

                try
                {
                    //fill the list with the retrieved data
                    //in the 2D array, the first index represents the column, and the second index represents the row
                    for (int i = 0; i < numberofDepots; ++i)
                    {
                        Depot depot = new Depot();
                        depot.CarrierName = depotInfoRetrieved[0][i];
                        depot.CityID = int.Parse(depotInfoRetrieved[1][i]);

                        //retrieve the name of the city where the depot is located
                        List<List<String>> cityName = new List<List<String>>();
                        sqlc.RetrieveFromColumnsWithLookup("cities", "CityName", "CityID", depot.CityID.ToString(), out cityName);

                        depot.CityName = cityName[0][0];
                        depot.FTLAvailability = int.Parse(depotInfoRetrieved[2][i]);
                        depot.LTLAvailability = int.Parse(depotInfoRetrieved[3][i]);

                        depotsFetched.Add(depot);
                    }
                }
                catch (Exception ex)
                {
                    Logger logger = new Logger(ConfigurationManager.AppSettings["logpath"]);
                    logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
                }
                return depotsFetched;
            }
            else
            {
                return null;
            }
        }



        /// <summary>
        /// Method FetchCarrierData fetches city data from the database and returns a list of City objects.
        /// Returns null if fetch failed.
        /// </summary>
        public ObservableCollection<City> FetchCityData()
        {
            //create a list in which to store the data
            List<List<string>> cityInfoRetrieved = new List<List<string>>();

            //retrieve the data
            if (sqlc.RetrieveFromColumns("cities", "cityID, cityName, cityProvince, cityCountry, kilometersToNextCityEast, timeToNextCityEast, nextCityWest, nextCityEast", out cityInfoRetrieved))
            {
                //get the number of carriers
                int numberofCities = cityInfoRetrieved[0].Count;

                //create a list of carriers
                ObservableCollection<City> citiesFetched = new ObservableCollection<City>();

                try
                {
                    //fill the list with the retrieved data
                    //in the 2D array, the first index represents the column, and the second index represents the row
                    for (int i = 0; i < numberofCities; ++i)
                    {
                        City city = new City();
                        city.CityID = int.Parse(cityInfoRetrieved[0][i]);
                        city.CityName = cityInfoRetrieved[1][i];
                        city.CityProvince = cityInfoRetrieved[2][i];
                        city.CityCountry = cityInfoRetrieved[3][i];
                        int number;
                        if (!int.TryParse(cityInfoRetrieved[4][i], out number))
                        {
                            city.KilometersToNextCityEast = null;
                        }
                        else
                        {
                            city.KilometersToNextCityEast = number;
                        }
                        float realNumber;
                        if (!float.TryParse(cityInfoRetrieved[5][i], out realNumber))
                        {
                            city.TimeToNextCityEast = null;
                        }
                        else
                        {
                            city.TimeToNextCityEast = realNumber;
                        }             
                        if (!int.TryParse(cityInfoRetrieved[6][i], out number))
                        {
                            city.NextCityWestID = null;
                        }
                        else
                        {
                            city.NextCityWestID = number;
                        }
                        if (!int.TryParse(cityInfoRetrieved[7][i], out number))
                        {
                            city.NextCityEastID = null;
                        }
                        else
                        {
                            city.NextCityEastID = number;
                        }


                        List<List<String>> cityName = new List<List<String>>();
                        sqlc.RetrieveFromColumnsWithLookup("cities", "CityName", "CityID", city.NextCityWestID.ToString(), out cityName);

                        if (cityName[0].Count != 0)
                        {
                            city.NextCityWestName = cityName[0][0];
                        }


                        cityName = new List<List<String>>();
                        sqlc.RetrieveFromColumnsWithLookup("cities", "CityName", "CityID", city.NextCityEastID.ToString(), out cityName);

                        if (cityName[0].Count != 0)
                        {
                            city.NextCityEastName = cityName[0][0];
                        }

                        citiesFetched.Add(city);
                    }
                }
                catch (Exception ex)
                {
                    Logger logger = new Logger(ConfigurationManager.AppSettings["logpath"]);
                    logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
                }
                return citiesFetched;
            }
            else
            {
                return null;
            }
        }
    }


    /// <summary>
    /// Buyer derives from User and adds methods CreatOrder(), GetContract(), GenerateInvoice()
    /// </summary>
    public class Buyer : TMSUser
        {
            /// <summary>
            /// Method CreateOrder
            /// </summary>
            public void CreateOrder()
            {

            }

            /// <summary>
            /// Method GetContract
            /// </summary>
            public void GetContract()
            {

            }

            /// <summary>
            /// Method GenerateInvoice
            /// </summary>
            public void GenerateInvoice()
            {

            }

        }


        /// <summary>
        /// Planner derives from User and adds methods AdvanceTime(), PairCarrierToOrder(), ConfirmOrder(), FetchShipmentData()
        /// </summary>
        public class Planner : TMSUser
        {
            /// <summary>
            /// Method AdvanceTime
            /// </summary>
            public void AdvanceTime()
            {

            }

            /// <summary>
            /// Method PAirCarrierToOrder
            /// </summary>
            public void PairCarrierToOrder()
            {

            }

            /// <summary>
            /// Method FetchShipmentData
            /// </summary>
            public void FetchShipmentData()
            {

            }
        }
    }

