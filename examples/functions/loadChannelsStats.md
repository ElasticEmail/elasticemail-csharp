# Load Channels Statistics

This guide shows how to load delivery statistics for each channel using the Elastic Email C# library.

*Required Access Level: ViewChannels*

## What's a channel?

A channel groups the emails you send under one name, for example the `ChannelName` you set in a send's options or the campaign that sent them. Elastic Email keeps statistics per channel.

## Preparation

Install the [.NET SDK](https://dotnet.microsoft.com/download) 10 or later.

Create a file named `loadChannelsStats.cs`. Its first line, `#:package ElasticEmail@4.4.0`, tells `dotnet run` to download the `ElasticEmail` package from NuGet, so you don't need a project file.

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

Call `StatisticsChannelsGetAsync`. `limit` and `offset` page through the results. Print a line per channel. Errors from the API arrive as an `ApiException`, with the HTTP status in `ErrorCode`:

```csharp
try
{
    List<ChannelLogStatusSummary> result = await statistics.StatisticsChannelsGetAsync(limit: 100, offset: 0);
    foreach (var channel in result)
    {
        Console.WriteLine($"{channel.ChannelName}: {channel.Recipients} recipients, {channel.Delivered} delivered, {channel.Opened} opened, {channel.Clicked} clicked");
    }
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

// Loads delivery statistics for each channel, up to 100 at a time.
// Required API key access level: ViewChannels
// Run: dotnet run loadChannelsStats.cs

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

try
{
    List<ChannelLogStatusSummary> result = await statistics.StatisticsChannelsGetAsync(limit: 100, offset: 0);
    foreach (var channel in result)
    {
        Console.WriteLine($"{channel.ChannelName}: {channel.Recipients} recipients, {channel.Delivered} delivered, {channel.Opened} opened, {channel.Clicked} clicked");
    }
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
dotnet run loadChannelsStats.cs
```
