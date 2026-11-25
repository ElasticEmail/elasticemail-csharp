#:package ElasticEmail@4.4.0

// Updates the campaign "hello campaign": same template and list, new subject.
// Required API key access level: ModifyCampaigns
// Run: dotnet run updateCampaign.cs

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

var campaign = new Campaign(
    name: "hello campaign",
    status: CampaignStatus.Draft,
    content: new List<CampaignTemplate>
    {
        new CampaignTemplate(
            from: "myemail@domain.com",
            replyTo: "myemail@domain.com",
            subject: "Hello again",
            templateName: "hello_template"
        )
    },
    recipients: new CampaignRecipient(listNames: new List<string> { "my list name" })
);

try
{
    Campaign result = await campaigns.CampaignsByNamePutAsync(name, campaign);
    Console.WriteLine(result.ToJson());
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
