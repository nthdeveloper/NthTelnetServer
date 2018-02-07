namespace NthDeveloper.TelnetServer
{
    public interface ITelnetService
    {
        bool IsRunning { get; }
        TelnetServiceSettings Settings { get; }

        bool Start(TelnetServiceSettings settings);
        void Stop();
    }
}