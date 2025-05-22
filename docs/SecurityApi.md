# ElasticEmail.Api.SecurityApi

All URIs are relative to *https://api.elasticemail.com/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecurityApikeysByNameDelete**](SecurityApi.md#securityapikeysbynamedelete) | **DELETE** /security/apikeys/{name} | Delete ApiKey |
| [**SecurityApikeysByNameGet**](SecurityApi.md#securityapikeysbynameget) | **GET** /security/apikeys/{name} | Load ApiKey |
| [**SecurityApikeysByNamePut**](SecurityApi.md#securityapikeysbynameput) | **PUT** /security/apikeys/{name} | Update ApiKey |
| [**SecurityApikeysGet**](SecurityApi.md#securityapikeysget) | **GET** /security/apikeys | List ApiKeys |
| [**SecurityApikeysPost**](SecurityApi.md#securityapikeyspost) | **POST** /security/apikeys | Add ApiKey |
| [**SecuritySmtpByNameDelete**](SecurityApi.md#securitysmtpbynamedelete) | **DELETE** /security/smtp/{name} | Delete SMTP Credential |
| [**SecuritySmtpByNameGet**](SecurityApi.md#securitysmtpbynameget) | **GET** /security/smtp/{name} | Load SMTP Credential |
| [**SecuritySmtpByNamePut**](SecurityApi.md#securitysmtpbynameput) | **PUT** /security/smtp/{name} | Update SMTP Credential |
| [**SecuritySmtpGet**](SecurityApi.md#securitysmtpget) | **GET** /security/smtp | List SMTP Credentials |
| [**SecuritySmtpPost**](SecurityApi.md#securitysmtppost) | **POST** /security/smtp | Add SMTP Credential |

<a id="securityapikeysbynamedelete"></a>
# **SecurityApikeysByNameDelete**
> void SecurityApikeysByNameDelete (string name, string subaccount = null)

Delete ApiKey

Delete your existing ApiKey. Required Access Level: ModifyAccessTokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SecurityApikeysByNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SecurityApi(config);
            var name = "name_example";  // string | Name of the ApiKey
            var subaccount = "subaccount_example";  // string | Email of the subaccount of which ApiKey should be deleted (optional) 

            try
            {
                // Delete ApiKey
                apiInstance.SecurityApikeysByNameDelete(name, subaccount);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityApikeysByNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityApikeysByNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete ApiKey
    apiInstance.SecurityApikeysByNameDeleteWithHttpInfo(name, subaccount);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityApi.SecurityApikeysByNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of the ApiKey |  |
| **subaccount** | **string** | Email of the subaccount of which ApiKey should be deleted | [optional]  |

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

<a id="securityapikeysbynameget"></a>
# **SecurityApikeysByNameGet**
> ApiKey SecurityApikeysByNameGet (string name, string subaccount = null)

Load ApiKey

Load your existing ApiKey info. Required Access Level: Security

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SecurityApikeysByNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SecurityApi(config);
            var name = "name_example";  // string | Name of the ApiKey
            var subaccount = "subaccount_example";  // string | Email of the subaccount of which ApiKey should be loaded (optional) 

            try
            {
                // Load ApiKey
                ApiKey result = apiInstance.SecurityApikeysByNameGet(name, subaccount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityApikeysByNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityApikeysByNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load ApiKey
    ApiResponse<ApiKey> response = apiInstance.SecurityApikeysByNameGetWithHttpInfo(name, subaccount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityApi.SecurityApikeysByNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of the ApiKey |  |
| **subaccount** | **string** | Email of the subaccount of which ApiKey should be loaded | [optional]  |

### Return type

[**ApiKey**](ApiKey.md)

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

<a id="securityapikeysbynameput"></a>
# **SecurityApikeysByNamePut**
> ApiKey SecurityApikeysByNamePut (string name, ApiKeyPayload apiKeyPayload)

Update ApiKey

Update your existing ApiKey. Required Access Level: ModifyAccessTokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SecurityApikeysByNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SecurityApi(config);
            var name = "name_example";  // string | Name of the ApiKey
            var apiKeyPayload = new ApiKeyPayload(); // ApiKeyPayload | 

            try
            {
                // Update ApiKey
                ApiKey result = apiInstance.SecurityApikeysByNamePut(name, apiKeyPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityApikeysByNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityApikeysByNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update ApiKey
    ApiResponse<ApiKey> response = apiInstance.SecurityApikeysByNamePutWithHttpInfo(name, apiKeyPayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityApi.SecurityApikeysByNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of the ApiKey |  |
| **apiKeyPayload** | [**ApiKeyPayload**](ApiKeyPayload.md) |  |  |

### Return type

[**ApiKey**](ApiKey.md)

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

<a id="securityapikeysget"></a>
# **SecurityApikeysGet**
> List&lt;ApiKey&gt; SecurityApikeysGet (string subaccount = null)

List ApiKeys

List all your existing ApiKeys. Required Access Level: Security

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SecurityApikeysGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SecurityApi(config);
            var subaccount = "subaccount_example";  // string | Email of the subaccount of which ApiKeys should be loaded (optional) 

            try
            {
                // List ApiKeys
                List<ApiKey> result = apiInstance.SecurityApikeysGet(subaccount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityApikeysGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityApikeysGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List ApiKeys
    ApiResponse<List<ApiKey>> response = apiInstance.SecurityApikeysGetWithHttpInfo(subaccount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityApi.SecurityApikeysGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subaccount** | **string** | Email of the subaccount of which ApiKeys should be loaded | [optional]  |

### Return type

[**List&lt;ApiKey&gt;**](ApiKey.md)

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

<a id="securityapikeyspost"></a>
# **SecurityApikeysPost**
> NewApiKey SecurityApikeysPost (ApiKeyPayload apiKeyPayload)

Add ApiKey

Add a new ApiKey. Required Access Level: ModifyAccessTokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SecurityApikeysPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SecurityApi(config);
            var apiKeyPayload = new ApiKeyPayload(); // ApiKeyPayload | 

            try
            {
                // Add ApiKey
                NewApiKey result = apiInstance.SecurityApikeysPost(apiKeyPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityApikeysPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityApikeysPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add ApiKey
    ApiResponse<NewApiKey> response = apiInstance.SecurityApikeysPostWithHttpInfo(apiKeyPayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityApi.SecurityApikeysPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiKeyPayload** | [**ApiKeyPayload**](ApiKeyPayload.md) |  |  |

### Return type

[**NewApiKey**](NewApiKey.md)

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

<a id="securitysmtpbynamedelete"></a>
# **SecuritySmtpByNameDelete**
> void SecuritySmtpByNameDelete (string name, string subaccount = null)

Delete SMTP Credential

Delete your existing SMTP Credentials. Required Access Level: ModifyAccessTokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SecuritySmtpByNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SecurityApi(config);
            var name = "name_example";  // string | Name of the SMTP Credential
            var subaccount = "subaccount_example";  // string | Email of the subaccount of which credential should be deleted (optional) 

            try
            {
                // Delete SMTP Credential
                apiInstance.SecuritySmtpByNameDelete(name, subaccount);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SecuritySmtpByNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecuritySmtpByNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete SMTP Credential
    apiInstance.SecuritySmtpByNameDeleteWithHttpInfo(name, subaccount);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityApi.SecuritySmtpByNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of the SMTP Credential |  |
| **subaccount** | **string** | Email of the subaccount of which credential should be deleted | [optional]  |

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

<a id="securitysmtpbynameget"></a>
# **SecuritySmtpByNameGet**
> SmtpCredentials SecuritySmtpByNameGet (string name, string subaccount = null)

Load SMTP Credential

Load your existing SMTP Credential info. Required Access Level: Security

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SecuritySmtpByNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SecurityApi(config);
            var name = "name_example";  // string | Name of the SMTP Credential
            var subaccount = "subaccount_example";  // string | Email of the subaccount of which credential should be loaded (optional) 

            try
            {
                // Load SMTP Credential
                SmtpCredentials result = apiInstance.SecuritySmtpByNameGet(name, subaccount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SecuritySmtpByNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecuritySmtpByNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load SMTP Credential
    ApiResponse<SmtpCredentials> response = apiInstance.SecuritySmtpByNameGetWithHttpInfo(name, subaccount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityApi.SecuritySmtpByNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of the SMTP Credential |  |
| **subaccount** | **string** | Email of the subaccount of which credential should be loaded | [optional]  |

### Return type

[**SmtpCredentials**](SmtpCredentials.md)

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

<a id="securitysmtpbynameput"></a>
# **SecuritySmtpByNamePut**
> SmtpCredentials SecuritySmtpByNamePut (string name, SmtpCredentialsPayload smtpCredentialsPayload)

Update SMTP Credential

Update your existing SMTP Credentials. Required Access Level: ModifyAccessTokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SecuritySmtpByNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SecurityApi(config);
            var name = "name_example";  // string | Name of the SMTP Credential
            var smtpCredentialsPayload = new SmtpCredentialsPayload(); // SmtpCredentialsPayload | 

            try
            {
                // Update SMTP Credential
                SmtpCredentials result = apiInstance.SecuritySmtpByNamePut(name, smtpCredentialsPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SecuritySmtpByNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecuritySmtpByNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update SMTP Credential
    ApiResponse<SmtpCredentials> response = apiInstance.SecuritySmtpByNamePutWithHttpInfo(name, smtpCredentialsPayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityApi.SecuritySmtpByNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name of the SMTP Credential |  |
| **smtpCredentialsPayload** | [**SmtpCredentialsPayload**](SmtpCredentialsPayload.md) |  |  |

### Return type

[**SmtpCredentials**](SmtpCredentials.md)

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

<a id="securitysmtpget"></a>
# **SecuritySmtpGet**
> List&lt;SmtpCredentials&gt; SecuritySmtpGet (string subaccount = null)

List SMTP Credentials

List all your existing SMTP Credentials. Required Access Level: Security

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SecuritySmtpGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SecurityApi(config);
            var subaccount = "subaccount_example";  // string | Email of the subaccount of which credentials should be listed (optional) 

            try
            {
                // List SMTP Credentials
                List<SmtpCredentials> result = apiInstance.SecuritySmtpGet(subaccount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SecuritySmtpGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecuritySmtpGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List SMTP Credentials
    ApiResponse<List<SmtpCredentials>> response = apiInstance.SecuritySmtpGetWithHttpInfo(subaccount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityApi.SecuritySmtpGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subaccount** | **string** | Email of the subaccount of which credentials should be listed | [optional]  |

### Return type

[**List&lt;SmtpCredentials&gt;**](SmtpCredentials.md)

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

<a id="securitysmtppost"></a>
# **SecuritySmtpPost**
> NewSmtpCredentials SecuritySmtpPost (SmtpCredentialsPayload smtpCredentialsPayload)

Add SMTP Credential

Add new SMTP Credential. Required Access Level: ModifyAccessTokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SecuritySmtpPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SecurityApi(config);
            var smtpCredentialsPayload = new SmtpCredentialsPayload(); // SmtpCredentialsPayload | 

            try
            {
                // Add SMTP Credential
                NewSmtpCredentials result = apiInstance.SecuritySmtpPost(smtpCredentialsPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SecuritySmtpPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecuritySmtpPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add SMTP Credential
    ApiResponse<NewSmtpCredentials> response = apiInstance.SecuritySmtpPostWithHttpInfo(smtpCredentialsPayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityApi.SecuritySmtpPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smtpCredentialsPayload** | [**SmtpCredentialsPayload**](SmtpCredentialsPayload.md) |  |  |

### Return type

[**NewSmtpCredentials**](NewSmtpCredentials.md)

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

