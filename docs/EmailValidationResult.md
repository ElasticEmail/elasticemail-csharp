# ElasticEmail.Model.EmailValidationResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Local part of an email | [optional] 
**Domain** | **string** | Name of selected domain. | [optional] 
**Email** | **string** | Full email address that was verified | [optional] 
**SuggestedSpelling** | **string** | Suggested spelling if a possible mistake was found | [optional] 
**Disposable** | **bool** | Does the email have a temporary domain | [optional] 
**Role** | **bool** | Is an email a role email (e.g. info@, noreply@ etc.) | [optional] 
**Reason** | **string** | All detected issues | [optional] 
**DateAdded** | **DateTime** | Added date | [optional] 
**Result** | **EmailValidationStatus** |  | [optional] 
**PredictedScore** | **decimal** | Predicted score | [optional] 
**PredictedStatus** | **EmailPredictedValidationStatus** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

