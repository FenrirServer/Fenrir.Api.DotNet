/*
 * Fenrir Api
 * 
 * This file was automatically generated using openapi generator. 
 * DO NOT EDIT MANUALLY.
 * Refer to: https://github.com/FenrirServer/Cloud.SdkTemplates
 */


using Polly;
using RestSharp;

namespace Fenrir.Api.Client
{
    /// <summary>
    /// Configuration class to set the polly retry policies to be applied to the requests.
    /// </summary>
    public static class RetryConfiguration
    {
        /// <summary>
        /// Retry policy
        /// </summary>
        public static Policy<RestResponse> RetryPolicy { get; set; }

        /// <summary>
        /// Async retry policy
        /// </summary>
        public static AsyncPolicy<RestResponse> AsyncRetryPolicy { get; set; }
    }
}
