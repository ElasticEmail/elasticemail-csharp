# ElasticEmail.Api.TemplatesApi

All URIs are relative to *https://api.elasticemail.com/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TemplatesByNameDelete**](TemplatesApi.md#templatesbynamedelete) | **DELETE** /templates/{name} | Delete Template |
| [**TemplatesByNameGet**](TemplatesApi.md#templatesbynameget) | **GET** /templates/{name} | Load Template |
| [**TemplatesByNamePut**](TemplatesApi.md#templatesbynameput) | **PUT** /templates/{name} | Update Template |
| [**TemplatesGet**](TemplatesApi.md#templatesget) | **GET** /templates | Load Templates |
| [**TemplatesPost**](TemplatesApi.md#templatespost) | **POST** /templates | Add Template |

<a name="templatesbynamedelete"></a>
# **TemplatesByNameDelete**
> void TemplatesByNameDelete (string name)

Delete Template

Delete template with the specified name. Required Access Level: ModifyTemplates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class TemplatesByNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var name = Template01;  // string | Name of template.

            try
            {
                // Delete Template
                apiInstance.TemplatesByNameDelete(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesByNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplatesByNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Template
    apiInstance.TemplatesByNameDeleteWithHttpInfo(name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplatesByNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of template. |  |

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

<a name="templatesbynameget"></a>
# **TemplatesByNameGet**
> Template TemplatesByNameGet (string name)

Load Template

Load detailed information of the specified template. Required Access Level: ViewTemplates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class TemplatesByNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var name = Template01;  // string | Name of template.

            try
            {
                // Load Template
                Template result = apiInstance.TemplatesByNameGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesByNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplatesByNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Template
    ApiResponse<Template> response = apiInstance.TemplatesByNameGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplatesByNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of template. |  |

### Return type

[**Template**](Template.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Serialized template |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesbynameput"></a>
# **TemplatesByNamePut**
> Template TemplatesByNamePut (string name, TemplatePayload templatePayload)

Update Template

Update existing template, overwriting existing data. Required Access Level: ModifyTemplates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class TemplatesByNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var name = Template01;  // string | Name of template.
            var templatePayload = new TemplatePayload(); // TemplatePayload | 

            try
            {
                // Update Template
                Template result = apiInstance.TemplatesByNamePut(name, templatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesByNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplatesByNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Template
    ApiResponse<Template> response = apiInstance.TemplatesByNamePutWithHttpInfo(name, templatePayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplatesByNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of template. |  |
| **templatePayload** | [**TemplatePayload**](TemplatePayload.md) |  |  |

### Return type

[**Template**](Template.md)

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

<a name="templatesget"></a>
# **TemplatesGet**
> List&lt;Template&gt; TemplatesGet (List<TemplateScope> scopeType, List<TemplateType> templateTypes = null, int? limit = null, int? offset = null)

Load Templates

Returns a list of templates for the specified type. Required Access Level: ViewTemplates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class TemplatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var scopeType = new List<TemplateScope>(); // List<TemplateScope> | Return templates with specified scope only
            var templateTypes = new List<TemplateType>(); // List<TemplateType> | Return templates with specified type only (optional) 
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Load Templates
                List<Template> result = apiInstance.TemplatesGet(scopeType, templateTypes, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Templates
    ApiResponse<List<Template>> response = apiInstance.TemplatesGetWithHttpInfo(scopeType, templateTypes, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scopeType** | [**List&lt;TemplateScope&gt;**](TemplateScope.md) | Return templates with specified scope only |  |
| **templateTypes** | [**List&lt;TemplateType&gt;**](TemplateType.md) | Return templates with specified type only | [optional]  |
| **limit** | **int?** | Maximum number of returned items. | [optional]  |
| **offset** | **int?** | How many items should be returned ahead. | [optional]  |

### Return type

[**List&lt;Template&gt;**](Template.md)

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

<a name="templatespost"></a>
# **TemplatesPost**
> Template TemplatesPost (TemplatePayload templatePayload)

Add Template

Add a new Template. Required Access Level: ModifyTemplates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class TemplatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var templatePayload = new TemplatePayload(); // TemplatePayload | 

            try
            {
                // Add Template
                Template result = apiInstance.TemplatesPost(templatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Template
    ApiResponse<Template> response = apiInstance.TemplatesPostWithHttpInfo(templatePayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.TemplatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templatePayload** | [**TemplatePayload**](TemplatePayload.md) |  |  |

### Return type

[**Template**](Template.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Template |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

