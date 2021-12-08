//
// FILE          : TMSObject.cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file contains the TMSObject class
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSObjectLibrary
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
