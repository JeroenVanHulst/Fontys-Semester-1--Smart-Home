using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProftaakSmartHome.Classes;
using Server.Classes;

namespace Server.Services
{
    public class MessageReaderService
    {
        private SerialPortObject _serialPortObject;

        private bool _stopWorking;

        private MessageBuilder _messageBuilder;

        public MessageReaderService(SerialPortObject serialPort)
        {
            _serialPortObject = serialPort;
            _messageBuilder = new MessageBuilder("%", "#");
        }

        /// <summary>
        /// Worker, runs until the thread stops
        /// </summary>
        public void Work()
        {
            while (!_stopWorking)
            {
                if (_serialPortObject.SerialPort.IsOpen && _serialPortObject.SerialPort.BytesToRead > 0)
                {
                    try
                    {
                        var dataFromSocket = _serialPortObject.SerialPort.ReadExisting();
                        _messageBuilder.Append(dataFromSocket);
                        ProcessMessages();
                    }
                    catch (Exception exception) // Not very nice to catch Exception...but for now it's good enough.
                    {
                        Console.WriteLine("Could not read from serial port: " + exception.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Find and process all buffered messages .
        /// </summary>
        private void ProcessMessages()
        {
            String message = _messageBuilder.FindAndRemoveNextMessage();
            while (message != null)
            {
                Console.WriteLine(_serialPortObject.ArduinoPort + ": " + message);
                MessageReceived(message);
                message = _messageBuilder.FindAndRemoveNextMessage();
            }
        }

        /// <summary>
        /// Split message and send it to other functions
        /// </summary>
        public void MessageReceived(string message)
        {
            message = message.Substring(1, message.Length - 2);
            if (message.StartsWith("<") && message.EndsWith(">"))
            {
                ReadDevices(message);
            }
        }

        /// <summary>
        /// Read all devices from a message and set it in the database
        /// </summary>
        public void ReadDevices(string message)
        {
            var devices = Device.GetAllDevices();
            if (message.StartsWith("<LIGHTS_LIST:"))
            {
                var itemStartIndex = message.IndexOf("*");
                var lights = message.Substring(itemStartIndex, message.IndexOf(">") - itemStartIndex).Split('*').ToList();
                foreach (var light in lights)
                {
                    var device = new Device("Light", DeviceType.Light, _serialPortObject.ArduinoPort, Convert.ToInt32(light));
                    device.Insert();
                }
            }
            else if (message.StartsWith("<LIGHTSPWM_LIST:"))
            {
                var itemStartIndex = message.IndexOf("*");
                var lights = message.Substring(itemStartIndex, message.IndexOf(">") - itemStartIndex).Split('*').ToList();
                foreach (var light in lights)
                {
                    var device = new Device("DimmableLight", DeviceType.DimmableLight, _serialPortObject.ArduinoPort, Convert.ToInt32(light));
                    device.Insert();
                }
            }
        }
    }
}
