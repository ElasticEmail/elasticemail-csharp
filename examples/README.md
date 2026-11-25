# C# examples

One small program per API call, for the Elastic Email C# library (the [`ElasticEmail`](https://www.nuget.org/packages/ElasticEmail) NuGet package). Each example in [functions/](functions) has a `.cs` file you can run and a `.md` guide that walks through the code.

## Requirements

- The [.NET SDK](https://dotnet.microsoft.com/download) 10 or later
- An Elastic Email API key with the access level the example needs (listed in the table below). Create one in your [API settings](https://help.elasticemail.com/en/articles/4799160-api-settings).
- For the send examples, a sender address on a [verified domain](https://help.elasticemail.com/en/articles/4934400-how-to-verify-your-domain)

## How the examples run

Each `.cs` file is a [file-based app](https://learn.microsoft.com/dotnet/core/sdk/file-based-apps): a single C# file with top-level statements and no project file. Its first line,

```csharp
#:package ElasticEmail@4.4.0
```

tells `dotnet run` to download the library from NuGet, so there is nothing to install by hand. These files aren't part of the library's build: the library project in `src/ElasticEmail` only compiles the files under its own folder.

## Run an example

1. Set your API key:

   ```bash
   export ELASTICEMAIL_API_KEY="your-api-key"
   ```

   On Windows PowerShell: `$env:ELASTICEMAIL_API_KEY = "your-api-key"`.

2. Open the example and replace the placeholder values, such as `myemail@domain.com` (your sender) and `johnsmith@domain.com` (the recipient), list, template and campaign names.

3. Run it from the `functions` folder:

   ```bash
   cd examples/functions
   dotnet run sendTransactionalEmails.cs
   ```

`uploadContacts.cs` reads `files/contacts.csv`, and `sendTransactionalEmailsWithAttachment.cs` reads `invoice.pdf`, both relative to the folder you run them from.

### Using an older .NET SDK

File-based apps need .NET 10. On an older SDK, create a console project, add the package, and paste the example into `Program.cs` without the `#:package` line:

```bash
dotnet new console -o ElasticEmailExample
cd ElasticEmailExample
dotnet add package ElasticEmail
```

## Examples

Example | Guide | Method | Required access level
--- | --- | --- | ---
[addCampaign](functions/addCampaign.cs) | [readme](functions/addCampaign.md) | `CampaignsPostAsync` | ModifyCampaigns
[addContacts](functions/addContacts.cs) | [readme](functions/addContacts.md) | `ContactsPostAsync` | ModifyContacts
[addList](functions/addList.cs) | [readme](functions/addList.md) | `ListsPostAsync` | ModifyContacts
[addTemplate](functions/addTemplate.cs) | [readme](functions/addTemplate.md) | `TemplatesPostAsync` | ModifyTemplates
[deleteCampaign](functions/deleteCampaign.cs) | [readme](functions/deleteCampaign.md) | `CampaignsByNameDeleteAsync` | ModifyCampaigns
[deleteContact](functions/deleteContact.cs) | [readme](functions/deleteContact.md) | `ContactsByEmailDeleteAsync` | ModifyContacts
[deleteContacts](functions/deleteContacts.cs) | [readme](functions/deleteContacts.md) | `ContactsDeletePostAsync` | ModifyContacts
[deleteList](functions/deleteList.cs) | [readme](functions/deleteList.md) | `ListsByNameDeleteAsync` | ModifyContacts
[deleteTemplate](functions/deleteTemplate.cs) | [readme](functions/deleteTemplate.md) | `TemplatesByNameDeleteAsync` | ModifyTemplates
[exportContacts](functions/exportContacts.cs) | [readme](functions/exportContacts.md) | `ContactsExportPostAsync` | Export
[loadCampaign](functions/loadCampaign.cs) | [readme](functions/loadCampaign.md) | `CampaignsByNameGetAsync` | ViewCampaigns
[loadCampaignsStats](functions/loadCampaignsStats.cs) | [readme](functions/loadCampaignsStats.md) | `StatisticsCampaignsGetAsync` | ViewChannels
[loadChannelsStats](functions/loadChannelsStats.cs) | [readme](functions/loadChannelsStats.md) | `StatisticsChannelsGetAsync` | ViewChannels
[loadList](functions/loadList.cs) | [readme](functions/loadList.md) | `ListsByNameGetAsync` | ViewContacts
[loadStatistics](functions/loadStatistics.cs) | [readme](functions/loadStatistics.md) | `StatisticsGetAsync` | ViewReports
[loadTemplate](functions/loadTemplate.cs) | [readme](functions/loadTemplate.md) | `TemplatesByNameGetAsync` | ViewTemplates
[sendBulkEmails](functions/sendBulkEmails.cs) | [readme](functions/sendBulkEmails.md) | `EmailsPostAsync` | SendHttp
[sendTransactionalEmails](functions/sendTransactionalEmails.cs) | [readme](functions/sendTransactionalEmails.md) | `EmailsTransactionalPostAsync` | SendHttp
[sendTransactionalEmailsWithAttachment](functions/sendTransactionalEmailsWithAttachment.cs) | [readme](functions/sendTransactionalEmailsWithAttachment.md) | `EmailsTransactionalPostAsync` | SendHttp
[updateCampaign](functions/updateCampaign.cs) | [readme](functions/updateCampaign.md) | `CampaignsByNamePutAsync` | ModifyCampaigns
[uploadContacts](functions/uploadContacts.cs) | [readme](functions/uploadContacts.md) | `ContactsImportPostAsync` | ModifyContacts

The send examples pass an `Idempotency-Key`, so a send retried after a timeout can't go out twice, and print it next to the `TransactionID`. See [Retry a send safely](../README.md#retry-a-send-safely-idempotency-key) in the main README.

More complete samples, including web apps, webhooks and inbound email, are in the [Elastic Email examples repository](https://github.com/ElasticEmail/elasticemail-examples/tree/main/dotnet-elasticemail-examples).
