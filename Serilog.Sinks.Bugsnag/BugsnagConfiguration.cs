using Bugsnag;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Serilog.Sinks.Bugsnag
{
    public class BugsnagConfiguration : IConfiguration
    {
        public string ApiKey { get; set; }

        public Uri Endpoint { get; set; }

        public bool AutoNotify { get; set; }

        public string ReleaseStage { get; set; }

        public string[] NotifyReleaseStages { get; set; }

        public string AppVersion { get; set; }

        public string AppType { get; set; }

        public string[] ProjectRoots { get; set; }

        public string[] ProjectNamespaces { get; set; }

        public Type[] IgnoreClasses { get; set; }

        public KeyValuePair<string, object>[] GlobalMetadata { get; set; }

        public string[] MetadataFilters { get; set; }

        public bool AutoCaptureSessions { get; set; }

        public Uri SessionEndpoint { get; set; }

        public TimeSpan SessionTrackingInterval { get; set; }

        public IWebProxy Proxy { get; set; }

        public int MaximumBreadcrumbs { get; set; }
    }
}
