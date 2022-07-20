# Campaign class

This guide will walk you through the process of creating basic methods for campaigns using the C# library.

*Required Access Level: ModifyCampaigns*

## What's a campaign?
When using Elastic Email, when you send an email to any group of contacts we call that a "campaign".

To send a campaign you need a template (which becomes the email body itself) and you need contacts (the recipients who receive the email).

## Preparation
Create a Visual Studio project of your choosing, that's using at least .NET Framework 4.8.

Then, install our NuGet Package from https://www.nuget.org/packages/ElasticEmail/ in your project.

## Let's dig into the code
In the campaign class load library namespaces using lines below:

```cs
using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;
```

Below code you will repeat in all campaign's methods:
Generate and use your API key (remember to check a required access level):

```cs
Configuration config = new Configuration();
// Configure API key authorization: apikey
config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
```

Create an instance of CampaignsApi that will be used to create a campaign.

```cs
CampaignsApi apiInstance = new CampaignsApi(config);
```

# Add campaign

Create an example campaign object:
- Name: defines campaign name by which you can identify it later
- Recipients: define your audience
- Conent: define your message details
- Status: define status in which campaign should be created

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/campaignsPost

Send will be triggered immediately or postponed, depending on given options.
Because we define `Status` as `Draft`, so in this case it will be postponed and campaign will be added to drafts.


```cs
CampaignRecipient recipients = new CampaignRecipient();
recipients.ListNames = new List<string>();
recipients.ListNames.Add("your list");

Campaign yourCampaign = new Campaign(name: "My Campaign", recipients: recipients);
yourCampaign.Content = new List<CampaignTemplate>();
CampaignTemplate campaignTemplate = new CampaignTemplate();
campaignTemplate.From = "myemail@domain.com";
campaignTemplate.ReplyTo = "myemail@domain.com";
campaignTemplate.TemplateName = "hello_template";
campaignTemplate.Subject = "Hello";

yourCampaign.Content.Add(campaignTemplate);
yourCampaign.Status = CampaignStatus.Draft;
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, we will return the data that API sends us about the newly created campaign.
Finally, call the API to create a campaign:

```cs
try
{
    return apiInstance.CampaignsPost(yourCampaign);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CampaignsApi.CampaignsPost: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public Campaign AddCampaign()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    /**
        * Add Campaign
        * Example api call that creates a new campaign.
        * Send will be triggered immediately or postponed, depending on given options.
    */
    var apiInstance = new CampaignsApi(config);

    var recipients = new CampaignRecipient();
    recipients.ListNames = new List<string>();
    recipients.ListNames.Add("your list");

    Campaign yourCampaign = new Campaign(name: "My Campaign", recipients: recipients);
    yourCampaign.Content = new List<CampaignTemplate>();
    CampaignTemplate campaignTemplate = new CampaignTemplate();
    campaignTemplate.From = "myemail@domain.com";
    campaignTemplate.ReplyTo = "myemail@domain.com";
    campaignTemplate.TemplateName = "hello_template";
    campaignTemplate.Subject = "Hello";
    yourCampaign.Content.Add(campaignTemplate);
    yourCampaign.Status = CampaignStatus.Draft;

    try
    {
        return apiInstance.CampaignsPost(yourCampaign);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling CampaignsApi.CampaignsPost: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Load Campaign

Create variable with campaign's name which you want to load

```cs
string campaignName = "My Campaign";
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, we will return the data that API sends us about the loaded campaign.
Finally, call the API to load a campaign:

```cs
try
{
    return apiInstance.CampaignsByNameGet(campaignName);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CampaignsApi.CampaignsByNameGet: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public Campaign LoadCampaign()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new CampaignsApi(config);

    /**
    * Load Campaign
    * Example api call that fetches details about single campaign like: name, status, recipients, subject etc.
    */
    string campaignName = "My Campaign";

    try
    {
        return apiInstance.CampaignsByNameGet(campaignName);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling CampaignsApi.CampaignsByNameGet: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Update Campaign
Create an example campaign object:
- Name: defines campaign name by which you can identify it later
- Recipients: define your audience
- Conent: define your message details
- Status: define status in which campaign should be created

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/campaignsByNamePut

Send will be triggered immediately or postponed, depending on given options.
Because we define `Status` as `Draft`, so in this case it will be postponed and campaign will be added to drafts.

```cs
var recipients = new CampaignRecipient();
recipients.ListNames = new List<string>();
recipients.ListNames.Add("yourList");
string campaignName = "My Campaign";

Campaign yourCampaign = new Campaign(name: "new campaignName", recipients: recipients);

yourCampaign.Content = new List<CampaignTemplate>();
CampaignTemplate campaignTemplate = new CampaignTemplate();
campaignTemplate.From = "myemail@domain.com";

campaignTemplate.ReplyTo = "myemail@domain.com";
campaignTemplate.TemplateName = "hello_template";
campaignTemplate.Subject = "Hello";
yourCampaign.Content.Add(campaignTemplate);
yourCampaign.Status = CampaignStatus.Draft;
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, we will return the data that API sends us about the updated campaign.
Finally, call the API to update a campaign:

```cs
try
{
    return apiInstance.CampaignsByNamePut(campaignName, yourCampaign);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CampaignsApi.CampaignsByNamePut: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:
```cs
public Campaign UpdateCampaign()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new CampaignsApi(config);

    /**
        * Update Campaign
        * Example api call that updates a campaign.
        * Send will be triggered immediately or postponed, depending on given options.
        */

    var recipients = new CampaignRecipient();
    recipients.ListNames = new List<string>();
    recipients.ListNames.Add("yourList");
    string campaignName = "My Campaign";

    Campaign yourCampaign = new Campaign(name: "new campaignName", recipients: recipients);

    yourCampaign.Content = new List<CampaignTemplate>();
    CampaignTemplate campaignTemplate = new CampaignTemplate();
    campaignTemplate.From = "myemail@domain.com";

    campaignTemplate.ReplyTo = "myemail@domain.com";
    campaignTemplate.TemplateName = "hello_template";
    campaignTemplate.Subject = "Hello";
    yourCampaign.Content.Add(campaignTemplate);
    yourCampaign.Status = CampaignStatus.Draft;

    try
    {
        return apiInstance.CampaignsByNamePut(campaignName, yourCampaign);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling CampaignsApi.CampaignsByNamePut: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Delete Campaign

Create a variable with campaign's name which you want to delete

```cs
string campaignName = "My Campaign";
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a success messages.
Finally, call the API to delete a campaign:

```cs
try
{
    apiInstance.CampaignsByNameDelete(campaignName);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CampaignsApi.CampaignsByNameDelete: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:
```cs
public void DeleteCampaign()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new CampaignsApi(config);

    /**
    * Delete Campaign
    * Example api call that deletes an existing campaign.
    */
    string campaignName = "new campaignName";

    try
    {
        apiInstance.CampaignsByNameDelete(campaignName);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling CampaignsApi.CampaignsByNameDelete: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

## Run the code
Simply run your project and be sure that the code we wrote can be reached.