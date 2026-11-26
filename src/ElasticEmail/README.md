<!-- This file is generated from README.md by public-sdk-pipelines scripts/readme_blocks.py. Edit README.md instead. -->

<div align="center">

<img src="https://raw.githubusercontent.com/ElasticEmail/elasticemail-csharp/master/src/ElasticEmail/ee-logo.png" alt="Elastic Email" width="96" />

# Elastic Email C# SDK

The official C# / .NET client library for the [Elastic Email](https://elasticemail.com) REST API v4.

[![NuGet](https://img.shields.io/nuget/v/ElasticEmail?logo=nuget&label=NuGet&color=004880)](https://www.nuget.org/packages/ElasticEmail)
[![NuGet downloads](https://img.shields.io/nuget/dt/ElasticEmail?logo=nuget&label=downloads&color=004880)](https://www.nuget.org/packages/ElasticEmail)
[![.NET Standard](https://img.shields.io/badge/.NET%20Standard-2.0-512BD4?logo=dotnet)](https://learn.microsoft.com/dotnet/standard/net-standard)
[![API](https://img.shields.io/badge/API-v4-0A7BBB)](https://elasticemail.com/developers/api-documentation/rest-api)
[![OpenAPI Generator](https://img.shields.io/badge/generated%20by-OpenAPI%20Generator-6BA539?logo=openapiinitiative&logoColor=white)](https://openapi-generator.tech)
[![License: MIT](https://img.shields.io/github/license/ElasticEmail/elasticemail-csharp?color=yellow)](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/LICENSE)

[![Latest release](https://img.shields.io/github/v/release/ElasticEmail/elasticemail-csharp?logo=github&label=release)](https://github.com/ElasticEmail/elasticemail-csharp/releases)
[![Last commit](https://img.shields.io/github/last-commit/ElasticEmail/elasticemail-csharp?logo=github)](https://github.com/ElasticEmail/elasticemail-csharp/commits/master)
[![Open issues](https://img.shields.io/github/issues/ElasticEmail/elasticemail-csharp?logo=github)](https://github.com/ElasticEmail/elasticemail-csharp/issues)
[![GitHub stars](https://img.shields.io/github/stars/ElasticEmail/elasticemail-csharp?style=flat&logo=github)](https://github.com/ElasticEmail/elasticemail-csharp/stargazers)

[Installation](#installation) •
[Quick start](#quick-start) •
[Examples](#more-examples) •
[API reference](#api-reference) •
[Models](#models) •
[Contributing](#contributing)

</div>

---

## Features

- **Transactional and bulk email.** Send single messages, bulk campaigns or CSV merge-file sends.
- **Safe retries.** Pass an `Idempotency-Key` to the send methods so a retried send is delivered and charged only once.
- **Contacts, lists and segments.** Add, update, import, export and bulk-delete contacts.
- **Campaigns and automations.** Create, update, pause and trigger automations for a contact.
- **Templates, files and attachments.** Manage templates and uploaded files.
- **Domains.** Verify sending domains and check SPF, DKIM, tracking and certificate status.
- **Webhooks and inbound routes.** Receive delivery events, optionally signed with HMAC-SHA256 and sent as JSON, and route incoming mail.
- **Statistics, events and suppressions.** Track delivery, bounces, complaints and unsubscribes.
- **Subaccounts and security.** Manage subaccounts and API keys.
- **Sync and async.** Every endpoint has a blocking method and an `…Async` method that takes a `CancellationToken`.

## Requirements

| Platform | Version |
| --- | --- |
| .NET / .NET Core | 2.0 or later (library targets `netstandard2.0`) |
| .NET Framework | 4.6.1 or later |
| Mono / Xamarin | Any version that supports .NET Standard 2.0 |

You'll also need an Elastic Email **API key**. You can create one in your [API settings](https://app.elasticemail.com/marketing/settings/new/manage-api). Each endpoint's documentation lists the access level it needs.

## Installation

Install the [`ElasticEmail`](https://www.nuget.org/packages/ElasticEmail) package from NuGet:

```bash
dotnet add package ElasticEmail
```

Or with the Package Manager Console:

```powershell
Install-Package ElasticEmail
```

Or add it to your `.csproj`:

```xml
<PackageReference Include="ElasticEmail" Version="4.4.0" />
```

NuGet installs the dependencies ([RestSharp](https://www.nuget.org/packages/RestSharp), [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json), [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes) and [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations)) for you.

## Quick start

> [!IMPORTANT]
> Elastic Email only sends from verified domains. Before your first send, [verify your sending domain](https://help.elasticemail.com/en/articles/4934400-how-to-verify-your-domain) and use an address on that domain as the sender.

### Configure the client

```csharp
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

var config = new Configuration();
config.BasePath = "https://api.elasticemail.com/v4";
config.ApiKey.Add("X-ElasticEmail-ApiKey", Environment.GetEnvironmentVariable("ELASTICEMAIL_API_KEY"));
```

> [!TIP]
> Keep your API key out of source code. Load it from an environment variable, user secrets or a secrets manager.

### Send a transactional email

```csharp
var emails = new EmailsApi(config);

var message = new EmailTransactionalMessageData(
    recipients: new TransactionalRecipient(to: new List<string> { "john.doe@example.com" }),
    content: new EmailContent(
        from: "My App <no-reply@yourdomain.com>",
        subject: "Welcome aboard!",
        body: new List<BodyPart>
        {
            new BodyPart(BodyContentType.HTML, "<h1>Hello!</h1><p>Thanks for signing up.</p>"),
            new BodyPart(BodyContentType.PlainText, "Hello! Thanks for signing up.")
        }
    )
);

try
{
    EmailSend result = await emails.EmailsTransactionalPostAsync(message);
    Console.WriteLine($"Sent. TransactionID: {result.TransactionID}, MessageID: {result.MessageID}");
}
catch (ApiException e)
{
    Console.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
}
```

The `from` address must use a domain you've [verified in your Elastic Email account](https://help.elasticemail.com/en/articles/4934400-how-to-verify-your-domain).

### Retry a send safely (Idempotency-Key)

Pass an `Idempotency-Key` to `EmailsPost`, `EmailsTransactionalPost` or `EmailsMergefilePost` (or their `…Async` variants) so a retry after a timeout or a dropped connection can't send the same email twice. If Elastic Email already processed the key, it returns the stored response (same `TransactionID` and `MessageID`, with an `Idempotency-Replayed: true` header) and sends nothing again.

```csharp
// One key per logical send; reuse it only to retry that same send.
var idempotencyKey = Guid.NewGuid().ToString();

EmailSend result = null;
for (var attempt = 1; result == null; attempt++)
{
    var wait = TimeSpan.FromSeconds(2);
    try
    {
        // Returns null when there was no response (network error or timeout).
        result = await emails.EmailsTransactionalPostAsync(message, idempotencyKey);
    }
    catch (ApiException e) when (attempt < 3 && (e.ErrorCode == 409 || e.ErrorCode >= 500))
    {
        if (e.Headers != null && e.Headers.TryGetValue("Retry-After", out var retryAfter))
            wait = TimeSpan.FromSeconds(int.Parse(retryAfter[0]));
    }
    if (result == null && attempt == 3)
        throw new TimeoutException("No response from Elastic Email after 3 attempts.");
    if (result == null)
        await Task.Delay(wait); // then retry with the same key and the same message
}
```

Keys are kept for 24 hours per account, and a retry must send the same body: reusing a key with a different request returns `422`. A `409` means the first request with that key is still running, and a `503` means the key couldn't be checked, so wait for `Retry-After` and retry with the same key. The parameter is optional, and calls without it work as before.

### Send from a template with merge fields

```csharp
var message = new EmailTransactionalMessageData(
    recipients: new TransactionalRecipient(to: new List<string> { "john.doe@example.com" }),
    content: new EmailContent(
        from: "My App <no-reply@yourdomain.com>",
        templateName: "welcome-template",
        merge: new Dictionary<string, string> { ["firstname"] = "John" }
    )
);

await emails.EmailsTransactionalPostAsync(message);
```

### Using a proxy

```csharp
var webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
config.Proxy = webProxy;
```

### Create a signed webhook

Webhooks can sign every request with HMAC-SHA256 and send events as a `POST` with a JSON body. Both options are set when you create the webhook and can't be changed later. Webhooks created without them keep working as unsigned `GET` requests.

```csharp
var webhookApi = new WebhookApi(config);

var created = await webhookApi.WebhookPostAsync(new WebhookCreatePayload(
    name: "my-webhook",
    uRL: "https://your-app.example.com/webhook",
    notificationForSent: true,
    notificationForOpened: true,
    notificationForClicked: true,
    enableSigning: true,
    deliveryMethod: WebhookDeliveryMethod.PostJson));

// Returned only now: store it, e.g. as ELASTICEMAIL_WEBHOOK_SECRET.
Console.WriteLine(created.SigningSecret);
```

`SigningSecret` is returned only when the webhook is created and when you rotate it with `WebhookByPublicidSecretRotatePostAsync`, so store it right away. Each signed request carries `X-ElasticEmail-Timestamp` and `X-ElasticEmail-Signature: v1=<hex>`, where the signature is `hex(HMAC-SHA256(secret, "{timestamp}\n{METHOD}\n{path and query}\n{raw body}"))`. Verify it against the raw body before you parse the JSON, reject timestamps more than 5 minutes old, and compare in constant time. The [webhooks guide](https://github.com/ElasticEmail/elasticemail-examples/blob/main/docs/webhooks.md) and the [examples repository](https://github.com/ElasticEmail/elasticemail-examples) have ready-made handlers.

## More examples

More complete, runnable samples are in the **[Elastic Email examples repository](https://github.com/ElasticEmail/elasticemail-examples)**. It covers transactional email, SMTP, webhooks, inbound email, contacts and serverless platforms across 20+ languages and frameworks.

- 📁 [Examples in this repository](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/README.md): one runnable file per API call
- 🟣 [.NET / C# examples](https://github.com/ElasticEmail/elasticemail-examples/tree/main/dotnet-elasticemail-examples)
- 📂 [All examples](https://github.com/ElasticEmail/elasticemail-examples)

<details>
<summary><strong>Snippets in this repository</strong></summary>

One runnable file per API call, with a step-by-step guide for each. See [examples/README.md](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/README.md) for how to run them (`dotnet run sendTransactionalEmails.cs`, .NET 10 or later).

Function | Guide
------------ | -------------
[addCampaign](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/addCampaign.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/addCampaign.md)
[addContacts](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/addContacts.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/addContacts.md)
[addList](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/addList.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/addList.md)
[addTemplate](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/addTemplate.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/addTemplate.md)
[deleteCampaign](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/deleteCampaign.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/deleteCampaign.md)
[deleteContact](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/deleteContact.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/deleteContact.md)
[deleteContacts](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/deleteContacts.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/deleteContacts.md)
[deleteList](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/deleteList.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/deleteList.md)
[deleteTemplate](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/deleteTemplate.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/deleteTemplate.md)
[exportContacts](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/exportContacts.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/exportContacts.md)
[loadCampaign](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadCampaign.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadCampaign.md)
[loadCampaignsStats](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadCampaignsStats.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadCampaignsStats.md)
[loadChannelsStats](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadChannelsStats.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadChannelsStats.md)
[loadList](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadList.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadList.md)
[loadStatistics](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadStatistics.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadStatistics.md)
[loadTemplate](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadTemplate.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/loadTemplate.md)
[sendBulkEmails](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/sendBulkEmails.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/sendBulkEmails.md)
[sendTransactionalEmails](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/sendTransactionalEmails.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/sendTransactionalEmails.md)
[sendTransactionalEmailsWithAttachment](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/sendTransactionalEmailsWithAttachment.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/sendTransactionalEmailsWithAttachment.md)
[updateCampaign](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/updateCampaign.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/updateCampaign.md)
[uploadContacts](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/uploadContacts.cs) | [readme](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/examples/functions/uploadContacts.md)

</details>

## Authentication

| Scheme | Header | Used for |
| --- | --- | --- |
| `apikey` | `X-ElasticEmail-ApiKey` | All standard API calls |
| `ApiKeyAuthCustomBranding` | `X-Auth-Token` | Custom-branding (white-label) accounts |

## API limits

- Up to **20 concurrent connections** per account. The API doesn't return `429`; a `5xx` under load means slow down and retry with backoff
- A request with no response for about **50 seconds** fails with a gateway error (`5xx`)
- Up to **50 recipients** per `POST /emails/transactional` and **1000 contacts or suppressions** per upload (`413` above that). For more recipients, send one bulk `POST /emails`

## API reference

All URIs are relative to `https://api.elasticemail.com/v4`. The SDK covers **115 endpoints** across 16 API classes: `CampaignsApi`, `ContactsApi`, `DomainsApi`, `EmailsApi`, `EventsApi`, `FilesApi`, `InboundRouteApi`, `ListsApi`, `SecurityApi`, `SegmentsApi`, `StatisticsApi`, `SubAccountsApi`, `SuppressionsApi`, `TemplatesApi`, `VerificationsApi` and `WebhookApi`.

<details>
<summary><strong>Show all endpoints</strong></summary>


All URIs are relative to *https://api.elasticemail.com/v4*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CampaignsApi* | [**CampaignsAutomationByNameTriggerPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignsApi.md#campaignsautomationbynametriggerpost) | **POST** /campaigns/automation/{name}/trigger | Trigger Automation for Contact
*CampaignsApi* | [**CampaignsByNameDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignsApi.md#campaignsbynamedelete) | **DELETE** /campaigns/{name} | Delete Campaign
*CampaignsApi* | [**CampaignsByNameGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignsApi.md#campaignsbynameget) | **GET** /campaigns/{name} | Load Campaign
*CampaignsApi* | [**CampaignsByNamePausePut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignsApi.md#campaignsbynamepauseput) | **PUT** /campaigns/{name}/pause | Pause Campaign
*CampaignsApi* | [**CampaignsByNamePut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignsApi.md#campaignsbynameput) | **PUT** /campaigns/{name} | Update Campaign
*CampaignsApi* | [**CampaignsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignsApi.md#campaignsget) | **GET** /campaigns | Load Campaigns
*CampaignsApi* | [**CampaignsPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignsApi.md#campaignspost) | **POST** /campaigns | Add Campaign
*ContactsApi* | [**ContactsByEmailDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactsApi.md#contactsbyemaildelete) | **DELETE** /contacts/{email} | Delete Contact
*ContactsApi* | [**ContactsByEmailGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactsApi.md#contactsbyemailget) | **GET** /contacts/{email} | Load Contact
*ContactsApi* | [**ContactsByEmailPut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactsApi.md#contactsbyemailput) | **PUT** /contacts/{email} | Update Contact
*ContactsApi* | [**ContactsDeletePost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactsApi.md#contactsdeletepost) | **POST** /contacts/delete | Delete Contacts Bulk
*ContactsApi* | [**ContactsExportByIdStatusGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactsApi.md#contactsexportbyidstatusget) | **GET** /contacts/export/{id}/status | Check Export Status
*ContactsApi* | [**ContactsExportPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactsApi.md#contactsexportpost) | **POST** /contacts/export | Export Contacts
*ContactsApi* | [**ContactsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactsApi.md#contactsget) | **GET** /contacts | Load Contacts
*ContactsApi* | [**ContactsImportPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactsApi.md#contactsimportpost) | **POST** /contacts/import | Upload Contacts
*ContactsApi* | [**ContactsPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactsApi.md#contactspost) | **POST** /contacts | Add Contact
*DomainsApi* | [**DomainsByDomainDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainsApi.md#domainsbydomaindelete) | **DELETE** /domains/{domain} | Delete Domain
*DomainsApi* | [**DomainsByDomainGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainsApi.md#domainsbydomainget) | **GET** /domains/{domain} | Load Domain
*DomainsApi* | [**DomainsByDomainPut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainsApi.md#domainsbydomainput) | **PUT** /domains/{domain} | Update Domain
*DomainsApi* | [**DomainsByDomainRestrictedGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainsApi.md#domainsbydomainrestrictedget) | **GET** /domains/{domain}/restricted | Check for domain restriction
*DomainsApi* | [**DomainsByDomainVerificationPut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainsApi.md#domainsbydomainverificationput) | **PUT** /domains/{domain}/verification | Verify Domain
*DomainsApi* | [**DomainsByEmailDefaultPatch**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainsApi.md#domainsbyemaildefaultpatch) | **PATCH** /domains/{email}/default | Set Default
*DomainsApi* | [**DomainsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainsApi.md#domainsget) | **GET** /domains | Load Domains
*DomainsApi* | [**DomainsPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainsApi.md#domainspost) | **POST** /domains | Add Domain
*EmailsApi* | [**EmailsByMsgidViewGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailsApi.md#emailsbymsgidviewget) | **GET** /emails/{msgid}/view | View Email
*EmailsApi* | [**EmailsByTransactionidStatusGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailsApi.md#emailsbytransactionidstatusget) | **GET** /emails/{transactionid}/status | Get Status
*EmailsApi* | [**EmailsMergefilePost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailsApi.md#emailsmergefilepost) | **POST** /emails/mergefile | Send Bulk Emails CSV
*EmailsApi* | [**EmailsPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailsApi.md#emailspost) | **POST** /emails | Send Bulk Emails
*EmailsApi* | [**EmailsTransactionalPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailsApi.md#emailstransactionalpost) | **POST** /emails/transactional | Send Transactional Email
*EventsApi* | [**EventsByTransactionidGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EventsApi.md#eventsbytransactionidget) | **GET** /events/{transactionid} | Load Email Events
*EventsApi* | [**EventsChannelsByNameExportPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EventsApi.md#eventschannelsbynameexportpost) | **POST** /events/channels/{name}/export | Export Channel Events
*EventsApi* | [**EventsChannelsByNameGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EventsApi.md#eventschannelsbynameget) | **GET** /events/channels/{name} | Load Channel Events
*EventsApi* | [**EventsChannelsExportByIdStatusGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EventsApi.md#eventschannelsexportbyidstatusget) | **GET** /events/channels/export/{id}/status | Check Channel Export Status
*EventsApi* | [**EventsExportByIdStatusGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EventsApi.md#eventsexportbyidstatusget) | **GET** /events/export/{id}/status | Check Export Status
*EventsApi* | [**EventsExportPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EventsApi.md#eventsexportpost) | **POST** /events/export | Export Events
*EventsApi* | [**EventsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EventsApi.md#eventsget) | **GET** /events | Load Events
*FilesApi* | [**FilesByNameDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/FilesApi.md#filesbynamedelete) | **DELETE** /files/{name} | Delete File
*FilesApi* | [**FilesByNameGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/FilesApi.md#filesbynameget) | **GET** /files/{name} | Download File
*FilesApi* | [**FilesByNameInfoGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/FilesApi.md#filesbynameinfoget) | **GET** /files/{name}/info | Load File Details
*FilesApi* | [**FilesGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/FilesApi.md#filesget) | **GET** /files | List Files
*FilesApi* | [**FilesPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/FilesApi.md#filespost) | **POST** /files | Upload File
*InboundRouteApi* | [**InboundrouteByIdDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/InboundRouteApi.md#inboundroutebyiddelete) | **DELETE** /inboundroute/{id} | Delete Route
*InboundRouteApi* | [**InboundrouteByIdGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/InboundRouteApi.md#inboundroutebyidget) | **GET** /inboundroute/{id} | Get Route
*InboundRouteApi* | [**InboundrouteByIdPut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/InboundRouteApi.md#inboundroutebyidput) | **PUT** /inboundroute/{id} | Update Route
*InboundRouteApi* | [**InboundrouteGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/InboundRouteApi.md#inboundrouteget) | **GET** /inboundroute | Get Routes
*InboundRouteApi* | [**InboundrouteOrderPut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/InboundRouteApi.md#inboundrouteorderput) | **PUT** /inboundroute/order | Update Sorting
*InboundRouteApi* | [**InboundroutePost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/InboundRouteApi.md#inboundroutepost) | **POST** /inboundroute | Create Route
*ListsApi* | [**ListsByListnameContactsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ListsApi.md#listsbylistnamecontactsget) | **GET** /lists/{listname}/contacts | Load Contacts in List
*ListsApi* | [**ListsByNameContactsPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ListsApi.md#listsbynamecontactspost) | **POST** /lists/{name}/contacts | Add Contacts to List
*ListsApi* | [**ListsByNameContactsRemovePost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ListsApi.md#listsbynamecontactsremovepost) | **POST** /lists/{name}/contacts/remove | Remove Contacts from List
*ListsApi* | [**ListsByNameDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ListsApi.md#listsbynamedelete) | **DELETE** /lists/{name} | Delete List
*ListsApi* | [**ListsByNameGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ListsApi.md#listsbynameget) | **GET** /lists/{name} | Load List
*ListsApi* | [**ListsByNamePut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ListsApi.md#listsbynameput) | **PUT** /lists/{name} | Update List
*ListsApi* | [**ListsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ListsApi.md#listsget) | **GET** /lists | Load Lists
*ListsApi* | [**ListsPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ListsApi.md#listspost) | **POST** /lists | Add List
*SecurityApi* | [**SecurityApikeysByNameDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SecurityApi.md#securityapikeysbynamedelete) | **DELETE** /security/apikeys/{name} | Delete ApiKey
*SecurityApi* | [**SecurityApikeysByNameGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SecurityApi.md#securityapikeysbynameget) | **GET** /security/apikeys/{name} | Load ApiKey
*SecurityApi* | [**SecurityApikeysByNamePut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SecurityApi.md#securityapikeysbynameput) | **PUT** /security/apikeys/{name} | Update ApiKey
*SecurityApi* | [**SecurityApikeysGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SecurityApi.md#securityapikeysget) | **GET** /security/apikeys | List ApiKeys
*SecurityApi* | [**SecurityApikeysPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SecurityApi.md#securityapikeyspost) | **POST** /security/apikeys | Add ApiKey
*SecurityApi* | [**SecuritySmtpByNameDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SecurityApi.md#securitysmtpbynamedelete) | **DELETE** /security/smtp/{name} | Delete SMTP Credential
*SecurityApi* | [**SecuritySmtpByNameGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SecurityApi.md#securitysmtpbynameget) | **GET** /security/smtp/{name} | Load SMTP Credential
*SecurityApi* | [**SecuritySmtpByNamePut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SecurityApi.md#securitysmtpbynameput) | **PUT** /security/smtp/{name} | Update SMTP Credential
*SecurityApi* | [**SecuritySmtpGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SecurityApi.md#securitysmtpget) | **GET** /security/smtp | List SMTP Credentials
*SecurityApi* | [**SecuritySmtpPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SecurityApi.md#securitysmtppost) | **POST** /security/smtp | Add SMTP Credential
*SegmentsApi* | [**SegmentsByNameDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SegmentsApi.md#segmentsbynamedelete) | **DELETE** /segments/{name} | Delete Segment
*SegmentsApi* | [**SegmentsByNameGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SegmentsApi.md#segmentsbynameget) | **GET** /segments/{name} | Load Segment
*SegmentsApi* | [**SegmentsByNamePut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SegmentsApi.md#segmentsbynameput) | **PUT** /segments/{name} | Update Segment
*SegmentsApi* | [**SegmentsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SegmentsApi.md#segmentsget) | **GET** /segments | Load Segments
*SegmentsApi* | [**SegmentsPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SegmentsApi.md#segmentspost) | **POST** /segments | Add Segment
*StatisticsApi* | [**StatisticsCampaignsByNameGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/StatisticsApi.md#statisticscampaignsbynameget) | **GET** /statistics/campaigns/{name} | Load Campaign Stats
*StatisticsApi* | [**StatisticsCampaignsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/StatisticsApi.md#statisticscampaignsget) | **GET** /statistics/campaigns | Load Campaigns Stats
*StatisticsApi* | [**StatisticsChannelsByNameGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/StatisticsApi.md#statisticschannelsbynameget) | **GET** /statistics/channels/{name} | Load Channel Stats
*StatisticsApi* | [**StatisticsChannelsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/StatisticsApi.md#statisticschannelsget) | **GET** /statistics/channels | Load Channels Stats
*StatisticsApi* | [**StatisticsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/StatisticsApi.md#statisticsget) | **GET** /statistics | Load Statistics
*SubAccountsApi* | [**SubaccountsByEmailApikeyGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubAccountsApi.md#subaccountsbyemailapikeyget) | **GET** /subaccounts/{email}/apikey | Get SubAccount ApiKey
*SubAccountsApi* | [**SubaccountsByEmailCreditsPatch**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubAccountsApi.md#subaccountsbyemailcreditspatch) | **PATCH** /subaccounts/{email}/credits | Add, Subtract Email Credits
*SubAccountsApi* | [**SubaccountsByEmailDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubAccountsApi.md#subaccountsbyemaildelete) | **DELETE** /subaccounts/{email} | Delete SubAccount
*SubAccountsApi* | [**SubaccountsByEmailGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubAccountsApi.md#subaccountsbyemailget) | **GET** /subaccounts/{email} | Load SubAccount
*SubAccountsApi* | [**SubaccountsByEmailSettingsEmailPut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubAccountsApi.md#subaccountsbyemailsettingsemailput) | **PUT** /subaccounts/{email}/settings/email | Update SubAccount Email Settings
*SubAccountsApi* | [**SubaccountsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubAccountsApi.md#subaccountsget) | **GET** /subaccounts | Load SubAccounts
*SubAccountsApi* | [**SubaccountsPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubAccountsApi.md#subaccountspost) | **POST** /subaccounts | Add SubAccount
*SuppressionsApi* | [**SuppressionsBouncesGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionsbouncesget) | **GET** /suppressions/bounces | Get Bounce List
*SuppressionsApi* | [**SuppressionsBouncesImportPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionsbouncesimportpost) | **POST** /suppressions/bounces/import | Add Bounces Async
*SuppressionsApi* | [**SuppressionsBouncesPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionsbouncespost) | **POST** /suppressions/bounces | Add Bounces
*SuppressionsApi* | [**SuppressionsByEmailDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionsbyemaildelete) | **DELETE** /suppressions/{email} | Delete Suppression
*SuppressionsApi* | [**SuppressionsByEmailGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionsbyemailget) | **GET** /suppressions/{email} | Get Suppression
*SuppressionsApi* | [**SuppressionsComplaintsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionscomplaintsget) | **GET** /suppressions/complaints | Get Complaints List
*SuppressionsApi* | [**SuppressionsComplaintsImportPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionscomplaintsimportpost) | **POST** /suppressions/complaints/import | Add Complaints Async
*SuppressionsApi* | [**SuppressionsComplaintsPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionscomplaintspost) | **POST** /suppressions/complaints | Add Complaints
*SuppressionsApi* | [**SuppressionsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionsget) | **GET** /suppressions | Get Suppressions
*SuppressionsApi* | [**SuppressionsUnsubscribesGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionsunsubscribesget) | **GET** /suppressions/unsubscribes | Get Unsubscribes List
*SuppressionsApi* | [**SuppressionsUnsubscribesImportPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionsunsubscribesimportpost) | **POST** /suppressions/unsubscribes/import | Add Unsubscribes Async
*SuppressionsApi* | [**SuppressionsUnsubscribesPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SuppressionsApi.md#suppressionsunsubscribespost) | **POST** /suppressions/unsubscribes | Add Unsubscribes
*TemplatesApi* | [**TemplatesByNameDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TemplatesApi.md#templatesbynamedelete) | **DELETE** /templates/{name} | Delete Template
*TemplatesApi* | [**TemplatesByNameGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TemplatesApi.md#templatesbynameget) | **GET** /templates/{name} | Load Template
*TemplatesApi* | [**TemplatesByNamePut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TemplatesApi.md#templatesbynameput) | **PUT** /templates/{name} | Update Template
*TemplatesApi* | [**TemplatesGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TemplatesApi.md#templatesget) | **GET** /templates | Load Templates
*TemplatesApi* | [**TemplatesPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TemplatesApi.md#templatespost) | **POST** /templates | Add Template
*VerificationsApi* | [**VerificationsByEmailDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationsApi.md#verificationsbyemaildelete) | **DELETE** /verifications/{email} | Delete Email Verification Result
*VerificationsApi* | [**VerificationsByEmailGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationsApi.md#verificationsbyemailget) | **GET** /verifications/{email} | Get Email Verification Result
*VerificationsApi* | [**VerificationsByEmailPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationsApi.md#verificationsbyemailpost) | **POST** /verifications/{email} | Verify Email
*VerificationsApi* | [**VerificationsFilesByIdDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationsApi.md#verificationsfilesbyiddelete) | **DELETE** /verifications/files/{id} | Delete File Verification Result
*VerificationsApi* | [**VerificationsFilesByIdResultDownloadGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationsApi.md#verificationsfilesbyidresultdownloadget) | **GET** /verifications/files/{id}/result/download | Download File Verification Result
*VerificationsApi* | [**VerificationsFilesByIdResultGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationsApi.md#verificationsfilesbyidresultget) | **GET** /verifications/files/{id}/result | Get Detailed File Verification Result
*VerificationsApi* | [**VerificationsFilesByIdVerificationPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationsApi.md#verificationsfilesbyidverificationpost) | **POST** /verifications/files/{id}/verification | Start verification
*VerificationsApi* | [**VerificationsFilesPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationsApi.md#verificationsfilespost) | **POST** /verifications/files | Upload File with Emails
*VerificationsApi* | [**VerificationsFilesResultGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationsApi.md#verificationsfilesresultget) | **GET** /verifications/files/result | Get Files Verification Results
*VerificationsApi* | [**VerificationsGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationsApi.md#verificationsget) | **GET** /verifications | Get Emails Verification Results
*WebhookApi* | [**WebhookByPublicidDelete**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/WebhookApi.md#webhookbypubliciddelete) | **DELETE** /webhook/{publicid} | Delete Webhook
*WebhookApi* | [**WebhookByPublicidGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/WebhookApi.md#webhookbypublicidget) | **GET** /webhook/{publicid} | Load Webhook
*WebhookApi* | [**WebhookByPublicidPut**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/WebhookApi.md#webhookbypublicidput) | **PUT** /webhook/{publicid} | Update Webhook
*WebhookApi* | [**WebhookByPublicidSecretRotatePost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/WebhookApi.md#webhookbypublicidsecretrotatepost) | **POST** /webhook/{publicid}/secret/rotate | Rotate Webhook Secret
*WebhookApi* | [**WebhookGet**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/WebhookApi.md#webhookget) | **GET** /webhook | Load Webhooks
*WebhookApi* | [**WebhookPost**](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/WebhookApi.md#webhookpost) | **POST** /webhook | Add Webhook


</details>

## Models

<details>
<summary><strong>Show all 99 models</strong></summary>

 - [Model.AccessLevel](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/AccessLevel.md)
 - [Model.AccountStatusEnum](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/AccountStatusEnum.md)
 - [Model.ApiKey](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ApiKey.md)
 - [Model.ApiKeyPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ApiKeyPayload.md)
 - [Model.BodyContentType](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/BodyContentType.md)
 - [Model.BodyPart](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/BodyPart.md)
 - [Model.Campaign](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/Campaign.md)
 - [Model.CampaignOptions](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignOptions.md)
 - [Model.CampaignRecipient](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignRecipient.md)
 - [Model.CampaignStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignStatus.md)
 - [Model.CampaignTemplate](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CampaignTemplate.md)
 - [Model.CertificateValidationStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CertificateValidationStatus.md)
 - [Model.ChannelLogStatusSummary](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ChannelLogStatusSummary.md)
 - [Model.CompressionFormat](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/CompressionFormat.md)
 - [Model.ConsentData](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ConsentData.md)
 - [Model.ConsentTracking](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ConsentTracking.md)
 - [Model.Contact](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/Contact.md)
 - [Model.ContactActivity](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactActivity.md)
 - [Model.ContactPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactPayload.md)
 - [Model.ContactSource](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactSource.md)
 - [Model.ContactStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactStatus.md)
 - [Model.ContactUpdatePayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactUpdatePayload.md)
 - [Model.ContactsList](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ContactsList.md)
 - [Model.DKIMRecord](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DKIMRecord.md)
 - [Model.DeliveryOptimizationType](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DeliveryOptimizationType.md)
 - [Model.DomainData](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainData.md)
 - [Model.DomainDetail](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainDetail.md)
 - [Model.DomainOwner](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainOwner.md)
 - [Model.DomainPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainPayload.md)
 - [Model.DomainUpdatePayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/DomainUpdatePayload.md)
 - [Model.EmailContent](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailContent.md)
 - [Model.EmailData](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailData.md)
 - [Model.EmailJobFailedStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailJobFailedStatus.md)
 - [Model.EmailJobStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailJobStatus.md)
 - [Model.EmailMessageData](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailMessageData.md)
 - [Model.EmailPredictedValidationStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailPredictedValidationStatus.md)
 - [Model.EmailRecipient](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailRecipient.md)
 - [Model.EmailSend](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailSend.md)
 - [Model.EmailStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailStatus.md)
 - [Model.EmailTransactionalMessageData](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailTransactionalMessageData.md)
 - [Model.EmailValidationResult](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailValidationResult.md)
 - [Model.EmailValidationStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailValidationStatus.md)
 - [Model.EmailView](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailView.md)
 - [Model.EmailsPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EmailsPayload.md)
 - [Model.EncodingType](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EncodingType.md)
 - [Model.EventType](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EventType.md)
 - [Model.EventsOrderBy](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/EventsOrderBy.md)
 - [Model.ExportFileFormats](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ExportFileFormats.md)
 - [Model.ExportLink](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ExportLink.md)
 - [Model.ExportStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ExportStatus.md)
 - [Model.FileInfo](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/FileInfo.md)
 - [Model.FilePayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/FilePayload.md)
 - [Model.FileUploadResult](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/FileUploadResult.md)
 - [Model.InboundPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/InboundPayload.md)
 - [Model.InboundRoute](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/InboundRoute.md)
 - [Model.InboundRouteActionType](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/InboundRouteActionType.md)
 - [Model.InboundRouteFilterType](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/InboundRouteFilterType.md)
 - [Model.ListPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ListPayload.md)
 - [Model.ListUpdatePayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/ListUpdatePayload.md)
 - [Model.LogJobStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/LogJobStatus.md)
 - [Model.LogStatusSummary](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/LogStatusSummary.md)
 - [Model.MergeEmailPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/MergeEmailPayload.md)
 - [Model.MessageAttachment](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/MessageAttachment.md)
 - [Model.MessageCategory](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/MessageCategory.md)
 - [Model.MessageCategoryEnum](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/MessageCategoryEnum.md)
 - [Model.NewApiKey](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/NewApiKey.md)
 - [Model.NewSmtpCredentials](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/NewSmtpCredentials.md)
 - [Model.Options](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/Options.md)
 - [Model.RecipientEvent](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/RecipientEvent.md)
 - [Model.Segment](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/Segment.md)
 - [Model.SegmentPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SegmentPayload.md)
 - [Model.SmtpCredentials](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SmtpCredentials.md)
 - [Model.SmtpCredentialsPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SmtpCredentialsPayload.md)
 - [Model.SortOrderItem](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SortOrderItem.md)
 - [Model.SplitOptimizationType](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SplitOptimizationType.md)
 - [Model.SplitOptions](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SplitOptions.md)
 - [Model.SubAccountInfo](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubAccountInfo.md)
 - [Model.SubaccountEmailCreditsPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubaccountEmailCreditsPayload.md)
 - [Model.SubaccountEmailSettings](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubaccountEmailSettings.md)
 - [Model.SubaccountEmailSettingsPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubaccountEmailSettingsPayload.md)
 - [Model.SubaccountPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubaccountPayload.md)
 - [Model.SubaccountSettingsInfo](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubaccountSettingsInfo.md)
 - [Model.SubaccountSettingsInfoPayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/SubaccountSettingsInfoPayload.md)
 - [Model.Suppression](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/Suppression.md)
 - [Model.Template](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/Template.md)
 - [Model.TemplatePayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TemplatePayload.md)
 - [Model.TemplateScope](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TemplateScope.md)
 - [Model.TemplateType](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TemplateType.md)
 - [Model.TrackingType](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TrackingType.md)
 - [Model.TrackingValidationStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TrackingValidationStatus.md)
 - [Model.TransactionalRecipient](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/TransactionalRecipient.md)
 - [Model.Utm](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/Utm.md)
 - [Model.VerificationFileResult](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationFileResult.md)
 - [Model.VerificationFileResultDetails](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationFileResultDetails.md)
 - [Model.VerificationStatus](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/VerificationStatus.md)
 - [Model.Webhook](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/Webhook.md)
 - [Model.WebhookCreatePayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/WebhookCreatePayload.md)
 - [Model.WebhookDeliveryMethod](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/WebhookDeliveryMethod.md)
 - [Model.WebhookUpdatePayload](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/docs/WebhookUpdatePayload.md)


</details>

## Known issues

- RestSharp on .NET Core creates a new socket for each API call, which can exhaust sockets under heavy load. Reuse API client instances where you can. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

## Versioning

The SDK follows the Elastic Email API v4. Package versions and release notes are listed on [NuGet](https://www.nuget.org/packages/ElasticEmail#versions-body-tab) and in [GitHub Releases](https://github.com/ElasticEmail/elasticemail-csharp/releases).

<details>
<summary>Build details</summary>

- API version: 4.0.0
- SDK version: 4.4.0
- Generator version: 7.11.0
- Build package: `org.openapitools.codegen.languages.CSharpClientCodegen`

</details>

## Contributing

Contributions are welcome! Most of this SDK is generated from the Elastic Email OpenAPI specification, so please read [CONTRIBUTING.md](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/CONTRIBUTING.md) before opening a pull request.

- 🐛 [Report a bug](https://github.com/ElasticEmail/elasticemail-csharp/issues/new?template=bug_report.md)
- 💡 [Request a feature](https://github.com/ElasticEmail/elasticemail-csharp/issues/new?template=feature_request.md)
- 🔒 [Report a security issue](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/SECURITY.md)

This project follows the [Contributor Covenant Code of Conduct](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/CODE_OF_CONDUCT.md).

## Support

> [!IMPORTANT]
> The fastest way to get help is the **chat widget on [elasticemail.com](https://elasticemail.com)**. Our support team can help with your account, sending, deliverability and API questions.

- 💬 [Chat with support on elasticemail.com](https://elasticemail.com) (preferred)
- 📚 [API documentation](https://elasticemail.com/developers/api-documentation/rest-api)
- 🧪 [Examples repository](https://github.com/ElasticEmail/elasticemail-examples)
- 🐛 [GitHub issues](https://github.com/ElasticEmail/elasticemail-csharp/issues), for bugs in this SDK only

## License

Released under the [MIT License](https://github.com/ElasticEmail/elasticemail-csharp/blob/master/LICENSE). Copyright © 2021–2026 Elastic Email.
