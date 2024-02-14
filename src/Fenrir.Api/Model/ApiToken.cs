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
    /// ApiToken
    /// </summary>
    [DataContract(Name = "ApiToken")]
    public partial class ApiToken : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiToken" /> class.
        /// </summary>
        /// <param name="applicationUuid">A uuid of the application this token is limited to..</param>
        /// <param name="label">A label for the token..</param>
        public ApiToken(string applicationUuid = default(string), string label = default(string))
        {
            this.ApplicationUuid = applicationUuid;
            this.Label = label;
        }

        /// <summary>
        /// A uuid of the application this token is limited to.
        /// </summary>
        /// <value>A uuid of the application this token is limited to.</value>
        /// <example>e1bbf5bd471c484fa2f7989f048dbbbc</example>
        [DataMember(Name = "application_uuid", EmitDefaultValue = false)]
        public string ApplicationUuid { get; set; }

        /// <summary>
        /// Time when the token was created.
        /// </summary>
        /// <value>Time when the token was created.</value>
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
        /// A label for the token.
        /// </summary>
        /// <value>A label for the token.</value>
        /// <example>my-token</example>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// A plain text value of the token. Only returned when the token is created.
        /// </summary>
        /// <value>A plain text value of the token. Only returned when the token is created.</value>
        /// <example>4f03ff9f9caf4e1388126436b0c841f4</example>
        [DataMember(Name = "token_plaintext", EmitDefaultValue = true)]
        public Object TokenPlaintext { get; private set; }

        /// <summary>
        /// Returns false as TokenPlaintext should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTokenPlaintext()
        {
            return false;
        }
        /// <summary>
        /// Time when the token was last updated.
        /// </summary>
        /// <value>Time when the token was last updated.</value>
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
        /// A unique id of the api token.
        /// </summary>
        /// <value>A unique id of the api token.</value>
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
            sb.Append("class ApiToken {\n");
            sb.Append("  ApplicationUuid: ").Append(ApplicationUuid).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  TokenPlaintext: ").Append(TokenPlaintext).Append("\n");
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
            // Label (string) maxLength
            if (this.Label != null && this.Label.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Label, length must be less than 128.", new [] { "Label" });
            }

            // Label (string) minLength
            if (this.Label != null && this.Label.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Label, length must be greater than 4.", new [] { "Label" });
            }

            yield break;
        }
    }

}
