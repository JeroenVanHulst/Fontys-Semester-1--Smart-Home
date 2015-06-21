using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace ProftaakSmartHome.Classes
{
    public class Database
    {
        public static SQLiteConnection Connection { get; set; }
        private static SQLiteCommand _command;

        public static readonly string Filename = "Database.db";
        public static SQLiteCommand Command { get { return _command; } }
        public static Guid PreviousHash;

        public static string Query
        {
            set
            {
                PrepareConnection();
                _command = new SQLiteCommand(value, Connection);
            }
        }

        public static void OpenConnection()
        {
            // Checks if the connection is not already open
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        public static void CloseConnection()
        {
            // Checks if the connection is not already closed
            if (Connection.State != ConnectionState.Closed)
            {
                //Dispose the SQLite adapter settings
                Command.Dispose();
                GC.Collect();
                Connection.Close();
            }
        }

        /// <summary>
        /// Checks whether the database exists or not. If it doesn't, generates an empty database and fills it with the default schemas.
        /// Initializes the database connection if it isn't connected.
        /// </summary>
        private static void PrepareConnection()
        {
            var createNew = !File.Exists(Filename);

            if (createNew)
            {
                SQLiteConnection.CreateFile(Filename);
                GenerateSchemas();
            }

            if (Connection == null)
            {
                Connection = new SQLiteConnection(String.Format("Data Source={0};Version=3", Filename));
            }
        }

        /// <summary>
        /// Generates DB schemas based on the SQL statements in databaseExport.sql
        /// Default tables are: device, device_group, devicetypes, groups, permissions, users
        /// </summary>
        private static void GenerateSchemas(bool addDummyData = false)
        {
            OpenConnection();

            var query = string.Empty;
            var lines = File.ReadAllLines("databaseExport.sql");

            query = lines.Aggregate(query, (current, line) => current + line); // Puts every line in a single string.
            Query = query;

            Command.ExecuteNonQuery();

            CloseConnection();

            if (addDummyData)
            {
                GenerateDummyData();
            }
        }

        /// <summary>
        /// Inserts dummy data into the database, after clearing all data and resetting the auto increments
        /// </summary>
        private static void GenerateDummyData()
        {
            OpenConnection();

            var query = string.Empty;
            var lines = File.ReadAllLines("dummyData.sql");

            query = lines.Aggregate(query, (current, line) => current + line); // Puts every line in a single string.
            Query = query;

            Command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
