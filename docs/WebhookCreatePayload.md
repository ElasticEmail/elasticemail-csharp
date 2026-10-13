# ElasticEmail.Model.WebhookCreatePayload
Create webhook payload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Filename | 
**URL** | **string** | URL of notification. | 
**NotifyOncePerEmail** | **bool** |  | [optional] 
**NotificationForSent** | **bool** |  | [optional] 
**NotificationForOpened** | **bool** |  | [optional] 
**NotificationForClicked** | **bool** |  | [optional] 
**NotificationForUnsubscribed** | **bool** |  | [optional] 
**NotificationForAbuseReport** | **bool** |  | [optional] 
**NotificationForError** | **bool** |  | [optional] 
**EnableSigning** | **bool?** | Sign every request with HMAC-SHA256. Can be set only when the webhook is created. Default: false. | [optional] 
**DeliveryMethod** | **WebhookDeliveryMethod** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

