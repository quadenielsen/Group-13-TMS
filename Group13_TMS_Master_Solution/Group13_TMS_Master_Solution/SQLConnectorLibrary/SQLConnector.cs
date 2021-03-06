//
// FILE          : SQLConnector.cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file contains the SQLConnector class which establishes connections with databases
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SQLConnectorLibrary
{
    public class SQLConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        Logger logger = new Logger();

        //============================
        // CONSTRUCTORS
        //============================


        /// <summary>
        /// Default constructor for the DBConnector class.
        /// </summary>
        public SQLConnector()
        {
            Initialize();
        }



        /// <summary>
        /// Constructor for the DBConnector class. Creates an object which connects to a user-specified
        /// server and database, using a user-specified uid and password.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="database"></param>
        /// <param name="uid"></param>
        /// <param name="password"></param>
        public SQLConnector(string server, string database, string uid, string password)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.password = password;
            string connectionString;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        //============================
        // PRIVATE METHODS
        //============================

        /// <summary>
        /// Initializer for the DBConnector class. To be called in the default constructor.
        /// Initializes object variables with defaults.
        /// </summary>
        private void Initialize()
        {
            
            server = "localhost";    
            database = "OMNI_TMS_13";
            uid = "root";
            password = "securepassword!94";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }



        /// <summary>
        /// Opens a connection to the database which the object is pointing to.
        /// </summary>
        /// <returns>Returns true if the connection was successful, otherwise false.</returns>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }



        /// <summary>
        /// Closes a connection to the database which the object is pointing to.
        /// </summary>
        /// <returns>Returns true if the disconnection was successful, otherwise false.</returns>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }



        /// <summary>
        /// Inserts a row into a relation in the database.
        /// String for table must be formatted as follows: "tableName (column1, column2...)"
        /// String for values must be formatted as follows: "'value1', 'value2'..."
        /// </summary>
        /// <param name="table"></param>
        /// <param name="values"></param>
        /// <returns>Returns true if the insertion was successful, otherwise false.</returns>
        public bool InsertRow(string table, string values)
        {
            //create query string including the table and values specified by the user
            string query = "INSERT INTO " + table + " VALUES(" + values + ")";

            if (this.OpenConnection() == true)
            {
                try
                {
                    //create a MySQL command and execute it
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch (MySqlException ex)
                {
                    this.CloseConnection();
                    logger.Log(ex.Message);
                    return false;
                }
            }
            return false;
        }



        /// <summary>
        /// Inserts a row into a relation in the database.
        /// String for table must be formatted as follows: "tableName"
        /// String for values must be formatted as follows: "column1='value1', column2='value2'..."
        /// String for location must be formatted as follows: "column='value'"
        /// </summary>
        /// <param name="table"></param>
        /// <param name="values"></param>
        /// <param name="location"></param>
        /// <returns>Returns true if the insertion was successful, otherwise false.</returns>
        public void UpdateRow(string table, string values, string location)
        {
            string query = "UPDATE " + table + " SET " + values + " WHERE " + location;

            //Open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }



        /// <summary>
        /// Inserts a row into a relation in the database.
        /// String for table must be formatted as follows: "tableName"
        /// String for location must be formatted as follows: "column='value'"
        /// </summary>
        /// <param name="table"></param>
        /// <param name="location"></param>
        public void DeleteRow(string table, string location)
        {
            string query = "DELETE FROM " + table + " WHERE " + location;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }



        /// <summary>
        /// Deletes all rows in a table.
        /// String for table must be formatted as follows: "tableName"
        /// </summary>
        /// <param name="table"></param>
        public void ClearTable(string table)
        {
            string query = "DELETE FROM " + table;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }



        /// <summary>
        /// Gets data from a table in a database.
        /// String for table must be formatted as follows: "tableName"
        /// String for columns must be formatted as follows: "column1, column2..."
        /// </summary>
        /// <param name="table"></param>
        /// <param name="columns"></param>
        /// <returns>Returns a dynamic array of lists of strings which contain the specified data that was retrieved.
        /// The first index is the column, the second index is the row.</returns>
        public bool RetrieveFromColumns(string table, string columns, out List<List<string>> output)
        {
            string query = "SELECT * FROM " + table;


            //parse columns
            char[] columnNameDelimiter = { ',', ' ' };
            string[] columnNames = columns.Split(columnNameDelimiter, StringSplitOptions.RemoveEmptyEntries);


            //create dynamic array of lists of strings in which to store data
            List<List<string>> manyColumns = new List<List<string>>();
            foreach (string s in columnNames)
            {
                List<string> singleColumn = new List<string>();
                manyColumns.Add(singleColumn);
            }
            output = manyColumns;

            //attempt to read from database
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    int numberOfColumns = manyColumns.Count;

                    for (int i = 0; i < numberOfColumns; ++i)
                    {
                        if (!DataRecordExtensions.HasColumn(dataReader, columnNames[i]))
                        {
                            return false;
                        }
                    }

                    while (dataReader.Read())
                    {


                        for (int i = 0; i < numberOfColumns; ++i)
                        {
                            manyColumns[i].Add(dataReader[columnNames[i]] + "");
                        }
                    }

                    dataReader.Close();
                    this.CloseConnection();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Logger logger = new Logger(ConfigurationManager.AppSettings["logpath"]);
                logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
            }
            return false;
        }



        /// <summary>
        /// Gets data from a table in a database, specifying a value to look for.
        /// Effectively issues a SELECT * FROM `table` WHERE `column`='value' to the database
        /// String for table must be formatted as follows: "tableName"
        /// String for requestColumns must be formatted as follows: "column1, column2..."
        /// String for lookupColumn must be formatted as follows: "columnName"
        /// String for value must be formatted as follows: "value"
        /// </summary>
        /// <param name="table"></param>
        /// <param name="requestColumns"></param>
        /// <param name="lookupColumn"></param>
        /// <param name="value"></param>
        /// <returns>Returns a dynamic array of lists of strings which contain the specified data that was retrieved.</returns>
        public bool RetrieveFromColumnsWithLookup(string table, string requestColumns, string lookupColumn, string value, out List<List<string>> output)
        {
            string query = "SELECT * FROM " + table + " WHERE " + lookupColumn + "=" + value;

            //parse columns
            char[] columnNameDelimiter = { ',', ' ' };
            string[] columnNames = requestColumns.Split(columnNameDelimiter, StringSplitOptions.RemoveEmptyEntries);


            //create dynamic array of lists of strings in which to store data
            List<List<string>> manyColumns = new List<List<string>>();
            foreach (string s in columnNames)
            {
                List<string> singleColumn = new List<string>();
                manyColumns.Add(singleColumn);
            }
            output = manyColumns;

            // check to make sure that there is a value to look up
            if (value != "")
            {
                //attempt to read from database
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        int numberOfColumns = manyColumns.Count;

                        for (int i = 0; i < numberOfColumns; ++i)
                        {
                            if (!DataRecordExtensions.HasColumn(dataReader, columnNames[i]))
                            {
                                return false;
                            }
                        }

                        while (dataReader.Read())
                        {


                            for (int i = 0; i < numberOfColumns; ++i)
                            {
                                manyColumns[i].Add(dataReader[columnNames[i]] + "");
                            }
                        }

                        dataReader.Close();
                        this.CloseConnection();
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    Logger logger = new Logger(ConfigurationManager.AppSettings["logpath"]);
                    logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
                }
            }
            return false;
        }




        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //increment column by day(s)
        public bool incrementDay(string table, string column, int increment, out List<List<string>> output)
        {
            string query = "SELECT * DATEADD(day, " + increment + ", *) AS * FROM " + table;
            Console.WriteLine(query);

            //parse columns
            char[] columnNameDelimiter = { ',', ' ' };
            string[] columnName = column.Split(columnNameDelimiter, StringSplitOptions.RemoveEmptyEntries);


            //create dynamic array of lists of strings in which to store data
            List<List<string>> oneColumn = new List<List<string>>();
            foreach (string s in columnName)
            {
                List<string> singleColumn = new List<string>();
                oneColumn.Add(singleColumn);
            }
            output = oneColumn;

            //attempt to read from database
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    int numberOfColumns = oneColumn.Count;

                    for (int i = 0; i < numberOfColumns; ++i)
                    {
                        if (!DataRecordExtensions.HasColumn(dataReader, columnName[i]))
                        {
                            return false;
                        }
                    }

                    while (dataReader.Read())
                    {
                        for (int i = 0; i < numberOfColumns; ++i)
                        {
                            oneColumn[i].Add(dataReader[columnName[i]] + "");
                        }
                    }

                    dataReader.Close();
                    this.CloseConnection();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Logger logger = new Logger(ConfigurationManager.AppSettings["logpath"]);
                logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
            }
            return false;
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }


    }
}