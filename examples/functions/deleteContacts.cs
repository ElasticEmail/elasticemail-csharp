#:package ElasticEmail@4.4.0

// Deletes several contacts in one call, by a list of email addresses.
// To delete one contact, see deleteContact.cs.
// Required API key access level: ModifyContacts
// Run: dotnet run deleteContacts.cs

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

var emailsPayload = new EmailsPayload(
    emails: new List<string> { "johnsmith@domain.com", "janesmith@domain.com" }
);

try
{
    await contacts.ContactsDeletePostAsync(emailsPayload);
    Console.WriteLine("Contacts deleted.");
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
