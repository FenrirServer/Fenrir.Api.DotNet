/*
 * Fenrir Api
 * 
 * This file was automatically generated using openapi generator. 
 * DO NOT EDIT MANUALLY.
 * Refer to: https://github.com/FenrirServer/Cloud.SdkTemplates
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Fenrir.Api.Client.OpenAPIDateConverter;

namespace Fenrir.Api.Model
{
    /// <summary>
    /// ApiTokenListResponse
    /// </summary>
    [DataContract(Name = "ApiTokenListResponse")]
    public partial class ApiTokenListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenListResponse" /> class.
        /// </summary>
        /// <param name="apiTokens">A list of API tokens.</param>
        public ApiTokenListResponse(List<ApiToken> apiTokens = default(List<ApiToken>))
        {
            this.ApiTokens = apiTokens;
        }

        /// <summary>
        /// A list of API tokens
        /// </summary>
        /// <value>A list of API tokens</value>
        [DataMember(Name = "api_tokens", EmitDefaultValue = false)]
        public List<ApiToken> ApiTokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiTokenListResponse {\n");
            sb.Append("  ApiTokens: ").Append(ApiTokens).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
