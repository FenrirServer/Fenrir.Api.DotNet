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
    /// MatchmakingQueue
    /// </summary>
    [DataContract(Name = "MatchmakingQueue")]
    public partial class MatchmakingQueue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchmakingQueue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueue" /> class.
        /// </summary>
        /// <param name="varConfiguration">varConfiguration (required).</param>
        /// <param name="name">A name of the matchmaking queue. (required).</param>
        public MatchmakingQueue(MatchmakingQueueConfiguration varConfiguration = default(MatchmakingQueueConfiguration), string name = default(string))
        {
            // to ensure "varConfiguration" is required (not null)
            if (varConfiguration == null)
            {
                throw new ArgumentNullException("varConfiguration is a required property for MatchmakingQueue and cannot be null");
            }
            this.VarConfiguration = varConfiguration;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for MatchmakingQueue and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// A uuid of the application this queue is for.
        /// </summary>
        /// <value>A uuid of the application this queue is for.</value>
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
        /// Gets or Sets VarConfiguration
        /// </summary>
        [DataMember(Name = "configuration", IsRequired = true, EmitDefaultValue = true)]
        public MatchmakingQueueConfiguration VarConfiguration { get; set; }

        /// <summary>
        /// Time when the matchmaking queue was created.
        /// </summary>
        /// <value>Time when the matchmaking queue was created.</value>
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
        /// A name of the matchmaking queue.
        /// </summary>
        /// <value>A name of the matchmaking queue.</value>
        /// <example>my-queue</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Time when the matchmaking queue was last updated.
        /// </summary>
        /// <value>Time when the matchmaking queue was last updated.</value>
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
        /// A unique id of the matchmaking queue.
        /// </summary>
        /// <value>A unique id of the matchmaking queue.</value>
        /// <example>146f44647dd941a89dbe8d487b7aa1ca</example>
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
            sb.Append("class MatchmakingQueue {\n");
            sb.Append("  ApplicationUuid: ").Append(ApplicationUuid).Append("\n");
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
                Regex regexName = new Regex(@"^[0-9a-z\-_]+$", RegexOptions.CultureInvariant);
                if (!regexName.Match(this.Name).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
                }
            }

            yield break;
        }
    }

}
