using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProftaakSmartHome.Classes;
using Server.Classes;
using Server.Services;
using Timer = System.Timers.Timer;

namespace Server
{
    class Program
    {
        private static List<SerialPortObject> _arduinos;

        private static Timer _timer;

        private static bool _quit;

        private static List<Thread> _threads;

        private static List<MessageSenderService> _messageSenders;

        private static FileSystemWatcher _watcher;

        private static List<Device> _devices;

        static void Main(string[] args)
        {
            Console.WriteLine("Starting server..");
            _arduinos = getArduinoPorts();
            _arduinos.ForEach(x => x.OpenConnection());
            _threads = new List<Thread>();
            _messageSenders = new List<MessageSenderService>();

            _devices = new List<Device>();

            foreach (var arduino in _arduinos)
            {
                var thread = new Thread(new MessageReaderService(arduino).Work);
                thread.Start();
                _threads.Add(thread);
                var service = new MessageSenderService(arduino);
                _messageSenders.Add(service);
                service.RequestAllLights();
            }

            _watcher = new FileSystemWatcher
            {
                NotifyFilter =
                    NotifyFilters.LastAccess | NotifyFilters.LastWrite // These are the flags of change types to watch for
                    | NotifyFilters.FileName | NotifyFilters.DirectoryName,
                Path = Path.GetDirectoryName(Database.Filename),
                Filter = Path.GetFileName(Database.Filename)
            };
            _watcher.Changed += DatabaseOnChanged;
            _watcher.EnableRaisingEvents = true; // Begin watching

            while (!_quit)
            {
                Console.WriteLine("Server started!");
                if (Console.ReadLine() == "Exit")
                {
                    Console.WriteLine("Are you sure you want to stop the server? (y, n)");
                    if (Console.ReadLine() == "y") _quit = true;
                }
            }

            foreach (var thread in _threads)
            {
                thread.Abort();
            }
        }

        private static void DatabaseOnChanged(object sender, FileSystemEventArgs e)
        {
            var devices = Device.GetAllDevices();
            var newlist = new List<Device>();

            foreach (var device in devices)
            {
                if (_devices.Count != 0 && _devices.FirstOrDefault(x => x.Id == device.Id).OnOff != device.OnOff && device.OnOff)
                {
                    _messageSenders.FirstOrDefault(x => x.SerialPortObject.ArduinoPort == device.ComPort).TurnLightOn(device.Pin);
                }
                else if (_devices.Count != 0 && _devices.FirstOrDefault(x => x.Id == device.Id).OnOff != device.OnOff && !device.OnOff)
                {
                    _messageSenders.FirstOrDefault(x => x.SerialPortObject.ArduinoPort == device.ComPort).TurnLightOff(device.Pin);
                }

                if (_devices.Count != 0 && device.OnOff && _devices.FirstOrDefault(x => x.Id == device.Id).Value != device.Value)
                {
                    _messageSenders.FirstOrDefault(x => x.SerialPortObject.ArduinoPort == device.ComPort).SetLightValue(device.Pin, device.Value);
                }

                newlist.Add(device);
            }
            _devices = newlist;
        }

        //Get all ports from connected arduinos
        static List<SerialPortObject> getArduinoPorts()
        {
            var ports = new List<SerialPortObject>();
            foreach (var str in SerialPort.GetPortNames())
            {
                try
                {
                    var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity");

                    foreach (var o in searcher.Get())
                    {
                        var queryObj = (ManagementObject) o;
                        if (queryObj["Caption"] != null && queryObj["Caption"].ToString().Contains("Arduino"))
                        {
                            var obj = queryObj["Caption"].ToString();
                            var startIndex = obj.IndexOf('(') + 1;
                            var length = obj.IndexOf(')') - startIndex;
                            ports.Add(new SerialPortObject(obj.Substring(startIndex, length), 9600));
                        }
                    }
                }
                catch (ManagementException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return ports;
        }
    }
}
