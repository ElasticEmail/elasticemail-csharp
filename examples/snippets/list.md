# List class

This guide will walk you through the process of creating basic methods for lists using the C# library.

## What's a list?
When using Elastic Email, you send emails to contacts – recipients who receive your emails. Contacts can be grouped by created segments or lists. Segments add contacts automatically when specfied conditions are met, and contacts on lists are managed manually.

## Preparation
Create a Visual Studio project of your choosing, that's using at least .NET Framework 4.8.

Then, install our NuGet Package from https://www.nuget.org/packages/ElasticEmail/ in your project.

## Let's dig into the code
In the list class load library namespaces using lines below:

```cs
using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;
```

Below code you will repeat in all list's methods:
Generate and use your API key (remember to check a required access level):

```cs
Configuration config = new Configuration();
// Configure API key authorization: apikey
config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
```

Create an instance of ListsApi that will be used to work with list's methods.

```cs
var apiInstance = new ListsApi(config);
```

# Add list

*Required Access Level: ModifyContacts*

Create an object with details about new list. Only ListName is required.
You can also define if to allow unsubscription from list and pass an emails array of existing contacts on your account to add them to list during list creation.

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/listsPost

```cs
ListPayload listData = new ListPayload(listName: "My contacts");
listData.AllowUnsubscribe = true;
listData.Emails = new List<string>();
listData.Emails.Add("johnsmith@domain.com");
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a success messages.
Finally, call the API to add list:

```cs
try
{
    return apiInstance.ListsPost(listData);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ListsApi.ListsPost: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public ContactsList AddList()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new ListsApi(config);

    /**
        * Add list
        * Example api call that creates a new contacts list.
        * Emails – An array of existing contact emails that should be added to this list. Leave empty for all contacts
        */

    ListPayload listData = new ListPayload(listName: "My contacts");
    listData.AllowUnsubscribe = true;
    listData.Emails = new List<string>();
    listData.Emails.Add("johnsmith@domain.com");

    try
    {
        return apiInstance.ListsPost(listData);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling ListsApi.ListsPost: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Load list

*Required Access Level: ViewContacts*

The only thing needed is a list name.

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/listsByNameGet

```cs
string listName = "My contacts";
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a list object.
Finally, call the API to load a list:

```cs
try
{
    return apiInstance.ListsByNameGet(listName);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ListsApi.ListsByNameGet: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public ContactsList LoadList()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new ListsApi(config);

    /**
        * Load list
        * Example api call that loads given contacts list.
        */
    string listName = "My contacts";

    try
    {
        return apiInstance.ListsByNameGet(listName);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling ListsApi.ListsByNameGet: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

# Delete list

*Required Access Level: ModifyContacts*

The only thing needed is a list name.

> Find out more by checking our API's documentation: https://elasticemail.com/developers/api-documentation/rest-api#operation/listsByNameDelete

```cs
string listName = "My contacts";
```

Surround the api call in the try catch block, so that in case of error it will display error details.
Otherwise, it will display a success messages.
Finally, call the API to delete a list:

```cs
try
{
    apiInstance.ListsByNameDelete(listName);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ListsApi.ListsByNameDelete: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);

    throw;
}
```

## The whole code to copy and paste:

```cs
public void DeleteList()
{
    Configuration config = new Configuration();
    // Configure API key authorization: apikey
    config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

    var apiInstance = new ListsApi(config);

    /**
        * Load list
        * Example api call that loads given contacts list.
        */
    string listName = "My contacts";

    try
    {
        apiInstance.ListsByNameDelete(listName);
    }
    catch (ApiException e)
    {
        Console.WriteLine("Exception when calling ListsApi.ListsByNameDelete: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);

        throw;
    }
}
```

## Run the code
Simply run your project and be sure that the code we wrote can be reached.