using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSObjectLibrary;
using SQLConnectorLibrary;
using System.Configuration;

namespace TMSUserLibrary
{
    public class Admin : TMSUser
    {

        public Admin() : base("admin")
        {

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

        /// <summary>
        /// This method updates the `carriers` and `depots` tables on the database.
        /// It does this by first deleting everything in those tables and then repopulating the tables using the new data
        /// specified by the Admin.
        /// </summary>
        /// <returns>True if the update was successful.</returns>
        public string UpdateCarrierData()
        {
            try
            {
                foreach (Carrier carrier in Carriers)
                {
                    foreach (Depot depot in carrier.Depots)
                    {
                        if (!depot.ValidateProperties(Cities))
                        {
                            return "New depot is located in unknown city. Please create a new city.";
                        }
                    }
                }
                

                //clear the tables in the database
                sqlcTMS.ClearTable("depots");
                sqlcTMS.ClearTable("carriers");

                //for each carrier, insert a new row into the database
                foreach (Carrier carrier in this.Carriers)
                {
                    sqlcTMS.InsertRow("carriers (carrierName, FTLRate, LTLRate, ReefCharge)", carrier.GenerateCommaDelimitedString());

                    //for each depot owned by the carrier, add a new row into the database
                    foreach (Depot depot in carrier.Depots)
                    {
                        {
                            sqlcTMS.InsertRow("depots (carrierName, CityID, FTLAvailability, LTLAvailability)", depot.GenerateCommaDelimitedString());
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Logger logger = new Logger(ConfigurationManager.AppSettings["logpath"]);
                logger.Log(ex.ToString());
                return "Update failed.";
            }
            
            return "Update successful.";
        }



        /// <summary>
        /// This method updates the `cities` table on the database.
        /// It does this by first deleting everything in those tables and then repopulating the tables using the new data
        /// specified by the Admin.
        /// </summary>
        /// <returns>True if the update was successful.</returns>
        public string UpdateCityData()
        {
            try
            { 
                //clear the tables in the database
                sqlcTMS.ClearTable("cities");


                //for each carrier, insert a new row into the database
                foreach (City city in this.Cities)
                {
                    sqlcTMS.InsertRow("cities (cityName, cityProvince, cityCountry, kilometersToNextCityEast, timeToNextCityEast, nextCityWest, nextCityEast)", city.GenerateCommaDelimitedString());
                }

            }
            catch (Exception ex)
            {
                Logger logger = new Logger(ConfigurationManager.AppSettings["logpath"]);
                logger.Log(ex.ToString());
                return "Update failed.";
            }

            return "Update successful.";
        }

    }
}
