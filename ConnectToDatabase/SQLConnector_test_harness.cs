using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using UserClasses;


namespace ConnectToDatabase
{
    class SQLConnector_test_harness
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User("planner");
            
                foreach (Carrier carrier in user.Carriers)
                {
                    Console.WriteLine(carrier.GenerateQueryString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
