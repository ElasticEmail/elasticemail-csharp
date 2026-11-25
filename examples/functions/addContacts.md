# Add Contacts

This guide shows how to add contacts to your account using the Elastic Email C# library.

*Required Access Level: ModifyContacts*

## What's a contact?

A contact is a recipient you send email to. You can group contacts into lists and segments.

## Preparation

Install the [.NET SDK](https://dotnet.microsoft.com/download) 10 or later.

Create a file named `addContacts.cs`. Its first line, `#:package ElasticEmail@4.4.0`, tells `dotnet run` to download the `ElasticEmail` package from NuGet, so you don't need a project file.

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

Describe the contacts to add. One call takes up to 1000 contacts:

```csharp
var newContacts = new List<ContactPayload>
{
    new ContactPayload(
        email: "johnsmith@domain.com",
        status: ContactStatus.Active,
        firstName: "John",
        lastName: "Smith"
    )
};
```

Optionally, name the lists the contacts should join:

```csharp
var listNames = new List<string> { "New list" };
```

Call `ContactsPostAsync` and print the added contacts. Errors from the API arrive as an `ApiException`, with the HTTP status in `ErrorCode`:

```csharp
try
{
    List<Contact> result = await contacts.ContactsPostAsync(newContacts, listNames);
    foreach (var contact in result)
    {
        Console.WriteLine($"Added {contact.Email} ({contact.Status})");
    }
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

// Adds a contact to your account and to the list "New list".
// One call can add up to 1000 contacts.
// Required API key access level: ModifyContacts
// Run: dotnet run addContacts.cs

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

var newContacts = new List<ContactPayload>
{
    new ContactPayload(
        email: "johnsmith@domain.com",
        status: ContactStatus.Active,
        firstName: "John",
        lastName: "Smith"
    )
};

var listNames = new List<string> { "New list" };

try
{
    List<Contact> result = await contacts.ContactsPostAsync(newContacts, listNames);
    foreach (var contact in result)
    {
        Console.WriteLine($"Added {contact.Email} ({contact.Status})");
    }
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
dotnet run addContacts.cs
```
