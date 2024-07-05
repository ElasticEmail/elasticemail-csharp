# ElasticEmail.Model.EmailContent
Proper e-mail content

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Body** | [**List&lt;BodyPart&gt;**](BodyPart.md) | List of e-mail body parts, with user-provided MIME types (text/html, text/plain etc) | [optional] 
**Merge** | **Dictionary&lt;string, string&gt;** | A key-value collection of custom merge fields, shared between recipients. Should be used in e-mail body like so: {firstname}, {lastname} etc. | [optional] 
**Attachments** | [**List&lt;MessageAttachment&gt;**](MessageAttachment.md) | Attachments provided by sending binary data | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | A key-value collection of custom e-mail headers. | [optional] 
**Postback** | **string** | Postback header. | [optional] 
**EnvelopeFrom** | **string** | E-mail with an optional name to be used as the envelope from address (e.g.: John Doe &lt;email@domain.com&gt;) | [optional] 
**From** | **string** | Your e-mail with an optional name (e.g.: John Doe &lt;email@domain.com&gt;) | 
**ReplyTo** | **string** | To what address should the recipients reply to (e.g. John Doe &lt;email@domain.com&gt;) | [optional] 
**Subject** | **string** | Default subject of email. | [optional] 
**TemplateName** | **string** | Name of template. | [optional] 
**AttachFiles** | **List&lt;string&gt;** | Names of previously uploaded files that should be sent as downloadable attachments | [optional] 
**Utm** | [**Utm**](Utm.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

