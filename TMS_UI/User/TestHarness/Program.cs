using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Users.Maintenance;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool a = ValidateUser.ValidateCredentials("fgdfg", "", "", "");
        }
    }
}
