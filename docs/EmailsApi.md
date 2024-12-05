# ElasticEmail.Api.EmailsApi

All URIs are relative to *https://api.elasticemail.com/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmailsByMsgidViewGet**](EmailsApi.md#emailsbymsgidviewget) | **GET** /emails/{msgid}/view | View Email |
| [**EmailsByTransactionidStatusGet**](EmailsApi.md#emailsbytransactionidstatusget) | **GET** /emails/{transactionid}/status | Get Status |
| [**EmailsMergefilePost**](EmailsApi.md#emailsmergefilepost) | **POST** /emails/mergefile | Send Bulk Emails CSV |
| [**EmailsPost**](EmailsApi.md#emailspost) | **POST** /emails | Send Bulk Emails |
| [**EmailsTransactionalPost**](EmailsApi.md#emailstransactionalpost) | **POST** /emails/transactional | Send Transactional Email |

<a id="emailsbymsgidviewget"></a>
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
            var msgid = "msgid_example";  // string | Message identifier

            try
            {
                // View Email
                EmailData result = apiInstance.EmailsByMsgidViewGet(msgid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailsApi.EmailsByMsgidViewGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmailsByMsgidViewGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // View Email
    ApiResponse<EmailData> response = apiInstance.EmailsByMsgidViewGetWithHttpInfo(msgid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailsApi.EmailsByMsgidViewGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **msgid** | **string** | Message identifier |  |

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

<a id="emailsbytransactionidstatusget"></a>
# **EmailsByTransactionidStatusGet**
> EmailJobStatus EmailsByTransactionidStatusGet (string transactionid, bool? showFailed = null, bool? showSent = null, bool? showDelivered = null, bool? showPending = null, bool? showOpened = null, bool? showClicked = null, bool? showAbuse = null, bool? showUnsubscribed = null, bool? showErrors = null, bool? showMessageIDs = null)

Get Status

Get status details of an email transaction. Required Access Level: ViewReports

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class EmailsByTransactionidStatusGetExample
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
            var transactionid = "transactionid_example";  // string | Transaction identifier
            var showFailed = false;  // bool? | Include Bounced email addresses. (optional)  (default to false)
            var showSent = false;  // bool? | Include Sent email addresses. (optional)  (default to false)
            var showDelivered = false;  // bool? | Include all delivered email addresses. (optional)  (default to false)
            var showPending = false;  // bool? | Include Ready to send email addresses. (optional)  (default to false)
            var showOpened = false;  // bool? | Include Opened email addresses. (optional)  (default to false)
            var showClicked = false;  // bool? | Include Clicked email addresses. (optional)  (default to false)
            var showAbuse = false;  // bool? | Include Reported as abuse email addresses. (optional)  (default to false)
            var showUnsubscribed = false;  // bool? | Include Unsubscribed email addresses. (optional)  (default to false)
            var showErrors = false;  // bool? | Include error messages for bounced emails. (optional)  (default to false)
            var showMessageIDs = false;  // bool? | Include all MessageIDs for this transaction (optional)  (default to false)

            try
            {
                // Get Status
                EmailJobStatus result = apiInstance.EmailsByTransactionidStatusGet(transactionid, showFailed, showSent, showDelivered, showPending, showOpened, showClicked, showAbuse, showUnsubscribed, showErrors, showMessageIDs);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailsApi.EmailsByTransactionidStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmailsByTransactionidStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Status
    ApiResponse<EmailJobStatus> response = apiInstance.EmailsByTransactionidStatusGetWithHttpInfo(transactionid, showFailed, showSent, showDelivered, showPending, showOpened, showClicked, showAbuse, showUnsubscribed, showErrors, showMessageIDs);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailsApi.EmailsByTransactionidStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionid** | **string** | Transaction identifier |  |
| **showFailed** | **bool?** | Include Bounced email addresses. | [optional] [default to false] |
| **showSent** | **bool?** | Include Sent email addresses. | [optional] [default to false] |
| **showDelivered** | **bool?** | Include all delivered email addresses. | [optional] [default to false] |
| **showPending** | **bool?** | Include Ready to send email addresses. | [optional] [default to false] |
| **showOpened** | **bool?** | Include Opened email addresses. | [optional] [default to false] |
| **showClicked** | **bool?** | Include Clicked email addresses. | [optional] [default to false] |
| **showAbuse** | **bool?** | Include Reported as abuse email addresses. | [optional] [default to false] |
| **showUnsubscribed** | **bool?** | Include Unsubscribed email addresses. | [optional] [default to false] |
| **showErrors** | **bool?** | Include error messages for bounced emails. | [optional] [default to false] |
| **showMessageIDs** | **bool?** | Include all MessageIDs for this transaction | [optional] [default to false] |

### Return type

[**EmailJobStatus**](EmailJobStatus.md)

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

<a id="emailsmergefilepost"></a>
# **EmailsMergefilePost**
> EmailSend EmailsMergefilePost (MergeEmailPayload mergeEmailPayload)

Send Bulk Emails CSV

Send to a list of contacts submitted in a CSV data file. The first column in the CSV must be the email address and the CSV must contain a header row. Additional fields can be included with a named header row and can be merged with the template using {merge} tags in the content.                           Example CSV:                           email, firstname, lastname              test1@gmail.com, michael, smith              test2@gmail.com, janet, smith                           Merge file must not be empty. Required Access Level: SendHttp

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
                Debug.Print("Exception when calling EmailsApi.EmailsMergefilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmailsMergefilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Bulk Emails CSV
    ApiResponse<EmailSend> response = apiInstance.EmailsMergefilePostWithHttpInfo(mergeEmailPayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailsApi.EmailsMergefilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mergeEmailPayload** | [**MergeEmailPayload**](MergeEmailPayload.md) | Email data |  |

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

<a id="emailspost"></a>
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
                Debug.Print("Exception when calling EmailsApi.EmailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Bulk Emails
    ApiResponse<EmailSend> response = apiInstance.EmailsPostWithHttpInfo(emailMessageData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailsApi.EmailsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailMessageData** | [**EmailMessageData**](EmailMessageData.md) | Email data |  |

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

<a id="emailstransactionalpost"></a>
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
                Debug.Print("Exception when calling EmailsApi.EmailsTransactionalPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmailsTransactionalPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Transactional Email
    ApiResponse<EmailSend> response = apiInstance.EmailsTransactionalPostWithHttpInfo(emailTransactionalMessageData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailsApi.EmailsTransactionalPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailTransactionalMessageData** | [**EmailTransactionalMessageData**](EmailTransactionalMessageData.md) | Email data |  |

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

