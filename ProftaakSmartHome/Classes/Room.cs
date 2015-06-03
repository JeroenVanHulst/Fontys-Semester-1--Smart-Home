using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakSmartHome.Classes
{
    public class Room : IDatabaseObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Device> Devices;

        public Room(int id, string name)
        {
            Id = id;
            Name = name;
            Devices = new List<Device>();
        }

        public Room(int id, string name, List<Device> devices) : this(id, name)
        {
            Devices.AddRange(devices);
        }

        public void Update()
        {
            var query = "UPDATE room SET name = '" + Name + "' WHERE roomid = " + Id;
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void Remove()
        {
            var query = "DELETE FROM device WHERE roomid=" + Id + "; DELETE FROM room WHERE id=" + Id;
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void Insert()
        {
            var query = "INSERT INTO room (name) VALUES ('" + Name +"')";
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        #region DB queries
        public static List<Room> GetAllRooms()
        {
            var queryRooms = "SELECT * FROM room";
            var queryLights = "SELECT * FROM device";

            Database.Query = queryRooms;
            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();

            var rooms = new List<Room>();

            while (reader.Read())
            {
                rooms.Add(new Room((int)reader["roomid"], reader["name"].ToString()));
            }

            Database.Query = queryLights;
            reader = Database.Command.ExecuteReader();
            while (reader.Read()) // For every light from the lights table
            {
                Device device = new Device((int) reader["deviceid"], reader["name"].ToString(), (int) reader["value"],
                    (DeviceType) reader["type"]); // Create new device object
                rooms.First(x => x.Id == (int)reader["roomid"]).Devices.Add(device); // If device roomID is equal to a room's ID, add it to its list of devices
            }
            
            Database.CloseConnection();

            return rooms;
        }

        public static Room GetRoomById(int id)
        {
            Room result;
            var queryRoom = "SELECT * FROM room WHERE roomid =" + id;
            Database.Query = queryRoom;
   
            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();

            if (reader.HasRows)
            {
                result = new Room((int) reader["roomid"], reader["name"].ToString());
                var queryDevice = "SELECT * FROM device WHERE roomid =" + result.Id;
                Database.Query = queryDevice;
                var deviceReader = Database.Command.ExecuteReader();

                while (deviceReader.Read())
                {
                    result.Devices.Add(new Device((int) deviceReader["deviceid"], deviceReader["name"].ToString(),
                        (int) deviceReader["value"], (DeviceType) deviceReader["type"]));
                }
            }
            else
            {
                return null;
            }

            Database.CloseConnection();

            return result;
        }
        

        public static Room GetRoomByName(string name)
        {
            Room result;
            var queryRoom = "SELECT * FROM room WHERE name ='" + name +"'";
            Database.Query = queryRoom;

            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();

            if (reader.HasRows)
            {
                result = new Room((int)reader["roomid"], reader["name"].ToString());
                var queryDevice = "SELECT * FROM device WHERE roomid =" + result.Id;
                Database.Query = queryDevice;
                var deviceReader = Database.Command.ExecuteReader();

                while (deviceReader.Read())
                {
                    result.Devices.Add(new Device((int)deviceReader["deviceid"], deviceReader["name"].ToString(),
                        (int)deviceReader["value"], (DeviceType)deviceReader["type"]));
                }
            }
            else
            {
                return null;
            }

            Database.CloseConnection();

            return result;
        }
        #endregion
    }
}
