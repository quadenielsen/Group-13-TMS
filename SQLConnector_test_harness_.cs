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
            SQLConnector dbc = new SQLConnector();
            List<List<string>> stuff = new List<List<string>>();
            
            if (dbc.Select("customers", "customerName, contactLast", out stuff))
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
