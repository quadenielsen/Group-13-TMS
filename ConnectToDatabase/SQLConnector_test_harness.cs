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
            User user = new User();
            List <Carrier> carriers = user.FetchCarrierData();
            foreach (Carrier carrier in carriers)
            {
                Console.WriteLine(carrier.GenerateQueryString());
            }
        
        }
     }
        
        


    
    
}
