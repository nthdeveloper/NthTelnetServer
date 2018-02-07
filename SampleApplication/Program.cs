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
            TelnetService _telnetService = new TelnetService(new ITelnetCommand[]
            {
                new HelloCommand(),
                new EchoCommand()
            });

            TelnetServiceSettings _telnetSettings = new TelnetServiceSettings();
            _telnetSettings.PromtText = "SampleApp@" + Environment.MachineName;
            _telnetSettings.PortNumber = 32202;
            _telnetSettings.Charset = Encoding.Default.CodePage;

            _telnetService.Start(_telnetSettings);

            Console.WriteLine("Telnet Service is running.\r\nPress enter to stop application.");
            Console.ReadLine();
            _telnetService.Stop();
        }
    }
}
