# ElasticEmail.Model.EmailsPayload
Provide either rule or a list of emails, not both.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rule** | **string** | SQL-like rule. Sending &#39;All&#39; as a value loads all resources of the given type. Help for building a segment rule can be found here: https://help.elasticemail.com/en/articles/5162182-segment-rules | [optional] 
**Emails** | **List&lt;string&gt;** | Comma delimited list of contact emails | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

