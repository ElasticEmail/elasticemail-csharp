# Contacts class

This guide will walk you through the process of creating basic methods for contacts using the C# library.

*Required Access Level: ModifyContacts*

## What's a contact?

When using Elastic Email, you send emails to contacts – recipients who receive your emails. Contacts can be grouped by created segments or lists.

## Preparation
Create a Visual Studio project of your choosing, that's using at least .NET Framework 4.8.

Then, install our NuGet Package from https://www.nuget.org/packages/ElasticEmail/ in your project.

## Let's dig into the code
In the contact class load library namespaces using lines below:

```cs
using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;
```

Below code you will repeat in all contact's methods:
Generate and use your API key (remember to check a required access level):

```cs
Configuration config = new Configuration();
// Configure API key authorization: apikey
config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
```

Create an instance of ContactsApi that will be used to work with contact's methods.

```cs
var apiInstance = new ContactsApi(config);
```

# Add contact

Create an array with new contacts.
You can pass an array with up to 1000 contacts.
The Email field is mandatory, the rest is optional.

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/contactsPost

```cs
List<ContactPayload> myContacts = new List<ContactPayload>();
ContactPayload singleContact = new ContactPayload(email: "johnsmith@domain.com");
singleContact.FirstName = "John";
singleContact.LastName = "Smith";
myContacts.Add(singleContact);
```

Specify an existing list name in options, otherwise contacts will be added to all contacts.

```cs
List<string> listnames = new List<string>();
listnames.Add("yourList");
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, we will return the data that API sends us about the newly added contact.
Finally, call the API to add a contact:

```cs
try
{
    return apiInstance.ContactsPost(myContacts, listnames);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ContactsApi.ContactsPost: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public List<Contact> AddContacts()
{
    Configuration config = new Configuration();

    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    /**
        * Add contacts
        * Example api call that adds new contacts.
        * Pass array with contact details to add up to 1000 contacts.
        * Specify a list name in options or add to all contacts.
        */

    var apiInstance = new ContactsApi(config);
    List<ContactPayload> myContacts = new List<ContactPayload>();
    ContactPayload singleContact = new ContactPayload(email: "johnsmith@domain.com");
    singleContact.FirstName = "John";
    singleContact.LastName = "Smith";
    myContacts.Add(singleContact);

    List<string> listnames = new List<string>();
    listnames.Add("yourList");

    try
    {
        return apiInstance.ContactsPost(myContacts, listnames);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling ContactsApi.ContactsPost: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Export Contacts

In this example we will export contacts to a CSV file.
Create options:

- fileFormat - specify format in which file should be created, options are: "Csv" "Xml" "Json".
- emails - select contacts to export by providing array of emails
- fileName - you can specify file name of your choice

Other options:

- rule - eg. rule=Status%20=%20Engaged – Query used for filtering
- compressionFormat - "None" "Zip"

Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/contactsExportPost

```cs
ExportFileFormats fileFormat = new ExportFileFormats();
fileFormat = ExportFileFormats.Csv;

List<string> emails = new List<string>();
emails.Add("johnsmith@domain.com");

string fileName = "exported.csv";
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a success messages and link to a file.
Finally, call the API to export contacts:

```cs
try
{
    apiInstance.ContactsExportPost(fileFormat, null, emails, null, fileName);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ContactsApi.ContactsExportPost: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public void ExportContacts()
{
    Configuration config = new Configuration();

    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    /**
        * Export contacts
        * Example api call that exports selected contacts to downloadable file.
        * Options:
        * fileFormat: "Csv" "Xml" "Json" – Format of the exported file
        * rule: rule=Status%20=%20Engaged – Query used for filtering.
        * emails: [mail@contact.com,mail1@contact.com,mail2@contact.com] – Array of contact emails
        * compressionFormat: "None" "Zip"
        * fileName=filename.txt – Name of your file including extension.
        */
    var apiInstance = new ContactsApi(config);
    ExportFileFormats fileFormat = new ExportFileFormats();
    fileFormat = ExportFileFormats.Csv;

    List<string> emails = new List<string>();
    emails.Add("johnsmith@domain.com");

    string fileName = "exported.csv";

    try
    {
        apiInstance.ContactsExportPost(fileFormat, null, emails, null, fileName);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling ContactsApi.ContactsExportPost: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Delete Contact
Create an object with an array of contacts to delete.

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/contactsByEmailDelete

```cs
EmailsPayload emails = new EmailsPayload();
emails.Emails = new List<string>();
emails.Emails.Add("johnsmith@domain.com");
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a success message.
Finally, call the API to delete contact:

```cs
try
{
    apiInstance.ContactsDeletePost(emails);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ContactsApi.ContactsExportPost: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:
```cs
public void DeleteContact()
{
    Configuration config = new Configuration();

    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    /**
        * Delete contact
        * Example api call that deletes given contact(s).
        */
    var apiInstance = new ContactsApi(config);
    EmailsPayload emails = new EmailsPayload();
    emails.Emails = new List<string>();
    emails.Emails.Add("johnsmith@domain.com");

    try
    {
        apiInstance.ContactsDeletePost(emails);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling ContactsApi.ContactsExportPost: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

## Run the code
Simply run your project and be sure that the code we wrote can be reached.