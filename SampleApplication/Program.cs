using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NthDeveloper.TelnetServer;

namespace SampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TelnetService _telnetService = new TelnetService(null);

            TelnetServiceSettings _telnetSettings = new TelnetServiceSettings();
            _telnetSettings.PromtText = "SampleApp@" + Environment.MachineName;

            _telnetService.Start(_telnetSettings);

            Console.WriteLine("Telnet Service is running.\r\nPress enter to stop application.");
            Console.ReadLine();
            _telnetService.Stop();
        }
    }
}
