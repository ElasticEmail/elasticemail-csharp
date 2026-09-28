<div align="center">

<img src="src/ElasticEmail/ee-logo.png" alt="Elastic Email" width="96" />

# Elastic Email C# SDK

The official C# / .NET client library for the [Elastic Email](https://elasticemail.com) REST API v4.

[![NuGet](https://img.shields.io/nuget/v/ElasticEmail?logo=nuget&label=NuGet&color=004880)](https://www.nuget.org/packages/ElasticEmail)
[![NuGet downloads](https://img.shields.io/nuget/dt/ElasticEmail?logo=nuget&label=downloads&color=004880)](https://www.nuget.org/packages/ElasticEmail)
[![.NET Standard](https://img.shields.io/badge/.NET%20Standard-2.0-512BD4?logo=dotnet)](https://learn.microsoft.com/dotnet/standard/net-standard)
[![API](https://img.shields.io/badge/API-v4-0A7BBB)](https://elasticemail.com/developers/api-documentation/rest-api)
[![OpenAPI Generator](https://img.shields.io/badge/generated%20by-OpenAPI%20Generator-6BA539?logo=openapiinitiative&logoColor=white)](https://openapi-generator.tech)
[![License: MIT](https://img.shields.io/github/license/ElasticEmail/elasticemail-csharp?color=yellow)](LICENSE)

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
- **Contacts, lists and segments.** Add, update, import, export and bulk-delete contacts.
- **Campaigns and automations.** Create, update, pause and trigger automations for a contact.
- **Templates, files and attachments.** Manage templates and uploaded files.
- **Domains.** Verify sending domains and check SPF, DKIM, tracking and certificate status.
- **Webhooks and inbound routes.** Receive delivery events and route incoming mail.
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
<PackageReference Include="ElasticEmail" Version="4.2.0" />
```

NuGet installs the dependencies ([RestSharp](https://www.nuget.org/packages/RestSharp), [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json), [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes) and [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations)) for you.

## Quick start

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

The `from` address must use a domain you've verified in your Elastic Email account.

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

## More examples

More complete, runnable samples are in the **[Elastic Email examples repository](https://github.com/ElasticEmail/elasticemail-examples)**. It covers transactional email, SMTP, webhooks, inbound email, contacts and serverless platforms across 20+ languages and frameworks.

- 🟣 [.NET / C# examples](https://github.com/ElasticEmail/elasticemail-examples/tree/main/dotnet-elasticemail-examples)
- 📂 [All examples](https://github.com/ElasticEmail/elasticemail-examples)

## Authentication

| Scheme | Header | Used for |
| --- | --- | --- |
| `apikey` | `X-ElasticEmail-ApiKey` | All standard API calls |
| `ApiKeyAuthCustomBranding` | `X-Auth-Token` | Custom-branding (white-label) accounts |

## API limits

- Up to **20 concurrent connections** per account
- A hard timeout of **600 seconds** per request

## API reference

All URIs are relative to `https://api.elasticemail.com/v4`. The SDK covers **114 endpoints** across 16 API classes: `CampaignsApi`, `ContactsApi`, `DomainsApi`, `EmailsApi`, `EventsApi`, `FilesApi`, `InboundRouteApi`, `ListsApi`, `SecurityApi`, `SegmentsApi`, `StatisticsApi`, `SubAccountsApi`, `SuppressionsApi`, `TemplatesApi`, `VerificationsApi` and `WebhookApi`.

<details>
<summary><strong>Show all endpoints</strong></summary>


All URIs are relative to *https://api.elasticemail.com/v4*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CampaignsApi* | [**CampaignsAutomationByNameTriggerPost**](docs/CampaignsApi.md#campaignsautomationbynametriggerpost) | **POST** /campaigns/automation/{name}/trigger | Trigger Automation for Contact
*CampaignsApi* | [**CampaignsByNameDelete**](docs/CampaignsApi.md#campaignsbynamedelete) | **DELETE** /campaigns/{name} | Delete Campaign
*CampaignsApi* | [**CampaignsByNameGet**](docs/CampaignsApi.md#campaignsbynameget) | **GET** /campaigns/{name} | Load Campaign
*CampaignsApi* | [**CampaignsByNamePausePut**](docs/CampaignsApi.md#campaignsbynamepauseput) | **PUT** /campaigns/{name}/pause | Pause Campaign
*CampaignsApi* | [**CampaignsByNamePut**](docs/CampaignsApi.md#campaignsbynameput) | **PUT** /campaigns/{name} | Update Campaign
*CampaignsApi* | [**CampaignsGet**](docs/CampaignsApi.md#campaignsget) | **GET** /campaigns | Load Campaigns
*CampaignsApi* | [**CampaignsPost**](docs/CampaignsApi.md#campaignspost) | **POST** /campaigns | Add Campaign
*ContactsApi* | [**ContactsByEmailDelete**](docs/ContactsApi.md#contactsbyemaildelete) | **DELETE** /contacts/{email} | Delete Contact
*ContactsApi* | [**ContactsByEmailGet**](docs/ContactsApi.md#contactsbyemailget) | **GET** /contacts/{email} | Load Contact
*ContactsApi* | [**ContactsByEmailPut**](docs/ContactsApi.md#contactsbyemailput) | **PUT** /contacts/{email} | Update Contact
*ContactsApi* | [**ContactsDeletePost**](docs/ContactsApi.md#contactsdeletepost) | **POST** /contacts/delete | Delete Contacts Bulk
*ContactsApi* | [**ContactsExportByIdStatusGet**](docs/ContactsApi.md#contactsexportbyidstatusget) | **GET** /contacts/export/{id}/status | Check Export Status
*ContactsApi* | [**ContactsExportPost**](docs/ContactsApi.md#contactsexportpost) | **POST** /contacts/export | Export Contacts
*ContactsApi* | [**ContactsGet**](docs/ContactsApi.md#contactsget) | **GET** /contacts | Load Contacts
*ContactsApi* | [**ContactsImportPost**](docs/ContactsApi.md#contactsimportpost) | **POST** /contacts/import | Upload Contacts
*ContactsApi* | [**ContactsPost**](docs/ContactsApi.md#contactspost) | **POST** /contacts | Add Contact
*DomainsApi* | [**DomainsByDomainDelete**](docs/DomainsApi.md#domainsbydomaindelete) | **DELETE** /domains/{domain} | Delete Domain
*DomainsApi* | [**DomainsByDomainGet**](docs/DomainsApi.md#domainsbydomainget) | **GET** /domains/{domain} | Load Domain
*DomainsApi* | [**DomainsByDomainPut**](docs/DomainsApi.md#domainsbydomainput) | **PUT** /domains/{domain} | Update Domain
*DomainsApi* | [**DomainsByDomainRestrictedGet**](docs/DomainsApi.md#domainsbydomainrestrictedget) | **GET** /domains/{domain}/restricted | Check for domain restriction
*DomainsApi* | [**DomainsByDomainVerificationPut**](docs/DomainsApi.md#domainsbydomainverificationput) | **PUT** /domains/{domain}/verification | Verify Domain
*DomainsApi* | [**DomainsByEmailDefaultPatch**](docs/DomainsApi.md#domainsbyemaildefaultpatch) | **PATCH** /domains/{email}/default | Set Default
*DomainsApi* | [**DomainsGet**](docs/DomainsApi.md#domainsget) | **GET** /domains | Load Domains
*DomainsApi* | [**DomainsPost**](docs/DomainsApi.md#domainspost) | **POST** /domains | Add Domain
*EmailsApi* | [**EmailsByMsgidViewGet**](docs/EmailsApi.md#emailsbymsgidviewget) | **GET** /emails/{msgid}/view | View Email
*EmailsApi* | [**EmailsByTransactionidStatusGet**](docs/EmailsApi.md#emailsbytransactionidstatusget) | **GET** /emails/{transactionid}/status | Get Status
*EmailsApi* | [**EmailsMergefilePost**](docs/EmailsApi.md#emailsmergefilepost) | **POST** /emails/mergefile | Send Bulk Emails CSV
*EmailsApi* | [**EmailsPost**](docs/EmailsApi.md#emailspost) | **POST** /emails | Send Bulk Emails
*EmailsApi* | [**EmailsTransactionalPost**](docs/EmailsApi.md#emailstransactionalpost) | **POST** /emails/transactional | Send Transactional Email
*EventsApi* | [**EventsByTransactionidGet**](docs/EventsApi.md#eventsbytransactionidget) | **GET** /events/{transactionid} | Load Email Events
*EventsApi* | [**EventsChannelsByNameExportPost**](docs/EventsApi.md#eventschannelsbynameexportpost) | **POST** /events/channels/{name}/export | Export Channel Events
*EventsApi* | [**EventsChannelsByNameGet**](docs/EventsApi.md#eventschannelsbynameget) | **GET** /events/channels/{name} | Load Channel Events
*EventsApi* | [**EventsChannelsExportByIdStatusGet**](docs/EventsApi.md#eventschannelsexportbyidstatusget) | **GET** /events/channels/export/{id}/status | Check Channel Export Status
*EventsApi* | [**EventsExportByIdStatusGet**](docs/EventsApi.md#eventsexportbyidstatusget) | **GET** /events/export/{id}/status | Check Export Status
*EventsApi* | [**EventsExportPost**](docs/EventsApi.md#eventsexportpost) | **POST** /events/export | Export Events
*EventsApi* | [**EventsGet**](docs/EventsApi.md#eventsget) | **GET** /events | Load Events
*FilesApi* | [**FilesByNameDelete**](docs/FilesApi.md#filesbynamedelete) | **DELETE** /files/{name} | Delete File
*FilesApi* | [**FilesByNameGet**](docs/FilesApi.md#filesbynameget) | **GET** /files/{name} | Download File
*FilesApi* | [**FilesByNameInfoGet**](docs/FilesApi.md#filesbynameinfoget) | **GET** /files/{name}/info | Load File Details
*FilesApi* | [**FilesGet**](docs/FilesApi.md#filesget) | **GET** /files | List Files
*FilesApi* | [**FilesPost**](docs/FilesApi.md#filespost) | **POST** /files | Upload File
*InboundRouteApi* | [**InboundrouteByIdDelete**](docs/InboundRouteApi.md#inboundroutebyiddelete) | **DELETE** /inboundroute/{id} | Delete Route
*InboundRouteApi* | [**InboundrouteByIdGet**](docs/InboundRouteApi.md#inboundroutebyidget) | **GET** /inboundroute/{id} | Get Route
*InboundRouteApi* | [**InboundrouteByIdPut**](docs/InboundRouteApi.md#inboundroutebyidput) | **PUT** /inboundroute/{id} | Update Route
*InboundRouteApi* | [**InboundrouteGet**](docs/InboundRouteApi.md#inboundrouteget) | **GET** /inboundroute | Get Routes
*InboundRouteApi* | [**InboundrouteOrderPut**](docs/InboundRouteApi.md#inboundrouteorderput) | **PUT** /inboundroute/order | Update Sorting
*InboundRouteApi* | [**InboundroutePost**](docs/InboundRouteApi.md#inboundroutepost) | **POST** /inboundroute | Create Route
*ListsApi* | [**ListsByListnameContactsGet**](docs/ListsApi.md#listsbylistnamecontactsget) | **GET** /lists/{listname}/contacts | Load Contacts in List
*ListsApi* | [**ListsByNameContactsPost**](docs/ListsApi.md#listsbynamecontactspost) | **POST** /lists/{name}/contacts | Add Contacts to List
*ListsApi* | [**ListsByNameContactsRemovePost**](docs/ListsApi.md#listsbynamecontactsremovepost) | **POST** /lists/{name}/contacts/remove | Remove Contacts from List
*ListsApi* | [**ListsByNameDelete**](docs/ListsApi.md#listsbynamedelete) | **DELETE** /lists/{name} | Delete List
*ListsApi* | [**ListsByNameGet**](docs/ListsApi.md#listsbynameget) | **GET** /lists/{name} | Load List
*ListsApi* | [**ListsByNamePut**](docs/ListsApi.md#listsbynameput) | **PUT** /lists/{name} | Update List
*ListsApi* | [**ListsGet**](docs/ListsApi.md#listsget) | **GET** /lists | Load Lists
*ListsApi* | [**ListsPost**](docs/ListsApi.md#listspost) | **POST** /lists | Add List
*SecurityApi* | [**SecurityApikeysByNameDelete**](docs/SecurityApi.md#securityapikeysbynamedelete) | **DELETE** /security/apikeys/{name} | Delete ApiKey
*SecurityApi* | [**SecurityApikeysByNameGet**](docs/SecurityApi.md#securityapikeysbynameget) | **GET** /security/apikeys/{name} | Load ApiKey
*SecurityApi* | [**SecurityApikeysByNamePut**](docs/SecurityApi.md#securityapikeysbynameput) | **PUT** /security/apikeys/{name} | Update ApiKey
*SecurityApi* | [**SecurityApikeysGet**](docs/SecurityApi.md#securityapikeysget) | **GET** /security/apikeys | List ApiKeys
*SecurityApi* | [**SecurityApikeysPost**](docs/SecurityApi.md#securityapikeyspost) | **POST** /security/apikeys | Add ApiKey
*SecurityApi* | [**SecuritySmtpByNameDelete**](docs/SecurityApi.md#securitysmtpbynamedelete) | **DELETE** /security/smtp/{name} | Delete SMTP Credential
*SecurityApi* | [**SecuritySmtpByNameGet**](docs/SecurityApi.md#securitysmtpbynameget) | **GET** /security/smtp/{name} | Load SMTP Credential
*SecurityApi* | [**SecuritySmtpByNamePut**](docs/SecurityApi.md#securitysmtpbynameput) | **PUT** /security/smtp/{name} | Update SMTP Credential
*SecurityApi* | [**SecuritySmtpGet**](docs/SecurityApi.md#securitysmtpget) | **GET** /security/smtp | List SMTP Credentials
*SecurityApi* | [**SecuritySmtpPost**](docs/SecurityApi.md#securitysmtppost) | **POST** /security/smtp | Add SMTP Credential
*SegmentsApi* | [**SegmentsByNameDelete**](docs/SegmentsApi.md#segmentsbynamedelete) | **DELETE** /segments/{name} | Delete Segment
*SegmentsApi* | [**SegmentsByNameGet**](docs/SegmentsApi.md#segmentsbynameget) | **GET** /segments/{name} | Load Segment
*SegmentsApi* | [**SegmentsByNamePut**](docs/SegmentsApi.md#segmentsbynameput) | **PUT** /segments/{name} | Update Segment
*SegmentsApi* | [**SegmentsGet**](docs/SegmentsApi.md#segmentsget) | **GET** /segments | Load Segments
*SegmentsApi* | [**SegmentsPost**](docs/SegmentsApi.md#segmentspost) | **POST** /segments | Add Segment
*StatisticsApi* | [**StatisticsCampaignsByNameGet**](docs/StatisticsApi.md#statisticscampaignsbynameget) | **GET** /statistics/campaigns/{name} | Load Campaign Stats
*StatisticsApi* | [**StatisticsCampaignsGet**](docs/StatisticsApi.md#statisticscampaignsget) | **GET** /statistics/campaigns | Load Campaigns Stats
*StatisticsApi* | [**StatisticsChannelsByNameGet**](docs/StatisticsApi.md#statisticschannelsbynameget) | **GET** /statistics/channels/{name} | Load Channel Stats
*StatisticsApi* | [**StatisticsChannelsGet**](docs/StatisticsApi.md#statisticschannelsget) | **GET** /statistics/channels | Load Channels Stats
*StatisticsApi* | [**StatisticsGet**](docs/StatisticsApi.md#statisticsget) | **GET** /statistics | Load Statistics
*SubAccountsApi* | [**SubaccountsByEmailApikeyGet**](docs/SubAccountsApi.md#subaccountsbyemailapikeyget) | **GET** /subaccounts/{email}/apikey | Get SubAccount ApiKey
*SubAccountsApi* | [**SubaccountsByEmailCreditsPatch**](docs/SubAccountsApi.md#subaccountsbyemailcreditspatch) | **PATCH** /subaccounts/{email}/credits | Add, Subtract Email Credits
*SubAccountsApi* | [**SubaccountsByEmailDelete**](docs/SubAccountsApi.md#subaccountsbyemaildelete) | **DELETE** /subaccounts/{email} | Delete SubAccount
*SubAccountsApi* | [**SubaccountsByEmailGet**](docs/SubAccountsApi.md#subaccountsbyemailget) | **GET** /subaccounts/{email} | Load SubAccount
*SubAccountsApi* | [**SubaccountsByEmailSettingsEmailPut**](docs/SubAccountsApi.md#subaccountsbyemailsettingsemailput) | **PUT** /subaccounts/{email}/settings/email | Update SubAccount Email Settings
*SubAccountsApi* | [**SubaccountsGet**](docs/SubAccountsApi.md#subaccountsget) | **GET** /subaccounts | Load SubAccounts
*SubAccountsApi* | [**SubaccountsPost**](docs/SubAccountsApi.md#subaccountspost) | **POST** /subaccounts | Add SubAccount
*SuppressionsApi* | [**SuppressionsBouncesGet**](docs/SuppressionsApi.md#suppressionsbouncesget) | **GET** /suppressions/bounces | Get Bounce List
*SuppressionsApi* | [**SuppressionsBouncesImportPost**](docs/SuppressionsApi.md#suppressionsbouncesimportpost) | **POST** /suppressions/bounces/import | Add Bounces Async
*SuppressionsApi* | [**SuppressionsBouncesPost**](docs/SuppressionsApi.md#suppressionsbouncespost) | **POST** /suppressions/bounces | Add Bounces
*SuppressionsApi* | [**SuppressionsByEmailDelete**](docs/SuppressionsApi.md#suppressionsbyemaildelete) | **DELETE** /suppressions/{email} | Delete Suppression
*SuppressionsApi* | [**SuppressionsByEmailGet**](docs/SuppressionsApi.md#suppressionsbyemailget) | **GET** /suppressions/{email} | Get Suppression
*SuppressionsApi* | [**SuppressionsComplaintsGet**](docs/SuppressionsApi.md#suppressionscomplaintsget) | **GET** /suppressions/complaints | Get Complaints List
*SuppressionsApi* | [**SuppressionsComplaintsImportPost**](docs/SuppressionsApi.md#suppressionscomplaintsimportpost) | **POST** /suppressions/complaints/import | Add Complaints Async
*SuppressionsApi* | [**SuppressionsComplaintsPost**](docs/SuppressionsApi.md#suppressionscomplaintspost) | **POST** /suppressions/complaints | Add Complaints
*SuppressionsApi* | [**SuppressionsGet**](docs/SuppressionsApi.md#suppressionsget) | **GET** /suppressions | Get Suppressions
*SuppressionsApi* | [**SuppressionsUnsubscribesGet**](docs/SuppressionsApi.md#suppressionsunsubscribesget) | **GET** /suppressions/unsubscribes | Get Unsubscribes List
*SuppressionsApi* | [**SuppressionsUnsubscribesImportPost**](docs/SuppressionsApi.md#suppressionsunsubscribesimportpost) | **POST** /suppressions/unsubscribes/import | Add Unsubscribes Async
*SuppressionsApi* | [**SuppressionsUnsubscribesPost**](docs/SuppressionsApi.md#suppressionsunsubscribespost) | **POST** /suppressions/unsubscribes | Add Unsubscribes
*TemplatesApi* | [**TemplatesByNameDelete**](docs/TemplatesApi.md#templatesbynamedelete) | **DELETE** /templates/{name} | Delete Template
*TemplatesApi* | [**TemplatesByNameGet**](docs/TemplatesApi.md#templatesbynameget) | **GET** /templates/{name} | Load Template
*TemplatesApi* | [**TemplatesByNamePut**](docs/TemplatesApi.md#templatesbynameput) | **PUT** /templates/{name} | Update Template
*TemplatesApi* | [**TemplatesGet**](docs/TemplatesApi.md#templatesget) | **GET** /templates | Load Templates
*TemplatesApi* | [**TemplatesPost**](docs/TemplatesApi.md#templatespost) | **POST** /templates | Add Template
*VerificationsApi* | [**VerificationsByEmailDelete**](docs/VerificationsApi.md#verificationsbyemaildelete) | **DELETE** /verifications/{email} | Delete Email Verification Result
*VerificationsApi* | [**VerificationsByEmailGet**](docs/VerificationsApi.md#verificationsbyemailget) | **GET** /verifications/{email} | Get Email Verification Result
*VerificationsApi* | [**VerificationsByEmailPost**](docs/VerificationsApi.md#verificationsbyemailpost) | **POST** /verifications/{email} | Verify Email
*VerificationsApi* | [**VerificationsFilesByIdDelete**](docs/VerificationsApi.md#verificationsfilesbyiddelete) | **DELETE** /verifications/files/{id} | Delete File Verification Result
*VerificationsApi* | [**VerificationsFilesByIdResultDownloadGet**](docs/VerificationsApi.md#verificationsfilesbyidresultdownloadget) | **GET** /verifications/files/{id}/result/download | Download File Verification Result
*VerificationsApi* | [**VerificationsFilesByIdResultGet**](docs/VerificationsApi.md#verificationsfilesbyidresultget) | **GET** /verifications/files/{id}/result | Get Detailed File Verification Result
*VerificationsApi* | [**VerificationsFilesByIdVerificationPost**](docs/VerificationsApi.md#verificationsfilesbyidverificationpost) | **POST** /verifications/files/{id}/verification | Start verification
*VerificationsApi* | [**VerificationsFilesPost**](docs/VerificationsApi.md#verificationsfilespost) | **POST** /verifications/files | Upload File with Emails
*VerificationsApi* | [**VerificationsFilesResultGet**](docs/VerificationsApi.md#verificationsfilesresultget) | **GET** /verifications/files/result | Get Files Verification Results
*VerificationsApi* | [**VerificationsGet**](docs/VerificationsApi.md#verificationsget) | **GET** /verifications | Get Emails Verification Results
*WebhookApi* | [**WebhookByPublicidDelete**](docs/WebhookApi.md#webhookbypubliciddelete) | **DELETE** /webhook/{publicid} | Delete Webhook
*WebhookApi* | [**WebhookByPublicidGet**](docs/WebhookApi.md#webhookbypublicidget) | **GET** /webhook/{publicid} | Load Webhook
*WebhookApi* | [**WebhookByPublicidPut**](docs/WebhookApi.md#webhookbypublicidput) | **PUT** /webhook/{publicid} | Update Webhook
*WebhookApi* | [**WebhookGet**](docs/WebhookApi.md#webhookget) | **GET** /webhook | Load Webhooks
*WebhookApi* | [**WebhookPost**](docs/WebhookApi.md#webhookpost) | **POST** /webhook | Add Webhook


</details>

## Models

<details>
<summary><strong>Show all 98 models</strong></summary>

 - [Model.AccessLevel](docs/AccessLevel.md)
 - [Model.AccountStatusEnum](docs/AccountStatusEnum.md)
 - [Model.ApiKey](docs/ApiKey.md)
 - [Model.ApiKeyPayload](docs/ApiKeyPayload.md)
 - [Model.BodyContentType](docs/BodyContentType.md)
 - [Model.BodyPart](docs/BodyPart.md)
 - [Model.Campaign](docs/Campaign.md)
 - [Model.CampaignOptions](docs/CampaignOptions.md)
 - [Model.CampaignRecipient](docs/CampaignRecipient.md)
 - [Model.CampaignStatus](docs/CampaignStatus.md)
 - [Model.CampaignTemplate](docs/CampaignTemplate.md)
 - [Model.CertificateValidationStatus](docs/CertificateValidationStatus.md)
 - [Model.ChannelLogStatusSummary](docs/ChannelLogStatusSummary.md)
 - [Model.CompressionFormat](docs/CompressionFormat.md)
 - [Model.ConsentData](docs/ConsentData.md)
 - [Model.ConsentTracking](docs/ConsentTracking.md)
 - [Model.Contact](docs/Contact.md)
 - [Model.ContactActivity](docs/ContactActivity.md)
 - [Model.ContactPayload](docs/ContactPayload.md)
 - [Model.ContactSource](docs/ContactSource.md)
 - [Model.ContactStatus](docs/ContactStatus.md)
 - [Model.ContactUpdatePayload](docs/ContactUpdatePayload.md)
 - [Model.ContactsList](docs/ContactsList.md)
 - [Model.DKIMRecord](docs/DKIMRecord.md)
 - [Model.DeliveryOptimizationType](docs/DeliveryOptimizationType.md)
 - [Model.DomainData](docs/DomainData.md)
 - [Model.DomainDetail](docs/DomainDetail.md)
 - [Model.DomainOwner](docs/DomainOwner.md)
 - [Model.DomainPayload](docs/DomainPayload.md)
 - [Model.DomainUpdatePayload](docs/DomainUpdatePayload.md)
 - [Model.EmailContent](docs/EmailContent.md)
 - [Model.EmailData](docs/EmailData.md)
 - [Model.EmailJobFailedStatus](docs/EmailJobFailedStatus.md)
 - [Model.EmailJobStatus](docs/EmailJobStatus.md)
 - [Model.EmailMessageData](docs/EmailMessageData.md)
 - [Model.EmailPredictedValidationStatus](docs/EmailPredictedValidationStatus.md)
 - [Model.EmailRecipient](docs/EmailRecipient.md)
 - [Model.EmailSend](docs/EmailSend.md)
 - [Model.EmailStatus](docs/EmailStatus.md)
 - [Model.EmailTransactionalMessageData](docs/EmailTransactionalMessageData.md)
 - [Model.EmailValidationResult](docs/EmailValidationResult.md)
 - [Model.EmailValidationStatus](docs/EmailValidationStatus.md)
 - [Model.EmailView](docs/EmailView.md)
 - [Model.EmailsPayload](docs/EmailsPayload.md)
 - [Model.EncodingType](docs/EncodingType.md)
 - [Model.EventType](docs/EventType.md)
 - [Model.EventsOrderBy](docs/EventsOrderBy.md)
 - [Model.ExportFileFormats](docs/ExportFileFormats.md)
 - [Model.ExportLink](docs/ExportLink.md)
 - [Model.ExportStatus](docs/ExportStatus.md)
 - [Model.FileInfo](docs/FileInfo.md)
 - [Model.FilePayload](docs/FilePayload.md)
 - [Model.FileUploadResult](docs/FileUploadResult.md)
 - [Model.InboundPayload](docs/InboundPayload.md)
 - [Model.InboundRoute](docs/InboundRoute.md)
 - [Model.InboundRouteActionType](docs/InboundRouteActionType.md)
 - [Model.InboundRouteFilterType](docs/InboundRouteFilterType.md)
 - [Model.ListPayload](docs/ListPayload.md)
 - [Model.ListUpdatePayload](docs/ListUpdatePayload.md)
 - [Model.LogJobStatus](docs/LogJobStatus.md)
 - [Model.LogStatusSummary](docs/LogStatusSummary.md)
 - [Model.MergeEmailPayload](docs/MergeEmailPayload.md)
 - [Model.MessageAttachment](docs/MessageAttachment.md)
 - [Model.MessageCategory](docs/MessageCategory.md)
 - [Model.MessageCategoryEnum](docs/MessageCategoryEnum.md)
 - [Model.NewApiKey](docs/NewApiKey.md)
 - [Model.NewSmtpCredentials](docs/NewSmtpCredentials.md)
 - [Model.Options](docs/Options.md)
 - [Model.RecipientEvent](docs/RecipientEvent.md)
 - [Model.Segment](docs/Segment.md)
 - [Model.SegmentPayload](docs/SegmentPayload.md)
 - [Model.SmtpCredentials](docs/SmtpCredentials.md)
 - [Model.SmtpCredentialsPayload](docs/SmtpCredentialsPayload.md)
 - [Model.SortOrderItem](docs/SortOrderItem.md)
 - [Model.SplitOptimizationType](docs/SplitOptimizationType.md)
 - [Model.SplitOptions](docs/SplitOptions.md)
 - [Model.SubAccountInfo](docs/SubAccountInfo.md)
 - [Model.SubaccountEmailCreditsPayload](docs/SubaccountEmailCreditsPayload.md)
 - [Model.SubaccountEmailSettings](docs/SubaccountEmailSettings.md)
 - [Model.SubaccountEmailSettingsPayload](docs/SubaccountEmailSettingsPayload.md)
 - [Model.SubaccountPayload](docs/SubaccountPayload.md)
 - [Model.SubaccountSettingsInfo](docs/SubaccountSettingsInfo.md)
 - [Model.SubaccountSettingsInfoPayload](docs/SubaccountSettingsInfoPayload.md)
 - [Model.Suppression](docs/Suppression.md)
 - [Model.Template](docs/Template.md)
 - [Model.TemplatePayload](docs/TemplatePayload.md)
 - [Model.TemplateScope](docs/TemplateScope.md)
 - [Model.TemplateType](docs/TemplateType.md)
 - [Model.TrackingType](docs/TrackingType.md)
 - [Model.TrackingValidationStatus](docs/TrackingValidationStatus.md)
 - [Model.TransactionalRecipient](docs/TransactionalRecipient.md)
 - [Model.Utm](docs/Utm.md)
 - [Model.VerificationFileResult](docs/VerificationFileResult.md)
 - [Model.VerificationFileResultDetails](docs/VerificationFileResultDetails.md)
 - [Model.VerificationStatus](docs/VerificationStatus.md)
 - [Model.Webhook](docs/Webhook.md)
 - [Model.WebhookCreatePayload](docs/WebhookCreatePayload.md)
 - [Model.WebhookUpdatePayload](docs/WebhookUpdatePayload.md)


</details>

## Known issues

- RestSharp on .NET Core creates a new socket for each API call, which can exhaust sockets under heavy load. Reuse API client instances where you can. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

## Versioning

The SDK follows the Elastic Email API v4. Package versions and release notes are listed on [NuGet](https://www.nuget.org/packages/ElasticEmail#versions-body-tab) and in [GitHub Releases](https://github.com/ElasticEmail/elasticemail-csharp/releases).

<details>
<summary>Build details</summary>

- API version: 4.0.0
- SDK version: 4.2.0
- Generator version: 7.11.0
- Build package: `org.openapitools.codegen.languages.CSharpClientCodegen`

</details>

## Contributing

Contributions are welcome! Most of this SDK is generated from the [OpenAPI specification](api/openapi.yaml), so please read [CONTRIBUTING.md](CONTRIBUTING.md) before opening a pull request.

- 🐛 [Report a bug](https://github.com/ElasticEmail/elasticemail-csharp/issues/new?template=bug_report.md)
- 💡 [Request a feature](https://github.com/ElasticEmail/elasticemail-csharp/issues/new?template=feature_request.md)
- 🔒 [Report a security issue](SECURITY.md)

This project follows the [Contributor Covenant Code of Conduct](CODE_OF_CONDUCT.md).

## Support

> [!IMPORTANT]
> The fastest way to get help is the **chat widget on [elasticemail.com](https://elasticemail.com)**. Our support team can help with your account, sending, deliverability and API questions.

- 💬 [Chat with support on elasticemail.com](https://elasticemail.com) (preferred)
- 📚 [API documentation](https://elasticemail.com/developers/api-documentation/rest-api)
- 🧪 [Examples repository](https://github.com/ElasticEmail/elasticemail-examples)
- 🐛 [GitHub issues](https://github.com/ElasticEmail/elasticemail-csharp/issues), for bugs in this SDK only

## License

Released under the [MIT License](LICENSE). Copyright © 2021–2026 Elastic Email.
