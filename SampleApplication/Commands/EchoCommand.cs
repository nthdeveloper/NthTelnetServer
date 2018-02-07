using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NthDeveloper.TelnetServer;

namespace SampleApplication.Commands
{
    class EchoCommand : ITelnetCommand
    {
        CommandParameter[] m_Parameters;

        public string CommandName
        {
            get { return "echo"; }
        }

        public string Description
        {
            get { return "Echos the entered message."; }
        }

        public IEnumerable<CommandParameter> Parameters { get { return m_Parameters; } }

        public EchoCommand()
        {
            m_Parameters = new CommandParameter[]
            {
                new CommandParameter("message", true, "Your message.")
            };
        }

        public TelnetCommandResult Execute(Dictionary<string, string> parameters)
        {
            string _enteredMessage = String.Empty;
            if (parameters.ContainsKey("message"))
                _enteredMessage = parameters["message"];

            return TelnetCommandResult.Success("You entered:"+_enteredMessage);
        }
    }
}
