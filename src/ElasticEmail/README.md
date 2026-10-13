# Elastic Email C# SDK

The official .NET client for the [Elastic Email REST API v4](https://elasticemail.com/developers/api-documentation/rest-api). Send transactional and marketing email, manage contacts, lists, templates, domains, webhooks and suppressions, and read delivery statistics.

Targets .NET Standard 2.0, so it runs on .NET 6/7/8+, .NET Framework 4.6.1+ and Mono.

## Installation

```sh
dotnet add package ElasticEmail
```

## Quick start

Elastic Email only sends from verified domains. Before your first send, [verify your sending domain](https://help.elasticemail.com/en/articles/4934400-how-to-verify-your-domain) and use an address on that domain as the sender.

```csharp
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

var config = new Configuration();
config.BasePath = "https://api.elasticemail.com/v4";
config.ApiKey.Add("X-ElasticEmail-ApiKey", Environment.GetEnvironmentVariable("ELASTICEMAIL_API_KEY"));

var emails = new EmailsApi(config);

var message = new EmailTransactionalMessageData(
    recipients: new TransactionalRecipient(to: new List<string> { "john.doe@example.com" }),
    content: new EmailContent(
        from: "My App <no-reply@yourdomain.com>",
        subject: "Welcome aboard!",
        body: new List<BodyPart>
        {
            new BodyPart(BodyContentType.HTML, "<h1>Hello!</h1><p>Thanks for signing up.</p>"),
            new BodyPart(BodyContentType.PlainText, "Hello! Thanks for signing up.")
        }
    )
);

try
{
    EmailSend result = await emails.EmailsTransactionalPostAsync(message);
    Console.WriteLine($"Sent. TransactionID: {result.TransactionID}, MessageID: {result.MessageID}");
}
catch (ApiException e)
{
    Console.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
}
```

Keep your API key out of source code: load it from an environment variable, user secrets or a secrets manager. Create one in your [API settings](https://app.elasticemail.com/marketing/settings/new/manage-api).

## Retry a send safely (Idempotency-Key)

Pass an `Idempotency-Key` to `EmailsPost`, `EmailsTransactionalPost` or `EmailsMergefilePost` (or their `…Async` variants) so a retry after a timeout or a dropped connection can't send the same email twice. If the key was already processed, you get the stored response (same `TransactionID` and `MessageID`) and nothing is sent again.

```csharp
// One key per logical send; reuse it only to retry that same send.
var idempotencyKey = Guid.NewGuid().ToString();

EmailSend result = null;
for (var attempt = 1; result == null; attempt++)
{
    var wait = TimeSpan.FromSeconds(2);
    try
    {
        // Returns null when there was no response (network error or timeout).
        result = await emails.EmailsTransactionalPostAsync(message, idempotencyKey);
    }
    catch (ApiException e) when (attempt < 3 && (e.ErrorCode == 409 || e.ErrorCode >= 500))
    {
        if (e.Headers != null && e.Headers.TryGetValue("Retry-After", out var retryAfter))
            wait = TimeSpan.FromSeconds(int.Parse(retryAfter[0]));
    }
    if (result == null && attempt == 3)
        throw new TimeoutException("No response from Elastic Email after 3 attempts.");
    if (result == null)
        await Task.Delay(wait); // then retry with the same key and the same message
}
```

Reuse a key only to retry the same send, with the same body, within 24 hours: a different request with the same key returns `422`. A `409` means the first request is still running, and a `503` means the key couldn't be checked, so wait for `Retry-After` and retry with the same key. Without the key, sends work as before.

## Signed webhooks

Webhooks can be signed with HMAC-SHA256 and delivered as POST + JSON. Both are chosen when the webhook is created:

```csharp
var webhookApi = new WebhookApi(config);

var created = await webhookApi.WebhookPostAsync(new WebhookCreatePayload(
    name: "my-webhook",
    uRL: "https://your-app.example.com/webhook",
    notificationForSent: true,
    enableSigning: true,
    deliveryMethod: WebhookDeliveryMethod.PostJson));

// Returned only now - store it in your secret manager.
Console.WriteLine(created.SigningSecret);
```

Each request then carries `X-ElasticEmail-Timestamp`, `X-ElasticEmail-Signature: v1=<hex>` and `X-ElasticEmail-Webhook-Id`. To verify it, read the raw body before parsing it, reject timestamps more than 5 minutes off, compute `hex(HMAC-SHA256(secret, "{timestamp}\n{METHOD}\n{raw path and query}\n{raw body}"))` and compare it with every `v1=` entry in constant time. Return `401` on a mismatch; the event is retried. Rotate the secret with `WebhookByPublicidSecretRotatePostAsync`.

## Links

- [REST API documentation](https://elasticemail.com/developers/api-documentation/rest-api)
- [Help center](https://help.elasticemail.com)
- [Full SDK reference (every API method and model)](https://github.com/ElasticEmail/elasticemail-csharp#api-reference)
- [Examples for ASP.NET Core and console apps](https://github.com/ElasticEmail/elasticemail-examples/tree/main/dotnet-elasticemail-examples)
- [Release notes](https://github.com/ElasticEmail/elasticemail-csharp/releases)
- [Report an issue](https://github.com/ElasticEmail/elasticemail-csharp/issues)

## License

MIT
