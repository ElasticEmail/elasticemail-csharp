# ElasticEmail.Api.SuppressionsApi

All URIs are relative to *https://api.elasticemail.com/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SuppressionsBouncesGet**](SuppressionsApi.md#suppressionsbouncesget) | **GET** /suppressions/bounces | Get Bounce List |
| [**SuppressionsBouncesImportPost**](SuppressionsApi.md#suppressionsbouncesimportpost) | **POST** /suppressions/bounces/import | Add Bounces Async |
| [**SuppressionsBouncesPost**](SuppressionsApi.md#suppressionsbouncespost) | **POST** /suppressions/bounces | Add Bounces |
| [**SuppressionsByEmailDelete**](SuppressionsApi.md#suppressionsbyemaildelete) | **DELETE** /suppressions/{email} | Delete Suppression |
| [**SuppressionsByEmailGet**](SuppressionsApi.md#suppressionsbyemailget) | **GET** /suppressions/{email} | Get Suppression |
| [**SuppressionsComplaintsGet**](SuppressionsApi.md#suppressionscomplaintsget) | **GET** /suppressions/complaints | Get Complaints List |
| [**SuppressionsComplaintsImportPost**](SuppressionsApi.md#suppressionscomplaintsimportpost) | **POST** /suppressions/complaints/import | Add Complaints Async |
| [**SuppressionsComplaintsPost**](SuppressionsApi.md#suppressionscomplaintspost) | **POST** /suppressions/complaints | Add Complaints |
| [**SuppressionsGet**](SuppressionsApi.md#suppressionsget) | **GET** /suppressions | Get Suppressions |
| [**SuppressionsUnsubscribesGet**](SuppressionsApi.md#suppressionsunsubscribesget) | **GET** /suppressions/unsubscribes | Get Unsubscribes List |
| [**SuppressionsUnsubscribesImportPost**](SuppressionsApi.md#suppressionsunsubscribesimportpost) | **POST** /suppressions/unsubscribes/import | Add Unsubscribes Async |
| [**SuppressionsUnsubscribesPost**](SuppressionsApi.md#suppressionsunsubscribespost) | **POST** /suppressions/unsubscribes | Add Unsubscribes |

<a name="suppressionsbouncesget"></a>
# **SuppressionsBouncesGet**
> List&lt;Suppression&gt; SuppressionsBouncesGet (string search = null, int? limit = null, int? offset = null)

Get Bounce List

Retrieve your list of bounced emails. Required Access Level: ViewContacts, ViewSuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsBouncesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var search = text;  // string | Text fragment used for searching. (optional) 
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Get Bounce List
                List<Suppression> result = apiInstance.SuppressionsBouncesGet(search, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsBouncesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsBouncesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Bounce List
    ApiResponse<List<Suppression>> response = apiInstance.SuppressionsBouncesGetWithHttpInfo(search, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsBouncesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **search** | **string** | Text fragment used for searching. | [optional]  |
| **limit** | **int?** | Maximum number of returned items. | [optional]  |
| **offset** | **int?** | How many items should be returned ahead. | [optional]  |

### Return type

[**List&lt;Suppression&gt;**](Suppression.md)

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

<a name="suppressionsbouncesimportpost"></a>
# **SuppressionsBouncesImportPost**
> void SuppressionsBouncesImportPost (System.IO.Stream file = null)

Add Bounces Async

Add Bounced. Required Access Level: ModifyContacts, ModifySuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsBouncesImportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var file = new System.IO.FileStream("/path/to/file.txt", FileMode.Open, FileAccess.Read);  // System.IO.Stream |  (optional) 

            try
            {
                // Add Bounces Async
                apiInstance.SuppressionsBouncesImportPost(file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsBouncesImportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsBouncesImportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Bounces Async
    apiInstance.SuppressionsBouncesImportPostWithHttpInfo(file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsBouncesImportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suppressionsbouncespost"></a>
# **SuppressionsBouncesPost**
> List&lt;Suppression&gt; SuppressionsBouncesPost (List<string> requestBody)

Add Bounces

Add Bounced. Required Access Level: ModifyContacts, ModifySuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsBouncesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var requestBody = new List<string>(); // List<string> | Emails to add as bounces. Limited to 1000 per request

            try
            {
                // Add Bounces
                List<Suppression> result = apiInstance.SuppressionsBouncesPost(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsBouncesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsBouncesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Bounces
    ApiResponse<List<Suppression>> response = apiInstance.SuppressionsBouncesPostWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsBouncesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) | Emails to add as bounces. Limited to 1000 per request |  |

### Return type

[**List&lt;Suppression&gt;**](Suppression.md)

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

<a name="suppressionsbyemaildelete"></a>
# **SuppressionsByEmailDelete**
> void SuppressionsByEmailDelete (string email)

Delete Suppression

Delete Suppression. Required Access Level: ViewContacts, ViewSuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsByEmailDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var email = mail@example.com;  // string | Proper email address.

            try
            {
                // Delete Suppression
                apiInstance.SuppressionsByEmailDelete(email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsByEmailDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsByEmailDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Suppression
    apiInstance.SuppressionsByEmailDeleteWithHttpInfo(email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsByEmailDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Proper email address. |  |

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

<a name="suppressionsbyemailget"></a>
# **SuppressionsByEmailGet**
> Suppression SuppressionsByEmailGet (string email)

Get Suppression

Retrieve your suppression. Required Access Level: ViewContacts, ViewSuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsByEmailGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var email = mail@example.com;  // string | Proper email address.

            try
            {
                // Get Suppression
                Suppression result = apiInstance.SuppressionsByEmailGet(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsByEmailGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsByEmailGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Suppression
    ApiResponse<Suppression> response = apiInstance.SuppressionsByEmailGetWithHttpInfo(email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsByEmailGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Proper email address. |  |

### Return type

[**Suppression**](Suppression.md)

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

<a name="suppressionscomplaintsget"></a>
# **SuppressionsComplaintsGet**
> List&lt;Suppression&gt; SuppressionsComplaintsGet (string search = null, int? limit = null, int? offset = null)

Get Complaints List

Retrieve your list of complaints. Required Access Level: ViewContacts, ViewSuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsComplaintsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var search = text;  // string | Text fragment used for searching. (optional) 
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Get Complaints List
                List<Suppression> result = apiInstance.SuppressionsComplaintsGet(search, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsComplaintsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsComplaintsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Complaints List
    ApiResponse<List<Suppression>> response = apiInstance.SuppressionsComplaintsGetWithHttpInfo(search, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsComplaintsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **search** | **string** | Text fragment used for searching. | [optional]  |
| **limit** | **int?** | Maximum number of returned items. | [optional]  |
| **offset** | **int?** | How many items should be returned ahead. | [optional]  |

### Return type

[**List&lt;Suppression&gt;**](Suppression.md)

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

<a name="suppressionscomplaintsimportpost"></a>
# **SuppressionsComplaintsImportPost**
> void SuppressionsComplaintsImportPost (System.IO.Stream file = null)

Add Complaints Async

Add Complaints. Required Access Level: ModifyContacts, ModifySuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsComplaintsImportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var file = new System.IO.FileStream("/path/to/file.txt", FileMode.Open, FileAccess.Read);  // System.IO.Stream |  (optional) 

            try
            {
                // Add Complaints Async
                apiInstance.SuppressionsComplaintsImportPost(file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsComplaintsImportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsComplaintsImportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Complaints Async
    apiInstance.SuppressionsComplaintsImportPostWithHttpInfo(file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsComplaintsImportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suppressionscomplaintspost"></a>
# **SuppressionsComplaintsPost**
> List&lt;Suppression&gt; SuppressionsComplaintsPost (List<string> requestBody)

Add Complaints

Add Complaints. Required Access Level: ModifyContacts, ModifySuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsComplaintsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var requestBody = new List<string>(); // List<string> | Emails to add as complaints. Limited to 1000 per request

            try
            {
                // Add Complaints
                List<Suppression> result = apiInstance.SuppressionsComplaintsPost(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsComplaintsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsComplaintsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Complaints
    ApiResponse<List<Suppression>> response = apiInstance.SuppressionsComplaintsPostWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsComplaintsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) | Emails to add as complaints. Limited to 1000 per request |  |

### Return type

[**List&lt;Suppression&gt;**](Suppression.md)

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

<a name="suppressionsget"></a>
# **SuppressionsGet**
> List&lt;Suppression&gt; SuppressionsGet (int? limit = null, int? offset = null)

Get Suppressions

Retrieve your suppressions. Required Access Level: ViewContacts, ViewSuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Get Suppressions
                List<Suppression> result = apiInstance.SuppressionsGet(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Suppressions
    ApiResponse<List<Suppression>> response = apiInstance.SuppressionsGetWithHttpInfo(limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Maximum number of returned items. | [optional]  |
| **offset** | **int?** | How many items should be returned ahead. | [optional]  |

### Return type

[**List&lt;Suppression&gt;**](Suppression.md)

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

<a name="suppressionsunsubscribesget"></a>
# **SuppressionsUnsubscribesGet**
> List&lt;Suppression&gt; SuppressionsUnsubscribesGet (string search = null, int? limit = null, int? offset = null)

Get Unsubscribes List

Retrieve your list of unsubscribes. Required Access Level: ViewContacts, ViewSuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsUnsubscribesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var search = text;  // string | Text fragment used for searching. (optional) 
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Get Unsubscribes List
                List<Suppression> result = apiInstance.SuppressionsUnsubscribesGet(search, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsUnsubscribesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsUnsubscribesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Unsubscribes List
    ApiResponse<List<Suppression>> response = apiInstance.SuppressionsUnsubscribesGetWithHttpInfo(search, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsUnsubscribesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **search** | **string** | Text fragment used for searching. | [optional]  |
| **limit** | **int?** | Maximum number of returned items. | [optional]  |
| **offset** | **int?** | How many items should be returned ahead. | [optional]  |

### Return type

[**List&lt;Suppression&gt;**](Suppression.md)

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

<a name="suppressionsunsubscribesimportpost"></a>
# **SuppressionsUnsubscribesImportPost**
> void SuppressionsUnsubscribesImportPost (System.IO.Stream file = null)

Add Unsubscribes Async

Add Unsubscribes. Required Access Level: ModifyContacts, ModifySuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsUnsubscribesImportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var file = new System.IO.FileStream("/path/to/file.txt", FileMode.Open, FileAccess.Read);  // System.IO.Stream |  (optional) 

            try
            {
                // Add Unsubscribes Async
                apiInstance.SuppressionsUnsubscribesImportPost(file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsUnsubscribesImportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsUnsubscribesImportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Unsubscribes Async
    apiInstance.SuppressionsUnsubscribesImportPostWithHttpInfo(file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsUnsubscribesImportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suppressionsunsubscribespost"></a>
# **SuppressionsUnsubscribesPost**
> List&lt;Suppression&gt; SuppressionsUnsubscribesPost (List<string> requestBody)

Add Unsubscribes

Add Unsubscribes. Required Access Level: ModifyContacts, ModifySuppressions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SuppressionsUnsubscribesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SuppressionsApi(config);
            var requestBody = new List<string>(); // List<string> | Emails to add as unsubscribes. Limited to 1000 per request

            try
            {
                // Add Unsubscribes
                List<Suppression> result = apiInstance.SuppressionsUnsubscribesPost(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppressionsApi.SuppressionsUnsubscribesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppressionsUnsubscribesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Unsubscribes
    ApiResponse<List<Suppression>> response = apiInstance.SuppressionsUnsubscribesPostWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppressionsApi.SuppressionsUnsubscribesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) | Emails to add as unsubscribes. Limited to 1000 per request |  |

### Return type

[**List&lt;Suppression&gt;**](Suppression.md)

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

