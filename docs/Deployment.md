# Fenrir.Api.Model.Deployment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationUuid** | **string** | A uuid of the application this deployment is for. | [optional] [readonly] 
**ConfigurationUuid** | **string** | A uuid of the current application configuration. | [optional] [readonly] 
**Created** | **DateTime** | Time when the deployment was created. | [optional] [readonly] 
**ImageTag** | **string** | An image tag for your application. Possible image tags can be obtained by calling \&quot;GET /application/&lt;application_uuid&gt;/images\&quot; endpoint | 
**Label** | **string** | A label for your deployment | 
**Updated** | **DateTime** | Time when the deployment was last updated. | [optional] [readonly] 
**Uuid** | **string** | A unique id of the deployment. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

