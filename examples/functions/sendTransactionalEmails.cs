#:package ElasticEmail@4.4.0

// Sends a transactional email with an HTML and a plain-text body (up to 50 recipients per call).
// Passes an Idempotency-Key so a retry can't send the email twice.
// Required API key access level: SendHttp
// Run: dotnet run sendTransactionalEmails.cs

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

var message = new EmailTransactionalMessageData(
    recipients: new TransactionalRecipient(to: new List<string> { "johnsmith@domain.com" }),
    content: new EmailContent(
        from: "myemail@domain.com",
        replyTo: "myemail@domain.com",
        subject: "Example transactional email",
        body: new List<BodyPart>
        {
            new BodyPart(BodyContentType.HTML, "<strong>Mail content.</strong>", "utf-8"),
            new BodyPart(BodyContentType.PlainText, "Mail content.", "utf-8")
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
