# ElasticEmail.Model.SubAccountInfo
Detailed information about SubAccount.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PublicAccountID** | **string** | Public key for limited access to your Account such as contact/add so you can use it safely on public websites. | [optional] 
**Email** | **string** | Proper email address. | [optional] 
**Settings** | [**SubaccountSettingsInfo**](SubaccountSettingsInfo.md) | SubAccount settings | [optional] 
**LastActivity** | **DateTime** | Date of last activity on Account | [optional] 
**EmailCredits** | **int** | Amount of email credits | [optional] 
**TotalEmailsSent** | **long** | Amount of emails sent from this Account | [optional] 
**Reputation** | **double** | Numeric reputation | [optional] 
**Status** | **AccountStatusEnum** | Account&#39;s current status. | [optional] 
**ContactsCount** | **int** | How many contacts this SubAccount has stored | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

