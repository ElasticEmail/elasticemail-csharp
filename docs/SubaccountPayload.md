# ElasticEmail.Model.SubaccountPayload
New SubAccount payload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Proper email address. | 
**Password** | **string** | Current password. | 
**SendActivation** | **bool** | True, if you want to send activation email to this Account to confirm the creation of a new SubAccount. Otherwise, false (SubAccount will immediately be Active). | [optional] 
**Settings** | [**SubaccountSettingsInfoPayload**](SubaccountSettingsInfoPayload.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

