# Send Transactional Emails With Attachment

This guide shows how to send a transactional email with a file attached using the Elastic Email C# library.

*Required Access Level: SendHttp*

## Preparation

Install the [.NET SDK](https://dotnet.microsoft.com/download) 10 or later.

Create a file named `sendTransactionalEmailsWithAttachment.cs`. Its first line, `#:package ElasticEmail@4.4.0`, tells `dotnet run` to download the `ElasticEmail` package from NuGet, so you don't need a project file.

Set your API key in the `ELASTICEMAIL_API_KEY` environment variable. Create the key in your [API settings](https://help.elasticemail.com/en/articles/4799160-api-settings) with the access level above:

```bash
export ELASTICEMAIL_API_KEY="your-api-key"
```

Put a PDF named `invoice.pdf` in the folder you run the example from.

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

Read the file to attach. This example looks for `invoice.pdf` in the current folder; put any PDF there, or change the path:

```csharp
var attachmentPath = "invoice.pdf";
if (!File.Exists(attachmentPath))
{
    Console.Error.WriteLine($"Attachment not found: {Path.GetFullPath(attachmentPath)}");
    return 1;
}
var attachmentBytes = await File.ReadAllBytesAsync(attachmentPath);
```

Describe the message with an HTML and a plain-text body, and add the file to `attachments`. The library sends the bytes base64-encoded for you. The `from` address must use a domain you've [verified](https://help.elasticemail.com/en/articles/4934400-how-to-verify-your-domain).

```csharp
var message = new EmailTransactionalMessageData(
    recipients: new TransactionalRecipient(to: new List<string> { "johnsmith@domain.com" }),
    content: new EmailContent(
        from: "myemail@domain.com",
        replyTo: "myemail@domain.com",
        subject: "Example transactional email with attachment",
        body: new List<BodyPart>
        {
            new BodyPart(BodyContentType.HTML, "<strong>Your invoice is attached.</strong>", "utf-8"),
            new BodyPart(BodyContentType.PlainText, "Your invoice is attached.", "utf-8")
        },
        attachments: new List<MessageAttachment>
        {
            new MessageAttachment(binaryContent: attachmentBytes, name: "invoice.pdf", contentType: "application/pdf")
        }
    )
);
```

Create an `Idempotency-Key` for this send. If the request times out, retry it with the same key and the same message: Elastic Email returns the first result instead of sending the email twice. Create a new key for every new email.

```csharp
var idempotencyKey = Guid.NewGuid().ToString();
```

Call `EmailsTransactionalPostAsync` with the message and the key, and print the IDs. Errors from the API arrive as an `ApiException`, with the HTTP status in `ErrorCode`:

```csharp
try
{
    EmailSend result = await emails.EmailsTransactionalPostAsync(message, idempotencyKey);
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

// Sends a transactional email with invoice.pdf (from the current folder) attached.
// Passes an Idempotency-Key so a retry can't send the email twice.
// Required API key access level: SendHttp
// Run: dotnet run sendTransactionalEmailsWithAttachment.cs

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

var attachmentPath = "invoice.pdf";
if (!File.Exists(attachmentPath))
{
    Console.Error.WriteLine($"Attachment not found: {Path.GetFullPath(attachmentPath)}");
    return 1;
}
var attachmentBytes = await File.ReadAllBytesAsync(attachmentPath);

var message = new EmailTransactionalMessageData(
    recipients: new TransactionalRecipient(to: new List<string> { "johnsmith@domain.com" }),
    content: new EmailContent(
        from: "myemail@domain.com",
        replyTo: "myemail@domain.com",
        subject: "Example transactional email with attachment",
        body: new List<BodyPart>
        {
            new BodyPart(BodyContentType.HTML, "<strong>Your invoice is attached.</strong>", "utf-8"),
            new BodyPart(BodyContentType.PlainText, "Your invoice is attached.", "utf-8")
        },
        attachments: new List<MessageAttachment>
        {
            new MessageAttachment(binaryContent: attachmentBytes, name: "invoice.pdf", contentType: "application/pdf")
        }
    )
);

var idempotencyKey = Guid.NewGuid().ToString();

try
{
    EmailSend result = await emails.EmailsTransactionalPostAsync(message, idempotencyKey);
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
dotnet run sendTransactionalEmailsWithAttachment.cs
```
