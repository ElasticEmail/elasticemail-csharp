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
