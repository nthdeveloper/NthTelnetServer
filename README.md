# Nth Telnet Service
Very simple Telnet server written in C#. You can add your own commands and enable password control for connecting to the telnet server.

## Features
- Very simple, can be used with only two lines of codes
- Supports multiple client connections at the same time
- Supports password protection
- Customizable Telnet prompt
- Built in help and exit commands
- You can add your own commands only by implementing a simple command interface

## How to use
- **The simplest way**
```csharp
//Create the TelnetService object
TelnetService _telnetService = new TelnetService(new ITelnetCommand[0]);

//Start with default settings
_telnetService.Start(new TelnetServiceSettings());
```

- **Start with custom settings**
```csharp
TelnetService _telnetService = new TelnetService(new ITelnetCommand[0]);

TelnetServiceSettings _telnetSettings = new TelnetServiceSettings();
_telnetSettings.PromtText = "SampleApp@" + Environment.MachineName;
_telnetSettings.PortNumber = 32202;
_telnetSettings.Charset = Encoding.Default.CodePage;
//Other settings..
_telnetService.Start(_telnetSettings);
```

- **Add custom commands**

You can pass your custom commands to the TelnetService as a constructor parameter
```csharp
TelnetService _telnetService = new TelnetService(new ITelnetCommand[]
{
    new HelloCommand(),
    new EchoCommand()
});
```

## Sample console screenshots

- Help command usage

![Help command usage](/Docs/images/help_usage.png)

- Custom command usage with not parameters and one parameter

![Help command usage](/Docs/images/sample_command_usages.png)
