/*
 * File:		Logger.cs
 * Project:		myOwnWebServer
 * By:			Quade Nielsen
 * Date:		November 27, 2021
 * Description:	This file contains the Logger class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Configuration;


namespace SQLConnectorLibrary
{
    public class Logger
    {
        string filepath { get; set; }

        // Constructors
        public Logger()
        {
            filepath = Directory.GetCurrentDirectory() + @"\logger.log"; // Default filepath in current directory
            SetAppConfig("logpath", filepath); //Set app config to default
        }

        public Logger(string filepath)
        {
            this.filepath = filepath; // Custom Filepath - must be absolute path
        }

        public void Log(string msg)
        {
            //Give log file a name, change name if needed 
            string pathname = filepath;

            //Format log message
            string logmsg = DateTime.Now.ToString() + ": " + msg;

            //Open and append to file if exists or create log file if it does not exist
            //Log file will appear in same folder as myOwnWebServer.exe
            FileStream file;
            StreamWriter sw;
            file = File.Open(pathname, FileMode.Append);
            sw = new StreamWriter(file);
            sw.WriteLine(logmsg);

            //Close file/streamwriter
            sw.Close();
            file.Close();
        }

        // Change filepath to specified string
        public void ChangeFilepath(string filepath)
        {
            this.filepath = filepath;

        }

        // Get the current filepath
        public string GetFilepath()
        {
            return this.filepath;
        }

        public static void SetAppConfig(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

    }

}
