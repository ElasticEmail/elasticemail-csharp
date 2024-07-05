# ElasticEmail.Model.CampaignOptions
Different send options for a Campaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeliveryOptimization** | **DeliveryOptimizationType** |  | [optional] 
**TrackOpens** | **bool?** | Should the opens be tracked? If no value has been provided, Account&#39;s default setting will be used. | [optional] 
**TrackClicks** | **bool?** | Should the clicks be tracked? If no value has been provided, Account&#39;s default setting will be used. | [optional] 
**ScheduleFor** | **DateTime?** | Date when this Campaign is scheduled to be sent on | [optional] 
**TriggerFrequency** | **double** | How often (in minutes) to send the campaign | [optional] 
**TriggerCount** | **int** | How many times send the campaign | [optional] 
**SplitOptions** | [**SplitOptions**](SplitOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

