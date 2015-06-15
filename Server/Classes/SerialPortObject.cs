using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes
{
    public class SerialPortObject
    {
        public string ArduinoPort { get; set; }

        public int Speed { get; set; }

        public SerialPort SerialPort { get; private set; }

        public SerialPortObject(string port, int speed)
        {
            ArduinoPort = port;
            Speed = speed;
        }

        public void OpenConnection()
        {
            if (SerialPort == null)
            {
                SerialPort = new SerialPort(ArduinoPort, Speed);
            }

            if (SerialPort.IsOpen) return;

            SerialPort.Open();
        }

        public void CloseConnection()
        {
            if (SerialPort.IsOpen) SerialPort.Close();
        }
    }
}
