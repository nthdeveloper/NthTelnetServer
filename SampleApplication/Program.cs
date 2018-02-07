using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NthDeveloper.TelnetServer;
using SampleApplication.Commands;

namespace SampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Telnet service
            TelnetService _telnetService = new TelnetService(
                new TCPServer(), //Multi client TCP server
                new ITelnetCommand[]//Custom commands we implemented
            {
                new HelloCommand(),
                new EchoCommand()
            });

            //Settings for the Telnet service
            TelnetServiceSettings _telnetSettings = new TelnetServiceSettings();
            _telnetSettings.PromtText = "SampleApp@" + Environment.MachineName;
            _telnetSettings.PortNumber = 32202;
            _telnetSettings.Charset = Encoding.Default.CodePage;

            //Start listening for incoming connections
            _telnetService.Start(_telnetSettings);

            Console.WriteLine("Telnet Service is running.\r\nPress enter to stop application.");
            Console.ReadLine();

            //Stop service. Always stop the service when the application is shutting down.
            _telnetService.Stop();
        }
    }
}
