//
// FILE          : Buyer,cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file contains the Buyer class
//
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLConnectorLibrary;
using TMSObjectLibrary;
using System.Configuration;


namespace TMSUserLibrary
{
    /// <summary>
    /// Buyer derives from User and adds methods CreatOrder(), GetContract(), GenerateInvoice()
    /// </summary>
    public class Buyer : TMSUser
    {

        //private SQLConnector sqlcTMS;
        private SQLConnector sqlcCMP;

        public ObservableCollection<Contract> Contracts { get; set; }

        public Buyer() : base("buyer")
        {
            sqlcCMP = new SQLConnector("159.89.117.198", "cmp", "DevOSHT", "Snodgr4ss!");
            Contracts = FetchContracts();
        }
        


        /// <summary>
        /// Method CreateOrder
        /// </summary>
        public void CreateOrder()
        {

        }



        /// <summary>
        /// Method FetchCarrierData fetches carrier data from the database and returns a list of Carrier objects.
        /// Returns null if fetch failed.
        /// </summary>
        public ObservableCollection<Contract> FetchContracts()
        {
            //create a list in which to store the data
            List<List<string>> contractInfoRetrieved = new List<List<string>>();

            //retrieve the data
            if (sqlcCMP.RetrieveFromColumns("Contract", "CLIENT_NAME, JOB_TYPE, QUANTITY, ORIGIN, DESTINATION, VAN_TYPE", out contractInfoRetrieved))
            {
                //get the number of carriers
                int numberofCarriers = contractInfoRetrieved[0].Count;

                //create a list of carriers
                ObservableCollection<Contract> contractsFetched = new ObservableCollection<Contract>();

                try
                {
                    //fill the list with the retrieved data
                    //in the 2D array, the first index represents the column, and the second index represents the row
                    for (int i = 0; i < numberofCarriers; ++i)
                    {
                        Contract contract = new Contract();
                        contract.ClientName = contractInfoRetrieved[0][i];
                        contract.JobType = contractInfoRetrieved[1][i];
                        if (contract.JobType == "0")
                        {
                            contract.JobType = "FTL";
                        }
                        else
                        {
                            contract.JobType = "LTL";
                        }
                        contract.Quantity = int.Parse(contractInfoRetrieved[2][i]);
                        contract.Origin = contractInfoRetrieved[3][i];
                        contract.Destination = contractInfoRetrieved[4][i];
                        contract.VanType = contractInfoRetrieved[5][i];
                        if (contract.VanType == "0")
                        {
                            contract.VanType = "Dry";
                        }
                        else
                        {
                            contract.VanType = "Reefer";
                        }
                        contractsFetched.Add(contract);
                    }
                }
                catch (Exception ex)
                {
                    Logger logger = new Logger(ConfigurationManager.AppSettings["logpath"]);
                    logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
                }
                return contractsFetched;
            }
            else
            {
                return null;
            }
        }



        /// <summary>
        /// Method GenerateInvoice
        /// </summary>
        public void GenerateInvoice()
        {

        }

    }
}
