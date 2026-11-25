#:package ElasticEmail@4.4.0

// Adds a contact to your account and to the list "New list".
// One call can add up to 1000 contacts.
// Required API key access level: ModifyContacts
// Run: dotnet run addContacts.cs

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

var newContacts = new List<ContactPayload>
{
    new ContactPayload(
        email: "johnsmith@domain.com",
        status: ContactStatus.Active,
        firstName: "John",
        lastName: "Smith"
    )
};

var listNames = new List<string> { "New list" };

try
{
    List<Contact> result = await contacts.ContactsPostAsync(newContacts, listNames);
    foreach (var contact in result)
    {
        Console.WriteLine($"Added {contact.Email} ({contact.Status})");
    }
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
