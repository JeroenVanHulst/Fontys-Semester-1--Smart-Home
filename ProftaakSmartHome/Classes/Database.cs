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
            // Controleer of de verbinding niet al open is
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public static void CloseConnection()
        {
            // Controleer of de verbinding niet al gesloten is
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
                SQLiteConnection.CreateFile(_filename+"new");
            }

            if (_connection == null)
            {
                _connection = new SQLiteConnection(String.Format("Data Source={0};Version=3", _filename));
            }
        }
    }
}
