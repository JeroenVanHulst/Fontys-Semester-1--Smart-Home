using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Remove()
        {
            var query = "DELETE FROM device WHERE deviceid =" + Id;
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void Insert()
        {
            var query = "INSERT INTO device (name, value, type) VALUES('" + Name + "'," + 0 + ", " + (int) Type + ")";
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }
    }
}
