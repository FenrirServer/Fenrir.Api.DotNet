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
    /// MatchmakingQueueConfigurationPlayerProperty
    /// </summary>
    [DataContract(Name = "MatchmakingQueueConfigurationPlayerProperty")]
    public partial class MatchmakingQueueConfigurationPlayerProperty : IValidatableObject
    {
        /// <summary>
        /// Player property type. Must be \&quot;int\&quot;, \&quot;string\&quot;, \&quot;bool\&quot; or \&quot;float\&quot;.
        /// </summary>
        /// <value>Player property type. Must be \&quot;int\&quot;, \&quot;string\&quot;, \&quot;bool\&quot; or \&quot;float\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Int for value: int
            /// </summary>
            [EnumMember(Value = "int")]
            Int = 1,

            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 2,

            /// <summary>
            /// Enum Bool for value: bool
            /// </summary>
            [EnumMember(Value = "bool")]
            Bool = 3,

            /// <summary>
            /// Enum Float for value: float
            /// </summary>
            [EnumMember(Value = "float")]
            Float = 4
        }


        /// <summary>
        /// Player property type. Must be \&quot;int\&quot;, \&quot;string\&quot;, \&quot;bool\&quot; or \&quot;float\&quot;.
        /// </summary>
        /// <value>Player property type. Must be \&quot;int\&quot;, \&quot;string\&quot;, \&quot;bool\&quot; or \&quot;float\&quot;.</value>
        /// <example>int</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueueConfigurationPlayerProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchmakingQueueConfigurationPlayerProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueueConfigurationPlayerProperty" /> class.
        /// </summary>
        /// <param name="defaultValue">A default value for a property. If \&quot;required\&quot; is set to false, this default value will be used for tickets that did not specify this property..</param>
        /// <param name="key">A unique key of the property. (required).</param>
        /// <param name="required">A boolean value indicating if this property is required. If set to true, all matchmaking tickets must have this property..</param>
        /// <param name="type">Player property type. Must be \&quot;int\&quot;, \&quot;string\&quot;, \&quot;bool\&quot; or \&quot;float\&quot;. (required).</param>
        public MatchmakingQueueConfigurationPlayerProperty(string defaultValue = default(string), string key = default(string), bool required = default(bool), TypeEnum type = default(TypeEnum))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for MatchmakingQueueConfigurationPlayerProperty and cannot be null");
            }
            this.Key = key;
            this.Type = type;
            this.DefaultValue = defaultValue;
            this.Required = required;
        }

        /// <summary>
        /// A default value for a property. If \&quot;required\&quot; is set to false, this default value will be used for tickets that did not specify this property.
        /// </summary>
        /// <value>A default value for a property. If \&quot;required\&quot; is set to false, this default value will be used for tickets that did not specify this property.</value>
        /// <example>100</example>
        [DataMember(Name = "default_value", EmitDefaultValue = false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// A unique key of the property.
        /// </summary>
        /// <value>A unique key of the property.</value>
        /// <example>rank</example>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// A boolean value indicating if this property is required. If set to true, all matchmaking tickets must have this property.
        /// </summary>
        /// <value>A boolean value indicating if this property is required. If set to true, all matchmaking tickets must have this property.</value>
        /// <example>true</example>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchmakingQueueConfigurationPlayerProperty {\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            // DefaultValue (string) maxLength
            if (this.DefaultValue != null && this.DefaultValue.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DefaultValue, length must be less than 128.", new [] { "DefaultValue" });
            }

            // DefaultValue (string) minLength
            if (this.DefaultValue != null && this.DefaultValue.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DefaultValue, length must be greater than 4.", new [] { "DefaultValue" });
            }

            // Key (string) maxLength
            if (this.Key != null && this.Key.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be less than 128.", new [] { "Key" });
            }

            // Key (string) minLength
            if (this.Key != null && this.Key.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be greater than 1.", new [] { "Key" });
            }

            if (this.Key != null) {
                // Key (string) pattern
                Regex regexKey = new Regex(@"^[0-9a-z\-_]+$", RegexOptions.CultureInvariant);
                if (!regexKey.Match(this.Key).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, must match a pattern of " + regexKey, new [] { "Key" });
                }
            }

            yield break;
        }
    }

}
