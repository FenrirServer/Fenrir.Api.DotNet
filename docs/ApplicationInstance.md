# Fenrir.Api.Model.ApplicationInstance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationUuid** | **string** | A uuid of the application. | [optional] 
**ContainerId** | **string** | A unique id of the container | [optional] 
**Created** | **DateTime** | Time when the instance was created. | [optional] [readonly] 
**DeploymentUuid** | **string** | A uuid of the deployment | [optional] 
**DesiredState** | **string** | Desired state of the instance. Corresponds with docker container states. | [optional] 
**Hostname** | **string** | A hostname of the node the instance is running on. | [optional] 
**Ports** | [**List&lt;ApplicationInstancePort&gt;**](ApplicationInstancePort.md) | A list of ports exposed on the instance.  | [optional] 
**State** | **string** | State of the running instance. Corresponds with docker container states. | [optional] 
**Updated** | **DateTime** | Time when the instance was last updated. | [optional] [readonly] 
**Uuid** | **string** | A unique id of the instance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

