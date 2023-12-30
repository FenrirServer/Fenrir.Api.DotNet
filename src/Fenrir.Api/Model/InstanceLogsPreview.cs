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
    /// InstanceLogsPreview
    /// </summary>
    [DataContract(Name = "InstanceLogsPreview")]
    public partial class InstanceLogsPreview : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceLogsPreview" /> class.
        /// </summary>
        /// <param name="logLines">Most recent log lines..</param>
        public InstanceLogsPreview(List<string> logLines = default(List<string>))
        {
            this.LogLines = logLines;
        }

        /// <summary>
        /// Most recent log lines.
        /// </summary>
        /// <value>Most recent log lines.</value>
        /// <example>[&quot;2023-12-05T02:40:26.014317355Z 2023/12/05 02:40:26 [Info] Application started.&quot;,&quot;2023-12-05T02:40:26.014311573Z 2023/12/05 02:40:26 [Debug] Player connected&quot;]</example>
        [DataMember(Name = "log_lines", EmitDefaultValue = false)]
        public List<string> LogLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstanceLogsPreview {\n");
            sb.Append("  LogLines: ").Append(LogLines).Append("\n");
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
