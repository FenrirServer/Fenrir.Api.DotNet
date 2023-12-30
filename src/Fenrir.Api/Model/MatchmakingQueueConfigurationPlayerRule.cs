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
    /// MatchmakingQueueConfigurationPlayerRule
    /// </summary>
    [DataContract(Name = "MatchmakingQueueConfigurationPlayerRule")]
    public partial class MatchmakingQueueConfigurationPlayerRule : IValidatableObject
    {
        /// <summary>
        /// Player rule type.
        /// </summary>
        /// <value>Player rule type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ValueEquality for value: value_equality
            /// </summary>
            [EnumMember(Value = "value_equality")]
            ValueEquality = 1,

            /// <summary>
            /// Enum MaxDifferenceBetweenValues for value: max_difference_between_values
            /// </summary>
            [EnumMember(Value = "max_difference_between_values")]
            MaxDifferenceBetweenValues = 2
        }


        /// <summary>
        /// Player rule type.
        /// </summary>
        /// <value>Player rule type.</value>
        /// <example>value_equality</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueueConfigurationPlayerRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchmakingQueueConfigurationPlayerRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueueConfigurationPlayerRule" /> class.
        /// </summary>
        /// <param name="differenceValue">A value difference. Must be specified if player rule checks difference between values..</param>
        /// <param name="propertyKey">Player property key. Must be specified if a rule is applied to player properties. (required).</param>
        /// <param name="type">Player rule type. (required).</param>
        public MatchmakingQueueConfigurationPlayerRule(decimal differenceValue = default(decimal), string propertyKey = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "propertyKey" is required (not null)
            if (propertyKey == null)
            {
                throw new ArgumentNullException("propertyKey is a required property for MatchmakingQueueConfigurationPlayerRule and cannot be null");
            }
            this.PropertyKey = propertyKey;
            this.Type = type;
            this.DifferenceValue = differenceValue;
        }

        /// <summary>
        /// A value difference. Must be specified if player rule checks difference between values.
        /// </summary>
        /// <value>A value difference. Must be specified if player rule checks difference between values.</value>
        /// <example>20</example>
        [DataMember(Name = "difference_value", EmitDefaultValue = false)]
        public decimal DifferenceValue { get; set; }

        /// <summary>
        /// Player property key. Must be specified if a rule is applied to player properties.
        /// </summary>
        /// <value>Player property key. Must be specified if a rule is applied to player properties.</value>
        /// <example>rank</example>
        [DataMember(Name = "property_key", IsRequired = true, EmitDefaultValue = true)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchmakingQueueConfigurationPlayerRule {\n");
            sb.Append("  DifferenceValue: ").Append(DifferenceValue).Append("\n");
            sb.Append("  PropertyKey: ").Append(PropertyKey).Append("\n");
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
            // PropertyKey (string) maxLength
            if (this.PropertyKey != null && this.PropertyKey.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PropertyKey, length must be less than 128.", new [] { "PropertyKey" });
            }

            // PropertyKey (string) minLength
            if (this.PropertyKey != null && this.PropertyKey.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PropertyKey, length must be greater than 1.", new [] { "PropertyKey" });
            }

            if (this.PropertyKey != null) {
                // PropertyKey (string) pattern
                Regex regexPropertyKey = new Regex(@"^[0-9a-z\-_]+$", RegexOptions.CultureInvariant);
                if (!regexPropertyKey.Match(this.PropertyKey).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PropertyKey, must match a pattern of " + regexPropertyKey, new [] { "PropertyKey" });
                }
            }

            yield break;
        }
    }

}
