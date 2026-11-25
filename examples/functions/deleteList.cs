#:package ElasticEmail@4.4.0

// Deletes the list "Best contacts". The contacts in it stay on your account.
// Required API key access level: ModifyContacts
// Run: dotnet run deleteList.cs

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

var lists = new ListsApi(config);

var name = "Best contacts";

try
{
    await lists.ListsByNameDeleteAsync(name);
    Console.WriteLine($"List \"{name}\" deleted.");
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
