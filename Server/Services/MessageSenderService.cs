using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Server.Classes;

namespace Server.Services
{
    public class MessageSenderService
    {
        public SerialPortObject SerialPortObject;

        private string _startChar = "%";

        private string _endChar = "#";

        private string _paramaterChar = ":";

        private string _listItemChar = "*";

        private string _listStartChar = "<";

        private string _listEndChar = ">";

        public MessageSenderService(SerialPortObject serialPort)
        {
            SerialPortObject = serialPort;
        }

        /// <summary>
        /// Build turn light on message and send the message to the arduino
        /// </summary>
        public bool TurnLightOn(int pin)
        {
            return sendMessage(string.Format("{0}LIGHT_ON{1}{2}{3}", _startChar, _paramaterChar, pin, _endChar));
        }

        /// <summary>
        /// Build turn light off message and send the message to the arduino
        /// </summary>
        public bool TurnLightOff(int pin)
        {
            return sendMessage(string.Format("{0}LIGHT_OFF{1}{2}{3}", _startChar, _paramaterChar, pin, _endChar));
        }

        /// <summary>
        /// Build edit light value message and send the message to the arduino
        /// </summary>
        public bool SetLightValue(int pin, int value)
        {
            return sendMessage(string.Format("{0}LIGHT_EDIT{1}{2};{3}{4}", _startChar, _paramaterChar, pin, value, _endChar));
        }

        /// <summary>
        /// Build get all lights message and send the message to the arduino
        /// </summary>
        public bool RequestAllLights()
        {
            return sendMessage(string.Format("{0}LIGHT_ALL{1}", _startChar, _endChar));
        }

        /// <summary>
        /// Send message to the arduino
        /// </summary>
        private bool sendMessage(string message)
        {
            try
            {
                if (!SerialPortObject.SerialPort.IsOpen) throw new Exception();
                SerialPortObject.SerialPort.Write(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
    }
}
