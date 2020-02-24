# Serilog.Sinks.Bugsnag [![NuGet Version](http://img.shields.io/nuget/v/Serilog.Sinks.Bugsnag.svg?style=flat)](https://www.nuget.org/packages/Serilog.Sinks.Bugsnag/) [![Documentation](https://img.shields.io/badge/docs-wiki-yellow.svg)](https://github.com/serilog/serilog/wiki) [![Join the chat at https://gitter.im/serilog/serilog](https://img.shields.io/gitter/room/serilog/serilog.svg)](https://gitter.im/serilog/serilog) [![Help](https://img.shields.io/badge/stackoverflow-serilog-orange.svg)](http://stackoverflow.com/questions/tagged/serilog)

A Serilog sink that writes log events to Bugsnag.

### Getting started

To use the sink, first install the [NuGet package](https://nuget.org/packages/serilog.sinks.bugsnag):

```powershell
Install-Package Serilog.Sinks.Bugsnag
```

Then enable the sink using `WriteTo.Bugsnag(new Configuration { ApiKey="_YOU_API_KEY_"})`:

```csharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.Bugsnag(new BugsnagConfiguration { ApiKey="_YOU_API_KEY_"})
    .CreateLogger();
    
Log.Error(new Exception("Error"));
```

_Copyright &copy; 2017 Serilog Contributors - Provided under the [Apache License, Version 2.0](http://apache.org/licenses/LICENSE-2.0.html)._