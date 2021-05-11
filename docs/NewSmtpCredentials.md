# ElasticEmail.Model.NewSmtpCredentials
Newly generated SMTP Credentials with Token
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** | Unique token to be used in the system | [optional] 
**AccessLevel** | **AccessLevel** | Access level of this Smtp Credential. | [optional] 
**Name** | **string** | Name of the key. | [optional] 
**DateCreated** | **DateTime** | Date this SmtpCredential was created. | [optional] 
**LastUse** | **DateTime?** | Date this SmtpCredential was last used. | [optional] 
**Expires** | **DateTime?** | Date this SmtpCredential expires. | [optional] 
**RestrictAccessToIPRange** | **List&lt;string&gt;** | Which IPs can use this SmtpCredential | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

