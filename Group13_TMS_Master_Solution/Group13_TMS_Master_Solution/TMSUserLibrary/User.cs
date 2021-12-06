using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSObjectLibrary;
using SQLConnectorLibrary;

namespace TMSUserLibrary
{
    public class User
    {
        /// <summary>
        /// Properties - username, userPassword, userRole, Carriers
        /// </summary>
        protected string username { get; set; }
        protected string userPassword { get; set; }
        protected string userRole { get; set; }
        public ObservableCollection<Carrier> Carriers { get; set; }
        public ObservableCollection<Depot> Depots { get; set; }

        protected SQLConnector sqlc;

        /// <summary>
        /// Default constructor. 
        /// </summary>
        public User()
        {
            sqlc = new SQLConnector("localhost", "OMNI_TMS_13", "root", "securepassword!94");
        }

        /// <summary>
        /// Default constructor. 
        /// </summary>
        public User(string userRole)
        {
            sqlc = new SQLConnector("localhost", "OMNI_TMS_13", "root", "securepassword!94");
            if (userRole == "planner" || userRole == "admin")
            {
                Carriers = FetchCarrierData();
                Depots = FetchDepotData();
            }
        }

        /// <summary>
        /// Instance constructor that has three parameters.
        /// </summary>
        public User(string Username, string userPassword, string userRole)
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
                    Console.WriteLine(ex.Message);
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
                    Console.WriteLine(ex.Message);
                }
                return depotsFetched;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Method FetchOrderData fetches and orders made by user
        /// </summary>
        public void FetchCityData()
        {

        }
    }


    /// <summary>
    /// Buyer derives from User and adds methods CreatOrder(), GetContract(), GenerateInvoice()
    /// </summary>
    public class Buyer : User
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
    public class Planner : User
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
