# Add Campaign

This guide shows how to create a campaign using the Elastic Email C# library.

*Required Access Level: ModifyCampaigns*

## What's a campaign?

A campaign sends a template to the contacts in one or more lists or segments. It can go out right away, at a scheduled time, or stay as a draft until you start it.

## Preparation

Install the [.NET SDK](https://dotnet.microsoft.com/download) 10 or later.

Create a file named `addCampaign.cs`. Its first line, `#:package ElasticEmail@4.4.0`, tells `dotnet run` to download the `ElasticEmail` package from NuGet, so you don't need a project file.

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

Create an instance of `CampaignsApi`:

```csharp
var campaigns = new CampaignsApi(config);
```

Describe the campaign: its name, status, the template to send with sender and subject, and the lists to send to. `CampaignStatus.Draft` saves it without sending; use `CampaignStatus.Active` to start it. The `from` address must use a domain you've verified.

```csharp
var campaign = new Campaign(
    name: "hello campaign",
    status: CampaignStatus.Draft,
    content: new List<CampaignTemplate>
    {
        new CampaignTemplate(
            from: "myemail@domain.com",
            replyTo: "myemail@domain.com",
            subject: "Hello",
            templateName: "hello_template"
        )
    },
    recipients: new CampaignRecipient(listNames: new List<string> { "my list name" })
);
```

Call `CampaignsPostAsync` and print the created campaign. Errors from the API arrive as an `ApiException`, with the HTTP status in `ErrorCode`:

```csharp
try
{
    Campaign result = await campaigns.CampaignsPostAsync(campaign);
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

// Creates a draft campaign that sends the template "hello_template" to the list "my list name".
// Required API key access level: ModifyCampaigns
// Run: dotnet run addCampaign.cs

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

var campaign = new Campaign(
    name: "hello campaign",
    status: CampaignStatus.Draft,
    content: new List<CampaignTemplate>
    {
        new CampaignTemplate(
            from: "myemail@domain.com",
            replyTo: "myemail@domain.com",
            subject: "Hello",
            templateName: "hello_template"
        )
    },
    recipients: new CampaignRecipient(listNames: new List<string> { "my list name" })
);

try
{
    Campaign result = await campaigns.CampaignsPostAsync(campaign);
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
dotnet run addCampaign.cs
```
