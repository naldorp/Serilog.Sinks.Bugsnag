using Serilog.Configuration;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.Bugsnagg;
using System;

namespace Serilog
{
    public static class BugsnagSinkExtensions
    {
        public static LoggerConfiguration Bugsnag(this LoggerSinkConfiguration sinkConfiguration, Bugsnag.Configuration configuration, LogEventLevel restrictedToMinimumLevel = LogEventLevel.Verbose, LoggingLevelSwitch levelSwitch = null)
        {
            if (sinkConfiguration == null)
                throw new ArgumentNullException(nameof(sinkConfiguration));

            return sinkConfiguration.Sink(new BugsnagSink(configuration), restrictedToMinimumLevel, levelSwitch);
        }
    }
}
