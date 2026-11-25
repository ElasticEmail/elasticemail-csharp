#:package ElasticEmail@4.4.0

// Exports all contacts to a CSV file and prints the download link.
// Required API key access level: Export
// Run: dotnet run exportContacts.cs

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

try
{
    ExportLink result = await contacts.ContactsExportPostAsync(
        fileFormat: ExportFileFormats.Csv,
        compressionFormat: CompressionFormat.None,
        fileName: "exported.csv"
    );
    Console.WriteLine($"Export ID: {result.PublicExportID}");
    Console.WriteLine($"Download link: {result.Link}");
    return 0;
}
catch (ApiException e)
{
    Console.Error.WriteLine($"Elastic Email API error {e.ErrorCode}: {e.Message}");
    return 1;
}
