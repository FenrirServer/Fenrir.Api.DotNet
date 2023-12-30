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
    /// ApplicationInstancePort
    /// </summary>
    [DataContract(Name = "ApplicationInstancePort")]
    public partial class ApplicationInstancePort : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInstancePort" /> class.
        /// </summary>
        /// <param name="protocol">A protocol of the port. May be \&quot;tcp\&quot;, \&quot;udp\&quot; or empty if both..</param>
        /// <param name="publishedPort">A published port of the container. This is the port exposed from the external network..</param>
        /// <param name="targetPort">A target port on the container..</param>
        public ApplicationInstancePort(string protocol = default(string), int publishedPort = default(int), int targetPort = default(int))
        {
            this.Protocol = protocol;
            this.PublishedPort = publishedPort;
            this.TargetPort = targetPort;
        }

        /// <summary>
        /// A protocol of the port. May be \&quot;tcp\&quot;, \&quot;udp\&quot; or empty if both.
        /// </summary>
        /// <value>A protocol of the port. May be \&quot;tcp\&quot;, \&quot;udp\&quot; or empty if both.</value>
        /// <example>udp</example>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public string Protocol { get; set; }

        /// <summary>
        /// A published port of the container. This is the port exposed from the external network.
        /// </summary>
        /// <value>A published port of the container. This is the port exposed from the external network.</value>
        /// <example>27012</example>
        [DataMember(Name = "published_port", EmitDefaultValue = false)]
        public int PublishedPort { get; set; }

        /// <summary>
        /// A target port on the container.
        /// </summary>
        /// <value>A target port on the container.</value>
        /// <example>27000</example>
        [DataMember(Name = "target_port", EmitDefaultValue = false)]
        public int TargetPort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationInstancePort {\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  PublishedPort: ").Append(PublishedPort).Append("\n");
            sb.Append("  TargetPort: ").Append(TargetPort).Append("\n");
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
