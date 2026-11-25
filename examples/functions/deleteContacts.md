# Delete Contacts

This guide shows how to delete several contacts in one call using the Elastic Email C# library.

*Required Access Level: ModifyContacts*

## What's a contact?

A contact is a recipient you send email to. You can group contacts into lists and segments.

## Preparation

Install the [.NET SDK](https://dotnet.microsoft.com/download) 10 or later.

Create a file named `deleteContacts.cs`. Its first line, `#:package ElasticEmail@4.4.0`, tells `dotnet run` to download the `ElasticEmail` package from NuGet, so you don't need a project file.

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

Create an instance of `ContactsApi`:

```csharp
var contacts = new ContactsApi(config);
```

List the contacts to delete. `EmailsPayload` takes either a list of emails or a `rule` (a query that selects contacts), not both:

```csharp
var emailsPayload = new EmailsPayload(
    emails: new List<string> { "johnsmith@domain.com", "janesmith@domain.com" }
);
```

Call `ContactsDeletePostAsync`. Errors from the API arrive as an `ApiException`, with the HTTP status in `ErrorCode`:

```csharp
try
{
    await contacts.ContactsDeletePostAsync(emailsPayload);
    Console.WriteLine("Contacts deleted.");
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
```

To delete a single contact, see [Delete Contact](deleteContact.md).

## The whole code to copy and paste

```csharp
#:package ElasticEmail@4.4.0

// Deletes several contacts in one call, by a list of email addresses.
// To delete one contact, see deleteContact.cs.
// Required API key access level: ModifyContacts
// Run: dotnet run deleteContacts.cs

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

var contacts = new ContactsApi(config);

var emailsPayload = new EmailsPayload(
    emails: new List<string> { "johnsmith@domain.com", "janesmith@domain.com" }
);

try
{
    await contacts.ContactsDeletePostAsync(emailsPayload);
    Console.WriteLine("Contacts deleted.");
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
dotnet run deleteContacts.cs
```
