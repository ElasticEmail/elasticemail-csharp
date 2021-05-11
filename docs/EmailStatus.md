# ElasticEmail.Model.EmailStatus
Status information of the specified email
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | Email address this email was sent from. | [optional] 
**To** | **string** | Email address this email was sent to. | [optional] 
**Date** | **DateTime** | Date the email was submitted. | [optional] 
**Status** | **LogJobStatus** | Value of email&#39;s status | [optional] 
**StatusName** | **string** | Name of email&#39;s status | [optional] 
**StatusChangeDate** | **DateTime** | Date of last status change. | [optional] 
**DateSent** | **DateTime** | Date when the email was sent | [optional] 
**DateOpened** | **DateTime?** | Date when the email changed the status to &#39;opened&#39; | [optional] 
**DateClicked** | **DateTime?** | Date when the email changed the status to &#39;clicked&#39; | [optional] 
**ErrorMessage** | **string** | Detailed error or bounced message. | [optional] 
**TransactionID** | **string** | ID number of transaction | [optional] 
**EnvelopeFrom** | **string** | Envelope from address | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

