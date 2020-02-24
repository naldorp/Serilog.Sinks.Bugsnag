using Bugsnag;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Sinks.Bugsnagg
{
    public class BugsnagSink : ILogEventSink
    {
        private readonly Client client;
        public BugsnagSink(IConfiguration configuration)
        {
            client = new Client(configuration);
        }

        public void Emit(LogEvent logEvent)
        {
            if(logEvent?.Exception != null)
            {
                client.Notify(logEvent.Exception);
            }
        }
    }
}
