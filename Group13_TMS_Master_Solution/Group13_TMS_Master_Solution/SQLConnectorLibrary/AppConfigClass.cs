//
// FILE          : AppConfigClass.cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file containts the AppConfigClass which is used to change the app config settings
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SQLConnectorLibrary
{
    public class AppConfigClass
    {
        // Default Constructor
        public AppConfigClass()
        {

        }

        // FUNCTION    : SetAppConfig
        // DESCRIPTION : Changes the app.config settings for specified key and value
        // PARAMETERS  : string key
        //               string value
        // RETURNS     : none
        public static void SetAppConfig(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
