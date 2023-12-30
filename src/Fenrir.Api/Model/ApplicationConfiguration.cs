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
    /// ApplicationConfiguration
    /// </summary>
    [DataContract(Name = "ApplicationConfiguration")]
    public partial class ApplicationConfiguration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationConfiguration" /> class.
        /// </summary>
        /// <param name="maxInstances">Maximum number of instances. (required).</param>
        /// <param name="minInstances">Minimum number of instances. (required).</param>
        /// <param name="ports">Ports used by the application..</param>
        public ApplicationConfiguration(int maxInstances = default(int), int minInstances = default(int), List<PortConfiguration> ports = default(List<PortConfiguration>))
        {
            this.MaxInstances = maxInstances;
            this.MinInstances = minInstances;
            this.Ports = ports;
        }

        /// <summary>
        /// A uuid of the application this configuration is for.
        /// </summary>
        /// <value>A uuid of the application this configuration is for.</value>
        /// <example>df345e3497b14f2ca1ecd8c160131d7a</example>
        [DataMember(Name = "application_uuid", EmitDefaultValue = false)]
        public string ApplicationUuid { get; private set; }

        /// <summary>
        /// Returns false as ApplicationUuid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApplicationUuid()
        {
            return false;
        }
        /// <summary>
        /// Time when the configuration was created.
        /// </summary>
        /// <value>Time when the configuration was created.</value>
        /// <example>2024-01-22T19:28:42Z</example>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// Maximum number of instances.
        /// </summary>
        /// <value>Maximum number of instances.</value>
        /// <example>5</example>
        [DataMember(Name = "max_instances", IsRequired = true, EmitDefaultValue = true)]
        public int MaxInstances { get; set; }

        /// <summary>
        /// Minimum number of instances.
        /// </summary>
        /// <value>Minimum number of instances.</value>
        /// <example>1</example>
        [DataMember(Name = "min_instances", IsRequired = true, EmitDefaultValue = true)]
        public int MinInstances { get; set; }

        /// <summary>
        /// Ports used by the application.
        /// </summary>
        /// <value>Ports used by the application.</value>
        [DataMember(Name = "ports", EmitDefaultValue = false)]
        public List<PortConfiguration> Ports { get; set; }

        /// <summary>
        /// Time when the configuration was last updated.
        /// </summary>
        /// <value>Time when the configuration was last updated.</value>
        /// <example>2024-01-22T19:28:42Z</example>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public DateTime Updated { get; private set; }

        /// <summary>
        /// Returns false as Updated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdated()
        {
            return false;
        }
        /// <summary>
        /// A unique id of this application configuration.
        /// </summary>
        /// <value>A unique id of this application configuration.</value>
        /// <example>4a56d881916b48ac96e49e448f92f829</example>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Returns false as Uuid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUuid()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationConfiguration {\n");
            sb.Append("  ApplicationUuid: ").Append(ApplicationUuid).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  MaxInstances: ").Append(MaxInstances).Append("\n");
            sb.Append("  MinInstances: ").Append(MinInstances).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            // MaxInstances (int) minimum
            if (this.MaxInstances < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxInstances, must be a value greater than or equal to 1.", new [] { "MaxInstances" });
            }

            // MinInstances (int) maximum
            if (this.MinInstances > (int)50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinInstances, must be a value less than or equal to 50.", new [] { "MinInstances" });
            }

            // MinInstances (int) minimum
            if (this.MinInstances < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinInstances, must be a value greater than or equal to 1.", new [] { "MinInstances" });
            }

            yield break;
        }
    }

}
