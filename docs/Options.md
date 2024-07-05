# ElasticEmail.Model.Options
E-mail configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeOffset** | **int?** | By how long should an e-mail be delayed (in minutes). Maximum is 35 days. | [optional] 
**PoolName** | **string** | Name of your custom IP Pool to be used in the sending process | [optional] 
**ChannelName** | **string** | Name of selected channel. | [optional] 
**Encoding** | **EncodingType** |  | [optional] 
**TrackOpens** | **bool?** | Should the opens be tracked? If no value has been provided, Account&#39;s default setting will be used. | [optional] 
**TrackClicks** | **bool?** | Should the clicks be tracked? If no value has been provided, Account&#39;s default setting will be used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

