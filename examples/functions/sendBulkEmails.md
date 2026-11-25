# Send Bulk Emails

This guide shows how to send a bulk email with merge fields using the Elastic Email C# library.

*Required Access Level: SendHttp*

## What's a bulk email?

A bulk email is one send job to many recipients, such as a newsletter. Each recipient can carry its own merge fields, so `{name}` in the body becomes that recipient's name. For one message to the recipients of a single action (a receipt, a password reset), send a transactional email instead.

## Preparation

Install the [.NET SDK](https://dotnet.microsoft.com/download) 10 or later.

Create a file named `sendBulkEmails.cs`. Its first line, `#:package ElasticEmail@4.4.0`, tells `dotnet run` to download the `ElasticEmail` package from NuGet, so you don't need a project file.

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

Create an instance of `EmailsApi`:

```csharp
var emails = new EmailsApi(config);
```

Describe the message: the recipients with their merge fields, and the content with an HTML and a plain-text body. The `from` address must use a domain you've [verified](https://help.elasticemail.com/en/articles/4934400-how-to-verify-your-domain).

```csharp
var message = new EmailMessageData(
    recipients: new List<EmailRecipient>
    {
        new EmailRecipient(
            email: "johnsmith@domain.com",
            fields: new Dictionary<string, string> { ["name"] = "John" }
        )
    },
    content: new EmailContent(
        from: "myemail@domain.com",
        replyTo: "myemail@domain.com",
        subject: "Example email",
        body: new List<BodyPart>
        {
            new BodyPart(BodyContentType.HTML, "<strong>Hi {name}!</strong>", "utf-8"),
            new BodyPart(BodyContentType.PlainText, "Hi {name}!", "utf-8")
        }
    )
);
```

Create an `Idempotency-Key` for this send. If the request times out, retry it with the same key and the same message: Elastic Email returns the first result instead of sending the email twice. Create a new key for every new email.

```csharp
var idempotencyKey = Guid.NewGuid().ToString();
```

Call `EmailsPostAsync` with the message and the key, and print the IDs. Errors from the API arrive as an `ApiException`, with the HTTP status in `ErrorCode`:

```csharp
try
{
    EmailSend result = await emails.EmailsPostAsync(message, idempotencyKey);
    Console.WriteLine($"Sent. TransactionID: {result.TransactionID}, MessageID: {result.MessageID}, Idempotency-Key: {idempotencyKey}");
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

// Sends one bulk email job; each recipient gets its own {name} merge field.
// Passes an Idempotency-Key so a retry can't send the job twice.
// Required API key access level: SendHttp
// Run: dotnet run sendBulkEmails.cs

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

var emails = new EmailsApi(config);

var message = new EmailMessageData(
    recipients: new List<EmailRecipient>
    {
        new EmailRecipient(
            email: "johnsmith@domain.com",
            fields: new Dictionary<string, string> { ["name"] = "John" }
        )
    },
    content: new EmailContent(
        from: "myemail@domain.com",
        replyTo: "myemail@domain.com",
        subject: "Example email",
        body: new List<BodyPart>
        {
            new BodyPart(BodyContentType.HTML, "<strong>Hi {name}!</strong>", "utf-8"),
            new BodyPart(BodyContentType.PlainText, "Hi {name}!", "utf-8")
        }
    )
);

var idempotencyKey = Guid.NewGuid().ToString();

try
{
    EmailSend result = await emails.EmailsPostAsync(message, idempotencyKey);
    Console.WriteLine($"Sent. TransactionID: {result.TransactionID}, MessageID: {result.MessageID}, Idempotency-Key: {idempotencyKey}");
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
dotnet run sendBulkEmails.cs
```
