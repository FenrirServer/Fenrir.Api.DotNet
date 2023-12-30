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
    /// ApplicationInstanceStats
    /// </summary>
    [DataContract(Name = "ApplicationInstanceStats")]
    public partial class ApplicationInstanceStats : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInstanceStats" /> class.
        /// </summary>
        /// <param name="ccu">A number of players connected to this instance..</param>
        /// <param name="cpu">CPU utilization by this instance..</param>
        /// <param name="mem">Memory used by this instance, in megabytes..</param>
        public ApplicationInstanceStats(int ccu = default(int), decimal cpu = default(decimal), decimal mem = default(decimal))
        {
            this.Ccu = ccu;
            this.Cpu = cpu;
            this.Mem = mem;
        }

        /// <summary>
        /// A number of players connected to this instance.
        /// </summary>
        /// <value>A number of players connected to this instance.</value>
        /// <example>50</example>
        [DataMember(Name = "ccu", EmitDefaultValue = false)]
        public int Ccu { get; set; }

        /// <summary>
        /// CPU utilization by this instance.
        /// </summary>
        /// <value>CPU utilization by this instance.</value>
        /// <example>55.5</example>
        [DataMember(Name = "cpu", EmitDefaultValue = false)]
        public decimal Cpu { get; set; }

        /// <summary>
        /// Memory used by this instance, in megabytes.
        /// </summary>
        /// <value>Memory used by this instance, in megabytes.</value>
        /// <example>25</example>
        [DataMember(Name = "mem", EmitDefaultValue = false)]
        public decimal Mem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationInstanceStats {\n");
            sb.Append("  Ccu: ").Append(Ccu).Append("\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Mem: ").Append(Mem).Append("\n");
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
