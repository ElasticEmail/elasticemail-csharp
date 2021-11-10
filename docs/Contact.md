# ElasticEmail.Model.Contact
Contact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Proper email address. | [optional] 
**Status** | **ContactStatus** |  | [optional] 
**FirstName** | **string** | First name. | [optional] 
**LastName** | **string** | Last name. | [optional] 
**CustomFields** | **Dictionary&lt;string, string&gt;** | A key-value collection of custom contact fields which can be used in the system. | [optional] 
**Consent** | [**ConsentData**](ConsentData.md) |  | [optional] 
**Source** | **ContactSource** |  | [optional] 
**DateAdded** | **DateTime** | Date of creation in YYYY-MM-DDThh:ii:ss format | [optional] 
**DateUpdated** | **DateTime?** | Last change date | [optional] 
**StatusChangeDate** | **DateTime?** | Date of last status change. | [optional] 
**Activity** | [**ContactActivity**](ContactActivity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

