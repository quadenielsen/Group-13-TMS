using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserClasses;
using AdminWindow;

namespace ConnectToDatabase
{
    public class Admin : User
    {

        public Admin() : base("admin")
        {

        }



        /// <summary>
        /// This method updates the `carriers` and `depots` tables on the database.
        /// It does this by first deleting everything in those tables and then repopulating the tables using the new data
        /// specified by the Admin.
        /// </summary>
        /// <returns>True if the update was successful.</returns>
        public bool UpdateCarrierData()
        {
            try
            {
                //clear the tables in the database
                sqlc.ClearTable("depots");
                sqlc.ClearTable("carriers");

                //for each carrier, insert a new row into the database
                foreach (Carrier carrier in this.Carriers)
                {
                    sqlc.InsertRow("carriers (carrierName, FTLRate, LTLRate, ReefCharge)", carrier.GenerateCommaDelimitedString());

                    //for each depot owned by the carrier, add a new row into the database
                    foreach (Depot depot in carrier.Depots)
                    {
                        {
                            sqlc.InsertRow("depots (carrierName, CityID, FTLAvailability, LTLAvailability)", depot.GenerateCommaDelimitedString());
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Logger.Log(ex.ToString());
                return false;
            }
            
            return true;
        }

    }
}
