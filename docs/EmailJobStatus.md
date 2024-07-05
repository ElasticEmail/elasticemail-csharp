# ElasticEmail.Model.EmailJobStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **string** | ID number of your attachment | [optional] 
**Status** | **string** | Name of status: submitted, complete, in_progress | [optional] 
**RecipientsCount** | **int** |  | [optional] 
**Failed** | [**List&lt;EmailJobFailedStatus&gt;**](EmailJobFailedStatus.md) |  | [optional] 
**FailedCount** | **int** | Total emails failed. | [optional] 
**Sent** | **List&lt;string&gt;** |  | [optional] 
**SentCount** | **int** | Total emails sent. | [optional] 
**Delivered** | **List&lt;string&gt;** | Number of delivered messages | [optional] 
**DeliveredCount** | **int** |  | [optional] 
**Pending** | **List&lt;string&gt;** |  | [optional] 
**PendingCount** | **int** |  | [optional] 
**Opened** | **List&lt;string&gt;** | Number of opened messages | [optional] 
**OpenedCount** | **int** | Total emails opened. | [optional] 
**Clicked** | **List&lt;string&gt;** | Number of clicked messages | [optional] 
**ClickedCount** | **int** | Total emails clicked | [optional] 
**Unsubscribed** | **List&lt;string&gt;** | Number of unsubscribed messages | [optional] 
**UnsubscribedCount** | **int** | Total emails unsubscribed | [optional] 
**AbuseReports** | **List&lt;string&gt;** |  | [optional] 
**AbuseReportsCount** | **int** |  | [optional] 
**MessageIDs** | **List&lt;string&gt;** | List of all MessageIDs for this job. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

