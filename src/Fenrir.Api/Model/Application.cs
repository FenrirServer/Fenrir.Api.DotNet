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
    /// Application
    /// </summary>
    [DataContract(Name = "Application")]
    public partial class Application : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Application() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        /// <param name="varConfiguration">Initial configuration of the application. (required).</param>
        /// <param name="name">A unique name of the application. (required).</param>
        public Application(ApplicationConfiguration varConfiguration = default(ApplicationConfiguration), string name = default(string))
        {
            // to ensure "varConfiguration" is required (not null)
            if (varConfiguration == null)
            {
                throw new ArgumentNullException("varConfiguration is a required property for Application and cannot be null");
            }
            this.VarConfiguration = varConfiguration;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Application and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// Initial configuration of the application.
        /// </summary>
        /// <value>Initial configuration of the application.</value>
        [DataMember(Name = "configuration", IsRequired = true, EmitDefaultValue = true)]
        public ApplicationConfiguration VarConfiguration { get; set; }

        /// <summary>
        /// Time when the application was created.
        /// </summary>
        /// <value>Time when the application was created.</value>
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
        /// A unique name of the application.
        /// </summary>
        /// <value>A unique name of the application.</value>
        /// <example>my-application</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Time when the application was last updated.
        /// </summary>
        /// <value>Time when the application was last updated.</value>
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
        /// A unique id of the application.
        /// </summary>
        /// <value>A unique id of the application.</value>
        /// <example>262e7483484e40078abfdee18a89e7d2</example>
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
            sb.Append("class Application {\n");
            sb.Append("  VarConfiguration: ").Append(VarConfiguration).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            if (this.Name != null) {
                // Name (string) pattern
                Regex regexName = new Regex(@"^[0-9a-z\-]+$", RegexOptions.CultureInvariant);
                if (!regexName.Match(this.Name).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
                }
            }

            yield break;
        }
    }

}
