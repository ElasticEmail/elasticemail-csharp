# ElasticEmail.Api.StatisticsApi

All URIs are relative to *https://api.elasticemail.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StatisticsCampaignsByNameGet**](StatisticsApi.md#statisticscampaignsbynameget) | **GET** /statistics/campaigns/{name} | Load Campaign Stats
[**StatisticsCampaignsGet**](StatisticsApi.md#statisticscampaignsget) | **GET** /statistics/campaigns | Load Campaigns Stats
[**StatisticsChannelsByNameGet**](StatisticsApi.md#statisticschannelsbynameget) | **GET** /statistics/channels/{name} | Load Channel Stats
[**StatisticsChannelsGet**](StatisticsApi.md#statisticschannelsget) | **GET** /statistics/channels | Load Channels Stats
[**StatisticsGet**](StatisticsApi.md#statisticsget) | **GET** /statistics | Load Statistics


<a name="statisticscampaignsbynameget"></a>
# **StatisticsCampaignsByNameGet**
> ChannelLogStatusSummary StatisticsCampaignsByNameGet (string name)

Load Campaign Stats

Retrieve stats of an existing campaign. Required Access Level: ViewChannels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class StatisticsCampaignsByNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new StatisticsApi(config);
            var name = name_example;  // string | The name of the campaign to get.

            try
            {
                // Load Campaign Stats
                ChannelLogStatusSummary result = apiInstance.StatisticsCampaignsByNameGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsCampaignsByNameGet: " + e.Message );
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
 **name** | **string**| The name of the campaign to get. | 

### Return type

[**ChannelLogStatusSummary**](ChannelLogStatusSummary.md)

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

<a name="statisticscampaignsget"></a>
# **StatisticsCampaignsGet**
> List&lt;ChannelLogStatusSummary&gt; StatisticsCampaignsGet (int? limit = null, int? offset = null)

Load Campaigns Stats

Returns a list of your Campaigns' stats. Required Access Level: ViewChannels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class StatisticsCampaignsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new StatisticsApi(config);
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Load Campaigns Stats
                List<ChannelLogStatusSummary> result = apiInstance.StatisticsCampaignsGet(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsCampaignsGet: " + e.Message );
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

[**List&lt;ChannelLogStatusSummary&gt;**](ChannelLogStatusSummary.md)

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

<a name="statisticschannelsbynameget"></a>
# **StatisticsChannelsByNameGet**
> ChannelLogStatusSummary StatisticsChannelsByNameGet (string name)

Load Channel Stats

Retrieve an existing channel stats. Required Access Level: ViewChannels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class StatisticsChannelsByNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new StatisticsApi(config);
            var name = name_example;  // string | The name of the channel to get.

            try
            {
                // Load Channel Stats
                ChannelLogStatusSummary result = apiInstance.StatisticsChannelsByNameGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsChannelsByNameGet: " + e.Message );
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
 **name** | **string**| The name of the channel to get. | 

### Return type

[**ChannelLogStatusSummary**](ChannelLogStatusSummary.md)

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

<a name="statisticschannelsget"></a>
# **StatisticsChannelsGet**
> List&lt;ChannelLogStatusSummary&gt; StatisticsChannelsGet (int? limit = null, int? offset = null)

Load Channels Stats

Returns a list of your Channels' stats. Required Access Level: ViewChannels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class StatisticsChannelsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new StatisticsApi(config);
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Load Channels Stats
                List<ChannelLogStatusSummary> result = apiInstance.StatisticsChannelsGet(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsChannelsGet: " + e.Message );
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

[**List&lt;ChannelLogStatusSummary&gt;**](ChannelLogStatusSummary.md)

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

<a name="statisticsget"></a>
# **StatisticsGet**
> LogStatusSummary StatisticsGet (DateTime from, DateTime? to = null)

Load Statistics

Returns basic statistics. Required Access Level: ViewReports

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class StatisticsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new StatisticsApi(config);
            var from = 2013-10-20T19:20:30+01:00;  // DateTime | Starting date for search in YYYY-MM-DDThh:mm:ss format.
            var to = 2013-10-20T19:20:30+01:00;  // DateTime? | Ending date for search in YYYY-MM-DDThh:mm:ss format. (optional) 

            try
            {
                // Load Statistics
                LogStatusSummary result = apiInstance.StatisticsGet(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsGet: " + e.Message );
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
 **from** | **DateTime**| Starting date for search in YYYY-MM-DDThh:mm:ss format. | 
 **to** | **DateTime?**| Ending date for search in YYYY-MM-DDThh:mm:ss format. | [optional] 

### Return type

[**LogStatusSummary**](LogStatusSummary.md)

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

