using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakSmartHome.Classes
{
    class Database
    {
        private static readonly string _filename = "Database.sqlite";
        private static SQLiteConnection _connection;
        private static SQLiteCommand _command;

        /// <summary>
        /// Stel de SQL query in die uitgevoerd moet gaan worden.
        /// </summary>
        public static string Query
        {
            set
            {
                PrepareConnection();
                command = new SQLiteCommand(value, connection);
            }
        }



    }
}
