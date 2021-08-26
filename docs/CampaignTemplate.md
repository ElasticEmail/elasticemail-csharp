# ElasticEmail.Model.CampaignTemplate
Content of a Campaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Poolname** | **string** | Name of your custom IP Pool to be used in the sending process | [optional] 
**From** | **string** | Your e-mail with an optional name (e.g.: John Doe &lt;email@domain.com&gt;) | [optional] 
**ReplyTo** | **string** | To what address should the recipients reply to (e.g. John Doe &lt;email@domain.com&gt;) | [optional] 
**Subject** | **string** | Default subject of email. | [optional] 
**TemplateName** | **string** | Name of template. | [optional] 
**AttachFiles** | **List&lt;string&gt;** | Names of previously uploaded files that should be sent as downloadable attachments | [optional] 
**Utm** | [**Utm**](Utm.md) | Utm marketing data to be attached to every link in this e-mail. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

