using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace ConnectToDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLConnector dbc = new SQLConnector("localhost", "OMNI_TMS_13", "root", "securepassword!94");
            List<List<string>> stuff = new List<List<string>>();
            
            if (dbc.Select("cities", "cityName", out stuff))
            {
                foreach (List<string> bunchof in stuff)
                {
                    foreach (string thing in bunchof)
                    {
                        Console.WriteLine(thing);
                    }
                }
            }
            else
            {
                Console.WriteLine("Shit failed");
            }
        
        }
        


     }
        
        


    
    
}
