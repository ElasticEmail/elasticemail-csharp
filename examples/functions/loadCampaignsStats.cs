#:package ElasticEmail@4.4.0

// Loads delivery statistics for each campaign, up to 100 at a time.
// Required API key access level: ViewChannels
// Run: dotnet run loadCampaignsStats.cs

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
    List<ChannelLogStatusSummary> result = await statistics.StatisticsCampaignsGetAsync(limit: 100, offset: 0);
    foreach (var campaign in result)
    {
        Console.WriteLine($"{campaign.ChannelName}: {campaign.Recipients} recipients, {campaign.Delivered} delivered, {campaign.Opened} opened, {campaign.Clicked} clicked");
    }
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
