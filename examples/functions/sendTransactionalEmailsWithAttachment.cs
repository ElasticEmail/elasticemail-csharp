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
