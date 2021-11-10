# ElasticEmail.Model.RecipientEvent
Detailed information about message recipient

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionID** | **string** | ID number of transaction | [optional] 
**MsgID** | **string** | ID number of selected message. | [optional] 
**FromEmail** | **string** | Default From: email address. | [optional] 
**To** | **string** | Ending date for search in YYYY-MM-DDThh:mm:ss format. | [optional] 
**Subject** | **string** | Default subject of email. | [optional] 
**EventType** | **EventType** |  | [optional] 
**EventDate** | **DateTime** | Creation date | [optional] 
**ChannelName** | **string** | Name of selected channel. | [optional] 
**MessageCategory** | **MessageCategory** |  | [optional] 
**NextTryOn** | **DateTime?** | Date of next try | [optional] 
**Message** | **string** | Content of message, HTML encoded | [optional] 
**IPAddress** | **string** | IP which this email was sent through | [optional] 
**PoolName** | **string** | Name of an IP pool this email was sent through | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

