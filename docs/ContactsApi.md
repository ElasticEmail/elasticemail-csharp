# ElasticEmail.Api.ContactsApi

All URIs are relative to *https://api.elasticemail.com/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContactsByEmailDelete**](ContactsApi.md#contactsbyemaildelete) | **DELETE** /contacts/{email} | Delete Contact |
| [**ContactsByEmailGet**](ContactsApi.md#contactsbyemailget) | **GET** /contacts/{email} | Load Contact |
| [**ContactsByEmailPut**](ContactsApi.md#contactsbyemailput) | **PUT** /contacts/{email} | Update Contact |
| [**ContactsDeletePost**](ContactsApi.md#contactsdeletepost) | **POST** /contacts/delete | Delete Contacts Bulk |
| [**ContactsExportByIdStatusGet**](ContactsApi.md#contactsexportbyidstatusget) | **GET** /contacts/export/{id}/status | Check Export Status |
| [**ContactsExportPost**](ContactsApi.md#contactsexportpost) | **POST** /contacts/export | Export Contacts |
| [**ContactsGet**](ContactsApi.md#contactsget) | **GET** /contacts | Load Contacts |
| [**ContactsImportPost**](ContactsApi.md#contactsimportpost) | **POST** /contacts/import | Upload Contacts |
| [**ContactsPost**](ContactsApi.md#contactspost) | **POST** /contacts | Add Contact |

<a id="contactsbyemaildelete"></a>
# **ContactsByEmailDelete**
> void ContactsByEmailDelete (string email)

Delete Contact

Deletes the provided contact. Required Access Level: ModifyContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ContactsByEmailDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ContactsApi(config);
            var email = mail@example.com;  // string | Proper email address.

            try
            {
                // Delete Contact
                apiInstance.ContactsByEmailDelete(email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsByEmailDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactsByEmailDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Contact
    apiInstance.ContactsByEmailDeleteWithHttpInfo(email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.ContactsByEmailDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Proper email address. |  |

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

<a id="contactsbyemailget"></a>
# **ContactsByEmailGet**
> Contact ContactsByEmailGet (string email)

Load Contact

Load detailed contact information for specified email. Required Access Level: ViewContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ContactsByEmailGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ContactsApi(config);
            var email = mail@example.com;  // string | Proper email address.

            try
            {
                // Load Contact
                Contact result = apiInstance.ContactsByEmailGet(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsByEmailGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactsByEmailGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Contact
    ApiResponse<Contact> response = apiInstance.ContactsByEmailGetWithHttpInfo(email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.ContactsByEmailGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Proper email address. |  |

### Return type

[**Contact**](Contact.md)

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

<a id="contactsbyemailput"></a>
# **ContactsByEmailPut**
> Contact ContactsByEmailPut (string email, ContactUpdatePayload contactUpdatePayload)

Update Contact

Update selected contact. Omitted contact's fields will not be changed. Required Access Level: ModifyContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ContactsByEmailPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ContactsApi(config);
            var email = mail@example.com;  // string | Proper email address.
            var contactUpdatePayload = new ContactUpdatePayload(); // ContactUpdatePayload | 

            try
            {
                // Update Contact
                Contact result = apiInstance.ContactsByEmailPut(email, contactUpdatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsByEmailPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactsByEmailPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Contact
    ApiResponse<Contact> response = apiInstance.ContactsByEmailPutWithHttpInfo(email, contactUpdatePayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.ContactsByEmailPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Proper email address. |  |
| **contactUpdatePayload** | [**ContactUpdatePayload**](ContactUpdatePayload.md) |  |  |

### Return type

[**Contact**](Contact.md)

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

<a id="contactsdeletepost"></a>
# **ContactsDeletePost**
> void ContactsDeletePost (EmailsPayload emailsPayload)

Delete Contacts Bulk

Deletes provided contacts in bulk. Required Access Level: ModifyContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ContactsDeletePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ContactsApi(config);
            var emailsPayload = new EmailsPayload(); // EmailsPayload | Provide either rule or a list of emails, not both.

            try
            {
                // Delete Contacts Bulk
                apiInstance.ContactsDeletePost(emailsPayload);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeletePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactsDeletePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Contacts Bulk
    apiInstance.ContactsDeletePostWithHttpInfo(emailsPayload);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.ContactsDeletePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailsPayload** | [**EmailsPayload**](EmailsPayload.md) | Provide either rule or a list of emails, not both. |  |

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

<a id="contactsexportbyidstatusget"></a>
# **ContactsExportByIdStatusGet**
> ExportStatus ContactsExportByIdStatusGet (string id)

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
    public class ContactsExportByIdStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ContactsApi(config);
            var id = E33EBA7A-C20D-4D3D-8F2F-5EEF42F58E6F;  // string | ID of the exported file

            try
            {
                // Check Export Status
                ExportStatus result = apiInstance.ContactsExportByIdStatusGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsExportByIdStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactsExportByIdStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Export Status
    ApiResponse<ExportStatus> response = apiInstance.ContactsExportByIdStatusGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.ContactsExportByIdStatusGetWithHttpInfo: " + e.Message);
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

<a id="contactsexportpost"></a>
# **ContactsExportPost**
> ExportLink ContactsExportPost (ExportFileFormats? fileFormat = null, string rule = null, List<string> emails = null, CompressionFormat? compressionFormat = null, string fileName = null)

Export Contacts

Request an Export of specified Contacts. Required Access Level: Export

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ContactsExportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ContactsApi(config);
            var fileFormat = (ExportFileFormats) "Csv";  // ExportFileFormats? | Format of the exported file (optional) 
            var rule = Status%20=%20Engaged;  // string | Query used for filtering. (optional) 
            var emails = new List<string>(); // List<string> | Comma delimited list of contact emails (optional) 
            var compressionFormat = (CompressionFormat) "None";  // CompressionFormat? | FileResponse compression format. None or Zip. (optional) 
            var fileName = filename.txt;  // string | Name of your file including extension. (optional) 

            try
            {
                // Export Contacts
                ExportLink result = apiInstance.ContactsExportPost(fileFormat, rule, emails, compressionFormat, fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsExportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactsExportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export Contacts
    ApiResponse<ExportLink> response = apiInstance.ContactsExportPostWithHttpInfo(fileFormat, rule, emails, compressionFormat, fileName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.ContactsExportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileFormat** | **ExportFileFormats?** | Format of the exported file | [optional]  |
| **rule** | **string** | Query used for filtering. | [optional]  |
| **emails** | [**List&lt;string&gt;**](string.md) | Comma delimited list of contact emails | [optional]  |
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

<a id="contactsget"></a>
# **ContactsGet**
> List&lt;Contact&gt; ContactsGet (int? limit = null, int? offset = null)

Load Contacts

Returns a list of contacts. Required Access Level: ViewContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ContactsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ContactsApi(config);
            var limit = 100;  // int? | Maximum number of returned items. (optional) 
            var offset = 20;  // int? | How many items should be returned ahead. (optional) 

            try
            {
                // Load Contacts
                List<Contact> result = apiInstance.ContactsGet(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Contacts
    ApiResponse<List<Contact>> response = apiInstance.ContactsGetWithHttpInfo(limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.ContactsGetWithHttpInfo: " + e.Message);
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

[**List&lt;Contact&gt;**](Contact.md)

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

<a id="contactsimportpost"></a>
# **ContactsImportPost**
> void ContactsImportPost (string listName = null, string encodingName = null, string fileUrl = null, System.IO.Stream file = null)

Upload Contacts

Upload contacts from a file. Required Access Level: ModifyContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ContactsImportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ContactsApi(config);
            var listName = "listName_example";  // string | Name of an existing list to add these contacts to (optional) 
            var encodingName = "encodingName_example";  // string | In what encoding the file is uploaded (optional) 
            var fileUrl = "fileUrl_example";  // string | Optional url of csv to import (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Upload Contacts
                apiInstance.ContactsImportPost(listName, encodingName, fileUrl, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsImportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactsImportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload Contacts
    apiInstance.ContactsImportPostWithHttpInfo(listName, encodingName, fileUrl, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.ContactsImportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listName** | **string** | Name of an existing list to add these contacts to | [optional]  |
| **encodingName** | **string** | In what encoding the file is uploaded | [optional]  |
| **fileUrl** | **string** | Optional url of csv to import | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contactspost"></a>
# **ContactsPost**
> List&lt;Contact&gt; ContactsPost (List<ContactPayload> contactPayload, List<string> listnames = null)

Add Contact

Add new Contacts to your Lists. Up to 1000 can be added (for more please refer to the import request). Required Access Level: ModifyContacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace Example
{
    public class ContactsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.elasticemail.com/v4";
            // Configure API key authorization: apikey
            config.AddApiKey("X-ElasticEmail-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-ElasticEmail-ApiKey", "Bearer");

            var apiInstance = new ContactsApi(config);
            var contactPayload = new List<ContactPayload>(); // List<ContactPayload> | 
            var listnames = new List<string>(); // List<string> | Names of lists to which the uploaded contacts should be added to (optional) 

            try
            {
                // Add Contact
                List<Contact> result = apiInstance.ContactsPost(contactPayload, listnames);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Contact
    ApiResponse<List<Contact>> response = apiInstance.ContactsPostWithHttpInfo(contactPayload, listnames);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.ContactsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactPayload** | [**List&lt;ContactPayload&gt;**](ContactPayload.md) |  |  |
| **listnames** | [**List&lt;string&gt;**](string.md) | Names of lists to which the uploaded contacts should be added to | [optional]  |

### Return type

[**List&lt;Contact&gt;**](Contact.md)

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

