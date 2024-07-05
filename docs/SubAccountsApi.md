# ElasticEmail.Api.SubAccountsApi

All URIs are relative to *https://api.elasticemail.com/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubaccountsByEmailCreditsPatch**](SubAccountsApi.md#subaccountsbyemailcreditspatch) | **PATCH** /subaccounts/{email}/credits | Add, Subtract Email Credits |
| [**SubaccountsByEmailDelete**](SubAccountsApi.md#subaccountsbyemaildelete) | **DELETE** /subaccounts/{email} | Delete SubAccount |
| [**SubaccountsByEmailGet**](SubAccountsApi.md#subaccountsbyemailget) | **GET** /subaccounts/{email} | Load SubAccount |
| [**SubaccountsByEmailSettingsEmailPut**](SubAccountsApi.md#subaccountsbyemailsettingsemailput) | **PUT** /subaccounts/{email}/settings/email | Update SubAccount Email Settings |
| [**SubaccountsGet**](SubAccountsApi.md#subaccountsget) | **GET** /subaccounts | Load SubAccounts |
| [**SubaccountsPost**](SubAccountsApi.md#subaccountspost) | **POST** /subaccounts | Add SubAccount |

<a id="subaccountsbyemailcreditspatch"></a>
# **SubaccountsByEmailCreditsPatch**
> void SubaccountsByEmailCreditsPatch (string email, SubaccountEmailCreditsPayload subaccountEmailCreditsPayload)

Add, Subtract Email Credits

Update email credits of a subaccount by the given amount. Required Access Level: ModifySubAccounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SubaccountsByEmailCreditsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SubAccountsApi(config);
            var email = mail@example.com;  // string | Email address of Sub-Account
            var subaccountEmailCreditsPayload = new SubaccountEmailCreditsPayload(); // SubaccountEmailCreditsPayload | Amount of email credits to add or subtract from the current SubAccount email credits pool (positive or negative value)

            try
            {
                // Add, Subtract Email Credits
                apiInstance.SubaccountsByEmailCreditsPatch(email, subaccountEmailCreditsPayload);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubAccountsApi.SubaccountsByEmailCreditsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubaccountsByEmailCreditsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add, Subtract Email Credits
    apiInstance.SubaccountsByEmailCreditsPatchWithHttpInfo(email, subaccountEmailCreditsPayload);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubAccountsApi.SubaccountsByEmailCreditsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Email address of Sub-Account |  |
| **subaccountEmailCreditsPayload** | [**SubaccountEmailCreditsPayload**](SubaccountEmailCreditsPayload.md) | Amount of email credits to add or subtract from the current SubAccount email credits pool (positive or negative value) |  |

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

<a id="subaccountsbyemaildelete"></a>
# **SubaccountsByEmailDelete**
> void SubaccountsByEmailDelete (string email)

Delete SubAccount

Deletes specified SubAccount. An email will be sent to confirm this change. Required Access Level: ModifySubAccounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SubaccountsByEmailDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SubAccountsApi(config);
            var email = mail@example.com;  // string | Email address of Sub-Account

            try
            {
                // Delete SubAccount
                apiInstance.SubaccountsByEmailDelete(email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubAccountsApi.SubaccountsByEmailDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubaccountsByEmailDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete SubAccount
    apiInstance.SubaccountsByEmailDeleteWithHttpInfo(email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubAccountsApi.SubaccountsByEmailDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Email address of Sub-Account |  |

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

<a id="subaccountsbyemailget"></a>
# **SubaccountsByEmailGet**
> SubAccountInfo SubaccountsByEmailGet (string email)

Load SubAccount

Returns details for the specified SubAccount. Required Access Level: ViewSubAccounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SubaccountsByEmailGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SubAccountsApi(config);
            var email = mail@example.com;  // string | Email address of Sub-Account

            try
            {
                // Load SubAccount
                SubAccountInfo result = apiInstance.SubaccountsByEmailGet(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubAccountsApi.SubaccountsByEmailGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubaccountsByEmailGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load SubAccount
    ApiResponse<SubAccountInfo> response = apiInstance.SubaccountsByEmailGetWithHttpInfo(email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubAccountsApi.SubaccountsByEmailGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Email address of Sub-Account |  |

### Return type

[**SubAccountInfo**](SubAccountInfo.md)

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

<a id="subaccountsbyemailsettingsemailput"></a>
# **SubaccountsByEmailSettingsEmailPut**
> SubaccountEmailSettings SubaccountsByEmailSettingsEmailPut (string email, SubaccountEmailSettings subaccountEmailSettings)

Update SubAccount Email Settings

Update SubAccount email settings. Required Access Level: ModifySubAccounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SubaccountsByEmailSettingsEmailPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SubAccountsApi(config);
            var email = "email_example";  // string | 
            var subaccountEmailSettings = new SubaccountEmailSettings(); // SubaccountEmailSettings | Updated Email Settings

            try
            {
                // Update SubAccount Email Settings
                SubaccountEmailSettings result = apiInstance.SubaccountsByEmailSettingsEmailPut(email, subaccountEmailSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubAccountsApi.SubaccountsByEmailSettingsEmailPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubaccountsByEmailSettingsEmailPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update SubAccount Email Settings
    ApiResponse<SubaccountEmailSettings> response = apiInstance.SubaccountsByEmailSettingsEmailPutWithHttpInfo(email, subaccountEmailSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubAccountsApi.SubaccountsByEmailSettingsEmailPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** |  |  |
| **subaccountEmailSettings** | [**SubaccountEmailSettings**](SubaccountEmailSettings.md) | Updated Email Settings |  |

### Return type

[**SubaccountEmailSettings**](SubaccountEmailSettings.md)

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

<a id="subaccountsget"></a>
# **SubaccountsGet**
> List&lt;SubAccountInfo&gt; SubaccountsGet (int? limit = null, int? offset = null)

Load SubAccounts

Returns a list of all your SubAccounts. Required Access Level: ViewSubAccounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SubaccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SubAccountsApi(config);
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Load SubAccounts
                List<SubAccountInfo> result = apiInstance.SubaccountsGet(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubAccountsApi.SubaccountsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubaccountsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load SubAccounts
    ApiResponse<List<SubAccountInfo>> response = apiInstance.SubaccountsGetWithHttpInfo(limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubAccountsApi.SubaccountsGetWithHttpInfo: " + e.Message);
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

[**List&lt;SubAccountInfo&gt;**](SubAccountInfo.md)

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

<a id="subaccountspost"></a>
# **SubaccountsPost**
> SubAccountInfo SubaccountsPost (SubaccountPayload subaccountPayload)

Add SubAccount

Add a new SubAccount to your Account. To receive an access token for this SubAccount, make a POST security/apikeys request using the 'subaccount' parameter. Required Access Level: ModifySubAccounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class SubaccountsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new SubAccountsApi(config);
            var subaccountPayload = new SubaccountPayload(); // SubaccountPayload | 

            try
            {
                // Add SubAccount
                SubAccountInfo result = apiInstance.SubaccountsPost(subaccountPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubAccountsApi.SubaccountsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubaccountsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add SubAccount
    ApiResponse<SubAccountInfo> response = apiInstance.SubaccountsPostWithHttpInfo(subaccountPayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubAccountsApi.SubaccountsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subaccountPayload** | [**SubaccountPayload**](SubaccountPayload.md) |  |  |

### Return type

[**SubAccountInfo**](SubAccountInfo.md)

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

