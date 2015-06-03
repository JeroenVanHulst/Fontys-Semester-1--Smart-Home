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
            // TODO: Implementeren update functie
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
