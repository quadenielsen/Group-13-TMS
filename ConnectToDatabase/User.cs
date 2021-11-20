using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectToDatabase;

namespace UserClasses
{
    public class User
    {
        /// <summary>
        /// Properties - username, userPassword, userRole
        /// </summary>
        protected string username { get; set; }
        protected string userPassword { get; set; }
        protected string userRole { get; set; }


        /// <summary>
        /// Default constructor. 
        /// </summary>
        public User()
        {
          
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
        /// Method FetchCarrierData fetches carrier data from the database and retunrs a list of Carrier objects.
        /// Returns null if fetch failed.
        /// </summary>
        public  List<Carrier> FetchCarrierData()
        {
            //create SQLConnecter to connect to database
            SQLConnector carrierFetcher = new SQLConnector("localhost", "OMNI_TMS_13", "root", "securepassword!94");

            //create a list in which to store the data
            List<List<string>> carrierInfoRetrieved = new List<List<string>>();

            //retrieve the data
            if (carrierFetcher.RetrieveFromColumns("carriers", "carrierID, carrierName, FTLRate, LTLRate, reefCharge", out carrierInfoRetrieved))
            {
                //this int will later be initialized using a method that returns the number of rows in the `carrierID` column
                int numberofCarriers = 4;

                //create a list of carriers
                List<Carrier> carriersFetched = new List<Carrier>();

                //fill the list with the retrieved data
                for (int i = 0; i < numberofCarriers; ++i)
                {
                    Carrier carrier = new Carrier(int.Parse(carrierInfoRetrieved[0][i]));
                    carrier.CarrierName = carrierInfoRetrieved[1][i];
                    carrier.FTLRate = float.Parse(carrierInfoRetrieved[2][i]);
                    carrier.LTLRate = float.Parse(carrierInfoRetrieved[3][i]);
                    carrier.ReefCharge = float.Parse(carrierInfoRetrieved[4][i]);
                    carriersFetched.Add(carrier);
                }

                return carriersFetched;
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



    /// <summary>
    /// Planner derives from User and adds methods AdvanceTime(), PairCarrierToOrder(), ConfirmOrder(), FetchShipmentData()
    /// </summary>
    public class Admin : User
    {
        /// <summary>
        /// Method FetchLogData
        /// </summary>
        public void FetchLogData()
        {

        }

        /// <summary>
        /// Method StartLoggingDirectory
        /// </summary>
        public void StartLoggingDirectory()
        {

        }

        /// <summary>
        /// Method BackupDirectory
        /// </summary>
        public void BackupDirectory()
        {

        }

        /// <summary>
        /// Method TogglePAPermission
        /// </summary>
        public void TogglePAPermission()
        {

        }


    }
}
    