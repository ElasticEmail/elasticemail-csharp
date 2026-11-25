#:package ElasticEmail@4.4.0

// Deletes the campaign "hello campaign".
// Required API key access level: ModifyCampaigns
// Run: dotnet run deleteCampaign.cs

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

var campaigns = new CampaignsApi(config);

var name = "hello campaign";

try
{
    await campaigns.CampaignsByNameDeleteAsync(name);
    Console.WriteLine($"Campaign \"{name}\" deleted.");
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
