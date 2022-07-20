# Statistic class

This guide will walk you through the process of creating basic methods for statistic using the C# library.

## What statistics are returned?
When using Elastic Email you send emails to your contacts from that we create some statistics reports for you eg. number of emails sent, number of delivered messages, number of bounced messages, number of unsubscribed messages etc.

## Preparation
Create a Visual Studio project of your choosing, that's using at least .NET Framework 4.8.

Then, install our NuGet Package from https://www.nuget.org/packages/ElasticEmail/ in your project.

## Let's dig into the code
In the statistic class load library namespaces using lines below:

```cs
using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;
```

Below code you will repeat in all statistic's methods:
Generate and use your API key (remember to check a required access level):

```cs
Configuration config = new Configuration();
// Configure API key authorization: apikey
config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
```

Create an instance of StatisticsApi that will be used to work with statistic's methods.

```cs
var apiInstance = new StatisticsApi(config);
```

# Load statistics

*Required Access Level: ViewReports*

First you need to specify a date range:
- from date
- to date – optional

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/statisticsGet

```cs
DateTime from = new DateTime(2022, 01, 17);
DateTime to = DateTime.Today;
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a statistic data.
Finally, call the API to load statistics:

```cs
try
{
    return apiInstance.StatisticsGet(from, to);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling StatisticsApi.StatisticsGet: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public LogStatusSummary LoadStatistics()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new StatisticsApi(config);

    /**
        * Load statistics
        * Example api call that loads basic statistics.
        */

    DateTime from = new DateTime(2022, 01, 17);
    DateTime to = DateTime.Today;

    try
    {
        return apiInstance.StatisticsGet(from, to);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling StatisticsApi.StatisticsGet: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Load campaigns statistics

*Required Access Level: ViewChannels*

Campaigns statistics reponse is paginated you need to specfiy pagination options:
- limit – maximum returned items, limit = 0 means to return everything till the end of the list
- offset – how many items should be skipped from begging

Eg. to return first 20 elements specify pagination options as follows:

```cs
int limit = 20;
int offset = 0;
```

Let's fetch everthing:

```cs
int limit = 0;
int offset = 0;
```

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/statisticsCampaignsByNameGet

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display statistics data.
Finally, call the API to load campaigns statistics:

```cs
try
{
    return apiInstance.StatisticsCampaignsGet(limit, offset);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling StatisticsApi.StatisticsCampaignsGet: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public List<ChannelLogStatusSummary> LoadCampaignsStats()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new StatisticsApi(config);

    /**
        * Load campaigns stats
        * Example api call that loads a list of your campaigns' stats.
        */

    int limit = 0;
    int offset = 0;

    try
    {
        return apiInstance.StatisticsCampaignsGet(limit, offset);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling StatisticsApi.StatisticsCampaignsGet: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Load channels statistics

*Required Access Level: ViewChannels*

Channels statistics reponse is paginated you need to specfiy pagination options:
- limit – maximum returned items, limit = 0 means to return everything till the end of the list
- offset – how many items should be skipped from begging

Eg. to return first 20 elements specify pagination options as follows

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/statisticsChannelsGet

```cs
int limit = 20;
int offset = 0;
```

Let's fetch everthing:

```cs
int limit = 0;
int offset = 0;
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display statistics data.
Finally, call the API to load channels statistics:

```cs
try
{
    return apiInstance.StatisticsChannelsGet(limit, offset);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling StatisticsApi.StatisticsChannelsGet: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public List<ChannelLogStatusSummary> LoadChannelsStats()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new StatisticsApi(config);

    /**
        * Load channels stats
        * Example api call that loads a list of your channels' stats.
        */

    int limit = 0;
    int offset = 0;

    try
    {
        return apiInstance.StatisticsChannelsGet(limit, offset);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling StatisticsApi.StatisticsChannelsGet: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

## Run the code
Simply run your project and be sure that the code we wrote can be reached.