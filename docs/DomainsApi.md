# ElasticEmail.Api.DomainsApi

All URIs are relative to *https://api.elasticemail.com/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DomainsByDomainDelete**](DomainsApi.md#domainsbydomaindelete) | **DELETE** /domains/{domain} | Delete Domain |
| [**DomainsByDomainGet**](DomainsApi.md#domainsbydomainget) | **GET** /domains/{domain} | Load Domain |
| [**DomainsByDomainPut**](DomainsApi.md#domainsbydomainput) | **PUT** /domains/{domain} | Update Domain |
| [**DomainsByDomainRestrictedGet**](DomainsApi.md#domainsbydomainrestrictedget) | **GET** /domains/{domain}/restricted | Check for domain restriction |
| [**DomainsByDomainVerificationPut**](DomainsApi.md#domainsbydomainverificationput) | **PUT** /domains/{domain}/verification | Verify Domain |
| [**DomainsByEmailDefaultPatch**](DomainsApi.md#domainsbyemaildefaultpatch) | **PATCH** /domains/{email}/default | Set Default |
| [**DomainsGet**](DomainsApi.md#domainsget) | **GET** /domains | Load Domains |
| [**DomainsPost**](DomainsApi.md#domainspost) | **POST** /domains | Add Domain |

<a id="domainsbydomaindelete"></a>
# **DomainsByDomainDelete**
> void DomainsByDomainDelete (string domain)

Delete Domain

Deletes configured domain from Account. Required Access Level: ModifySettings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class DomainsByDomainDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new DomainsApi(config);
            var domain = "domain_example";  // string | Name of the given domain

            try
            {
                // Delete Domain
                apiInstance.DomainsByDomainDelete(domain);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsByDomainDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsByDomainDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Domain
    apiInstance.DomainsByDomainDeleteWithHttpInfo(domain);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsByDomainDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Name of the given domain |  |

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

<a id="domainsbydomainget"></a>
# **DomainsByDomainGet**
> DomainData DomainsByDomainGet (string domain)

Load Domain

Retrieve a domain configured for this Account. Required Access Level: ViewSettings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class DomainsByDomainGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new DomainsApi(config);
            var domain = "domain_example";  // string | Name of the given domain

            try
            {
                // Load Domain
                DomainData result = apiInstance.DomainsByDomainGet(domain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsByDomainGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsByDomainGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Domain
    ApiResponse<DomainData> response = apiInstance.DomainsByDomainGetWithHttpInfo(domain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsByDomainGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Name of the given domain |  |

### Return type

[**DomainData**](DomainData.md)

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

<a id="domainsbydomainput"></a>
# **DomainsByDomainPut**
> DomainDetail DomainsByDomainPut (string domain, DomainUpdatePayload domainUpdatePayload)

Update Domain

Updates the specified domain. Required Access Level: ModifySettings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class DomainsByDomainPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new DomainsApi(config);
            var domain = "domain_example";  // string | Name of the given domain
            var domainUpdatePayload = new DomainUpdatePayload(); // DomainUpdatePayload | Updated Domain resource

            try
            {
                // Update Domain
                DomainDetail result = apiInstance.DomainsByDomainPut(domain, domainUpdatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsByDomainPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsByDomainPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Domain
    ApiResponse<DomainDetail> response = apiInstance.DomainsByDomainPutWithHttpInfo(domain, domainUpdatePayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsByDomainPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Name of the given domain |  |
| **domainUpdatePayload** | [**DomainUpdatePayload**](DomainUpdatePayload.md) | Updated Domain resource |  |

### Return type

[**DomainDetail**](DomainDetail.md)

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

<a id="domainsbydomainrestrictedget"></a>
# **DomainsByDomainRestrictedGet**
> bool DomainsByDomainRestrictedGet (string domain)

Check for domain restriction

Checking if domain is from free provider, or restricted. Required Access Level: ViewSettings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class DomainsByDomainRestrictedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new DomainsApi(config);
            var domain = "domain_example";  // string | Name of the given domain

            try
            {
                // Check for domain restriction
                bool result = apiInstance.DomainsByDomainRestrictedGet(domain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsByDomainRestrictedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsByDomainRestrictedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check for domain restriction
    ApiResponse<bool> response = apiInstance.DomainsByDomainRestrictedGetWithHttpInfo(domain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsByDomainRestrictedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Name of the given domain |  |

### Return type

**bool**

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

<a id="domainsbydomainverificationput"></a>
# **DomainsByDomainVerificationPut**
> DomainData DomainsByDomainVerificationPut (string domain, string body)

Verify Domain

Verifies that required DNS records exist for specified domain. Required Access Level: ModifySettings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class DomainsByDomainVerificationPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new DomainsApi(config);
            var domain = "domain_example";  // string | Name of the given domain
            var body = "body_example";  // string | Tracking type used in the Tracking verification

            try
            {
                // Verify Domain
                DomainData result = apiInstance.DomainsByDomainVerificationPut(domain, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsByDomainVerificationPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsByDomainVerificationPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify Domain
    ApiResponse<DomainData> response = apiInstance.DomainsByDomainVerificationPutWithHttpInfo(domain, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsByDomainVerificationPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Name of the given domain |  |
| **body** | **string** | Tracking type used in the Tracking verification |  |

### Return type

[**DomainData**](DomainData.md)

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

<a id="domainsbyemaildefaultpatch"></a>
# **DomainsByEmailDefaultPatch**
> DomainDetail DomainsByEmailDefaultPatch (string email)

Set Default

Sets a verified email address as default sender. Required Access Level: ModifySettings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class DomainsByEmailDefaultPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new DomainsApi(config);
            var email = "email_example";  // string | Default email sender, example: mail@yourdomain.com

            try
            {
                // Set Default
                DomainDetail result = apiInstance.DomainsByEmailDefaultPatch(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsByEmailDefaultPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsByEmailDefaultPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Default
    ApiResponse<DomainDetail> response = apiInstance.DomainsByEmailDefaultPatchWithHttpInfo(email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsByEmailDefaultPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Default email sender, example: mail@yourdomain.com |  |

### Return type

[**DomainDetail**](DomainDetail.md)

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

<a id="domainsget"></a>
# **DomainsGet**
> List&lt;DomainDetail&gt; DomainsGet ()

Load Domains

Returns a list of all domains configured for this Account. Required Access Level: ViewSettings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class DomainsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new DomainsApi(config);

            try
            {
                // Load Domains
                List<DomainDetail> result = apiInstance.DomainsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Domains
    ApiResponse<List<DomainDetail>> response = apiInstance.DomainsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;DomainDetail&gt;**](DomainDetail.md)

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

<a id="domainspost"></a>
# **DomainsPost**
> DomainDetail DomainsPost (DomainPayload domainPayload)

Add Domain

Add new domain to Account. Required Access Level: ModifySettings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class DomainsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new DomainsApi(config);
            var domainPayload = new DomainPayload(); // DomainPayload | Domain to add

            try
            {
                // Add Domain
                DomainDetail result = apiInstance.DomainsPost(domainPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Domain
    ApiResponse<DomainDetail> response = apiInstance.DomainsPostWithHttpInfo(domainPayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainPayload** | [**DomainPayload**](DomainPayload.md) | Domain to add |  |

### Return type

[**DomainDetail**](DomainDetail.md)

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

