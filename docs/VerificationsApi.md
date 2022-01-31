# ElasticEmail.Api.VerificationsApi

All URIs are relative to *https://api.elasticemail.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VerificationsByEmailDelete**](VerificationsApi.md#verificationsbyemaildelete) | **DELETE** /verifications/{email} | Delete Email Verification Result
[**VerificationsByEmailGet**](VerificationsApi.md#verificationsbyemailget) | **GET** /verifications/{email} | Get Email Verification Result
[**VerificationsByEmailPost**](VerificationsApi.md#verificationsbyemailpost) | **POST** /verifications/{email} | Verify Email
[**VerificationsFilesByIdDelete**](VerificationsApi.md#verificationsfilesbyiddelete) | **DELETE** /verifications/files/{id} | Delete File Verification Result
[**VerificationsFilesByIdResultDownloadGet**](VerificationsApi.md#verificationsfilesbyidresultdownloadget) | **GET** /verifications/files/{id}/result/download | Download File Verification Result
[**VerificationsFilesByIdResultGet**](VerificationsApi.md#verificationsfilesbyidresultget) | **GET** /verifications/files/{id}/result | Get Detailed File Verification Result
[**VerificationsFilesByIdVerificationPost**](VerificationsApi.md#verificationsfilesbyidverificationpost) | **POST** /verifications/files/{id}/verification | Start verification
[**VerificationsFilesPost**](VerificationsApi.md#verificationsfilespost) | **POST** /verifications/files | Upload File with Emails
[**VerificationsFilesResultGet**](VerificationsApi.md#verificationsfilesresultget) | **GET** /verifications/files/result | Get Files Verification Results
[**VerificationsGet**](VerificationsApi.md#verificationsget) | **GET** /verifications | Get Emails Verification Results


<a name="verificationsbyemaildelete"></a>
# **VerificationsByEmailDelete**
> void VerificationsByEmailDelete (string email)

Delete Email Verification Result

Delete a result with given email if exists. Required Access Level: VerifyEmails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class VerificationsByEmailDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new VerificationsApi(config);
            var email = "email_example";  // string | Email address to verification

            try
            {
                // Delete Email Verification Result
                apiInstance.VerificationsByEmailDelete(email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationsApi.VerificationsByEmailDelete: " + e.Message );
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
 **email** | **string**| Email address to verification | 

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

<a name="verificationsbyemailget"></a>
# **VerificationsByEmailGet**
> EmailValidationResult VerificationsByEmailGet (string email)

Get Email Verification Result

Returns a result of verified email. Required Access Level: ViewEmailVerifications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class VerificationsByEmailGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new VerificationsApi(config);
            var email = "email_example";  // string | Email address to view verification result of

            try
            {
                // Get Email Verification Result
                EmailValidationResult result = apiInstance.VerificationsByEmailGet(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationsApi.VerificationsByEmailGet: " + e.Message );
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
 **email** | **string**| Email address to view verification result of | 

### Return type

[**EmailValidationResult**](EmailValidationResult.md)

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

<a name="verificationsbyemailpost"></a>
# **VerificationsByEmailPost**
> EmailValidationResult VerificationsByEmailPost (string email)

Verify Email

Verify single email address and returns result of verification. Required Access Level: VerifyEmails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class VerificationsByEmailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new VerificationsApi(config);
            var email = "email_example";  // string | Email address to verify

            try
            {
                // Verify Email
                EmailValidationResult result = apiInstance.VerificationsByEmailPost(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationsApi.VerificationsByEmailPost: " + e.Message );
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
 **email** | **string**| Email address to verify | 

### Return type

[**EmailValidationResult**](EmailValidationResult.md)

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

<a name="verificationsfilesbyiddelete"></a>
# **VerificationsFilesByIdDelete**
> void VerificationsFilesByIdDelete (string id)

Delete File Verification Result

Delete Verification Results if they exist. Required Access Level: VerifyEmails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class VerificationsFilesByIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new VerificationsApi(config);
            var id = E33EBA7A-C20D-4D3D-8F2F-5EEF42F58E6F;  // string | ID of the exported file

            try
            {
                // Delete File Verification Result
                apiInstance.VerificationsFilesByIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationsApi.VerificationsFilesByIdDelete: " + e.Message );
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
 **id** | **string**| ID of the exported file | 

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

<a name="verificationsfilesbyidresultdownloadget"></a>
# **VerificationsFilesByIdResultDownloadGet**
> System.IO.Stream VerificationsFilesByIdResultDownloadGet (string id)

Download File Verification Result

Download verification results as a ZIP file. Required Access Level: VerifyEmails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class VerificationsFilesByIdResultDownloadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new VerificationsApi(config);
            var id = "id_example";  // string | Verification ID to download

            try
            {
                // Download File Verification Result
                System.IO.Stream result = apiInstance.VerificationsFilesByIdResultDownloadGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationsApi.VerificationsFilesByIdResultDownloadGet: " + e.Message );
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
 **id** | **string**| Verification ID to download | 

### Return type

**System.IO.Stream**

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/_*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A ZIP file with verification details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verificationsfilesbyidresultget"></a>
# **VerificationsFilesByIdResultGet**
> VerificationFileResultDetails VerificationsFilesByIdResultGet (string id, int? limit = null, int? offset = null)

Get Detailed File Verification Result

Returns status and results (if verified) of file with given ID. Required Access Level: ViewEmailVerifications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class VerificationsFilesByIdResultGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new VerificationsApi(config);
            var id = "id_example";  // string | ID of the Verification to display status of
            var limit = 56;  // int? | Maximum number of returned email verification results (optional) 
            var offset = 56;  // int? | How many result items should be returned ahead (optional) 

            try
            {
                // Get Detailed File Verification Result
                VerificationFileResultDetails result = apiInstance.VerificationsFilesByIdResultGet(id, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationsApi.VerificationsFilesByIdResultGet: " + e.Message );
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
 **id** | **string**| ID of the Verification to display status of | 
 **limit** | **int?**| Maximum number of returned email verification results | [optional] 
 **offset** | **int?**| How many result items should be returned ahead | [optional] 

### Return type

[**VerificationFileResultDetails**](VerificationFileResultDetails.md)

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

<a name="verificationsfilesbyidverificationpost"></a>
# **VerificationsFilesByIdVerificationPost**
> void VerificationsFilesByIdVerificationPost (string id)

Start verification

Start a verification of the previously uploaded file with emails. Required Access Level: VerifyEmails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class VerificationsFilesByIdVerificationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new VerificationsApi(config);
            var id = "id_example";  // string | File ID to start verification

            try
            {
                // Start verification
                apiInstance.VerificationsFilesByIdVerificationPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationsApi.VerificationsFilesByIdVerificationPost: " + e.Message );
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
 **id** | **string**| File ID to start verification | 

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

<a name="verificationsfilespost"></a>
# **VerificationsFilesPost**
> VerificationFileResult VerificationsFilesPost (System.IO.Stream file = null)

Upload File with Emails

Uploads a CSV file with list of emails that can then be triggered for verification. An 'email' column is required. Required Access Level: VerifyEmails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class VerificationsFilesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new VerificationsApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Upload File with Emails
                VerificationFileResult result = apiInstance.VerificationsFilesPost(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationsApi.VerificationsFilesPost: " + e.Message );
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
 **file** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

[**VerificationFileResult**](VerificationFileResult.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verificationsfilesresultget"></a>
# **VerificationsFilesResultGet**
> List&lt;VerificationFileResult&gt; VerificationsFilesResultGet ()

Get Files Verification Results

Returns a list of uploaded files, their statuses and results. Required Access Level: ViewEmailVerifications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class VerificationsFilesResultGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new VerificationsApi(config);

            try
            {
                // Get Files Verification Results
                List<VerificationFileResult> result = apiInstance.VerificationsFilesResultGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationsApi.VerificationsFilesResultGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;VerificationFileResult&gt;**](VerificationFileResult.md)

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

<a name="verificationsget"></a>
# **VerificationsGet**
> List&lt;EmailValidationResult&gt; VerificationsGet (int? limit = null, int? offset = null)

Get Emails Verification Results

Returns a results of all verified single emails. Required Access Level: ViewEmailVerifications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class VerificationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new VerificationsApi(config);
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Get Emails Verification Results
                List<EmailValidationResult> result = apiInstance.VerificationsGet(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationsApi.VerificationsGet: " + e.Message );
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

[**List&lt;EmailValidationResult&gt;**](EmailValidationResult.md)

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

