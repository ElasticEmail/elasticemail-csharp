# ElasticEmail.Model.SubaccountEmailSettingsPayload
Settings related to sending emails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequiresEmailCredits** | **bool** | True, if Account needs credits to send emails. Otherwise, false | [optional] 
**EmailSizeLimit** | **int** | Maximum size of email including attachments in MB&#39;s | [optional] 
**DailySendLimit** | **int** | Amount of emails Account can send daily | [optional] 
**MaxContacts** | **int** | Maximum number of contacts the Account can have. 0 means that parent account&#39;s limit is used. | [optional] 
**EnablePrivateIPPurchase** | **bool** | Can the SubAccount purchase Private IP for themselves | [optional] 
**PoolName** | **string** | Name of your custom IP Pool to be used in the sending process | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

