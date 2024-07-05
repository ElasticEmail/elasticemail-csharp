# ElasticEmail.Api.EventsApi

All URIs are relative to *https://api.elasticemail.com/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EventsByTransactionidGet**](EventsApi.md#eventsbytransactionidget) | **GET** /events/{transactionid} | Load Email Events |
| [**EventsChannelsByNameExportPost**](EventsApi.md#eventschannelsbynameexportpost) | **POST** /events/channels/{name}/export | Export Channel Events |
| [**EventsChannelsByNameGet**](EventsApi.md#eventschannelsbynameget) | **GET** /events/channels/{name} | Load Channel Events |
| [**EventsChannelsExportByIdStatusGet**](EventsApi.md#eventschannelsexportbyidstatusget) | **GET** /events/channels/export/{id}/status | Check Channel Export Status |
| [**EventsExportByIdStatusGet**](EventsApi.md#eventsexportbyidstatusget) | **GET** /events/export/{id}/status | Check Export Status |
| [**EventsExportPost**](EventsApi.md#eventsexportpost) | **POST** /events/export | Export Events |
| [**EventsGet**](EventsApi.md#eventsget) | **GET** /events | Load Events |

<a id="eventsbytransactionidget"></a>
# **EventsByTransactionidGet**
> List&lt;RecipientEvent&gt; EventsByTransactionidGet (string transactionid, DateTime? from = null, DateTime? to = null, EventsOrderBy? orderBy = null, int? limit = null, int? offset = null)

Load Email Events

Returns a log of delivery events for the specific transaction ID. Required Access Level: ViewReports

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EventsByTransactionidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EventsApi(config);
            var transactionid = TransactionID;  // string | ID number of transaction
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Starting date for search in YYYY-MM-DDThh:mm:ss format. (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Ending date for search in YYYY-MM-DDThh:mm:ss format. (optional) 
            var orderBy = (EventsOrderBy) "DateDescending";  // EventsOrderBy? |  (optional) 
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Load Email Events
                List<RecipientEvent> result = apiInstance.EventsByTransactionidGet(transactionid, from, to, orderBy, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.EventsByTransactionidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EventsByTransactionidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Email Events
    ApiResponse<List<RecipientEvent>> response = apiInstance.EventsByTransactionidGetWithHttpInfo(transactionid, from, to, orderBy, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.EventsByTransactionidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionid** | **string** | ID number of transaction |  |
| **from** | **DateTime?** | Starting date for search in YYYY-MM-DDThh:mm:ss format. | [optional]  |
| **to** | **DateTime?** | Ending date for search in YYYY-MM-DDThh:mm:ss format. | [optional]  |
| **orderBy** | **EventsOrderBy?** |  | [optional]  |
| **limit** | **int?** | Maximum number of returned items. | [optional]  |
| **offset** | **int?** | How many items should be returned ahead. | [optional]  |

### Return type

[**List&lt;RecipientEvent&gt;**](RecipientEvent.md)

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

<a id="eventschannelsbynameexportpost"></a>
# **EventsChannelsByNameExportPost**
> ExportLink EventsChannelsByNameExportPost (string name, List<EventType> eventTypes = null, DateTime? from = null, DateTime? to = null, ExportFileFormats? fileFormat = null, CompressionFormat? compressionFormat = null, string fileName = null)

Export Channel Events

Export delivery events log information to the specified file format. Required Access Level: Export

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EventsChannelsByNameExportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EventsApi(config);
            var name = Channel01;  // string | Name of selected channel.
            var eventTypes = new List<EventType>(); // List<EventType> | Types of Events to return (optional) 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Starting date for search in YYYY-MM-DDThh:mm:ss format. (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Ending date for search in YYYY-MM-DDThh:mm:ss format. (optional) 
            var fileFormat = (ExportFileFormats) "Csv";  // ExportFileFormats? | Format of the exported file (optional) 
            var compressionFormat = (CompressionFormat) "None";  // CompressionFormat? | FileResponse compression format. None or Zip. (optional) 
            var fileName = filename.txt;  // string | Name of your file including extension. (optional) 

            try
            {
                // Export Channel Events
                ExportLink result = apiInstance.EventsChannelsByNameExportPost(name, eventTypes, from, to, fileFormat, compressionFormat, fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.EventsChannelsByNameExportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EventsChannelsByNameExportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export Channel Events
    ApiResponse<ExportLink> response = apiInstance.EventsChannelsByNameExportPostWithHttpInfo(name, eventTypes, from, to, fileFormat, compressionFormat, fileName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.EventsChannelsByNameExportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of selected channel. |  |
| **eventTypes** | [**List&lt;EventType&gt;**](EventType.md) | Types of Events to return | [optional]  |
| **from** | **DateTime?** | Starting date for search in YYYY-MM-DDThh:mm:ss format. | [optional]  |
| **to** | **DateTime?** | Ending date for search in YYYY-MM-DDThh:mm:ss format. | [optional]  |
| **fileFormat** | **ExportFileFormats?** | Format of the exported file | [optional]  |
| **compressionFormat** | **CompressionFormat?** | FileResponse compression format. None or Zip. | [optional]  |
| **fileName** | **string** | Name of your file including extension. | [optional]  |

### Return type

[**ExportLink**](ExportLink.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="eventschannelsbynameget"></a>
# **EventsChannelsByNameGet**
> List&lt;RecipientEvent&gt; EventsChannelsByNameGet (string name, List<EventType> eventTypes = null, DateTime? from = null, DateTime? to = null, EventsOrderBy? orderBy = null, int? limit = null, int? offset = null)

Load Channel Events

Returns a log of delivery events filtered by specified parameters. Required Access Level: ViewReports

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EventsChannelsByNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EventsApi(config);
            var name = Channel01;  // string | Name of selected channel.
            var eventTypes = new List<EventType>(); // List<EventType> | Types of Events to return (optional) 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Starting date for search in YYYY-MM-DDThh:mm:ss format. (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Ending date for search in YYYY-MM-DDThh:mm:ss format. (optional) 
            var orderBy = (EventsOrderBy) "DateDescending";  // EventsOrderBy? |  (optional) 
            var limit = 56;  // int? | How many items to load. Maximum for this request is 1000 items (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Load Channel Events
                List<RecipientEvent> result = apiInstance.EventsChannelsByNameGet(name, eventTypes, from, to, orderBy, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.EventsChannelsByNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EventsChannelsByNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Channel Events
    ApiResponse<List<RecipientEvent>> response = apiInstance.EventsChannelsByNameGetWithHttpInfo(name, eventTypes, from, to, orderBy, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.EventsChannelsByNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of selected channel. |  |
| **eventTypes** | [**List&lt;EventType&gt;**](EventType.md) | Types of Events to return | [optional]  |
| **from** | **DateTime?** | Starting date for search in YYYY-MM-DDThh:mm:ss format. | [optional]  |
| **to** | **DateTime?** | Ending date for search in YYYY-MM-DDThh:mm:ss format. | [optional]  |
| **orderBy** | **EventsOrderBy?** |  | [optional]  |
| **limit** | **int?** | How many items to load. Maximum for this request is 1000 items | [optional]  |
| **offset** | **int?** | How many items should be returned ahead. | [optional]  |

### Return type

[**List&lt;RecipientEvent&gt;**](RecipientEvent.md)

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

<a id="eventschannelsexportbyidstatusget"></a>
# **EventsChannelsExportByIdStatusGet**
> ExportStatus EventsChannelsExportByIdStatusGet (string id)

Check Channel Export Status

Check the current status of the channel export. Required Access Level: Export

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EventsChannelsExportByIdStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EventsApi(config);
            var id = E33EBA7A-C20D-4D3D-8F2F-5EEF42F58E6F;  // string | ID of the exported file

            try
            {
                // Check Channel Export Status
                ExportStatus result = apiInstance.EventsChannelsExportByIdStatusGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.EventsChannelsExportByIdStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EventsChannelsExportByIdStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Channel Export Status
    ApiResponse<ExportStatus> response = apiInstance.EventsChannelsExportByIdStatusGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.EventsChannelsExportByIdStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the exported file |  |

### Return type

[**ExportStatus**](ExportStatus.md)

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

<a id="eventsexportbyidstatusget"></a>
# **EventsExportByIdStatusGet**
> ExportStatus EventsExportByIdStatusGet (string id)

Check Export Status

Check the current status of the export. Required Access Level: Export

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EventsExportByIdStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EventsApi(config);
            var id = E33EBA7A-C20D-4D3D-8F2F-5EEF42F58E6F;  // string | ID of the exported file

            try
            {
                // Check Export Status
                ExportStatus result = apiInstance.EventsExportByIdStatusGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.EventsExportByIdStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EventsExportByIdStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Export Status
    ApiResponse<ExportStatus> response = apiInstance.EventsExportByIdStatusGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.EventsExportByIdStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the exported file |  |

### Return type

[**ExportStatus**](ExportStatus.md)

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

<a id="eventsexportpost"></a>
# **EventsExportPost**
> ExportLink EventsExportPost (List<EventType> eventTypes = null, DateTime? from = null, DateTime? to = null, ExportFileFormats? fileFormat = null, CompressionFormat? compressionFormat = null, string fileName = null)

Export Events

Export delivery events log information to the specified file format. Required Access Level: Export

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EventsExportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EventsApi(config);
            var eventTypes = new List<EventType>(); // List<EventType> | Types of Events to return (optional) 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Starting date for search in YYYY-MM-DDThh:mm:ss format. (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Ending date for search in YYYY-MM-DDThh:mm:ss format. (optional) 
            var fileFormat = (ExportFileFormats) "Csv";  // ExportFileFormats? | Format of the exported file (optional) 
            var compressionFormat = (CompressionFormat) "None";  // CompressionFormat? | FileResponse compression format. None or Zip. (optional) 
            var fileName = filename.txt;  // string | Name of your file including extension. (optional) 

            try
            {
                // Export Events
                ExportLink result = apiInstance.EventsExportPost(eventTypes, from, to, fileFormat, compressionFormat, fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.EventsExportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EventsExportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export Events
    ApiResponse<ExportLink> response = apiInstance.EventsExportPostWithHttpInfo(eventTypes, from, to, fileFormat, compressionFormat, fileName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.EventsExportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventTypes** | [**List&lt;EventType&gt;**](EventType.md) | Types of Events to return | [optional]  |
| **from** | **DateTime?** | Starting date for search in YYYY-MM-DDThh:mm:ss format. | [optional]  |
| **to** | **DateTime?** | Ending date for search in YYYY-MM-DDThh:mm:ss format. | [optional]  |
| **fileFormat** | **ExportFileFormats?** | Format of the exported file | [optional]  |
| **compressionFormat** | **CompressionFormat?** | FileResponse compression format. None or Zip. | [optional]  |
| **fileName** | **string** | Name of your file including extension. | [optional]  |

### Return type

[**ExportLink**](ExportLink.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="eventsget"></a>
# **EventsGet**
> List&lt;RecipientEvent&gt; EventsGet (List<EventType> eventTypes = null, DateTime? from = null, DateTime? to = null, EventsOrderBy? orderBy = null, int? limit = null, int? offset = null)

Load Events

Returns a log of delivery events filtered by specified parameters. Required Access Level: ViewReports

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EventsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EventsApi(config);
            var eventTypes = new List<EventType>(); // List<EventType> | Types of Events to return (optional) 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Starting date for search in YYYY-MM-DDThh:mm:ss format. (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Ending date for search in YYYY-MM-DDThh:mm:ss format. (optional) 
            var orderBy = (EventsOrderBy) "DateDescending";  // EventsOrderBy? |  (optional) 
            var limit = 56;  // int? | How many items to load. Maximum for this request is 1000 items (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Load Events
                List<RecipientEvent> result = apiInstance.EventsGet(eventTypes, from, to, orderBy, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.EventsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EventsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Events
    ApiResponse<List<RecipientEvent>> response = apiInstance.EventsGetWithHttpInfo(eventTypes, from, to, orderBy, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.EventsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventTypes** | [**List&lt;EventType&gt;**](EventType.md) | Types of Events to return | [optional]  |
| **from** | **DateTime?** | Starting date for search in YYYY-MM-DDThh:mm:ss format. | [optional]  |
| **to** | **DateTime?** | Ending date for search in YYYY-MM-DDThh:mm:ss format. | [optional]  |
| **orderBy** | **EventsOrderBy?** |  | [optional]  |
| **limit** | **int?** | How many items to load. Maximum for this request is 1000 items | [optional]  |
| **offset** | **int?** | How many items should be returned ahead. | [optional]  |

### Return type

[**List&lt;RecipientEvent&gt;**](RecipientEvent.md)

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

