# ElasticEmail.Model.SmtpCredentialsPayload
Create new SMTP Credentials

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the Credential for ease of reference. It must be a valid email address. | 
**Expires** | **DateTime?** | Date this SmtpCredential expires. | [optional] 
**RestrictAccessToIPRange** | **List&lt;string&gt;** | Which IPs can use this SmtpCredential | [optional] 
**Subaccount** | **string** | Email of the subaccount for which this SmtpCredential should be created | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

