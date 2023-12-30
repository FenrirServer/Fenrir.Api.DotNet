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
    /// PortConfiguration
    /// </summary>
    [DataContract(Name = "PortConfiguration")]
    public partial class PortConfiguration : IValidatableObject
    {
        /// <summary>
        /// Protocol. This may be \&quot;tcp\&quot;, \&quot;udp\&quot; or empty for both.
        /// </summary>
        /// <value>Protocol. This may be \&quot;tcp\&quot;, \&quot;udp\&quot; or empty for both.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolEnum
        {
            /// <summary>
            /// Enum Tcp for value: tcp
            /// </summary>
            [EnumMember(Value = "tcp")]
            Tcp = 1,

            /// <summary>
            /// Enum Udp for value: udp
            /// </summary>
            [EnumMember(Value = "udp")]
            Udp = 2,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 3
        }


        /// <summary>
        /// Protocol. This may be \&quot;tcp\&quot;, \&quot;udp\&quot; or empty for both.
        /// </summary>
        /// <value>Protocol. This may be \&quot;tcp\&quot;, \&quot;udp\&quot; or empty for both.</value>
        /// <example>udp</example>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public ProtocolEnum? Protocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortConfiguration" /> class.
        /// </summary>
        /// <param name="portNumber">Port number to expose. (required).</param>
        /// <param name="protocol">Protocol. This may be \&quot;tcp\&quot;, \&quot;udp\&quot; or empty for both..</param>
        public PortConfiguration(int portNumber = default(int), ProtocolEnum? protocol = default(ProtocolEnum?))
        {
            this.PortNumber = portNumber;
            this.Protocol = protocol;
        }

        /// <summary>
        /// Port number to expose.
        /// </summary>
        /// <value>Port number to expose.</value>
        /// <example>27015</example>
        [DataMember(Name = "port_number", IsRequired = true, EmitDefaultValue = true)]
        public int PortNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PortConfiguration {\n");
            sb.Append("  PortNumber: ").Append(PortNumber).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
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
            // PortNumber (int) maximum
            if (this.PortNumber > (int)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortNumber, must be a value less than or equal to 65535.", new [] { "PortNumber" });
            }

            // PortNumber (int) minimum
            if (this.PortNumber < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortNumber, must be a value greater than or equal to 0.", new [] { "PortNumber" });
            }

            yield break;
        }
    }

}
