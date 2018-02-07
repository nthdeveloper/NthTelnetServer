using System;

namespace NthDeveloper.TelnetServer
{
    public class TelnetServiceSettings
    {        
        public bool ListenAllAdapters { get; set; } = true;
        public string LocalIPAddress { get; set; }
        public int PortNumber { get; set; } = 32202;
        public bool PasswordIsEnabled { get; set; }
        public string Password { get; set; }
        public int MaxLoginTryCount { get; set; } = 3;
        public int Charset { get; set; } = 20127;//US-ASCII
        public string PromtText { get; set; } = "TelnetService";

        public TelnetServiceSettings Clone()
        {
            return (TelnetServiceSettings)this.MemberwiseClone();
        }
    }
}
