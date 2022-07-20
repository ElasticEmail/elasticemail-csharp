# Template class

This guide will walk you through the process of creating basic methods for templates using the C# library.

## What's a template?
When using Elastic Email you send emails to your contacts. A single template is a body of  email prepared and saved under given name. Till it's deleted it can be reused to send any number of emails.

## Preparation
Create a Visual Studio project of your choosing, that's using at least .NET Framework 4.8.

Then, install our NuGet Package from https://www.nuget.org/packages/ElasticEmail/ in your project.

## Let's dig into the code
In the template class load library namespaces using lines below:

```cs
using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;
```

Below code you will repeat in all template's methods:
Generate and use your API key (remember to check a required access level):

```cs
Configuration config = new Configuration();
// Configure API key authorization: apikey
config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
```

Create an instance of TemplatesApi that will be used to work with list's methods.

```cs
var apiInstance = new TemplatesApi(config);
```

# Add template

*Required Access Level: ModifyTemplates*

Create an object with details about new template:
- Name – name of your template by which it can be identified and used
- Subject – specify default subject for this template
- Body – specify acctual body content eg. in HTML, PlainText or both
- TemplateScope – specify scope, "Personal" template won't be shared, "Global" template can be shared with your sub accounts.

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/templatesPost

```cs
TemplatePayload template = new TemplatePayload(name: "My new template");
template.Subject = "Default Subject";
template.TemplateScope = TemplateScope.Personal;
template.Body = new List<BodyPart>();

BodyPart bodyPart = new BodyPart();
bodyPart.ContentType = BodyContentType.HTML;
bodyPart.Charset = "utf-8";
bodyPart.Content = "<h1>My template</h1>";

template.Body.Add(bodyPart);
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display object with newly created template data.
Finally, call the API to add template:

```cs
try
{
    return apiInstance.TemplatesPost(template);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TemplatesApi.TemplatesPost: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public Template AddTemplate()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new TemplatesApi(config);

    /**
        * Add template
        * Example api call that adds a new template.
        * TemplateScope: "Personal" or "Global"
        */

    TemplatePayload template = new TemplatePayload(name: "My new template");
    template.Subject = "Default Subject";
    template.TemplateScope = TemplateScope.Personal;
    template.Body = new List<BodyPart>();

    BodyPart bodyPart = new BodyPart();
    bodyPart.ContentType = BodyContentType.HTML;
    bodyPart.Charset = "utf-8";
    bodyPart.Content = "<h1>My template</h1>";

    template.Body.Add(bodyPart);

    try
    {
        return apiInstance.TemplatesPost(template);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling TemplatesApi.TemplatesPost: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Load template

*Required Access Level: ViewTemplates*

To load a template you need to specfiy it's name.

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/templatesByNameGet

```cs
string templateName = "My template";
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a template object.
Finally, call the API to load a template:

```cs
try
{
    return apiInstance.TemplatesByNameGet(templateName);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TemplatesApi.TemplatesByNameGet: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public Template LoadTemplate()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new TemplatesApi(config);

    /**
    * Load template
    * Example api call that loads an existing template.
    */

    string templateName = "My template";

    try
    {
        return apiInstance.TemplatesByNameGet(templateName);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling TemplatesApi.TemplatesByNameGet: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Delete template

*Required Access Level: ModifyTemplates*

The only thing needed is a template name.

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/templatesByNameDelete

```cs
string templateName = "My contacts";
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a success messages.
Finally, call the API to delete a template:

```cs
try
{
    apiInstance.TemplatesByNameDelete(templateName);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TemplatesApi.TemplatesByNameGet: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
 public void DeleteTemplate()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new TemplatesApi(config);

    /**
        * Delete template
        * Example api call that deletes existing template.
        */

    string templateName = "My template";

    try
    {
        apiInstance.TemplatesByNameDelete(templateName);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling TemplatesApi.TemplatesByNameGet: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

## Run the code
Simply run your project and be sure that the code we wrote can be reached.