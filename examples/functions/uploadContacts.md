# Upload Contacts

This guide shows how to add contacts by uploading a CSV file using the Elastic Email C# library.

*Required Access Level: ModifyContacts*

## What's a contact?

A contact is a recipient you send email to. You can group contacts into lists and segments.

## Preparation

Install the [.NET SDK](https://dotnet.microsoft.com/download) 10 or later.

Create a file named `uploadContacts.cs`. Its first line, `#:package ElasticEmail@4.4.0`, tells `dotnet run` to download the `ElasticEmail` package from NuGet, so you don't need a project file.

Set your API key in the `ELASTICEMAIL_API_KEY` environment variable. Create the key in your [API settings](https://help.elasticemail.com/en/articles/4799160-api-settings) with the access level above:

```bash
export ELASTICEMAIL_API_KEY="your-api-key"
```

Save a CSV file as `files/contacts.csv` next to `uploadContacts.cs` (or use the one in this folder), and run the example from that folder.

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

Open the CSV file. The only required column is `Email`; you can also add columns such as `FirstName`, `LastName`, `Status` or `ConsentDate`. [files/contacts.csv](files/contacts.csv) is a minimal example:

```csharp
await using var csv = File.OpenRead(Path.Combine("files", "contacts.csv"));
```

Call `ContactsImportPostAsync` with the list to add the contacts to, the file encoding and the file, and print a confirmation. Errors from the API arrive as an `ApiException`, with the HTTP status in `ErrorCode`:

```csharp
try
{
    await contacts.ContactsImportPostAsync(listName: "example list", encodingName: "utf-8", file: csv);
    Console.WriteLine("Contacts uploaded.");
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

// Uploads contacts from files/contacts.csv into the list "example list".
// Run it from the examples/functions folder so the relative path resolves.
// Required API key access level: ModifyContacts
// Run: dotnet run uploadContacts.cs

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

await using var csv = File.OpenRead(Path.Combine("files", "contacts.csv"));

try
{
    await contacts.ContactsImportPostAsync(listName: "example list", encodingName: "utf-8", file: csv);
    Console.WriteLine("Contacts uploaded.");
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
dotnet run uploadContacts.cs
```
