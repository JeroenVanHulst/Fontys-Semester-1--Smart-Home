using System.Collections.Generic;
using ProftaakSmartHome.Interfaces;

namespace ProftaakSmartHome.Classes
{
    /// <summary>
    /// A group represents a collection of Devices, with a given ID and Name.
    /// </summary>
    public class Group : IDatabaseObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Device> Devices { get; private set; }

        public Group(int id, string name)
        {
            Id = id;
            Name = name;
            Devices = new List<Device>();
        }

        public Group(int id, string name, List<Device> devices) : this(id, name)
        {
            Devices.AddRange(devices);
        }

        public void Update()
        {
            var query = "UPDATE groups SET name = '" + Name + "' WHERE groupid = " + Id;
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void Remove()
        {
            var query = "DELETE FROM device_group WHERE groupid=" + Id + "; DELETE FROM groups WHERE id=" + Id;
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void Insert()
        {
            var query = "INSERT INTO groups (name) VALUES ('" + Name +"')";
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        #region DB queries
        public static List<Group> GetAllGroups()
        {
            var queryGroups = "SELECT * FROM groups";
            var queryLights = "SELECT d.* FROM device d, device_group dg, groups g WHERE d.deviceid = dg.deviceid AND g.groupid = ";

            Database.Query = queryGroups;
            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();

            var groups = new List<Group>();

            while (reader.Read())
            {
                groups.Add(new Group((int)reader["groupid"], reader["name"].ToString()));
            }

            foreach (var group in groups)
            {
                Database.Query = queryLights + group.Id;
                reader = Database.Command.ExecuteReader();
                while (reader.Read())
                {
                    Device device = new Device((int)reader["deviceid"], reader["name"].ToString(), (int)reader["value"],
                        (DeviceType)reader["type"]); // Create new device object
                    group.Devices.Add(device); // And add it to this particular group
                }
            }
            
            Database.CloseConnection();

            return groups;
        }

        public static Group GetGroupById(int id)
        {
            Group result;
            var queryGroup = "SELECT * FROM groups WHERE groupid = " + id;
            Database.Query = queryGroup;
   
            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();

            if (reader.HasRows)
            {
                result = new Group((int) reader["groupid"], reader["name"].ToString());
                var queryDevice = "SELECT d.* FROM device d, device_group dg, group g WHERE d.deviceid = dg.deviceid AND g.groupid = " + result.Id;
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

        public static Group GetGroupByName(string name)
        {
            Group result;
            var queryGroup = "SELECT * FROM groups WHERE name ='" + name +"'";
            Database.Query = queryGroup;

            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();

            if (reader.HasRows)
            {
                result = new Group((int)reader["groupid"], reader["name"].ToString());
                var queryDevice = "SELECT d.* FROM device d, device_group dg, groups g WHERE d.deviceid = dg.deviceid AND g.groupid = " + result.Id;
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

        public void AddDeviceToGroup(Device d)
        {
            Database.Query = "INSERT INTO device_group VALUES (" + d.Id + ", " + Id + ");";
            Devices.Add(d);
        }
        #endregion
    }
}
