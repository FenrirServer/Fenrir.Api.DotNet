# Fenrir.Api.Model.ApplicationConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationUuid** | **string** | A uuid of the application this configuration is for. | [optional] [readonly] 
**Created** | **DateTime** | Time when the configuration was created. | [optional] [readonly] 
**MaxInstances** | **int** | Maximum number of instances. | 
**MinInstances** | **int** | Minimum number of instances. | 
**Ports** | [**List&lt;PortConfiguration&gt;**](PortConfiguration.md) | Ports used by the application. | [optional] 
**Updated** | **DateTime** | Time when the configuration was last updated. | [optional] [readonly] 
**Uuid** | **string** | A unique id of this application configuration. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

