/*
 * Fenrir Api
 * 
 * This file was automatically generated using openapi generator. 
 * DO NOT EDIT MANUALLY.
 * Refer to: https://github.com/FenrirServer/Cloud.SdkTemplates
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Fenrir.Api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFenrirApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiTokenResponse</returns>
        ApiTokenResponse CreateApiToken(ApiToken apiToken, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiTokenResponse</returns>
        ApiResponse<ApiTokenResponse> CreateApiTokenWithHttpInfo(ApiToken apiToken, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationResponse</returns>
        ApplicationResponse CreateApplication(Application application, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationResponse</returns>
        ApiResponse<ApplicationResponse> CreateApplicationWithHttpInfo(Application application, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates an application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="applicationConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationConfigurationResponse</returns>
        ApplicationConfigurationResponse CreateApplicationConfiguration(string applicationUuid, ApplicationConfiguration applicationConfiguration, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates an application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="applicationConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationConfigurationResponse</returns>
        ApiResponse<ApplicationConfigurationResponse> CreateApplicationConfigurationWithHttpInfo(string applicationUuid, ApplicationConfiguration applicationConfiguration, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Crates a new application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="deployment"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeploymentResponse</returns>
        DeploymentResponse CreateDeployment(string applicationUuid, Deployment deployment, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Crates a new application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="deployment"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeploymentResponse</returns>
        ApiResponse<DeploymentResponse> CreateDeploymentWithHttpInfo(string applicationUuid, Deployment deployment, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueResponse</returns>
        MatchmakingQueueResponse CreateMatchmakingQueue(string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueResponse</returns>
        ApiResponse<MatchmakingQueueResponse> CreateMatchmakingQueueWithHttpInfo(string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueueConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueConfigurationResponse</returns>
        MatchmakingQueueConfigurationResponse CreateMatchmakingQueueConfiguration(string queueUuid, string applicationUuid, MatchmakingQueueConfiguration matchmakingQueueConfiguration, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueueConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueConfigurationResponse</returns>
        ApiResponse<MatchmakingQueueConfigurationResponse> CreateMatchmakingQueueConfigurationWithHttpInfo(string queueUuid, string applicationUuid, MatchmakingQueueConfiguration matchmakingQueueConfiguration, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Response</returns>
        Response DeleteApiToken(string tokenUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> DeleteApiTokenWithHttpInfo(string tokenUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Response</returns>
        Response DeleteApplication(string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> DeleteApplicationWithHttpInfo(string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Response</returns>
        Response DeleteDeployment(string deploymentUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> DeleteDeploymentWithHttpInfo(string deploymentUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Response</returns>
        Response DeleteMatchmakingQueue(string queueUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> DeleteMatchmakingQueueWithHttpInfo(string queueUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiTokenListResponse</returns>
        ApiTokenListResponse GetApiToken(string tokenUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiTokenListResponse</returns>
        ApiResponse<ApiTokenListResponse> GetApiTokenWithHttpInfo(string tokenUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all API tokens on your account.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiTokenListResponse</returns>
        ApiTokenListResponse GetApiTokens(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all API tokens on your account.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiTokenListResponse</returns>
        ApiResponse<ApiTokenListResponse> GetApiTokensWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationResponse</returns>
        ApplicationResponse GetApplication(string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationResponse</returns>
        ApiResponse<ApplicationResponse> GetApplicationWithHttpInfo(string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationConfigurationResponse</returns>
        ApplicationConfigurationResponse GetApplicationConfiguration(string configurationUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationConfigurationResponse</returns>
        ApiResponse<ApplicationConfigurationResponse> GetApplicationConfigurationWithHttpInfo(string configurationUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application configurations ever created.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationConfigurationListResponse</returns>
        ApplicationConfigurationListResponse GetApplicationConfigurations(string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application configurations ever created.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationConfigurationListResponse</returns>
        ApiResponse<ApplicationConfigurationListResponse> GetApplicationConfigurationsWithHttpInfo(string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves application stats.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationStatsResponse</returns>
        ApplicationStatsResponse GetApplicationStats(string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves application stats.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationStatsResponse</returns>
        ApiResponse<ApplicationStatsResponse> GetApplicationStatsWithHttpInfo(string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all applications on your account.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationListResponse</returns>
        ApplicationListResponse GetApplications(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all applications on your account.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationListResponse</returns>
        ApiResponse<ApplicationListResponse> GetApplicationsWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves current application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationConfigurationResponse</returns>
        ApplicationConfigurationResponse GetCurrentApplicationConfiguration(string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves current application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationConfigurationResponse</returns>
        ApiResponse<ApplicationConfigurationResponse> GetCurrentApplicationConfigurationWithHttpInfo(string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves current matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueConfigurationResponse</returns>
        MatchmakingQueueConfigurationResponse GetCurrentMatchmakingQueueConfiguration(string queueUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves current matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueConfigurationResponse</returns>
        ApiResponse<MatchmakingQueueConfigurationResponse> GetCurrentMatchmakingQueueConfigurationWithHttpInfo(string queueUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeploymentResponse</returns>
        DeploymentResponse GetDeployment(string deploymentUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeploymentResponse</returns>
        ApiResponse<DeploymentResponse> GetDeploymentWithHttpInfo(string deploymentUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves deployment stats.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeploymentStatsResponse</returns>
        DeploymentStatsResponse GetDeploymentStats(string deploymentUuid, string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves deployment stats.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeploymentStatsResponse</returns>
        ApiResponse<DeploymentStatsResponse> GetDeploymentStatsWithHttpInfo(string deploymentUuid, string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application deployments.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeploymentListResponse</returns>
        DeploymentListResponse GetDeployments(string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application deployments.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeploymentListResponse</returns>
        ApiResponse<DeploymentListResponse> GetDeploymentsWithHttpInfo(string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application images.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ImageListResponse</returns>
        ImageListResponse GetImages(string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application images.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ImageListResponse</returns>
        ApiResponse<ImageListResponse> GetImagesWithHttpInfo(string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application instance.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstanceResponse</returns>
        ApplicationInstanceResponse GetInstance(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application instance.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstanceResponse</returns>
        ApiResponse<ApplicationInstanceResponse> GetInstanceWithHttpInfo(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves application instance logs.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InstanceLogs</returns>
        InstanceLogs GetInstanceLogs(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves application instance logs.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InstanceLogs</returns>
        ApiResponse<InstanceLogs> GetInstanceLogsWithHttpInfo(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a small number of most recent application instance logs.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InstanceLogsPreview</returns>
        InstanceLogsPreview GetInstanceLogsPreview(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a small number of most recent application instance logs.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InstanceLogsPreview</returns>
        ApiResponse<InstanceLogsPreview> GetInstanceLogsPreviewWithHttpInfo(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application instances for a given deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstanceListResponse</returns>
        ApplicationInstanceListResponse GetInstances(string deploymentUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application instances for a given deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstanceListResponse</returns>
        ApiResponse<ApplicationInstanceListResponse> GetInstancesWithHttpInfo(string deploymentUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueResponse</returns>
        MatchmakingQueueResponse GetMatchmakingQueue(string queueUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueResponse</returns>
        ApiResponse<MatchmakingQueueResponse> GetMatchmakingQueueWithHttpInfo(string queueUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueConfigurationResponse</returns>
        MatchmakingQueueConfigurationResponse GetMatchmakingQueueConfiguration(string configurationUuid, string queueUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueConfigurationResponse</returns>
        ApiResponse<MatchmakingQueueConfigurationResponse> GetMatchmakingQueueConfigurationWithHttpInfo(string configurationUuid, string queueUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists matchmaking queue configurations.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueConfigurationListResponse</returns>
        MatchmakingQueueConfigurationListResponse GetMatchmakingQueueConfigurations(string queueUuid, string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists matchmaking queue configurations.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueConfigurationListResponse</returns>
        ApiResponse<MatchmakingQueueConfigurationListResponse> GetMatchmakingQueueConfigurationsWithHttpInfo(string queueUuid, string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all matchmaking queues for a given application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueListResponse</returns>
        MatchmakingQueueListResponse GetMatchmakingQueues(string applicationUuid, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all matchmaking queues for a given application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueListResponse</returns>
        ApiResponse<MatchmakingQueueListResponse> GetMatchmakingQueuesWithHttpInfo(string applicationUuid, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationResponse</returns>
        ApplicationResponse UpdateApplication(string applicationUuid, Application application, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationResponse</returns>
        ApiResponse<ApplicationResponse> UpdateApplicationWithHttpInfo(string applicationUuid, Application application, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueResponse</returns>
        MatchmakingQueueResponse UpdateMatchmakingQueue(string queueUuid, string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueResponse</returns>
        ApiResponse<MatchmakingQueueResponse> UpdateMatchmakingQueueWithHttpInfo(string queueUuid, string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFenrirApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiTokenResponse</returns>
        System.Threading.Tasks.Task<ApiTokenResponse> CreateApiTokenAsync(ApiToken apiToken, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiTokenResponse>> CreateApiTokenWithHttpInfoAsync(ApiToken apiToken, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationResponse</returns>
        System.Threading.Tasks.Task<ApplicationResponse> CreateApplicationAsync(Application application, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationResponse>> CreateApplicationWithHttpInfoAsync(Application application, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates an application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="applicationConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationConfigurationResponse</returns>
        System.Threading.Tasks.Task<ApplicationConfigurationResponse> CreateApplicationConfigurationAsync(string applicationUuid, ApplicationConfiguration applicationConfiguration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates an application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="applicationConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationConfigurationResponse>> CreateApplicationConfigurationWithHttpInfoAsync(string applicationUuid, ApplicationConfiguration applicationConfiguration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Crates a new application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="deployment"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeploymentResponse</returns>
        System.Threading.Tasks.Task<DeploymentResponse> CreateDeploymentAsync(string applicationUuid, Deployment deployment, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Crates a new application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="deployment"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeploymentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeploymentResponse>> CreateDeploymentWithHttpInfoAsync(string applicationUuid, Deployment deployment, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueResponse</returns>
        System.Threading.Tasks.Task<MatchmakingQueueResponse> CreateMatchmakingQueueAsync(string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MatchmakingQueueResponse>> CreateMatchmakingQueueWithHttpInfoAsync(string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueueConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueConfigurationResponse</returns>
        System.Threading.Tasks.Task<MatchmakingQueueConfigurationResponse> CreateMatchmakingQueueConfigurationAsync(string queueUuid, string applicationUuid, MatchmakingQueueConfiguration matchmakingQueueConfiguration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueueConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MatchmakingQueueConfigurationResponse>> CreateMatchmakingQueueConfigurationWithHttpInfoAsync(string queueUuid, string applicationUuid, MatchmakingQueueConfiguration matchmakingQueueConfiguration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> DeleteApiTokenAsync(string tokenUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> DeleteApiTokenWithHttpInfoAsync(string tokenUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> DeleteApplicationAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> DeleteApplicationWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> DeleteDeploymentAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> DeleteDeploymentWithHttpInfoAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> DeleteMatchmakingQueueAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> DeleteMatchmakingQueueWithHttpInfoAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiTokenListResponse</returns>
        System.Threading.Tasks.Task<ApiTokenListResponse> GetApiTokenAsync(string tokenUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an API token.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiTokenListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiTokenListResponse>> GetApiTokenWithHttpInfoAsync(string tokenUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all API tokens on your account.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiTokenListResponse</returns>
        System.Threading.Tasks.Task<ApiTokenListResponse> GetApiTokensAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all API tokens on your account.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiTokenListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiTokenListResponse>> GetApiTokensWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationResponse</returns>
        System.Threading.Tasks.Task<ApplicationResponse> GetApplicationAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationResponse>> GetApplicationWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationConfigurationResponse</returns>
        System.Threading.Tasks.Task<ApplicationConfigurationResponse> GetApplicationConfigurationAsync(string configurationUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationConfigurationResponse>> GetApplicationConfigurationWithHttpInfoAsync(string configurationUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application configurations ever created.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationConfigurationListResponse</returns>
        System.Threading.Tasks.Task<ApplicationConfigurationListResponse> GetApplicationConfigurationsAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application configurations ever created.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationConfigurationListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationConfigurationListResponse>> GetApplicationConfigurationsWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves application stats.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationStatsResponse</returns>
        System.Threading.Tasks.Task<ApplicationStatsResponse> GetApplicationStatsAsync(string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves application stats.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationStatsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationStatsResponse>> GetApplicationStatsWithHttpInfoAsync(string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all applications on your account.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationListResponse</returns>
        System.Threading.Tasks.Task<ApplicationListResponse> GetApplicationsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all applications on your account.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationListResponse>> GetApplicationsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves current application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationConfigurationResponse</returns>
        System.Threading.Tasks.Task<ApplicationConfigurationResponse> GetCurrentApplicationConfigurationAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves current application configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationConfigurationResponse>> GetCurrentApplicationConfigurationWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves current matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueConfigurationResponse</returns>
        System.Threading.Tasks.Task<MatchmakingQueueConfigurationResponse> GetCurrentMatchmakingQueueConfigurationAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves current matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MatchmakingQueueConfigurationResponse>> GetCurrentMatchmakingQueueConfigurationWithHttpInfoAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeploymentResponse</returns>
        System.Threading.Tasks.Task<DeploymentResponse> GetDeploymentAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeploymentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeploymentResponse>> GetDeploymentWithHttpInfoAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves deployment stats.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeploymentStatsResponse</returns>
        System.Threading.Tasks.Task<DeploymentStatsResponse> GetDeploymentStatsAsync(string deploymentUuid, string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves deployment stats.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeploymentStatsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeploymentStatsResponse>> GetDeploymentStatsWithHttpInfoAsync(string deploymentUuid, string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application deployments.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeploymentListResponse</returns>
        System.Threading.Tasks.Task<DeploymentListResponse> GetDeploymentsAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application deployments.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeploymentListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeploymentListResponse>> GetDeploymentsWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application images.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ImageListResponse</returns>
        System.Threading.Tasks.Task<ImageListResponse> GetImagesAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application images.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ImageListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageListResponse>> GetImagesWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application instance.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstanceResponse</returns>
        System.Threading.Tasks.Task<ApplicationInstanceResponse> GetInstanceAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves an application instance.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstanceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationInstanceResponse>> GetInstanceWithHttpInfoAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves application instance logs.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InstanceLogs</returns>
        System.Threading.Tasks.Task<InstanceLogs> GetInstanceLogsAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves application instance logs.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InstanceLogs)</returns>
        System.Threading.Tasks.Task<ApiResponse<InstanceLogs>> GetInstanceLogsWithHttpInfoAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a small number of most recent application instance logs.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InstanceLogsPreview</returns>
        System.Threading.Tasks.Task<InstanceLogsPreview> GetInstanceLogsPreviewAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a small number of most recent application instance logs.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InstanceLogsPreview)</returns>
        System.Threading.Tasks.Task<ApiResponse<InstanceLogsPreview>> GetInstanceLogsPreviewWithHttpInfoAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application instances for a given deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstanceListResponse</returns>
        System.Threading.Tasks.Task<ApplicationInstanceListResponse> GetInstancesAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all application instances for a given deployment.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstanceListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationInstanceListResponse>> GetInstancesWithHttpInfoAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueResponse</returns>
        System.Threading.Tasks.Task<MatchmakingQueueResponse> GetMatchmakingQueueAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MatchmakingQueueResponse>> GetMatchmakingQueueWithHttpInfoAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueConfigurationResponse</returns>
        System.Threading.Tasks.Task<MatchmakingQueueConfigurationResponse> GetMatchmakingQueueConfigurationAsync(string configurationUuid, string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves a matchmaking queue configuration.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MatchmakingQueueConfigurationResponse>> GetMatchmakingQueueConfigurationWithHttpInfoAsync(string configurationUuid, string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists matchmaking queue configurations.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueConfigurationListResponse</returns>
        System.Threading.Tasks.Task<MatchmakingQueueConfigurationListResponse> GetMatchmakingQueueConfigurationsAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists matchmaking queue configurations.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueConfigurationListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MatchmakingQueueConfigurationListResponse>> GetMatchmakingQueueConfigurationsWithHttpInfoAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all matchmaking queues for a given application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueListResponse</returns>
        System.Threading.Tasks.Task<MatchmakingQueueListResponse> GetMatchmakingQueuesAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Lists all matchmaking queues for a given application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MatchmakingQueueListResponse>> GetMatchmakingQueuesWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationResponse</returns>
        System.Threading.Tasks.Task<ApplicationResponse> UpdateApplicationAsync(string applicationUuid, Application application, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an application.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationResponse>> UpdateApplicationWithHttpInfoAsync(string applicationUuid, Application application, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueResponse</returns>
        System.Threading.Tasks.Task<MatchmakingQueueResponse> UpdateMatchmakingQueueAsync(string queueUuid, string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates a matchmaking queue.
        /// </remarks>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MatchmakingQueueResponse>> UpdateMatchmakingQueueWithHttpInfoAsync(string queueUuid, string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFenrirApi : IFenrirApiSync, IFenrirApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FenrirApi : IFenrirApi
    {
        private Fenrir.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FenrirApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FenrirApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FenrirApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FenrirApi(string basePath)
        {
            this.Configuration = Fenrir.Api.Client.Configuration.MergeConfigurations(
                Fenrir.Api.Client.GlobalConfiguration.Instance,
                new Fenrir.Api.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Fenrir.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Fenrir.Api.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Fenrir.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FenrirApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FenrirApi(Fenrir.Api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Fenrir.Api.Client.Configuration.MergeConfigurations(
                Fenrir.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Fenrir.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Fenrir.Api.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Fenrir.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FenrirApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public FenrirApi(Fenrir.Api.Client.ISynchronousClient client, Fenrir.Api.Client.IAsynchronousClient asyncClient, Fenrir.Api.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Fenrir.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Fenrir.Api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Fenrir.Api.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Fenrir.Api.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Fenrir.Api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Creates a new API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiTokenResponse</returns>
        public ApiTokenResponse CreateApiToken(ApiToken apiToken, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApiTokenResponse> localVarResponse = CreateApiTokenWithHttpInfo(apiToken);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates a new API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiTokenResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApiTokenResponse> CreateApiTokenWithHttpInfo(ApiToken apiToken, int operationIndex = 0)
        {
            // verify the required parameter 'apiToken' is set
            if (apiToken == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'apiToken' when calling FenrirApi->CreateApiToken");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = apiToken;

            localVarRequestOptions.Operation = "FenrirApi.CreateApiToken";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ApiTokenResponse>("/api_tokens", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateApiToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Creates a new API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiTokenResponse</returns>
        public async System.Threading.Tasks.Task<ApiTokenResponse> CreateApiTokenAsync(ApiToken apiToken, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApiTokenResponse> localVarResponse = await CreateApiTokenWithHttpInfoAsync(apiToken, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates a new API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiTokenResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApiTokenResponse>> CreateApiTokenWithHttpInfoAsync(ApiToken apiToken, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'apiToken' is set
            if (apiToken == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'apiToken' when calling FenrirApi->CreateApiToken");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = apiToken;

            localVarRequestOptions.Operation = "FenrirApi.CreateApiToken";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ApiTokenResponse>("/api_tokens", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateApiToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Creates a new application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationResponse</returns>
        public ApplicationResponse CreateApplication(Application application, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationResponse> localVarResponse = CreateApplicationWithHttpInfo(application);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates a new application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationResponse> CreateApplicationWithHttpInfo(Application application, int operationIndex = 0)
        {
            // verify the required parameter 'application' is set
            if (application == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'application' when calling FenrirApi->CreateApplication");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = application;

            localVarRequestOptions.Operation = "FenrirApi.CreateApplication";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ApplicationResponse>("/applications", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Creates a new application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationResponse> CreateApplicationAsync(Application application, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationResponse> localVarResponse = await CreateApplicationWithHttpInfoAsync(application, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates a new application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationResponse>> CreateApplicationWithHttpInfoAsync(Application application, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'application' is set
            if (application == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'application' when calling FenrirApi->CreateApplication");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = application;

            localVarRequestOptions.Operation = "FenrirApi.CreateApplication";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ApplicationResponse>("/applications", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Creates an application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="applicationConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationConfigurationResponse</returns>
        public ApplicationConfigurationResponse CreateApplicationConfiguration(string applicationUuid, ApplicationConfiguration applicationConfiguration, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse> localVarResponse = CreateApplicationConfigurationWithHttpInfo(applicationUuid, applicationConfiguration);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates an application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="applicationConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationConfigurationResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse> CreateApplicationConfigurationWithHttpInfo(string applicationUuid, ApplicationConfiguration applicationConfiguration, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->CreateApplicationConfiguration");
            }

            // verify the required parameter 'applicationConfiguration' is set
            if (applicationConfiguration == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationConfiguration' when calling FenrirApi->CreateApplicationConfiguration");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = applicationConfiguration;

            localVarRequestOptions.Operation = "FenrirApi.CreateApplicationConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ApplicationConfigurationResponse>("/applications/{application_uuid}/configuration", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateApplicationConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Creates an application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="applicationConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationConfigurationResponse> CreateApplicationConfigurationAsync(string applicationUuid, ApplicationConfiguration applicationConfiguration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse> localVarResponse = await CreateApplicationConfigurationWithHttpInfoAsync(applicationUuid, applicationConfiguration, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates an application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="applicationConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse>> CreateApplicationConfigurationWithHttpInfoAsync(string applicationUuid, ApplicationConfiguration applicationConfiguration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->CreateApplicationConfiguration");
            }

            // verify the required parameter 'applicationConfiguration' is set
            if (applicationConfiguration == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationConfiguration' when calling FenrirApi->CreateApplicationConfiguration");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = applicationConfiguration;

            localVarRequestOptions.Operation = "FenrirApi.CreateApplicationConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ApplicationConfigurationResponse>("/applications/{application_uuid}/configuration", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateApplicationConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Crates a new application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="deployment"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeploymentResponse</returns>
        public DeploymentResponse CreateDeployment(string applicationUuid, Deployment deployment, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<DeploymentResponse> localVarResponse = CreateDeploymentWithHttpInfo(applicationUuid, deployment);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Crates a new application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="deployment"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeploymentResponse</returns>
        public Fenrir.Api.Client.ApiResponse<DeploymentResponse> CreateDeploymentWithHttpInfo(string applicationUuid, Deployment deployment, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->CreateDeployment");
            }

            // verify the required parameter 'deployment' is set
            if (deployment == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deployment' when calling FenrirApi->CreateDeployment");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = deployment;

            localVarRequestOptions.Operation = "FenrirApi.CreateDeployment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<DeploymentResponse>("/applications/{application_uuid}/deployments", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateDeployment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Crates a new application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="deployment"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeploymentResponse</returns>
        public async System.Threading.Tasks.Task<DeploymentResponse> CreateDeploymentAsync(string applicationUuid, Deployment deployment, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<DeploymentResponse> localVarResponse = await CreateDeploymentWithHttpInfoAsync(applicationUuid, deployment, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Crates a new application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="deployment"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeploymentResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<DeploymentResponse>> CreateDeploymentWithHttpInfoAsync(string applicationUuid, Deployment deployment, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->CreateDeployment");
            }

            // verify the required parameter 'deployment' is set
            if (deployment == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deployment' when calling FenrirApi->CreateDeployment");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = deployment;

            localVarRequestOptions.Operation = "FenrirApi.CreateDeployment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<DeploymentResponse>("/applications/{application_uuid}/deployments", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateDeployment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Creates a new matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueResponse</returns>
        public MatchmakingQueueResponse CreateMatchmakingQueue(string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse> localVarResponse = CreateMatchmakingQueueWithHttpInfo(applicationUuid, matchmakingQueue);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates a new matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueResponse</returns>
        public Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse> CreateMatchmakingQueueWithHttpInfo(string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->CreateMatchmakingQueue");
            }

            // verify the required parameter 'matchmakingQueue' is set
            if (matchmakingQueue == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'matchmakingQueue' when calling FenrirApi->CreateMatchmakingQueue");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = matchmakingQueue;

            localVarRequestOptions.Operation = "FenrirApi.CreateMatchmakingQueue";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<MatchmakingQueueResponse>("/applications/{application_uuid}/matchmaking/queues", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateMatchmakingQueue", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Creates a new matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueResponse</returns>
        public async System.Threading.Tasks.Task<MatchmakingQueueResponse> CreateMatchmakingQueueAsync(string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse> localVarResponse = await CreateMatchmakingQueueWithHttpInfoAsync(applicationUuid, matchmakingQueue, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates a new matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse>> CreateMatchmakingQueueWithHttpInfoAsync(string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->CreateMatchmakingQueue");
            }

            // verify the required parameter 'matchmakingQueue' is set
            if (matchmakingQueue == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'matchmakingQueue' when calling FenrirApi->CreateMatchmakingQueue");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = matchmakingQueue;

            localVarRequestOptions.Operation = "FenrirApi.CreateMatchmakingQueue";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<MatchmakingQueueResponse>("/applications/{application_uuid}/matchmaking/queues", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateMatchmakingQueue", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Creates a new matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueueConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueConfigurationResponse</returns>
        public MatchmakingQueueConfigurationResponse CreateMatchmakingQueueConfiguration(string queueUuid, string applicationUuid, MatchmakingQueueConfiguration matchmakingQueueConfiguration, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse> localVarResponse = CreateMatchmakingQueueConfigurationWithHttpInfo(queueUuid, applicationUuid, matchmakingQueueConfiguration);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates a new matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueueConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueConfigurationResponse</returns>
        public Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse> CreateMatchmakingQueueConfigurationWithHttpInfo(string queueUuid, string applicationUuid, MatchmakingQueueConfiguration matchmakingQueueConfiguration, int operationIndex = 0)
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->CreateMatchmakingQueueConfiguration");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->CreateMatchmakingQueueConfiguration");
            }

            // verify the required parameter 'matchmakingQueueConfiguration' is set
            if (matchmakingQueueConfiguration == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'matchmakingQueueConfiguration' when calling FenrirApi->CreateMatchmakingQueueConfiguration");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = matchmakingQueueConfiguration;

            localVarRequestOptions.Operation = "FenrirApi.CreateMatchmakingQueueConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<MatchmakingQueueConfigurationResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configuration", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateMatchmakingQueueConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Creates a new matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueueConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<MatchmakingQueueConfigurationResponse> CreateMatchmakingQueueConfigurationAsync(string queueUuid, string applicationUuid, MatchmakingQueueConfiguration matchmakingQueueConfiguration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse> localVarResponse = await CreateMatchmakingQueueConfigurationWithHttpInfoAsync(queueUuid, applicationUuid, matchmakingQueueConfiguration, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates a new matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueueConfiguration"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse>> CreateMatchmakingQueueConfigurationWithHttpInfoAsync(string queueUuid, string applicationUuid, MatchmakingQueueConfiguration matchmakingQueueConfiguration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->CreateMatchmakingQueueConfiguration");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->CreateMatchmakingQueueConfiguration");
            }

            // verify the required parameter 'matchmakingQueueConfiguration' is set
            if (matchmakingQueueConfiguration == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'matchmakingQueueConfiguration' when calling FenrirApi->CreateMatchmakingQueueConfiguration");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = matchmakingQueueConfiguration;

            localVarRequestOptions.Operation = "FenrirApi.CreateMatchmakingQueueConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<MatchmakingQueueConfigurationResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configuration", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateMatchmakingQueueConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Deletes an API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Response</returns>
        public Response DeleteApiToken(string tokenUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<Response> localVarResponse = DeleteApiTokenWithHttpInfo(tokenUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Deletes an API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Response</returns>
        public Fenrir.Api.Client.ApiResponse<Response> DeleteApiTokenWithHttpInfo(string tokenUuid, int operationIndex = 0)
        {
            // verify the required parameter 'tokenUuid' is set
            if (tokenUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'tokenUuid' when calling FenrirApi->DeleteApiToken");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("token_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(tokenUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.DeleteApiToken";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Response>("/api_tokens/{token_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteApiToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Deletes an API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> DeleteApiTokenAsync(string tokenUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<Response> localVarResponse = await DeleteApiTokenWithHttpInfoAsync(tokenUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Deletes an API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<Response>> DeleteApiTokenWithHttpInfoAsync(string tokenUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tokenUuid' is set
            if (tokenUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'tokenUuid' when calling FenrirApi->DeleteApiToken");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("token_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(tokenUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.DeleteApiToken";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Response>("/api_tokens/{token_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteApiToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Deletes an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Response</returns>
        public Response DeleteApplication(string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<Response> localVarResponse = DeleteApplicationWithHttpInfo(applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Deletes an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Response</returns>
        public Fenrir.Api.Client.ApiResponse<Response> DeleteApplicationWithHttpInfo(string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->DeleteApplication");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.DeleteApplication";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Response>("/applications/{application_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Deletes an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> DeleteApplicationAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<Response> localVarResponse = await DeleteApplicationWithHttpInfoAsync(applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Deletes an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<Response>> DeleteApplicationWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->DeleteApplication");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.DeleteApplication";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Response>("/applications/{application_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Deletes an application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Response</returns>
        public Response DeleteDeployment(string deploymentUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<Response> localVarResponse = DeleteDeploymentWithHttpInfo(deploymentUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Deletes an application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Response</returns>
        public Fenrir.Api.Client.ApiResponse<Response> DeleteDeploymentWithHttpInfo(string deploymentUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->DeleteDeployment");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->DeleteDeployment");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.DeleteDeployment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Response>("/applications/{application_uuid}/deployments/{deployment_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteDeployment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Deletes an application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> DeleteDeploymentAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<Response> localVarResponse = await DeleteDeploymentWithHttpInfoAsync(deploymentUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Deletes an application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<Response>> DeleteDeploymentWithHttpInfoAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->DeleteDeployment");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->DeleteDeployment");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.DeleteDeployment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Response>("/applications/{application_uuid}/deployments/{deployment_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteDeployment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Deletes a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Response</returns>
        public Response DeleteMatchmakingQueue(string queueUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<Response> localVarResponse = DeleteMatchmakingQueueWithHttpInfo(queueUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Deletes a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Response</returns>
        public Fenrir.Api.Client.ApiResponse<Response> DeleteMatchmakingQueueWithHttpInfo(string queueUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->DeleteMatchmakingQueue");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->DeleteMatchmakingQueue");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.DeleteMatchmakingQueue";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Response>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteMatchmakingQueue", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Deletes a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> DeleteMatchmakingQueueAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<Response> localVarResponse = await DeleteMatchmakingQueueWithHttpInfoAsync(queueUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Deletes a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<Response>> DeleteMatchmakingQueueWithHttpInfoAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->DeleteMatchmakingQueue");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->DeleteMatchmakingQueue");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.DeleteMatchmakingQueue";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Response>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteMatchmakingQueue", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves an API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiTokenListResponse</returns>
        public ApiTokenListResponse GetApiToken(string tokenUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApiTokenListResponse> localVarResponse = GetApiTokenWithHttpInfo(tokenUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves an API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiTokenListResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApiTokenListResponse> GetApiTokenWithHttpInfo(string tokenUuid, int operationIndex = 0)
        {
            // verify the required parameter 'tokenUuid' is set
            if (tokenUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'tokenUuid' when calling FenrirApi->GetApiToken");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("token_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(tokenUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetApiToken";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApiTokenListResponse>("/api_tokens/{token_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApiToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves an API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiTokenListResponse</returns>
        public async System.Threading.Tasks.Task<ApiTokenListResponse> GetApiTokenAsync(string tokenUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApiTokenListResponse> localVarResponse = await GetApiTokenWithHttpInfoAsync(tokenUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves an API token.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiTokenListResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApiTokenListResponse>> GetApiTokenWithHttpInfoAsync(string tokenUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tokenUuid' is set
            if (tokenUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'tokenUuid' when calling FenrirApi->GetApiToken");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("token_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(tokenUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetApiToken";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApiTokenListResponse>("/api_tokens/{token_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApiToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all API tokens on your account.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiTokenListResponse</returns>
        public ApiTokenListResponse GetApiTokens(int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApiTokenListResponse> localVarResponse = GetApiTokensWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all API tokens on your account.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiTokenListResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApiTokenListResponse> GetApiTokensWithHttpInfo(int operationIndex = 0)
        {
            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "FenrirApi.GetApiTokens";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApiTokenListResponse>("/api_tokens", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApiTokens", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all API tokens on your account.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiTokenListResponse</returns>
        public async System.Threading.Tasks.Task<ApiTokenListResponse> GetApiTokensAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApiTokenListResponse> localVarResponse = await GetApiTokensWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all API tokens on your account.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiTokenListResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApiTokenListResponse>> GetApiTokensWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "FenrirApi.GetApiTokens";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApiTokenListResponse>("/api_tokens", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApiTokens", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationResponse</returns>
        public ApplicationResponse GetApplication(string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationResponse> localVarResponse = GetApplicationWithHttpInfo(applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationResponse> GetApplicationWithHttpInfo(string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetApplication");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetApplication";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApplicationResponse>("/applications/{application_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationResponse> GetApplicationAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationResponse> localVarResponse = await GetApplicationWithHttpInfoAsync(applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationResponse>> GetApplicationWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetApplication");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetApplication";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApplicationResponse>("/applications/{application_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves an application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationConfigurationResponse</returns>
        public ApplicationConfigurationResponse GetApplicationConfiguration(string configurationUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse> localVarResponse = GetApplicationConfigurationWithHttpInfo(configurationUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves an application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationConfigurationResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse> GetApplicationConfigurationWithHttpInfo(string configurationUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'configurationUuid' is set
            if (configurationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'configurationUuid' when calling FenrirApi->GetApplicationConfiguration");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetApplicationConfiguration");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("configuration_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(configurationUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetApplicationConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApplicationConfigurationResponse>("/applications/{application_uuid}/configurations/{configuration_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplicationConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves an application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationConfigurationResponse> GetApplicationConfigurationAsync(string configurationUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse> localVarResponse = await GetApplicationConfigurationWithHttpInfoAsync(configurationUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves an application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse>> GetApplicationConfigurationWithHttpInfoAsync(string configurationUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'configurationUuid' is set
            if (configurationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'configurationUuid' when calling FenrirApi->GetApplicationConfiguration");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetApplicationConfiguration");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("configuration_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(configurationUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetApplicationConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApplicationConfigurationResponse>("/applications/{application_uuid}/configurations/{configuration_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplicationConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all application configurations ever created.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationConfigurationListResponse</returns>
        public ApplicationConfigurationListResponse GetApplicationConfigurations(string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationConfigurationListResponse> localVarResponse = GetApplicationConfigurationsWithHttpInfo(applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all application configurations ever created.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationConfigurationListResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationConfigurationListResponse> GetApplicationConfigurationsWithHttpInfo(string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetApplicationConfigurations");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetApplicationConfigurations";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApplicationConfigurationListResponse>("/applications/{application_uuid}/configurations", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplicationConfigurations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all application configurations ever created.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationConfigurationListResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationConfigurationListResponse> GetApplicationConfigurationsAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationConfigurationListResponse> localVarResponse = await GetApplicationConfigurationsWithHttpInfoAsync(applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all application configurations ever created.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationConfigurationListResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationConfigurationListResponse>> GetApplicationConfigurationsWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetApplicationConfigurations");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetApplicationConfigurations";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApplicationConfigurationListResponse>("/applications/{application_uuid}/configurations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplicationConfigurations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves application stats.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationStatsResponse</returns>
        public ApplicationStatsResponse GetApplicationStats(string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationStatsResponse> localVarResponse = GetApplicationStatsWithHttpInfo(applicationUuid, filter);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves application stats.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationStatsResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationStatsResponse> GetApplicationStatsWithHttpInfo(string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetApplicationStats");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fenrir.Api.Client.ClientUtils.ParameterToMultiMap("multi", "filter", filter));
            }

            localVarRequestOptions.Operation = "FenrirApi.GetApplicationStats";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApplicationStatsResponse>("/applications/{application_uuid}/stats", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplicationStats", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves application stats.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationStatsResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationStatsResponse> GetApplicationStatsAsync(string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationStatsResponse> localVarResponse = await GetApplicationStatsWithHttpInfoAsync(applicationUuid, filter, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves application stats.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationStatsResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationStatsResponse>> GetApplicationStatsWithHttpInfoAsync(string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetApplicationStats");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fenrir.Api.Client.ClientUtils.ParameterToMultiMap("multi", "filter", filter));
            }

            localVarRequestOptions.Operation = "FenrirApi.GetApplicationStats";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApplicationStatsResponse>("/applications/{application_uuid}/stats", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplicationStats", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all applications on your account.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationListResponse</returns>
        public ApplicationListResponse GetApplications(int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationListResponse> localVarResponse = GetApplicationsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all applications on your account.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationListResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationListResponse> GetApplicationsWithHttpInfo(int operationIndex = 0)
        {
            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "FenrirApi.GetApplications";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApplicationListResponse>("/applications", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplications", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all applications on your account.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationListResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationListResponse> GetApplicationsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationListResponse> localVarResponse = await GetApplicationsWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all applications on your account.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationListResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationListResponse>> GetApplicationsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "FenrirApi.GetApplications";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApplicationListResponse>("/applications", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplications", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves current application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationConfigurationResponse</returns>
        public ApplicationConfigurationResponse GetCurrentApplicationConfiguration(string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse> localVarResponse = GetCurrentApplicationConfigurationWithHttpInfo(applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves current application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationConfigurationResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse> GetCurrentApplicationConfigurationWithHttpInfo(string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetCurrentApplicationConfiguration");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetCurrentApplicationConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApplicationConfigurationResponse>("/applications/{application_uuid}/configuration", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCurrentApplicationConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves current application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationConfigurationResponse> GetCurrentApplicationConfigurationAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse> localVarResponse = await GetCurrentApplicationConfigurationWithHttpInfoAsync(applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves current application configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationConfigurationResponse>> GetCurrentApplicationConfigurationWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetCurrentApplicationConfiguration");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetCurrentApplicationConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApplicationConfigurationResponse>("/applications/{application_uuid}/configuration", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCurrentApplicationConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves current matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueConfigurationResponse</returns>
        public MatchmakingQueueConfigurationResponse GetCurrentMatchmakingQueueConfiguration(string queueUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse> localVarResponse = GetCurrentMatchmakingQueueConfigurationWithHttpInfo(queueUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves current matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueConfigurationResponse</returns>
        public Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse> GetCurrentMatchmakingQueueConfigurationWithHttpInfo(string queueUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->GetCurrentMatchmakingQueueConfiguration");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetCurrentMatchmakingQueueConfiguration");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetCurrentMatchmakingQueueConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<MatchmakingQueueConfigurationResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configuration", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCurrentMatchmakingQueueConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves current matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<MatchmakingQueueConfigurationResponse> GetCurrentMatchmakingQueueConfigurationAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse> localVarResponse = await GetCurrentMatchmakingQueueConfigurationWithHttpInfoAsync(queueUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves current matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse>> GetCurrentMatchmakingQueueConfigurationWithHttpInfoAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->GetCurrentMatchmakingQueueConfiguration");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetCurrentMatchmakingQueueConfiguration");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetCurrentMatchmakingQueueConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<MatchmakingQueueConfigurationResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configuration", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCurrentMatchmakingQueueConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves an application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeploymentResponse</returns>
        public DeploymentResponse GetDeployment(string deploymentUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<DeploymentResponse> localVarResponse = GetDeploymentWithHttpInfo(deploymentUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves an application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeploymentResponse</returns>
        public Fenrir.Api.Client.ApiResponse<DeploymentResponse> GetDeploymentWithHttpInfo(string deploymentUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetDeployment");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetDeployment");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetDeployment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DeploymentResponse>("/applications/{application_uuid}/deployments/{deployment_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDeployment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves an application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeploymentResponse</returns>
        public async System.Threading.Tasks.Task<DeploymentResponse> GetDeploymentAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<DeploymentResponse> localVarResponse = await GetDeploymentWithHttpInfoAsync(deploymentUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves an application deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeploymentResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<DeploymentResponse>> GetDeploymentWithHttpInfoAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetDeployment");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetDeployment");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetDeployment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DeploymentResponse>("/applications/{application_uuid}/deployments/{deployment_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDeployment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves deployment stats.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeploymentStatsResponse</returns>
        public DeploymentStatsResponse GetDeploymentStats(string deploymentUuid, string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<DeploymentStatsResponse> localVarResponse = GetDeploymentStatsWithHttpInfo(deploymentUuid, applicationUuid, filter);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves deployment stats.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeploymentStatsResponse</returns>
        public Fenrir.Api.Client.ApiResponse<DeploymentStatsResponse> GetDeploymentStatsWithHttpInfo(string deploymentUuid, string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0)
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetDeploymentStats");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetDeploymentStats");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fenrir.Api.Client.ClientUtils.ParameterToMultiMap("multi", "filter", filter));
            }

            localVarRequestOptions.Operation = "FenrirApi.GetDeploymentStats";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DeploymentStatsResponse>("/applications/{application_uuid}/deployments/{deployment_uuid}/stats", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDeploymentStats", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves deployment stats.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeploymentStatsResponse</returns>
        public async System.Threading.Tasks.Task<DeploymentStatsResponse> GetDeploymentStatsAsync(string deploymentUuid, string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<DeploymentStatsResponse> localVarResponse = await GetDeploymentStatsWithHttpInfoAsync(deploymentUuid, applicationUuid, filter, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves deployment stats.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeploymentStatsResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<DeploymentStatsResponse>> GetDeploymentStatsWithHttpInfoAsync(string deploymentUuid, string applicationUuid, List<string> filter = default(List<string>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetDeploymentStats");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetDeploymentStats");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Fenrir.Api.Client.ClientUtils.ParameterToMultiMap("multi", "filter", filter));
            }

            localVarRequestOptions.Operation = "FenrirApi.GetDeploymentStats";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DeploymentStatsResponse>("/applications/{application_uuid}/deployments/{deployment_uuid}/stats", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDeploymentStats", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all application deployments.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeploymentListResponse</returns>
        public DeploymentListResponse GetDeployments(string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<DeploymentListResponse> localVarResponse = GetDeploymentsWithHttpInfo(applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all application deployments.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeploymentListResponse</returns>
        public Fenrir.Api.Client.ApiResponse<DeploymentListResponse> GetDeploymentsWithHttpInfo(string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetDeployments");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetDeployments";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DeploymentListResponse>("/applications/{application_uuid}/deployments", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDeployments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all application deployments.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeploymentListResponse</returns>
        public async System.Threading.Tasks.Task<DeploymentListResponse> GetDeploymentsAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<DeploymentListResponse> localVarResponse = await GetDeploymentsWithHttpInfoAsync(applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all application deployments.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeploymentListResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<DeploymentListResponse>> GetDeploymentsWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetDeployments");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetDeployments";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DeploymentListResponse>("/applications/{application_uuid}/deployments", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDeployments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all application images.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ImageListResponse</returns>
        public ImageListResponse GetImages(string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ImageListResponse> localVarResponse = GetImagesWithHttpInfo(applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all application images.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ImageListResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ImageListResponse> GetImagesWithHttpInfo(string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetImages");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetImages";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ImageListResponse>("/applications/{application_uuid}/images", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetImages", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all application images.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ImageListResponse</returns>
        public async System.Threading.Tasks.Task<ImageListResponse> GetImagesAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ImageListResponse> localVarResponse = await GetImagesWithHttpInfoAsync(applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all application images.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ImageListResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ImageListResponse>> GetImagesWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetImages");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetImages";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ImageListResponse>("/applications/{application_uuid}/images", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetImages", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves an application instance.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstanceResponse</returns>
        public ApplicationInstanceResponse GetInstance(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationInstanceResponse> localVarResponse = GetInstanceWithHttpInfo(deploymentUuid, instanceUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves an application instance.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstanceResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationInstanceResponse> GetInstanceWithHttpInfo(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetInstance");
            }

            // verify the required parameter 'instanceUuid' is set
            if (instanceUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'instanceUuid' when calling FenrirApi->GetInstance");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetInstance");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("instance_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(instanceUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetInstance";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApplicationInstanceResponse>("/applications/{application_uuid}/deployments/{deployment_uuid}/instances/{instance_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstance", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves an application instance.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstanceResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationInstanceResponse> GetInstanceAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationInstanceResponse> localVarResponse = await GetInstanceWithHttpInfoAsync(deploymentUuid, instanceUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves an application instance.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstanceResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationInstanceResponse>> GetInstanceWithHttpInfoAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetInstance");
            }

            // verify the required parameter 'instanceUuid' is set
            if (instanceUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'instanceUuid' when calling FenrirApi->GetInstance");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetInstance");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("instance_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(instanceUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetInstance";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApplicationInstanceResponse>("/applications/{application_uuid}/deployments/{deployment_uuid}/instances/{instance_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstance", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves application instance logs.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InstanceLogs</returns>
        public InstanceLogs GetInstanceLogs(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<InstanceLogs> localVarResponse = GetInstanceLogsWithHttpInfo(deploymentUuid, instanceUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves application instance logs.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InstanceLogs</returns>
        public Fenrir.Api.Client.ApiResponse<InstanceLogs> GetInstanceLogsWithHttpInfo(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetInstanceLogs");
            }

            // verify the required parameter 'instanceUuid' is set
            if (instanceUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'instanceUuid' when calling FenrirApi->GetInstanceLogs");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetInstanceLogs");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("instance_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(instanceUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetInstanceLogs";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<InstanceLogs>("/applications/{application_uuid}/deployments/{deployment_uuid}/instances/{instance_uuid}/logs", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstanceLogs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves application instance logs.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InstanceLogs</returns>
        public async System.Threading.Tasks.Task<InstanceLogs> GetInstanceLogsAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<InstanceLogs> localVarResponse = await GetInstanceLogsWithHttpInfoAsync(deploymentUuid, instanceUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves application instance logs.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InstanceLogs)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<InstanceLogs>> GetInstanceLogsWithHttpInfoAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetInstanceLogs");
            }

            // verify the required parameter 'instanceUuid' is set
            if (instanceUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'instanceUuid' when calling FenrirApi->GetInstanceLogs");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetInstanceLogs");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("instance_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(instanceUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetInstanceLogs";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<InstanceLogs>("/applications/{application_uuid}/deployments/{deployment_uuid}/instances/{instance_uuid}/logs", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstanceLogs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves a small number of most recent application instance logs.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InstanceLogsPreview</returns>
        public InstanceLogsPreview GetInstanceLogsPreview(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<InstanceLogsPreview> localVarResponse = GetInstanceLogsPreviewWithHttpInfo(deploymentUuid, instanceUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves a small number of most recent application instance logs.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InstanceLogsPreview</returns>
        public Fenrir.Api.Client.ApiResponse<InstanceLogsPreview> GetInstanceLogsPreviewWithHttpInfo(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetInstanceLogsPreview");
            }

            // verify the required parameter 'instanceUuid' is set
            if (instanceUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'instanceUuid' when calling FenrirApi->GetInstanceLogsPreview");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetInstanceLogsPreview");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("instance_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(instanceUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetInstanceLogsPreview";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<InstanceLogsPreview>("/applications/{application_uuid}/deployments/{deployment_uuid}/instances/{instance_uuid}/logs/preview", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstanceLogsPreview", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves a small number of most recent application instance logs.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InstanceLogsPreview</returns>
        public async System.Threading.Tasks.Task<InstanceLogsPreview> GetInstanceLogsPreviewAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<InstanceLogsPreview> localVarResponse = await GetInstanceLogsPreviewWithHttpInfoAsync(deploymentUuid, instanceUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves a small number of most recent application instance logs.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="instanceUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InstanceLogsPreview)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<InstanceLogsPreview>> GetInstanceLogsPreviewWithHttpInfoAsync(string deploymentUuid, string instanceUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetInstanceLogsPreview");
            }

            // verify the required parameter 'instanceUuid' is set
            if (instanceUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'instanceUuid' when calling FenrirApi->GetInstanceLogsPreview");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetInstanceLogsPreview");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("instance_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(instanceUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetInstanceLogsPreview";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<InstanceLogsPreview>("/applications/{application_uuid}/deployments/{deployment_uuid}/instances/{instance_uuid}/logs/preview", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstanceLogsPreview", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all application instances for a given deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstanceListResponse</returns>
        public ApplicationInstanceListResponse GetInstances(string deploymentUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationInstanceListResponse> localVarResponse = GetInstancesWithHttpInfo(deploymentUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all application instances for a given deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstanceListResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationInstanceListResponse> GetInstancesWithHttpInfo(string deploymentUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetInstances");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetInstances");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetInstances";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApplicationInstanceListResponse>("/applications/{application_uuid}/deployments/{deployment_uuid}/instances", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstances", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all application instances for a given deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstanceListResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationInstanceListResponse> GetInstancesAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationInstanceListResponse> localVarResponse = await GetInstancesWithHttpInfoAsync(deploymentUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all application instances for a given deployment.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstanceListResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationInstanceListResponse>> GetInstancesWithHttpInfoAsync(string deploymentUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'deploymentUuid' is set
            if (deploymentUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'deploymentUuid' when calling FenrirApi->GetInstances");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetInstances");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("deployment_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(deploymentUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetInstances";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApplicationInstanceListResponse>("/applications/{application_uuid}/deployments/{deployment_uuid}/instances", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstances", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueResponse</returns>
        public MatchmakingQueueResponse GetMatchmakingQueue(string queueUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse> localVarResponse = GetMatchmakingQueueWithHttpInfo(queueUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueResponse</returns>
        public Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse> GetMatchmakingQueueWithHttpInfo(string queueUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->GetMatchmakingQueue");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetMatchmakingQueue");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetMatchmakingQueue";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<MatchmakingQueueResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMatchmakingQueue", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueResponse</returns>
        public async System.Threading.Tasks.Task<MatchmakingQueueResponse> GetMatchmakingQueueAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse> localVarResponse = await GetMatchmakingQueueWithHttpInfoAsync(queueUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse>> GetMatchmakingQueueWithHttpInfoAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->GetMatchmakingQueue");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetMatchmakingQueue");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetMatchmakingQueue";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<MatchmakingQueueResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMatchmakingQueue", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves a matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueConfigurationResponse</returns>
        public MatchmakingQueueConfigurationResponse GetMatchmakingQueueConfiguration(string configurationUuid, string queueUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse> localVarResponse = GetMatchmakingQueueConfigurationWithHttpInfo(configurationUuid, queueUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves a matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueConfigurationResponse</returns>
        public Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse> GetMatchmakingQueueConfigurationWithHttpInfo(string configurationUuid, string queueUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'configurationUuid' is set
            if (configurationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'configurationUuid' when calling FenrirApi->GetMatchmakingQueueConfiguration");
            }

            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->GetMatchmakingQueueConfiguration");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetMatchmakingQueueConfiguration");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("configuration_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(configurationUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetMatchmakingQueueConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<MatchmakingQueueConfigurationResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configurations/{configuration_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMatchmakingQueueConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieves a matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<MatchmakingQueueConfigurationResponse> GetMatchmakingQueueConfigurationAsync(string configurationUuid, string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse> localVarResponse = await GetMatchmakingQueueConfigurationWithHttpInfoAsync(configurationUuid, queueUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves a matchmaking queue configuration.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationUuid"></param>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationResponse>> GetMatchmakingQueueConfigurationWithHttpInfoAsync(string configurationUuid, string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'configurationUuid' is set
            if (configurationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'configurationUuid' when calling FenrirApi->GetMatchmakingQueueConfiguration");
            }

            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->GetMatchmakingQueueConfiguration");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetMatchmakingQueueConfiguration");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("configuration_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(configurationUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetMatchmakingQueueConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<MatchmakingQueueConfigurationResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configurations/{configuration_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMatchmakingQueueConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists matchmaking queue configurations.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueConfigurationListResponse</returns>
        public MatchmakingQueueConfigurationListResponse GetMatchmakingQueueConfigurations(string queueUuid, string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationListResponse> localVarResponse = GetMatchmakingQueueConfigurationsWithHttpInfo(queueUuid, applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists matchmaking queue configurations.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueConfigurationListResponse</returns>
        public Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationListResponse> GetMatchmakingQueueConfigurationsWithHttpInfo(string queueUuid, string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->GetMatchmakingQueueConfigurations");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetMatchmakingQueueConfigurations");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetMatchmakingQueueConfigurations";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<MatchmakingQueueConfigurationListResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configurations", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMatchmakingQueueConfigurations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists matchmaking queue configurations.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueConfigurationListResponse</returns>
        public async System.Threading.Tasks.Task<MatchmakingQueueConfigurationListResponse> GetMatchmakingQueueConfigurationsAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationListResponse> localVarResponse = await GetMatchmakingQueueConfigurationsWithHttpInfoAsync(queueUuid, applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists matchmaking queue configurations.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueConfigurationListResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<MatchmakingQueueConfigurationListResponse>> GetMatchmakingQueueConfigurationsWithHttpInfoAsync(string queueUuid, string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->GetMatchmakingQueueConfigurations");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetMatchmakingQueueConfigurations");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetMatchmakingQueueConfigurations";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<MatchmakingQueueConfigurationListResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configurations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMatchmakingQueueConfigurations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all matchmaking queues for a given application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueListResponse</returns>
        public MatchmakingQueueListResponse GetMatchmakingQueues(string applicationUuid, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueListResponse> localVarResponse = GetMatchmakingQueuesWithHttpInfo(applicationUuid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all matchmaking queues for a given application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueListResponse</returns>
        public Fenrir.Api.Client.ApiResponse<MatchmakingQueueListResponse> GetMatchmakingQueuesWithHttpInfo(string applicationUuid, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetMatchmakingQueues");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetMatchmakingQueues";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<MatchmakingQueueListResponse>("/applications/{application_uuid}/matchmaking/queues", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMatchmakingQueues", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Lists all matchmaking queues for a given application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueListResponse</returns>
        public async System.Threading.Tasks.Task<MatchmakingQueueListResponse> GetMatchmakingQueuesAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueListResponse> localVarResponse = await GetMatchmakingQueuesWithHttpInfoAsync(applicationUuid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Lists all matchmaking queues for a given application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueListResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<MatchmakingQueueListResponse>> GetMatchmakingQueuesWithHttpInfoAsync(string applicationUuid, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->GetMatchmakingQueues");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter

            localVarRequestOptions.Operation = "FenrirApi.GetMatchmakingQueues";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<MatchmakingQueueListResponse>("/applications/{application_uuid}/matchmaking/queues", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMatchmakingQueues", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Updates an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationResponse</returns>
        public ApplicationResponse UpdateApplication(string applicationUuid, Application application, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<ApplicationResponse> localVarResponse = UpdateApplicationWithHttpInfo(applicationUuid, application);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Updates an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationResponse</returns>
        public Fenrir.Api.Client.ApiResponse<ApplicationResponse> UpdateApplicationWithHttpInfo(string applicationUuid, Application application, int operationIndex = 0)
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->UpdateApplication");
            }

            // verify the required parameter 'application' is set
            if (application == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'application' when calling FenrirApi->UpdateApplication");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = application;

            localVarRequestOptions.Operation = "FenrirApi.UpdateApplication";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<ApplicationResponse>("/applications/{application_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Updates an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationResponse> UpdateApplicationAsync(string applicationUuid, Application application, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<ApplicationResponse> localVarResponse = await UpdateApplicationWithHttpInfoAsync(applicationUuid, application, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Updates an application.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationUuid"></param>
        /// <param name="application"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<ApplicationResponse>> UpdateApplicationWithHttpInfoAsync(string applicationUuid, Application application, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->UpdateApplication");
            }

            // verify the required parameter 'application' is set
            if (application == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'application' when calling FenrirApi->UpdateApplication");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = application;

            localVarRequestOptions.Operation = "FenrirApi.UpdateApplication";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<ApplicationResponse>("/applications/{application_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Updates a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MatchmakingQueueResponse</returns>
        public MatchmakingQueueResponse UpdateMatchmakingQueue(string queueUuid, string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0)
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse> localVarResponse = UpdateMatchmakingQueueWithHttpInfo(queueUuid, applicationUuid, matchmakingQueue);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Updates a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MatchmakingQueueResponse</returns>
        public Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse> UpdateMatchmakingQueueWithHttpInfo(string queueUuid, string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0)
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->UpdateMatchmakingQueue");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->UpdateMatchmakingQueue");
            }

            // verify the required parameter 'matchmakingQueue' is set
            if (matchmakingQueue == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'matchmakingQueue' when calling FenrirApi->UpdateMatchmakingQueue");
            }

            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = matchmakingQueue;

            localVarRequestOptions.Operation = "FenrirApi.UpdateMatchmakingQueue";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<MatchmakingQueueResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateMatchmakingQueue", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Updates a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MatchmakingQueueResponse</returns>
        public async System.Threading.Tasks.Task<MatchmakingQueueResponse> UpdateMatchmakingQueueAsync(string queueUuid, string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse> localVarResponse = await UpdateMatchmakingQueueWithHttpInfoAsync(queueUuid, applicationUuid, matchmakingQueue, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Updates a matchmaking queue.
        /// </summary>
        /// <exception cref="Fenrir.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueUuid"></param>
        /// <param name="applicationUuid"></param>
        /// <param name="matchmakingQueue"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MatchmakingQueueResponse)</returns>
        public async System.Threading.Tasks.Task<Fenrir.Api.Client.ApiResponse<MatchmakingQueueResponse>> UpdateMatchmakingQueueWithHttpInfoAsync(string queueUuid, string applicationUuid, MatchmakingQueue matchmakingQueue, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'queueUuid' is set
            if (queueUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'queueUuid' when calling FenrirApi->UpdateMatchmakingQueue");
            }

            // verify the required parameter 'applicationUuid' is set
            if (applicationUuid == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'applicationUuid' when calling FenrirApi->UpdateMatchmakingQueue");
            }

            // verify the required parameter 'matchmakingQueue' is set
            if (matchmakingQueue == null)
            {
                throw new Fenrir.Api.Client.ApiException(400, "Missing required parameter 'matchmakingQueue' when calling FenrirApi->UpdateMatchmakingQueue");
            }


            Fenrir.Api.Client.RequestOptions localVarRequestOptions = new Fenrir.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fenrir.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fenrir.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queue_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(queueUuid)); // path parameter
            localVarRequestOptions.PathParameters.Add("application_uuid", Fenrir.Api.Client.ClientUtils.ParameterToString(applicationUuid)); // path parameter
            localVarRequestOptions.Data = matchmakingQueue;

            localVarRequestOptions.Operation = "FenrirApi.UpdateMatchmakingQueue";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<MatchmakingQueueResponse>("/applications/{application_uuid}/matchmaking/queues/{queue_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateMatchmakingQueue", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
