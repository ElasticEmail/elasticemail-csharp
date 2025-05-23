# ElasticEmail - the C# library for the Elastic Email REST API

This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.

Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.

The API has a limit of 20 concurrent connections and a hard timeout of 600 seconds per request.

To start using this API, you will need your Access Token (available [here](https://app.elasticemail.com/marketing/settings/new/manage-api)). Remember to keep it safe. Required access levels are listed in the given request’s description.

Downloadable library clients can be found in our Github repository [here](https://github.com/ElasticEmail?tab=repositories&q=%22rest+api%22+in%3Areadme)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 4.0.0
- SDK version: 4.0.26
- Generator version: 7.5.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;
```
<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new CampaignsApi(config);
            var name = "name_example";  // string | Name of Campaign to delete

            try
            {
                // Delete Campaign
                apiInstance.CampaignsByNameDelete(name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CampaignsApi.CampaignsByNameDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>


All URIs are relative to *https://api.elasticemail.com/v4*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
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


<a id="documentation-for-models"></a>
## Documentation for Models

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


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="apikey"></a>
### apikey

- **Type**: API key
- **API key parameter name**: X-ElasticEmail-ApiKey
- **Location**: HTTP header

<a id="ApiKeyAuthCustomBranding"></a>
### ApiKeyAuthCustomBranding

- **Type**: API key
- **API key parameter name**: X-Auth-Token
- **Location**: HTTP header

