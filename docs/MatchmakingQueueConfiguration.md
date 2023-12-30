# Fenrir.Api.Model.MatchmakingQueueConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfirmationRequired** | **bool** | A boolean value indicating if match confirmation is required. If set to true, players will receive confirmation event before the match is formed. All matched players must confirm their participation within a time specified with \&quot;confirmation_time_seconds\&quot;, otherwise match is aborted. | [optional] 
**ConfirmationTimeSeconds** | **decimal** | A number of seconds given to players to confirm their match participation. | [optional] 
**Created** | **DateTime** | Time when the configuration was created. | [optional] [readonly] 
**DeploymentUuid** | **string** | A uuid of the deployment this matchmaking queue will point at. When a match is formed, a server is selected from the specified deployment. | 
**PlayerProperties** | [**List&lt;MatchmakingQueueConfigurationPlayerProperty&gt;**](MatchmakingQueueConfigurationPlayerProperty.md) | An array of player properties. | [optional] 
**PlayerRules** | [**List&lt;MatchmakingQueueConfigurationPlayerRule&gt;**](MatchmakingQueueConfigurationPlayerRule.md) | An array of player rules. | [optional] 
**TeamRules** | [**List&lt;MatchmakingQueueConfigurationTeamRule&gt;**](MatchmakingQueueConfigurationTeamRule.md) | An array of team rules. | [optional] 
**Teams** | [**List&lt;MatchmakingQueueConfigurationTeam&gt;**](MatchmakingQueueConfigurationTeam.md) | An array of teams. | [optional] 
**Uuid** | **string** | A unique id of the matchmaking queue configuration. | [optional] [readonly] 
**VarVersion** | **string** | A configuration schema version. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

