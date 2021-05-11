# ElasticEmail.Model.ContactActivity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalSent** | **int** | Total emails sent. | [optional] 
**TotalOpened** | **int** | Total emails opened. | [optional] 
**TotalClicked** | **int** | Total emails clicked | [optional] 
**TotalFailed** | **int** | Total emails failed. | [optional] 
**LastSent** | **DateTime?** | Last date when an email was sent to this contact | [optional] 
**LastOpened** | **DateTime?** | Date this contact last opened an email | [optional] 
**LastClicked** | **DateTime?** | Date this contact last clicked an email | [optional] 
**LastFailed** | **DateTime?** | Last date when an email sent to this contact bounced | [optional] 
**LastIP** | **string** | IP from which this contact opened or clicked their email last time | [optional] 
**ErrorCode** | **int?** | Last RFC Error code if any occurred | [optional] 
**FriendlyErrorMessage** | **string** | Last RFC error message if any occurred | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

