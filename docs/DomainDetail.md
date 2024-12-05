# ElasticEmail.Model.DomainDetail
Domain data, with information about domain records.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | Name of selected domain. | [optional] 
**DefaultDomain** | **bool** | True, if domain is used as default. Otherwise, false, | [optional] 
**Spf** | **bool** | True, if SPF record is verified | [optional] 
**Dkim** | **bool** | True, if DKIM record is verified | [optional] 
**MX** | **bool** | True, if MX record is verified | [optional] 
**DMARC** | **bool** |  | [optional] 
**IsRewriteDomainValid** | **bool** | True, if tracking CNAME record is verified | [optional] 
**Verify** | **bool** | True, if DKIM, SPF, or tracking are still to be verified | [optional] 
**Type** | **TrackingType** |  | [optional] 
**TrackingStatus** | **TrackingValidationStatus** |  | [optional] 
**CertificateStatus** | **CertificateValidationStatus** |  | [optional] 
**CertificateValidationError** | **string** |  | [optional] 
**TrackingTypeUserRequest** | **TrackingType** |  | [optional] 
**VERP** | **bool** |  | [optional] 
**CustomBouncesDomain** | **string** |  | [optional] 
**IsCustomBouncesDomainDefault** | **bool** |  | [optional] 
**IsMarkedForDeletion** | **bool** |  | [optional] 
**Ownership** | **DomainOwner** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

