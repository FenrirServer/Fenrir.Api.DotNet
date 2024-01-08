# Fenrir.Api.Api.FenrirApi

All URIs are relative to *https://api.fenrircloud.com/1.0/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateApiToken**](FenrirApi.md#createapitoken) | **POST** /api_tokens |  |
| [**CreateApplication**](FenrirApi.md#createapplication) | **POST** /applications |  |
| [**CreateApplicationConfiguration**](FenrirApi.md#createapplicationconfiguration) | **POST** /applications/{application_uuid}/configuration |  |
| [**CreateDeployment**](FenrirApi.md#createdeployment) | **POST** /applications/{application_uuid}/deployments |  |
| [**CreateMatchmakingQueue**](FenrirApi.md#creatematchmakingqueue) | **POST** /applications/{application_uuid}/matchmaking/queues |  |
| [**CreateMatchmakingQueueConfiguration**](FenrirApi.md#creatematchmakingqueueconfiguration) | **POST** /applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configuration |  |
| [**DeleteApiToken**](FenrirApi.md#deleteapitoken) | **DELETE** /api_tokens/{token_uuid} |  |
| [**DeleteApplication**](FenrirApi.md#deleteapplication) | **DELETE** /applications/{application_uuid} |  |
| [**DeleteDeployment**](FenrirApi.md#deletedeployment) | **DELETE** /applications/{application_uuid}/deployments/{deployment_uuid} |  |
| [**DeleteMatchmakingQueue**](FenrirApi.md#deletematchmakingqueue) | **DELETE** /applications/{application_uuid}/matchmaking/queues/{queue_uuid} |  |
| [**GetApiToken**](FenrirApi.md#getapitoken) | **GET** /api_tokens/{token_uuid} |  |
| [**GetApiTokens**](FenrirApi.md#getapitokens) | **GET** /api_tokens |  |
| [**GetApplication**](FenrirApi.md#getapplication) | **GET** /applications/{application_uuid} |  |
| [**GetApplicationConfiguration**](FenrirApi.md#getapplicationconfiguration) | **GET** /applications/{application_uuid}/configurations/{configuration_uuid} |  |
| [**GetApplicationConfigurations**](FenrirApi.md#getapplicationconfigurations) | **GET** /applications/{application_uuid}/configurations |  |
| [**GetApplicationStats**](FenrirApi.md#getapplicationstats) | **GET** /applications/{application_uuid}/stats |  |
| [**GetApplications**](FenrirApi.md#getapplications) | **GET** /applications |  |
| [**GetCurrentApplicationConfiguration**](FenrirApi.md#getcurrentapplicationconfiguration) | **GET** /applications/{application_uuid}/configuration |  |
| [**GetCurrentMatchmakingQueueConfiguration**](FenrirApi.md#getcurrentmatchmakingqueueconfiguration) | **GET** /applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configuration |  |
| [**GetDeployment**](FenrirApi.md#getdeployment) | **GET** /applications/{application_uuid}/deployments/{deployment_uuid} |  |
| [**GetDeploymentStats**](FenrirApi.md#getdeploymentstats) | **GET** /applications/{application_uuid}/deployments/{deployment_uuid}/stats |  |
| [**GetDeployments**](FenrirApi.md#getdeployments) | **GET** /applications/{application_uuid}/deployments |  |
| [**GetImages**](FenrirApi.md#getimages) | **GET** /applications/{application_uuid}/images |  |
| [**GetInstance**](FenrirApi.md#getinstance) | **GET** /applications/{application_uuid}/deployments/{deployment_uuid}/instances/{instance_uuid} |  |
| [**GetInstanceLogs**](FenrirApi.md#getinstancelogs) | **GET** /applications/{application_uuid}/deployments/{deployment_uuid}/instances/{instance_uuid}/logs |  |
| [**GetInstanceLogsPreview**](FenrirApi.md#getinstancelogspreview) | **GET** /applications/{application_uuid}/deployments/{deployment_uuid}/instances/{instance_uuid}/logs/preview |  |
| [**GetInstances**](FenrirApi.md#getinstances) | **GET** /applications/{application_uuid}/deployments/{deployment_uuid}/instances |  |
| [**GetMatchmakingQueue**](FenrirApi.md#getmatchmakingqueue) | **GET** /applications/{application_uuid}/matchmaking/queues/{queue_uuid} |  |
| [**GetMatchmakingQueueConfiguration**](FenrirApi.md#getmatchmakingqueueconfiguration) | **GET** /applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configurations/{configuration_uuid} |  |
| [**GetMatchmakingQueueConfigurations**](FenrirApi.md#getmatchmakingqueueconfigurations) | **GET** /applications/{application_uuid}/matchmaking/queues/{queue_uuid}/configurations |  |
| [**GetMatchmakingQueues**](FenrirApi.md#getmatchmakingqueues) | **GET** /applications/{application_uuid}/matchmaking/queues |  |
| [**UpdateApplication**](FenrirApi.md#updateapplication) | **PUT** /applications/{application_uuid} |  |
| [**UpdateMatchmakingQueue**](FenrirApi.md#updatematchmakingqueue) | **PUT** /applications/{application_uuid}/matchmaking/queues/{queue_uuid} |  |

<a id="createapitoken"></a>
# **CreateApiToken**
> ApiTokenResponse CreateApiToken (ApiToken apiToken)



Creates a new API token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class CreateApiTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var apiToken = new ApiToken(); // ApiToken | 

            try
            {
                ApiTokenResponse result = apiInstance.CreateApiToken(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.CreateApiToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateApiTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiTokenResponse> response = apiInstance.CreateApiTokenWithHttpInfo(apiToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.CreateApiTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiToken** | [**ApiToken**](ApiToken.md) |  |  |

### Return type

[**ApiTokenResponse**](ApiTokenResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **400** | Bad request syntax or unsupported method |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createapplication"></a>
# **CreateApplication**
> ApplicationResponse CreateApplication (Application application)



Creates a new application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class CreateApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var application = new Application(); // Application | 

            try
            {
                ApplicationResponse result = apiInstance.CreateApplication(application);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.CreateApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationResponse> response = apiInstance.CreateApplicationWithHttpInfo(application);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.CreateApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **application** | [**Application**](Application.md) |  |  |

### Return type

[**ApplicationResponse**](ApplicationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **400** | Bad request syntax or unsupported method |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createapplicationconfiguration"></a>
# **CreateApplicationConfiguration**
> ApplicationConfigurationResponse CreateApplicationConfiguration (string applicationUuid, ApplicationConfiguration applicationConfiguration)



Creates an application configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class CreateApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 
            var applicationConfiguration = new ApplicationConfiguration(); // ApplicationConfiguration | 

            try
            {
                ApplicationConfigurationResponse result = apiInstance.CreateApplicationConfiguration(applicationUuid, applicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.CreateApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationConfigurationResponse> response = apiInstance.CreateApplicationConfigurationWithHttpInfo(applicationUuid, applicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.CreateApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |
| **applicationConfiguration** | [**ApplicationConfiguration**](ApplicationConfiguration.md) |  |  |

### Return type

[**ApplicationConfigurationResponse**](ApplicationConfigurationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **400** | Bad request syntax or unsupported method |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createdeployment"></a>
# **CreateDeployment**
> DeploymentResponse CreateDeployment (string applicationUuid, Deployment deployment)



Crates a new application deployment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class CreateDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 
            var deployment = new Deployment(); // Deployment | 

            try
            {
                DeploymentResponse result = apiInstance.CreateDeployment(applicationUuid, deployment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.CreateDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeploymentResponse> response = apiInstance.CreateDeploymentWithHttpInfo(applicationUuid, deployment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.CreateDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |
| **deployment** | [**Deployment**](Deployment.md) |  |  |

### Return type

[**DeploymentResponse**](DeploymentResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **400** | Bad request syntax or unsupported method |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="creatematchmakingqueue"></a>
# **CreateMatchmakingQueue**
> MatchmakingQueueResponse CreateMatchmakingQueue (string applicationUuid, MatchmakingQueue matchmakingQueue)



Creates a new matchmaking queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class CreateMatchmakingQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 
            var matchmakingQueue = new MatchmakingQueue(); // MatchmakingQueue | 

            try
            {
                MatchmakingQueueResponse result = apiInstance.CreateMatchmakingQueue(applicationUuid, matchmakingQueue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.CreateMatchmakingQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMatchmakingQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MatchmakingQueueResponse> response = apiInstance.CreateMatchmakingQueueWithHttpInfo(applicationUuid, matchmakingQueue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.CreateMatchmakingQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |
| **matchmakingQueue** | [**MatchmakingQueue**](MatchmakingQueue.md) |  |  |

### Return type

[**MatchmakingQueueResponse**](MatchmakingQueueResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **400** | Bad request syntax or unsupported method |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="creatematchmakingqueueconfiguration"></a>
# **CreateMatchmakingQueueConfiguration**
> MatchmakingQueueConfigurationResponse CreateMatchmakingQueueConfiguration (string queueUuid, string applicationUuid, MatchmakingQueueConfiguration matchmakingQueueConfiguration)



Creates a new matchmaking queue configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class CreateMatchmakingQueueConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var queueUuid = "queueUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 
            var matchmakingQueueConfiguration = new MatchmakingQueueConfiguration(); // MatchmakingQueueConfiguration | 

            try
            {
                MatchmakingQueueConfigurationResponse result = apiInstance.CreateMatchmakingQueueConfiguration(queueUuid, applicationUuid, matchmakingQueueConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.CreateMatchmakingQueueConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMatchmakingQueueConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MatchmakingQueueConfigurationResponse> response = apiInstance.CreateMatchmakingQueueConfigurationWithHttpInfo(queueUuid, applicationUuid, matchmakingQueueConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.CreateMatchmakingQueueConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queueUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |
| **matchmakingQueueConfiguration** | [**MatchmakingQueueConfiguration**](MatchmakingQueueConfiguration.md) |  |  |

### Return type

[**MatchmakingQueueConfigurationResponse**](MatchmakingQueueConfigurationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **400** | Bad request syntax or unsupported method |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteapitoken"></a>
# **DeleteApiToken**
> Response DeleteApiToken (string tokenUuid)



Deletes an API token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class DeleteApiTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var tokenUuid = "tokenUuid_example";  // string | 

            try
            {
                Response result = apiInstance.DeleteApiToken(tokenUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.DeleteApiToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteApiTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Response> response = apiInstance.DeleteApiTokenWithHttpInfo(tokenUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.DeleteApiTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tokenUuid** | **string** |  |  |

### Return type

[**Response**](Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request fulfilled, nothing follows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteapplication"></a>
# **DeleteApplication**
> Response DeleteApplication (string applicationUuid)



Deletes an application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class DeleteApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                Response result = apiInstance.DeleteApplication(applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.DeleteApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Response> response = apiInstance.DeleteApplicationWithHttpInfo(applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.DeleteApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |

### Return type

[**Response**](Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request fulfilled, nothing follows |  -  |
| **400** | Bad request syntax or unsupported method |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletedeployment"></a>
# **DeleteDeployment**
> Response DeleteDeployment (string deploymentUuid, string applicationUuid)



Deletes an application deployment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class DeleteDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var deploymentUuid = "deploymentUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                Response result = apiInstance.DeleteDeployment(deploymentUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.DeleteDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Response> response = apiInstance.DeleteDeploymentWithHttpInfo(deploymentUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.DeleteDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**Response**](Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request fulfilled, nothing follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletematchmakingqueue"></a>
# **DeleteMatchmakingQueue**
> Response DeleteMatchmakingQueue (string queueUuid, string applicationUuid)



Deletes a matchmaking queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class DeleteMatchmakingQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var queueUuid = "queueUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                Response result = apiInstance.DeleteMatchmakingQueue(queueUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.DeleteMatchmakingQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMatchmakingQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Response> response = apiInstance.DeleteMatchmakingQueueWithHttpInfo(queueUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.DeleteMatchmakingQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queueUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**Response**](Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request fulfilled, nothing follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapitoken"></a>
# **GetApiToken**
> ApiTokenListResponse GetApiToken (string tokenUuid)



Retrieves an API token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetApiTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var tokenUuid = "tokenUuid_example";  // string | 

            try
            {
                ApiTokenListResponse result = apiInstance.GetApiToken(tokenUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetApiToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApiTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiTokenListResponse> response = apiInstance.GetApiTokenWithHttpInfo(tokenUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetApiTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tokenUuid** | **string** |  |  |

### Return type

[**ApiTokenListResponse**](ApiTokenListResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapitokens"></a>
# **GetApiTokens**
> ApiTokenListResponse GetApiTokens ()



Lists all API tokens on your account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetApiTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);

            try
            {
                ApiTokenListResponse result = apiInstance.GetApiTokens();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetApiTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApiTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiTokenListResponse> response = apiInstance.GetApiTokensWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetApiTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ApiTokenListResponse**](ApiTokenListResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapplication"></a>
# **GetApplication**
> ApplicationResponse GetApplication (string applicationUuid)



Retrieves an application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                ApplicationResponse result = apiInstance.GetApplication(applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationResponse> response = apiInstance.GetApplicationWithHttpInfo(applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |

### Return type

[**ApplicationResponse**](ApplicationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapplicationconfiguration"></a>
# **GetApplicationConfiguration**
> ApplicationConfigurationResponse GetApplicationConfiguration (string configurationUuid, string applicationUuid)



Retrieves an application configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var configurationUuid = "configurationUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                ApplicationConfigurationResponse result = apiInstance.GetApplicationConfiguration(configurationUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationConfigurationResponse> response = apiInstance.GetApplicationConfigurationWithHttpInfo(configurationUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**ApplicationConfigurationResponse**](ApplicationConfigurationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapplicationconfigurations"></a>
# **GetApplicationConfigurations**
> ApplicationConfigurationListResponse GetApplicationConfigurations (string applicationUuid)



Lists all application configurations ever created.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetApplicationConfigurationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                ApplicationConfigurationListResponse result = apiInstance.GetApplicationConfigurations(applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetApplicationConfigurations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationConfigurationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationConfigurationListResponse> response = apiInstance.GetApplicationConfigurationsWithHttpInfo(applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetApplicationConfigurationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |

### Return type

[**ApplicationConfigurationListResponse**](ApplicationConfigurationListResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapplicationstats"></a>
# **GetApplicationStats**
> ApplicationStatsResponse GetApplicationStats (string applicationUuid, List<string> filter = null)



Retrieves application stats.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetApplicationStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 
            var filter = new List<string>(); // List<string> |  (optional) 

            try
            {
                ApplicationStatsResponse result = apiInstance.GetApplicationStats(applicationUuid, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetApplicationStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationStatsResponse> response = apiInstance.GetApplicationStatsWithHttpInfo(applicationUuid, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetApplicationStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |
| **filter** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**ApplicationStatsResponse**](ApplicationStatsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapplications"></a>
# **GetApplications**
> ApplicationListResponse GetApplications ()



Lists all applications on your account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);

            try
            {
                ApplicationListResponse result = apiInstance.GetApplications();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetApplications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationListResponse> response = apiInstance.GetApplicationsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetApplicationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ApplicationListResponse**](ApplicationListResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcurrentapplicationconfiguration"></a>
# **GetCurrentApplicationConfiguration**
> ApplicationConfigurationResponse GetCurrentApplicationConfiguration (string applicationUuid)



Retrieves current application configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetCurrentApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                ApplicationConfigurationResponse result = apiInstance.GetCurrentApplicationConfiguration(applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetCurrentApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationConfigurationResponse> response = apiInstance.GetCurrentApplicationConfigurationWithHttpInfo(applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetCurrentApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |

### Return type

[**ApplicationConfigurationResponse**](ApplicationConfigurationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcurrentmatchmakingqueueconfiguration"></a>
# **GetCurrentMatchmakingQueueConfiguration**
> MatchmakingQueueConfigurationResponse GetCurrentMatchmakingQueueConfiguration (string queueUuid, string applicationUuid)



Retrieves current matchmaking queue configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetCurrentMatchmakingQueueConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var queueUuid = "queueUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                MatchmakingQueueConfigurationResponse result = apiInstance.GetCurrentMatchmakingQueueConfiguration(queueUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetCurrentMatchmakingQueueConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentMatchmakingQueueConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MatchmakingQueueConfigurationResponse> response = apiInstance.GetCurrentMatchmakingQueueConfigurationWithHttpInfo(queueUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetCurrentMatchmakingQueueConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queueUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**MatchmakingQueueConfigurationResponse**](MatchmakingQueueConfigurationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdeployment"></a>
# **GetDeployment**
> DeploymentResponse GetDeployment (string deploymentUuid, string applicationUuid)



Retrieves an application deployment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var deploymentUuid = "deploymentUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                DeploymentResponse result = apiInstance.GetDeployment(deploymentUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeploymentResponse> response = apiInstance.GetDeploymentWithHttpInfo(deploymentUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**DeploymentResponse**](DeploymentResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdeploymentstats"></a>
# **GetDeploymentStats**
> DeploymentStatsResponse GetDeploymentStats (string deploymentUuid, string applicationUuid, List<string> filter = null)



Retrieves deployment stats.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetDeploymentStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var deploymentUuid = "deploymentUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 
            var filter = new List<string>(); // List<string> |  (optional) 

            try
            {
                DeploymentStatsResponse result = apiInstance.GetDeploymentStats(deploymentUuid, applicationUuid, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetDeploymentStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeploymentStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeploymentStatsResponse> response = apiInstance.GetDeploymentStatsWithHttpInfo(deploymentUuid, applicationUuid, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetDeploymentStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |
| **filter** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**DeploymentStatsResponse**](DeploymentStatsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdeployments"></a>
# **GetDeployments**
> DeploymentListResponse GetDeployments (string applicationUuid)



Lists all application deployments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetDeploymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                DeploymentListResponse result = apiInstance.GetDeployments(applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetDeployments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeploymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeploymentListResponse> response = apiInstance.GetDeploymentsWithHttpInfo(applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetDeploymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |

### Return type

[**DeploymentListResponse**](DeploymentListResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getimages"></a>
# **GetImages**
> ImageListResponse GetImages (string applicationUuid)



Lists all application images.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetImagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                ImageListResponse result = apiInstance.GetImages(applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetImages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetImagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ImageListResponse> response = apiInstance.GetImagesWithHttpInfo(applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetImagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |

### Return type

[**ImageListResponse**](ImageListResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinstance"></a>
# **GetInstance**
> ApplicationInstanceResponse GetInstance (string deploymentUuid, string instanceUuid, string applicationUuid)



Retrieves an application instance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var deploymentUuid = "deploymentUuid_example";  // string | 
            var instanceUuid = "instanceUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                ApplicationInstanceResponse result = apiInstance.GetInstance(deploymentUuid, instanceUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationInstanceResponse> response = apiInstance.GetInstanceWithHttpInfo(deploymentUuid, instanceUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentUuid** | **string** |  |  |
| **instanceUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**ApplicationInstanceResponse**](ApplicationInstanceResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinstancelogs"></a>
# **GetInstanceLogs**
> InstanceLogs GetInstanceLogs (string deploymentUuid, string instanceUuid, string applicationUuid)



Retrieves application instance logs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetInstanceLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var deploymentUuid = "deploymentUuid_example";  // string | 
            var instanceUuid = "instanceUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                InstanceLogs result = apiInstance.GetInstanceLogs(deploymentUuid, instanceUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetInstanceLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstanceLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InstanceLogs> response = apiInstance.GetInstanceLogsWithHttpInfo(deploymentUuid, instanceUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetInstanceLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentUuid** | **string** |  |  |
| **instanceUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**InstanceLogs**](InstanceLogs.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinstancelogspreview"></a>
# **GetInstanceLogsPreview**
> InstanceLogsPreview GetInstanceLogsPreview (string deploymentUuid, string instanceUuid, string applicationUuid)



Retrieves a small number of most recent application instance logs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetInstanceLogsPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var deploymentUuid = "deploymentUuid_example";  // string | 
            var instanceUuid = "instanceUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                InstanceLogsPreview result = apiInstance.GetInstanceLogsPreview(deploymentUuid, instanceUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetInstanceLogsPreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstanceLogsPreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InstanceLogsPreview> response = apiInstance.GetInstanceLogsPreviewWithHttpInfo(deploymentUuid, instanceUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetInstanceLogsPreviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentUuid** | **string** |  |  |
| **instanceUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**InstanceLogsPreview**](InstanceLogsPreview.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinstances"></a>
# **GetInstances**
> ApplicationInstanceListResponse GetInstances (string deploymentUuid, string applicationUuid)



Lists all application instances for a given deployment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var deploymentUuid = "deploymentUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                ApplicationInstanceListResponse result = apiInstance.GetInstances(deploymentUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetInstances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationInstanceListResponse> response = apiInstance.GetInstancesWithHttpInfo(deploymentUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetInstancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**ApplicationInstanceListResponse**](ApplicationInstanceListResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmatchmakingqueue"></a>
# **GetMatchmakingQueue**
> MatchmakingQueueResponse GetMatchmakingQueue (string queueUuid, string applicationUuid)



Retrieves a matchmaking queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetMatchmakingQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var queueUuid = "queueUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                MatchmakingQueueResponse result = apiInstance.GetMatchmakingQueue(queueUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetMatchmakingQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMatchmakingQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MatchmakingQueueResponse> response = apiInstance.GetMatchmakingQueueWithHttpInfo(queueUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetMatchmakingQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queueUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**MatchmakingQueueResponse**](MatchmakingQueueResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmatchmakingqueueconfiguration"></a>
# **GetMatchmakingQueueConfiguration**
> MatchmakingQueueConfigurationResponse GetMatchmakingQueueConfiguration (string configurationUuid, string queueUuid, string applicationUuid)



Retrieves a matchmaking queue configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetMatchmakingQueueConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var configurationUuid = "configurationUuid_example";  // string | 
            var queueUuid = "queueUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                MatchmakingQueueConfigurationResponse result = apiInstance.GetMatchmakingQueueConfiguration(configurationUuid, queueUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetMatchmakingQueueConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMatchmakingQueueConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MatchmakingQueueConfigurationResponse> response = apiInstance.GetMatchmakingQueueConfigurationWithHttpInfo(configurationUuid, queueUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetMatchmakingQueueConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationUuid** | **string** |  |  |
| **queueUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**MatchmakingQueueConfigurationResponse**](MatchmakingQueueConfigurationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmatchmakingqueueconfigurations"></a>
# **GetMatchmakingQueueConfigurations**
> MatchmakingQueueConfigurationListResponse GetMatchmakingQueueConfigurations (string queueUuid, string applicationUuid)



Lists matchmaking queue configurations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetMatchmakingQueueConfigurationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var queueUuid = "queueUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                MatchmakingQueueConfigurationListResponse result = apiInstance.GetMatchmakingQueueConfigurations(queueUuid, applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetMatchmakingQueueConfigurations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMatchmakingQueueConfigurationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MatchmakingQueueConfigurationListResponse> response = apiInstance.GetMatchmakingQueueConfigurationsWithHttpInfo(queueUuid, applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetMatchmakingQueueConfigurationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queueUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |

### Return type

[**MatchmakingQueueConfigurationListResponse**](MatchmakingQueueConfigurationListResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmatchmakingqueues"></a>
# **GetMatchmakingQueues**
> MatchmakingQueueListResponse GetMatchmakingQueues (string applicationUuid)



Lists all matchmaking queues for a given application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class GetMatchmakingQueuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 

            try
            {
                MatchmakingQueueListResponse result = apiInstance.GetMatchmakingQueues(applicationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.GetMatchmakingQueues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMatchmakingQueuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MatchmakingQueueListResponse> response = apiInstance.GetMatchmakingQueuesWithHttpInfo(applicationUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.GetMatchmakingQueuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |

### Return type

[**MatchmakingQueueListResponse**](MatchmakingQueueListResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateapplication"></a>
# **UpdateApplication**
> ApplicationResponse UpdateApplication (string applicationUuid, Application application)



Updates an application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class UpdateApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var applicationUuid = "applicationUuid_example";  // string | 
            var application = new Application(); // Application | 

            try
            {
                ApplicationResponse result = apiInstance.UpdateApplication(applicationUuid, application);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.UpdateApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApplicationResponse> response = apiInstance.UpdateApplicationWithHttpInfo(applicationUuid, application);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.UpdateApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationUuid** | **string** |  |  |
| **application** | [**Application**](Application.md) |  |  |

### Return type

[**ApplicationResponse**](ApplicationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **400** | Bad request syntax or unsupported method |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatematchmakingqueue"></a>
# **UpdateMatchmakingQueue**
> MatchmakingQueueResponse UpdateMatchmakingQueue (string queueUuid, string applicationUuid, MatchmakingQueue matchmakingQueue)



Updates a matchmaking queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fenrir.Api.Api;
using Fenrir.Api.Client;
using Fenrir.Api.Model;

namespace Example
{
    public class UpdateMatchmakingQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fenrircloud.com/1.0/api";
            // Configure Bearer token for authorization: ApiKeyAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FenrirApi(config);
            var queueUuid = "queueUuid_example";  // string | 
            var applicationUuid = "applicationUuid_example";  // string | 
            var matchmakingQueue = new MatchmakingQueue(); // MatchmakingQueue | 

            try
            {
                MatchmakingQueueResponse result = apiInstance.UpdateMatchmakingQueue(queueUuid, applicationUuid, matchmakingQueue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FenrirApi.UpdateMatchmakingQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMatchmakingQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MatchmakingQueueResponse> response = apiInstance.UpdateMatchmakingQueueWithHttpInfo(queueUuid, applicationUuid, matchmakingQueue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FenrirApi.UpdateMatchmakingQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queueUuid** | **string** |  |  |
| **applicationUuid** | **string** |  |  |
| **matchmakingQueue** | [**MatchmakingQueue**](MatchmakingQueue.md) |  |  |

### Return type

[**MatchmakingQueueResponse**](MatchmakingQueueResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request fulfilled, document follows |  -  |
| **400** | Bad request syntax or unsupported method |  -  |
| **404** | Nothing matches the given URI |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

