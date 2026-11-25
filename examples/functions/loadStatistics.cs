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
