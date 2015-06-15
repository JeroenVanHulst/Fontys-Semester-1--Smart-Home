using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        static void Main(string[] args)
        {
            Console.WriteLine("Starting server..");
            _arduinos = getArduinoPorts();
            _arduinos.ForEach(x => x.OpenConnection());
            _threads = new List<Thread>();

            foreach (var arduino in _arduinos)
            {
                var thread = new Thread(new MessageReaderService(arduino).Work);
                thread.Start();
                _threads.Add(thread);
            }

            while (!_quit)
            {
                Console.WriteLine("Server started!");
                if (Console.ReadLine() == "Exit")
                {
                    Console.WriteLine("Are you sure you want to stop the server? (y, n)");
                    if (Console.ReadLine() == "y") _quit = true;
                }
                //TODO Database uitlezen wanneer veranderingen optreden
            }

            foreach (var thread in _threads)
            {
                thread.Abort();
            }
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
