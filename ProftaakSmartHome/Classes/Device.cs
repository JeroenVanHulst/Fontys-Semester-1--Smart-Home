using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using ProftaakSmartHome.Interfaces;

namespace ProftaakSmartHome.Classes
{
    public enum DeviceType
    {
        Light,
        DimmableLight,
        ServoMotor,
        StepperMotor,
        TemperatureSensor,
        LightSensor
    }

    public class Device : IDatabaseObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value;
        public DeviceType Type;

        public Device(int id, string name, int value, DeviceType type)
        {
            Id = id;
            Name = name;
            Value = value;
            Type = type;
        }
        
        public void Update()
        {
            var query = "UPDATE device SET name = '" + Name + "', value =" + Value + ", type =" + (int) Type;
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public bool Remove()
        {
            var query = "DELETE FROM device WHERE deviceid =" + Id;
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
            var query = "INSERT INTO device (name, value, type) VALUES('" + Name + "'," + 0 + ", " + (int) Type + ")";
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static List<Device> GetAllDevices()
        {
            var query = "SELECT * FROM device";
            Database.Query = query;

            var reader = Database.Command.ExecuteReader();
            var devices = new List<Device>();

            while (reader.Read())
            {
                Device device = new Device((int) reader["deviceid"], reader["name"].ToString(), (int) reader["value"],
                    (DeviceType) reader["type"]); // Create new device object
                devices.Add(device);
            }

            return devices;
        }
    }
}
