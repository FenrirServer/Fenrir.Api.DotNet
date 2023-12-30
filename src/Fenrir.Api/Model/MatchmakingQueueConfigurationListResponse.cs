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
    /// MatchmakingQueueConfigurationListResponse
    /// </summary>
    [DataContract(Name = "MatchmakingQueueConfigurationListResponse")]
    public partial class MatchmakingQueueConfigurationListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueueConfigurationListResponse" /> class.
        /// </summary>
        /// <param name="configurations">A list of matchmaking queue configurations..</param>
        public MatchmakingQueueConfigurationListResponse(List<MatchmakingQueueConfiguration> configurations = default(List<MatchmakingQueueConfiguration>))
        {
            this.Configurations = configurations;
        }

        /// <summary>
        /// A list of matchmaking queue configurations.
        /// </summary>
        /// <value>A list of matchmaking queue configurations.</value>
        [DataMember(Name = "configurations", EmitDefaultValue = false)]
        public List<MatchmakingQueueConfiguration> Configurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchmakingQueueConfigurationListResponse {\n");
            sb.Append("  Configurations: ").Append(Configurations).Append("\n");
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
