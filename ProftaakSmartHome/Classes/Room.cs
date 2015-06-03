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

        public static List<Room> GetAllRooms()
        {
            var query = "SELECT * FROM room";
            var rooms = new List<Room>();

            foreach (var room in rooms)
            {
                
            }

            return rooms;
        }

        public static Room GetRoomById(int id)
        {
            var query = "SELECT * FROM room WHERE id";
            var room = new Room(0, "fsdfsd");

            return room;
        }

        public static Room GetRoomByName(string name)
        {
            var query = "SELECT * FROM room WHERE name";
            var room = new Room(0, "fsdfsd");

            return room;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }
    }
}
