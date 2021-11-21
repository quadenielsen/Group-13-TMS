using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDatabase
{
    public class TMSObject
    {
        protected string objectType;
        virtual public bool ValidateProperties()
        {
            return true;
        }

        virtual public string GenerateQueryString()
        {
            return "hi";
        }


    }
}
