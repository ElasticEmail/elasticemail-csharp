# ElasticEmail.Model.NewApiKey
Newly generated ApiKey with Token
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** | Unique token to be used in the system | [optional] 
**AccessLevel** | [**List&lt;AccessLevel&gt;**](AccessLevel.md) | Access level or permission to be assigned to this ApiKey. | [optional] 
**Name** | **string** | Name of the ApiKey. | [optional] 
**DateCreated** | **DateTime** | Date this ApiKey was created. | [optional] 
**LastUse** | **DateTime?** | Date this ApiKey was last used. | [optional] 
**Expires** | **DateTime?** | Date this ApiKey expires. | [optional] 
**RestrictAccessToIPRange** | **List&lt;string&gt;** | Which IPs can use this ApiKey | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

