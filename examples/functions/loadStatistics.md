# Load Statistics

This guide shows how to load delivery statistics for your account using the Elastic Email C# library.

*Required Access Level: ViewReports*

## What do the statistics show?

Elastic Email counts what happened to your messages: recipients, deliveries, bounces, opens, clicks, unsubscribes and complaints.

## Preparation

Install the [.NET SDK](https://dotnet.microsoft.com/download) 10 or later.

Create a file named `loadStatistics.cs`. Its first line, `#:package ElasticEmail@4.4.0`, tells `dotnet run` to download the `ElasticEmail` package from NuGet, so you don't need a project file.

Set your API key in the `ELASTICEMAIL_API_KEY` environment variable. Create the key in your [API settings](https://help.elasticemail.com/en/articles/4799160-api-settings) with the access level above:

```bash
export ELASTICEMAIL_API_KEY="your-api-key"
```

## Let's dig into the code

Load the library's namespaces:

```csharp
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;
```

Read the API key from the environment, and stop with a clear message if it isn't set:

```csharp
var apiKey = Environment.GetEnvironmentVariable("ELASTICEMAIL_API_KEY");
if (string.IsNullOrEmpty(apiKey))
{
    Console.Error.WriteLine("Set the ELASTICEMAIL_API_KEY environment variable to your Elastic Email API key.");
    return 1;
}
```

Configure the client. `BasePath` is optional and defaults to `https://api.elasticemail.com/v4`:

```csharp
var config = new Configuration();
config.BasePath = "https://api.elasticemail.com/v4";
config.ApiKey.Add("X-ElasticEmail-ApiKey", apiKey);
```

Create an instance of `StatisticsApi`:

```csharp
var statistics = new StatisticsApi(config);
```

Pick the time range. The start date is required; the end date is optional and defaults to now:

```csharp
var since = DateTime.UtcNow.AddDays(-30);
var until = DateTime.UtcNow;
```

Call `StatisticsGetAsync` and print the totals. Errors from the API arrive as an `ApiException`, with the HTTP status in `ErrorCode`:

```csharp
try
{
    LogStatusSummary result = await statistics.StatisticsGetAsync(since, until);
    Console.WriteLine($"From {since:yyyy-MM-dd} to {until:yyyy-MM-dd}:");
    Console.WriteLine(result.ToJson());
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
```

## The whole code to copy and paste

```csharp
#:package ElasticEmail@4.4.0

// Loads delivery statistics for your account for the last 30 days.
// Required API key access level: ViewReports
// Run: dotnet run loadStatistics.cs

using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

var apiKey = Environment.GetEnvironmentVariable("ELASTICEMAIL_API_KEY");
if (string.IsNullOrEmpty(apiKey))
{
    Console.Error.WriteLine("Set the ELASTICEMAIL_API_KEY environment variable to your Elastic Email API key.");
    return 1;
}

var config = new Configuration();
config.BasePath = "https://api.elasticemail.com/v4";
config.ApiKey.Add("X-ElasticEmail-ApiKey", apiKey);

var statistics = new StatisticsApi(config);

var since = DateTime.UtcNow.AddDays(-30);
var until = DateTime.UtcNow;

try
{
    LogStatusSummary result = await statistics.StatisticsGetAsync(since, until);
    Console.WriteLine($"From {since:yyyy-MM-dd} to {until:yyyy-MM-dd}:");
    Console.WriteLine(result.ToJson());
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
```

## Run the code

```bash
dotnet run loadStatistics.cs
```
