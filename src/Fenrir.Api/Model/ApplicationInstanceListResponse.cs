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
    /// ApplicationInstanceListResponse
    /// </summary>
    [DataContract(Name = "ApplicationInstanceListResponse")]
    public partial class ApplicationInstanceListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInstanceListResponse" /> class.
        /// </summary>
        /// <param name="instances">A list of application instances..</param>
        public ApplicationInstanceListResponse(List<ApplicationInstance> instances = default(List<ApplicationInstance>))
        {
            this.Instances = instances;
        }

        /// <summary>
        /// A list of application instances.
        /// </summary>
        /// <value>A list of application instances.</value>
        [DataMember(Name = "instances", EmitDefaultValue = false)]
        public List<ApplicationInstance> Instances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationInstanceListResponse {\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
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
