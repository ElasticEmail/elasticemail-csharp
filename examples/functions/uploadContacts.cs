#:package ElasticEmail@4.4.0

// Uploads contacts from files/contacts.csv into the list "example list".
// Run it from the examples/functions folder so the relative path resolves.
// Required API key access level: ModifyContacts
// Run: dotnet run uploadContacts.cs

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

await using var csv = File.OpenRead(Path.Combine("files", "contacts.csv"));

try
{
    await contacts.ContactsImportPostAsync(listName: "example list", encodingName: "utf-8", file: csv);
    Console.WriteLine("Contacts uploaded.");
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
