using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserClasses;

namespace ConnectToDatabase
{
    class Admin : User
    {

        public Admin()
        {
            userRole = "admin";
            Carriers = FetchCarrierData();
        }


        public bool UpdateCarrierData()
        {
            //take our carriers
            //update the table in the database

            //sqlc.UpdateRow();

            return true;
        }

    }
}
