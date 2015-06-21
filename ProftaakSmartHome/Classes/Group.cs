using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProftaakSmartHome.Interfaces;

namespace ProftaakSmartHome.Classes
{
    /// <summary>
    /// A group represents a collection of Devices, with a given ID and Name.
    /// </summary>
    public class Group : IDatabaseObject
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Name { get; set; }

        [Browsable(false)]
        public List<Device> Devices { get; private set; }

        public Group(string name)
        {
            Name = name;
            Devices = new List<Device>();
        }

        public Group(int id, string name, List<Device> devices)
        {
            Devices.AddRange(devices);
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public void Update()
        {
            var query = string.Format("UPDATE groups SET name = '{0}' WHERE groupid = {1}", Name, Id);
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public bool Remove()
        {
            var query = "DELETE FROM device_group WHERE groupid=" + Id + "; DELETE FROM groups WHERE id=" + Id;
            Database.Query = query;

            try
            {
                Database.OpenConnection();
                Database.Command.ExecuteNonQuery();
                Database.CloseConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
            var queryDevices = "SELECT * FROM device d WHERE d.deviceid IN(SELECT deviceid FROM device_group WHERE groupid = ";

            Database.Query = queryGroups;
            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();

            var groups = new List<Group>();

            while (reader.Read())
            {
                groups.Add(new Group(reader["name"].ToString()){Id = Convert.ToInt32(reader["groupid"])});
            }

            foreach (var group in groups)
            {
                Database.Query = string.Format("{0}{1})",queryDevices, group.Id);
                reader = Database.Command.ExecuteReader();
                while (reader.Read())
                {
                    var device = new Device(Convert.ToInt32(reader["deviceid"]), reader["name"].ToString(),
                        Convert.ToInt32(reader["value"]),
                        (DeviceType) reader["type"])
                    {OnOff = Convert.ToBoolean(reader["status"])}; // Create new device object
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
            var queryDevices = "SELECT * FROM device d WHERE d.deviceid IN(SELECT deviceid FROM device_group WHERE groupid = ";
            Database.Query = queryGroup;
   
            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                result = new Group(reader["name"].ToString()) {Id = Convert.ToInt32(reader["groupid"])};
                Database.Query = string.Format("{0}{1})", queryDevices, result.Id);
                var deviceReader = Database.Command.ExecuteReader();

                while (deviceReader.Read())
                {
                    result.Devices.Add(new Device(Convert.ToInt32(deviceReader["deviceid"]), deviceReader["name"].ToString(),
                        Convert.ToInt32(deviceReader["value"]), (DeviceType) deviceReader["type"])
                    {
                        OnOff = Convert.ToBoolean(deviceReader["status"])
                    });
                }
            }
            else
            {
                return null;
            }

            return result;
        }

        public static Group GetGroupByName(string name)
        {
            Group result;
            var queryGroup = "SELECT * FROM groups WHERE name ='" + name +"'";
            var queryDevices = "SELECT * FROM device d WHERE d.deviceid IN(SELECT deviceid FROM device_group WHERE groupid = ";
            Database.Query = queryGroup;

            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();

            if (reader.HasRows)
            {
                result = new Group(reader["name"].ToString()) {Id = Convert.ToInt32(reader["id"])};
                Database.Query = string.Format("{0}{1})", queryDevices, result.Id);
                var deviceReader = Database.Command.ExecuteReader();

                while (deviceReader.Read())
                {
                    result.Devices.Add(new Device((int) deviceReader["deviceid"], deviceReader["name"].ToString(),
                        (int) deviceReader["value"], (DeviceType) deviceReader["type"])
                    {
                        OnOff = Convert.ToBoolean(reader["status"])
                    });
                }
            }
            else
            {
                return null;
            }

            Database.CloseConnection();

            return result;
        }

        public void UpdateDevices()
        {
            var queryRemove = "DELETE FROM device_group WHERE groupid = " + Id;
            Database.Query = queryRemove;
            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();

            foreach (var device in Devices)
            {
                var query = string.Format("INSERT INTO device_group VALUES ({0}, {1})",device.Id, Id);
                Database.Query = query;
                Database.OpenConnection();
                Database.Command.ExecuteNonQuery();
                Database.CloseConnection();
            }
        }
        #endregion
    }
}
