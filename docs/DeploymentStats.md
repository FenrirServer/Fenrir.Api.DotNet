# Fenrir.Api.Model.DeploymentStats

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CcuTotal** | **int** | A number of players currently connected. | [optional] 
**CpuAvg** | **decimal** | The average CPU utilization of the application across all instances in this deployment. | [optional] 
**InstanceStats** | [**Dictionary&lt;string, ApplicationInstanceStats&gt;**](ApplicationInstanceStats.md) | A dictionary of instance stats, per instance. | [optional] 
**MemAvg** | **decimal** | The average memory utilization of the application across all instances in this deployment, in megabytes. | [optional] 
**NumInstances** | **int** | The total number of instances in this deployment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

