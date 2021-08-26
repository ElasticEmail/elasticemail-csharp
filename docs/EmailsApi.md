# ElasticEmail.Api.EmailsApi

All URIs are relative to *https://api.elasticemail.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmailsByMsgidViewGet**](EmailsApi.md#emailsbymsgidviewget) | **GET** /emails/{msgid}/view | View Email
[**EmailsMergefilePost**](EmailsApi.md#emailsmergefilepost) | **POST** /emails/mergefile | Send Bulk Emails CSV
[**EmailsPost**](EmailsApi.md#emailspost) | **POST** /emails | Send Bulk Emails
[**EmailsTransactionalPost**](EmailsApi.md#emailstransactionalpost) | **POST** /emails/transactional | Send Transactional Email


<a name="emailsbymsgidviewget"></a>
# **EmailsByMsgidViewGet**
> EmailData EmailsByMsgidViewGet (string msgid)

View Email

Returns email details for viewing or rendering. Required Access Level: None

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EmailsByMsgidViewGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EmailsApi(config);
            var msgid = msgid_example;  // string | Message identifier

            try
            {
                // View Email
                EmailData result = apiInstance.EmailsByMsgidViewGet(msgid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailsApi.EmailsByMsgidViewGet: " + e.Message );
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
 **msgid** | **string**| Message identifier | 

### Return type

[**EmailData**](EmailData.md)

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

<a name="emailsmergefilepost"></a>
# **EmailsMergefilePost**
> EmailSend EmailsMergefilePost (MergeEmailPayload mergeEmailPayload)

Send Bulk Emails CSV

Send bulk merge email. Required Access Level: SendHttp

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EmailsMergefilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EmailsApi(config);
            var mergeEmailPayload = new MergeEmailPayload(); // MergeEmailPayload | Email data

            try
            {
                // Send Bulk Emails CSV
                EmailSend result = apiInstance.EmailsMergefilePost(mergeEmailPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailsApi.EmailsMergefilePost: " + e.Message );
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
 **mergeEmailPayload** | [**MergeEmailPayload**](MergeEmailPayload.md)| Email data | 

### Return type

[**EmailSend**](EmailSend.md)

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

<a name="emailspost"></a>
# **EmailsPost**
> EmailSend EmailsPost (EmailMessageData emailMessageData)

Send Bulk Emails

Send bulk merge email. Required Access Level: SendHttp

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EmailsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EmailsApi(config);
            var emailMessageData = new EmailMessageData(); // EmailMessageData | Email data

            try
            {
                // Send Bulk Emails
                EmailSend result = apiInstance.EmailsPost(emailMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailsApi.EmailsPost: " + e.Message );
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
 **emailMessageData** | [**EmailMessageData**](EmailMessageData.md)| Email data | 

### Return type

[**EmailSend**](EmailSend.md)

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

<a name="emailstransactionalpost"></a>
# **EmailsTransactionalPost**
> EmailSend EmailsTransactionalPost (EmailTransactionalMessageData emailTransactionalMessageData)

Send Transactional Email

Send transactional emails (recipients will be known to each other). Required Access Level: SendHttp

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EmailsTransactionalPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new EmailsApi(config);
            var emailTransactionalMessageData = new EmailTransactionalMessageData(); // EmailTransactionalMessageData | Email data

            try
            {
                // Send Transactional Email
                EmailSend result = apiInstance.EmailsTransactionalPost(emailTransactionalMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailsApi.EmailsTransactionalPost: " + e.Message );
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
 **emailTransactionalMessageData** | [**EmailTransactionalMessageData**](EmailTransactionalMessageData.md)| Email data | 

### Return type

[**EmailSend**](EmailSend.md)

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

