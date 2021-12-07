using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSObjectLibrary
{
    public class Contract
    {
        public string ClientName { get; set; }
        public string JobType { get; set; }
        public int Quantity { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string VanType { get; set; }


        public string GenerateCommaDelimitedString()
        {
            //check strings for characters that would possibly be misinterpreted as control characters by MySQL

            string name = ClientName;
            if (name.Contains('\'') == true)
            {
                name = name.Replace("\'", "\\\'");
            }

            //return a string that can be used in a MySQL query to specify the values for an INSERT statement
            return "'" + ClientName + "'" + ", " + JobType + ", " + Quantity + ", " + Origin + Destination + VanType;
        }
    }
}
