//
// FILE          : SQL_Connector_test_harness.cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file acts as a test harness for the SQLConnector class
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using SQLConnectorLibrary;
using TMSObjectLibrary;
using TMSUserLibrary;


namespace ConnectToDatabase
{
    class SQLConnector_test_harness
    {
        static void Main(string[] args)
        {
            try
            {
                Buyer buyer = new Buyer();
            
                foreach (Contract contract in buyer.Contracts)
                {
                    Console.WriteLine(contract.GenerateCommaDelimitedString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
                

            /*
            SQLConnector sqlc = new SQLConnector("localhost", "OMNI_TMS_13", "root", "securepassword!94");
            sqlc.InsertRow("carriers (carrierName, FTLRate, LTLRate, reefCharge)", "\"Shipping Stuff\", 0.5, 0.5, 0.5");
            carriers = user.FetchCarrierData();
            foreach (Carrier carrier in carriers)
            {
                Console.WriteLine(carrier.GenerateQueryString());
            }
            sqlc.DeleteRow("carriers", "carrierName='Shipping Stuff'");
            carriers = user.FetchCarrierData();
            foreach (Carrier carrier in carriers)
            {
                Console.WriteLine(carrier.GenerateQueryString());
            }
            */
        }
     }
}
