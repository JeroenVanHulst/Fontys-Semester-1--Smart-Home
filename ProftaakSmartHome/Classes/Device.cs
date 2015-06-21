using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using ProftaakSmartHome.Interfaces;

namespace ProftaakSmartHome.Classes
{
    public enum DeviceType // These are represented as 0, 1, 2, 3, etc in the database
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
        [Browsable(false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ComPort { get; set; }
        public int Value { get; set; }
        public bool OnOff { get; set; }
        [ReadOnly(true)]
        public DeviceType Type { get; set; }

        public int Pin { get; set; }

        public Device(string name, DeviceType type, string comPort, int pin)
        {
            Name = name;
            Type = type;
            Value = 0;
            ComPort = comPort;
            Pin = pin;
        }

        public Device(int id, string name, int value, DeviceType type)
        {
            Id = id;
            Name = name;
            Value = value;
            Type = type;
        }
        
        public void Update()
        {
            var query = string.Format("UPDATE device SET name = '{0}', value = {1}, type = {2}, status = {3} WHERE deviceid = {4}", Name, Value, (int) Type, Convert.ToInt32(OnOff), Id);
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

        public void Insert() // Unused, managed by server
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
            
            Database.OpenConnection();
            var reader = Database.Command.ExecuteReader();
            var devices = new List<Device>();

            while (reader.Read())
            {
                var device = new Device(Convert.ToInt32(reader["deviceid"]), reader["name"].ToString(), Convert.ToInt32(reader["value"]),
                    (DeviceType) reader["type"])
                {OnOff = Convert.ToBoolean(reader["status"])}; // Create new device object
                devices.Add(device);
            }

            Database.CloseConnection();

            return devices;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
