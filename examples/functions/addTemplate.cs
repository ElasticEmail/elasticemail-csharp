#:package ElasticEmail@4.4.0

// Adds the template "My new template" with an HTML and a plain-text body.
// Required API key access level: ModifyTemplates
// Run: dotnet run addTemplate.cs

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

var templatePayload = new TemplatePayload(
    name: "My new template",
    subject: "Default subject",
    body: new List<BodyPart>
    {
        new BodyPart(BodyContentType.HTML, "<p>My template</p>", "utf-8"),
        new BodyPart(BodyContentType.PlainText, "My template", "utf-8")
    },
    templateScope: TemplateScope.Personal
);

try
{
    Template result = await templates.TemplatesPostAsync(templatePayload);
    Console.WriteLine(result.ToJson());
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
