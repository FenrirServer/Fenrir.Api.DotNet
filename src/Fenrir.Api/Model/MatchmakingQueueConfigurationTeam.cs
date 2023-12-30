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
    /// MatchmakingQueueConfigurationTeam
    /// </summary>
    [DataContract(Name = "MatchmakingQueueConfigurationTeam")]
    public partial class MatchmakingQueueConfigurationTeam : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueueConfigurationTeam" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchmakingQueueConfigurationTeam() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueueConfigurationTeam" /> class.
        /// </summary>
        /// <param name="maxPlayers">A maximum number of players this team may have. (required).</param>
        /// <param name="minPlayers">A minimum number of players this team must have..</param>
        /// <param name="name">A unique name of the team. (required).</param>
        public MatchmakingQueueConfigurationTeam(int maxPlayers = default(int), int minPlayers = default(int), string name = default(string))
        {
            this.MaxPlayers = maxPlayers;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for MatchmakingQueueConfigurationTeam and cannot be null");
            }
            this.Name = name;
            this.MinPlayers = minPlayers;
        }

        /// <summary>
        /// A maximum number of players this team may have.
        /// </summary>
        /// <value>A maximum number of players this team may have.</value>
        /// <example>5</example>
        [DataMember(Name = "max_players", IsRequired = true, EmitDefaultValue = true)]
        public int MaxPlayers { get; set; }

        /// <summary>
        /// A minimum number of players this team must have.
        /// </summary>
        /// <value>A minimum number of players this team must have.</value>
        /// <example>5</example>
        [DataMember(Name = "min_players", EmitDefaultValue = false)]
        public int MinPlayers { get; set; }

        /// <summary>
        /// A unique name of the team.
        /// </summary>
        /// <value>A unique name of the team.</value>
        /// <example>counter_terrorists</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchmakingQueueConfigurationTeam {\n");
            sb.Append("  MaxPlayers: ").Append(MaxPlayers).Append("\n");
            sb.Append("  MinPlayers: ").Append(MinPlayers).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
