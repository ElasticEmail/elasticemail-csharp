# ElasticEmail.Api.ListsApi

All URIs are relative to *https://api.elasticemail.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListsByNameContactsPost**](ListsApi.md#listsbynamecontactspost) | **POST** /lists/{name}/contacts | Add Contacts to List
[**ListsByNameContactsRemovePost**](ListsApi.md#listsbynamecontactsremovepost) | **POST** /lists/{name}/contacts/remove | Remove Contacts from List
[**ListsByNameDelete**](ListsApi.md#listsbynamedelete) | **DELETE** /lists/{name} | Delete List
[**ListsByNameGet**](ListsApi.md#listsbynameget) | **GET** /lists/{name} | Load List
[**ListsByNamePut**](ListsApi.md#listsbynameput) | **PUT** /lists/{name} | Update List
[**ListsGet**](ListsApi.md#listsget) | **GET** /lists | Load Lists
[**ListsPost**](ListsApi.md#listspost) | **POST** /lists | Add List


<a name="listsbynamecontactspost"></a>
# **ListsByNameContactsPost**
> ContactsList ListsByNameContactsPost (string name, EmailsPayload emailsPayload)

Add Contacts to List

Add existing Contacts to specified list. Required Access Level: ModifyContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ListsByNameContactsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ListsApi(config);
            var name = My List 1;  // string | Name of your list.
            var emailsPayload = new EmailsPayload(); // EmailsPayload | Provide either rule or a list of emails, not both.

            try
            {
                // Add Contacts to List
                ContactsList result = apiInstance.ListsByNameContactsPost(name, emailsPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.ListsByNameContactsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of your list. | 
 **emailsPayload** | [**EmailsPayload**](EmailsPayload.md)| Provide either rule or a list of emails, not both. | 

### Return type

[**ContactsList**](ContactsList.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsbynamecontactsremovepost"></a>
# **ListsByNameContactsRemovePost**
> void ListsByNameContactsRemovePost (string name, EmailsPayload emailsPayload)

Remove Contacts from List

Remove specified Contacts from your list. Required Access Level: ModifyContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ListsByNameContactsRemovePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ListsApi(config);
            var name = My List 1;  // string | Name of your list.
            var emailsPayload = new EmailsPayload(); // EmailsPayload | Provide either rule or a list of emails, not both.

            try
            {
                // Remove Contacts from List
                apiInstance.ListsByNameContactsRemovePost(name, emailsPayload);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.ListsByNameContactsRemovePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of your list. | 
 **emailsPayload** | [**EmailsPayload**](EmailsPayload.md)| Provide either rule or a list of emails, not both. | 

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsbynamedelete"></a>
# **ListsByNameDelete**
> void ListsByNameDelete (string name)

Delete List

Deletes List and removes all the Contacts from it (does not delete Contacts). Required Access Level: ModifyContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ListsByNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ListsApi(config);
            var name = My List 1;  // string | Name of your list.

            try
            {
                // Delete List
                apiInstance.ListsByNameDelete(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.ListsByNameDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of your list. | 

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsbynameget"></a>
# **ListsByNameGet**
> ContactsList ListsByNameGet (string name)

Load List

Returns detailed information about specified list. Required Access Level: ViewContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ListsByNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ListsApi(config);
            var name = My List 1;  // string | Name of your list.

            try
            {
                // Load List
                ContactsList result = apiInstance.ListsByNameGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.ListsByNameGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of your list. | 

### Return type

[**ContactsList**](ContactsList.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsbynameput"></a>
# **ListsByNamePut**
> ContactsList ListsByNamePut (string name, ListUpdatePayload listUpdatePayload)

Update List

Update existing list. Required Access Level: ModifyContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ListsByNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ListsApi(config);
            var name = My List 1;  // string | Name of your list.
            var listUpdatePayload = new ListUpdatePayload(); // ListUpdatePayload | 

            try
            {
                // Update List
                ContactsList result = apiInstance.ListsByNamePut(name, listUpdatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.ListsByNamePut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of your list. | 
 **listUpdatePayload** | [**ListUpdatePayload**](ListUpdatePayload.md)|  | 

### Return type

[**ContactsList**](ContactsList.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsget"></a>
# **ListsGet**
> List&lt;ContactsList&gt; ListsGet (int? limit = null, int? offset = null)

Load Lists

Returns all your existing lists. Required Access Level: ViewContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ListsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ListsApi(config);
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Load Lists
                List<ContactsList> result = apiInstance.ListsGet(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.ListsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Maximum number of returned items. | [optional] 
 **offset** | **int?**| How many items should be returned ahead. | [optional] 

### Return type

[**List&lt;ContactsList&gt;**](ContactsList.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listspost"></a>
# **ListsPost**
> ContactsList ListsPost (ListPayload listPayload)

Add List

Add a new list. Required Access Level: ModifyContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ListsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ListsApi(config);
            var listPayload = new ListPayload(); // ListPayload | 

            try
            {
                // Add List
                ContactsList result = apiInstance.ListsPost(listPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.ListsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listPayload** | [**ListPayload**](ListPayload.md)|  | 

### Return type

[**ContactsList**](ContactsList.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

