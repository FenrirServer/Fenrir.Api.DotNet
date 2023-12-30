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
    /// Deployment
    /// </summary>
    [DataContract(Name = "Deployment")]
    public partial class Deployment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Deployment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment" /> class.
        /// </summary>
        /// <param name="imageTag">An image tag for your application. Possible image tags can be obtained by calling \&quot;GET /application/&lt;application_uuid&gt;/images\&quot; endpoint (required).</param>
        /// <param name="label">A label for your deployment (required).</param>
        public Deployment(string imageTag = default(string), string label = default(string))
        {
            // to ensure "imageTag" is required (not null)
            if (imageTag == null)
            {
                throw new ArgumentNullException("imageTag is a required property for Deployment and cannot be null");
            }
            this.ImageTag = imageTag;
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for Deployment and cannot be null");
            }
            this.Label = label;
        }

        /// <summary>
        /// A uuid of the application this deployment is for.
        /// </summary>
        /// <value>A uuid of the application this deployment is for.</value>
        /// <example>ac9fc73a152e4e10b87a1ad8a87f02cb</example>
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
        /// A uuid of the current application configuration.
        /// </summary>
        /// <value>A uuid of the current application configuration.</value>
        /// <example>f9821542d679488f87085cd74d2472cd</example>
        [DataMember(Name = "configuration_uuid", EmitDefaultValue = false)]
        public string ConfigurationUuid { get; private set; }

        /// <summary>
        /// Returns false as ConfigurationUuid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConfigurationUuid()
        {
            return false;
        }
        /// <summary>
        /// Time when the deployment was created.
        /// </summary>
        /// <value>Time when the deployment was created.</value>
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
        /// An image tag for your application. Possible image tags can be obtained by calling \&quot;GET /application/&lt;application_uuid&gt;/images\&quot; endpoint
        /// </summary>
        /// <value>An image tag for your application. Possible image tags can be obtained by calling \&quot;GET /application/&lt;application_uuid&gt;/images\&quot; endpoint</value>
        /// <example>1.0.0</example>
        [DataMember(Name = "image_tag", IsRequired = true, EmitDefaultValue = true)]
        public string ImageTag { get; set; }

        /// <summary>
        /// A label for your deployment
        /// </summary>
        /// <value>A label for your deployment</value>
        /// <example>production</example>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Time when the deployment was last updated.
        /// </summary>
        /// <value>Time when the deployment was last updated.</value>
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
        /// A unique id of the deployment.
        /// </summary>
        /// <value>A unique id of the deployment.</value>
        /// <example>e1bee97c79ac454bb8bcb81d37ec7e46</example>
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
            sb.Append("class Deployment {\n");
            sb.Append("  ApplicationUuid: ").Append(ApplicationUuid).Append("\n");
            sb.Append("  ConfigurationUuid: ").Append(ConfigurationUuid).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ImageTag: ").Append(ImageTag).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            // ImageTag (string) maxLength
            if (this.ImageTag != null && this.ImageTag.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageTag, length must be less than 128.", new [] { "ImageTag" });
            }

            // ImageTag (string) minLength
            if (this.ImageTag != null && this.ImageTag.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageTag, length must be greater than 1.", new [] { "ImageTag" });
            }

            // Label (string) maxLength
            if (this.Label != null && this.Label.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Label, length must be less than 128.", new [] { "Label" });
            }

            // Label (string) minLength
            if (this.Label != null && this.Label.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Label, length must be greater than 1.", new [] { "Label" });
            }

            yield break;
        }
    }

}
