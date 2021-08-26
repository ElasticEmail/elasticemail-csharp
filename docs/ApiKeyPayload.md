# ElasticEmail.Model.ApiKeyPayload
Create a new ApiKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the ApiKey for ease of reference. | 
**AccessLevel** | [**List&lt;AccessLevel&gt;**](AccessLevel.md) | Access level or permission to be assigned to this ApiKey. | 
**Expires** | **DateTime?** | Date this ApiKey expires. | [optional] 
**RestrictAccessToIPRange** | **List&lt;string&gt;** | Which IPs can use this ApiKey | [optional] 
**Subaccount** | **string** | Email of the subaccount for which this ApiKey should be created | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

