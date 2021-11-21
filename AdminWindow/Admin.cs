using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserClasses;

namespace ConnectToDatabase
{
    public class Admin : User
    {

        public Admin() : base("admin")
        {
            
        }


        public bool UpdateCarrierData()
        {
            sqlc.ClearTable("carriers");
            foreach (Carrier carrier in this.Carriers)
            {
                sqlc.InsertRow("carriers (carrierName, FTLRate, LTLRate, ReefCharge)", carrier.GenerateCommaDelimitedString());
            }

            return true;
        }

    }
}
