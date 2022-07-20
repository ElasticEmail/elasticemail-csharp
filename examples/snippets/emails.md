# Emails class

This guide will walk you through the process of sending transactional or bulk emails using the C# library.

*Required Access Level: SendHttp*

## What's a transactional email?
When using Elastic Email you send emails to your contacts. One of options is to send transational emails. Transactional emails can be described that they are emails generated as a response to a particular actions done by the subscriber eg. account changes, purchase receipts, other confirmations.
A transactional email have a limit of 50 maximum recipients.

## What's a bulk email?
When using Elastic Email you send emails to your contacts. One of options is to send bulk emails. Bulk email can be described as a single email message send to a large group at once.

## Preparation
Create a Visual Studio project of your choosing, that's using at least .NET Framework 4.8.

Then, install our NuGet Package from https://www.nuget.org/packages/ElasticEmail/ in your project.

## Let's dig into the code
In the email class load library namespaces using lines below:

```cs
using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;
```

Below code you will repeat in all email's methods:
Generate and use your API key (remember to check a required access level):

```cs
Configuration config = new Configuration();
// Configure API key authorization: apikey
config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
```

Create an instance of EmailsApi that will be used to work with email's methods.

```cs
var apiInstance = new EmailsApi(config);
```

# Send Transactional Emails

First you need to specify email details:
- email recipients
- email content:
    - body parts – in HTML, PlainText or in both
    - from email – it needs to be your validated email address
    - email subject

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/emailsTransactionalPost

```cs
var to = new List<string>();
to.Add("johnsmith@domain.com");
var recipients = new TransactionalRecipient(to: to);

EmailTransactionalMessageData emailData = new EmailTransactionalMessageData(recipients: recipients);

emailData.Content = new EmailContent();
emailData.Content.Body = new List<BodyPart>();

BodyPart htmlBodyPart = new BodyPart();
htmlBodyPart.ContentType = BodyContentType.HTML;
htmlBodyPart.Charset = "utf-8";
htmlBodyPart.Content = "<h1>Mail content</h1>";

BodyPart plainTextBodyPart = new BodyPart();
plainTextBodyPart.ContentType = BodyContentType.PlainText;
plainTextBodyPart.Charset = "utf-8";
plainTextBodyPart.Content = "Mail content";

emailData.Content.Body.Add(htmlBodyPart);
emailData.Content.Body.Add(plainTextBodyPart);

emailData.Content.From = "myemail@domain.com";
emailData.Content.Subject = "Example transactional email";
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a success messages.
Finally, call the API to send email:

```cs
try
{
    return apiInstance.EmailsTransactionalPost(emailData);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EmailsApi.EmailsTransactionalPost: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
 public EmailSend SendTransactionalEmails()
{
    Configuration config = new Configuration();

    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    /**
        * Send transactional emails
        * Example api call that sends transactional email.
        * Limit of 50 maximum recipients.
        */
    var apiInstance = new EmailsApi(config);

    var to = new List<string>();
    to.Add("johnsmith@domain.com");
    var recipients = new TransactionalRecipient(to: to);

    EmailTransactionalMessageData emailData = new EmailTransactionalMessageData(recipients: recipients);

    emailData.Content = new EmailContent();
    emailData.Content.Body = new List<BodyPart>();

    BodyPart htmlBodyPart = new BodyPart();
    htmlBodyPart.ContentType = BodyContentType.HTML;
    htmlBodyPart.Charset = "utf-8";
    htmlBodyPart.Content = "<h1>Mail content</h1>";

    BodyPart plainTextBodyPart = new BodyPart();
    plainTextBodyPart.ContentType = BodyContentType.PlainText;
    plainTextBodyPart.Charset = "utf-8";
    plainTextBodyPart.Content = "Mail content";

    emailData.Content.Body.Add(htmlBodyPart);
    emailData.Content.Body.Add(plainTextBodyPart);

    emailData.Content.From = "myemail@domain.com";
    emailData.Content.Subject = "Example transactional email";

    try
    {
        return apiInstance.EmailsTransactionalPost(emailData);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling EmailsApi.EmailsTransactionalPost: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Send Bulk Emails
First you need to specify email details:

- email recipients:
    - this example demostrates merge fields usage, for each recipient {name} will be changed to recipient's name

- email content:
    - body parts – in HTML, PlainText or in both
    - from email – it needs to be your validated email address
    - email subject

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/emailsPost

```cs
List<EmailRecipient> emailRecipients = new List<EmailRecipient>();
var recipients = new EmailRecipient(email: "johnsmith@domain.com");
recipients.Fields = new Dictionary<string, string>();
recipients.Fields.Add("name", "John");

emailRecipients.Add(recipients);
EmailMessageData emailData = new EmailMessageData(recipients: emailRecipients);

emailData.Content = new EmailContent();
emailData.Content.Body = new List<BodyPart>();

BodyPart htmlBodyPart = new BodyPart();
htmlBodyPart.ContentType = BodyContentType.HTML;
htmlBodyPart.Charset = "utf-8";
htmlBodyPart.Content = "<h1>Mail content</h1>";

BodyPart plainTextBodyPart = new BodyPart();
plainTextBodyPart.ContentType = BodyContentType.PlainText;
plainTextBodyPart.Charset = "utf-8";
plainTextBodyPart.Content = "Mail content";

emailData.Content.Body.Add(htmlBodyPart);
emailData.Content.Body.Add(plainTextBodyPart);

emailData.Content.From = "myemail@domain.com";
emailData.Content.Subject = "Example email";
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a success message.
Finally, call the API to delete contact:

```cs
try
{
    return apiInstance.EmailsPost(emailData);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EmailsApi.EmailsPost: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:
```cs
public EmailSend SendBulkEmails()
{
    Configuration config = new Configuration();

    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    /**
        * Send bulk emails
        * Example api call that sends bulk merge email.
        */
    var apiInstance = new EmailsApi(config);

    List<EmailRecipient> emailRecipients = new List<EmailRecipient>();
    var recipients = new EmailRecipient(email: "johnsmith@domain.com");
    recipients.Fields = new Dictionary<string, string>();
    recipients.Fields.Add("name", "John");

    emailRecipients.Add(recipients);
    EmailMessageData emailData = new EmailMessageData(recipients: emailRecipients);

    emailData.Content = new EmailContent();
    emailData.Content.Body = new List<BodyPart>();

    BodyPart htmlBodyPart = new BodyPart();
    htmlBodyPart.ContentType = BodyContentType.HTML;
    htmlBodyPart.Charset = "utf-8";
    htmlBodyPart.Content = "<h1>Mail content</h1>";

    BodyPart plainTextBodyPart = new BodyPart();
    plainTextBodyPart.ContentType = BodyContentType.PlainText;
    plainTextBodyPart.Charset = "utf-8";
    plainTextBodyPart.Content = "Mail content";

    emailData.Content.Body.Add(htmlBodyPart);
    emailData.Content.Body.Add(plainTextBodyPart);

    emailData.Content.From = "myemail@domain.com";
    emailData.Content.Subject = "Example email";

    try
    {
        return apiInstance.EmailsPost(emailData);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling EmailsApi.EmailsPost: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

## Run the code
Simply run your project and be sure that the code we wrote can be reached.