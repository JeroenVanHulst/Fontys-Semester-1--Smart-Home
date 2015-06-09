using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakSmartHome.Classes
{
    class Database
    {
        private static readonly string _filename = "Database.db";
        private static SQLiteConnection _connection;
        private static SQLiteCommand _command;

        public static SQLiteCommand Command { get { return _command; } }
        public static string Query
        {
            set
            {
                PrepareConnection();
                _command = new SQLiteCommand(value, _connection);
            }
        }

        public static void OpenConnection()
        {
            // Checks if the connection is not already open
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public static void CloseConnection()
        {
            // Checks if the connection is not already closed
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        private static void PrepareConnection()
        {
            var createNew = !File.Exists(_filename);

            if (createNew)
            {
                SQLiteConnection.CreateFile(_filename);
                GenerateSchemas();
            }

            if (_connection == null)
            {
                _connection = new SQLiteConnection(String.Format("Data Source={0};Version=3", _filename));
            }
        }

        private static void GenerateSchemas()
        {
            OpenConnection();

            var query = string.Empty;
            var lines = File.ReadAllLines("databaseExport.sql");

            query = lines.Aggregate(query, (current, line) => current + line); // Puts every line in a single string.
            Query = query;

            Command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
