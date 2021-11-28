﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
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
        /// Method FetchCarrierData fetches carrier data from the database and retunrs a list of Carrier objects.
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
                    for (int i = 0; i < numberofCarriers; ++i)
                    {
                        Carrier carrier = new Carrier();
                        carrier.CarrierName = carrierInfoRetrieved[0][i];
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
        /// Method FetchOrderData fetches and orders made by user
        /// </summary>
        public void FetchCityData()
        {

        }
    }


    /// <summary>
    /// Buyer derives from User and adds methods CreatOrder(), GetContract(), GenerateInvoice()
    /// </summary>
    public class TMSBuyer : TMSUser
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
    public class TMSPlanner : TMSUser
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
    public class TMSAdmin : TMSUser
    {

        public TMSAdmin() : base("admin")
        {
        }

        public bool UpdateCarrierData()
        {
            //take our carriers
            //update the table in the database

            //sqlc.UpdateRow();

            return true;
        }

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
