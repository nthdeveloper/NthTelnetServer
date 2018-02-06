using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NthDeveloper.TelnetServer
{
    public struct TelnetCommandResult
    {
        public bool IsSucceeded { get; private set; }
        public string ResponseText { get; private set; }
        
        public TelnetCommandResult(bool isSucceeded, string responseText)
        {
            this.IsSucceeded = isSucceeded;
            this.ResponseText = responseText;
        }

        public static TelnetCommandResult Success(string responseText=null)
        {
            return new TelnetCommandResult(true, responseText);
        }

        public static TelnetCommandResult Fail(string responseText=null)
        {
            return new TelnetCommandResult(false, responseText);
        }
    }
}
