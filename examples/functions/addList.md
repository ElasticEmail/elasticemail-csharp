# Add List

This guide shows how to create a contact list using the Elastic Email C# library.

*Required Access Level: ModifyContacts*

## What's a list?

A list is a named group of contacts. Campaigns and bulk sends can target one or more lists.

## Preparation

Install the [.NET SDK](https://dotnet.microsoft.com/download) 10 or later.

Create a file named `addList.cs`. Its first line, `#:package ElasticEmail@4.4.0`, tells `dotnet run` to download the `ElasticEmail` package from NuGet, so you don't need a project file.

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

Create an instance of `ListsApi`:

```csharp
var lists = new ListsApi(config);
```

Describe the list. `emails` takes contacts that already exist on your account:

```csharp
var listPayload = new ListPayload(
    listName: "Best contacts",
    allowUnsubscribe: true,
    emails: new List<string> { "johnsmith@domain.com" }
);
```

Call `ListsPostAsync` and print the new list. Errors from the API arrive as an `ApiException`, with the HTTP status in `ErrorCode`:

```csharp
try
{
    ContactsList result = await lists.ListsPostAsync(listPayload);
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

// Creates the list "Best contacts" with one existing contact in it.
// Required API key access level: ModifyContacts
// Run: dotnet run addList.cs

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

var lists = new ListsApi(config);

var listPayload = new ListPayload(
    listName: "Best contacts",
    allowUnsubscribe: true,
    emails: new List<string> { "johnsmith@domain.com" }
);

try
{
    ContactsList result = await lists.ListsPostAsync(listPayload);
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
dotnet run addList.cs
```
