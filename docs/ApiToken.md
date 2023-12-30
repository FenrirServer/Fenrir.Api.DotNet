# Fenrir.Api.Model.ApiToken

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationUuid** | **string** | A uuid of the application this token is limited to. | [optional] 
**Created** | **DateTime** | Time when the token was created. | [optional] [readonly] 
**IsPublic** | **bool** | A boolean value indicating if this token is a private or a public token. | [optional] 
**Label** | **string** | A label for the token. | [optional] 
**TokenPlaintext** | **Object** | A plain text value of the token. Only returned when the token is created. | [optional] [readonly] 
**Updated** | **DateTime** | Time when the token was last updated. | [optional] [readonly] 
**Uuid** | **string** | A unique id of the api token. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

