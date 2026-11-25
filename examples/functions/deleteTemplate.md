# Delete Template

This guide shows how to delete a template using the Elastic Email C# library.

*Required Access Level: ModifyTemplates*

## What's a template?

A template is a saved subject and body that you can reuse in campaigns and sends.

## Preparation

Install the [.NET SDK](https://dotnet.microsoft.com/download) 10 or later.

Create a file named `deleteTemplate.cs`. Its first line, `#:package ElasticEmail@4.4.0`, tells `dotnet run` to download the `ElasticEmail` package from NuGet, so you don't need a project file.

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

Create an instance of `TemplatesApi`:

```csharp
var templates = new TemplatesApi(config);
```

Name the template to delete:

```csharp
var name = "My new template";
```

Call `TemplatesByNameDeleteAsync`. Errors from the API arrive as an `ApiException`, with the HTTP status in `ErrorCode`:

```csharp
try
{
    await templates.TemplatesByNameDeleteAsync(name);
    Console.WriteLine($"Template \"{name}\" deleted.");
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

// Deletes the template "My new template".
// Required API key access level: ModifyTemplates
// Run: dotnet run deleteTemplate.cs

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

var templates = new TemplatesApi(config);

var name = "My new template";

try
{
    await templates.TemplatesByNameDeleteAsync(name);
    Console.WriteLine($"Template \"{name}\" deleted.");
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
dotnet run deleteTemplate.cs
```
