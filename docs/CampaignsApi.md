# ElasticEmail.Api.CampaignsApi

All URIs are relative to *https://api.elasticemail.com/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CampaignsByNameDelete**](CampaignsApi.md#campaignsbynamedelete) | **DELETE** /campaigns/{name} | Delete Campaign
[**CampaignsByNameGet**](CampaignsApi.md#campaignsbynameget) | **GET** /campaigns/{name} | Load Campaign
[**CampaignsByNamePut**](CampaignsApi.md#campaignsbynameput) | **PUT** /campaigns/{name} | Update Campaign
[**CampaignsGet**](CampaignsApi.md#campaignsget) | **GET** /campaigns | Load Campaigns
[**CampaignsPost**](CampaignsApi.md#campaignspost) | **POST** /campaigns | Add Campaign


<a name="campaignsbynamedelete"></a>
# **CampaignsByNameDelete**
> void CampaignsByNameDelete (string name)

Delete Campaign

Delete the specific campaign.  This does not cancel in progress email, see Cancel In Progress. Required Access Level: ModifyCampaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class CampaignsByNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new CampaignsApi(config);
            var name = name_example;  // string | Name of Campaign to delete

            try
            {
                // Delete Campaign
                apiInstance.CampaignsByNameDelete(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CampaignsByNameDelete: " + e.Message );
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
 **name** | **string**| Name of Campaign to delete | 

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

<a name="campaignsbynameget"></a>
# **CampaignsByNameGet**
> Campaign CampaignsByNameGet (string name)

Load Campaign

Returns the specified campaign details. Required Access Level: ViewCampaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class CampaignsByNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new CampaignsApi(config);
            var name = name_example;  // string | Name of Campaign to get

            try
            {
                // Load Campaign
                Campaign result = apiInstance.CampaignsByNameGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CampaignsByNameGet: " + e.Message );
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
 **name** | **string**| Name of Campaign to get | 

### Return type

[**Campaign**](Campaign.md)

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

<a name="campaignsbynameput"></a>
# **CampaignsByNamePut**
> Campaign CampaignsByNamePut (string name, Campaign campaign)

Update Campaign

Updates a previously added campaign.  Only Active and Paused campaigns can be updated. Required Access Level: ModifyCampaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class CampaignsByNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new CampaignsApi(config);
            var name = name_example;  // string | Name of Campaign to update
            var campaign = new Campaign(); // Campaign | JSON representation of a campaign

            try
            {
                // Update Campaign
                Campaign result = apiInstance.CampaignsByNamePut(name, campaign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CampaignsByNamePut: " + e.Message );
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
 **name** | **string**| Name of Campaign to update | 
 **campaign** | [**Campaign**](Campaign.md)| JSON representation of a campaign | 

### Return type

[**Campaign**](Campaign.md)

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

<a name="campaignsget"></a>
# **CampaignsGet**
> List&lt;Campaign&gt; CampaignsGet (string search = null, int? offset = null, int? limit = null)

Load Campaigns

Returns a list all of your campaigns. Limited to 1000 results. Required Access Level: ViewCampaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class CampaignsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new CampaignsApi(config);
            var search = search_example;  // string | Text fragment used for searching in Campaign name (using the 'contains' rule) (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 
            var limit = 100;  // int? | Maximum number of returned items. (optional) 

            try
            {
                // Load Campaigns
                List<Campaign> result = apiInstance.CampaignsGet(search, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CampaignsGet: " + e.Message );
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
 **search** | **string**| Text fragment used for searching in Campaign name (using the &#39;contains&#39; rule) | [optional] 
 **offset** | **int?**| How many items should be returned ahead. | [optional] 
 **limit** | **int?**| Maximum number of returned items. | [optional] 

### Return type

[**List&lt;Campaign&gt;**](Campaign.md)

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

<a name="campaignspost"></a>
# **CampaignsPost**
> Campaign CampaignsPost (Campaign campaign)

Add Campaign

Add a campaign for processing. Required Access Level: ModifyCampaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class CampaignsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new CampaignsApi(config);
            var campaign = new Campaign(); // Campaign | JSON representation of a campaign

            try
            {
                // Add Campaign
                Campaign result = apiInstance.CampaignsPost(campaign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CampaignsPost: " + e.Message );
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
 **campaign** | [**Campaign**](Campaign.md)| JSON representation of a campaign | 

### Return type

[**Campaign**](Campaign.md)

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

