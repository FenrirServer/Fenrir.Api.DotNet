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
    /// MatchmakingQueueConfiguration
    /// </summary>
    [DataContract(Name = "MatchmakingQueueConfiguration")]
    public partial class MatchmakingQueueConfiguration : IValidatableObject
    {
        /// <summary>
        /// A configuration schema version.
        /// </summary>
        /// <value>A configuration schema version.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VarVersionEnum
        {
            /// <summary>
            /// Enum _10 for value: 1.0
            /// </summary>
            [EnumMember(Value = "1.0")]
            _10 = 1
        }


        /// <summary>
        /// A configuration schema version.
        /// </summary>
        /// <value>A configuration schema version.</value>
        /// <example>1.0</example>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public VarVersionEnum VarVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueueConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchmakingQueueConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingQueueConfiguration" /> class.
        /// </summary>
        /// <param name="confirmationRequired">A boolean value indicating if match confirmation is required. If set to true, players will receive confirmation event before the match is formed. All matched players must confirm their participation within a time specified with \&quot;confirmation_time_seconds\&quot;, otherwise match is aborted..</param>
        /// <param name="confirmationTimeSeconds">A number of seconds given to players to confirm their match participation..</param>
        /// <param name="deploymentUuid">A uuid of the deployment this matchmaking queue will point at. When a match is formed, a server is selected from the specified deployment. (required).</param>
        /// <param name="playerProperties">An array of player properties..</param>
        /// <param name="playerRules">An array of player rules..</param>
        /// <param name="teamRules">An array of team rules..</param>
        /// <param name="teams">An array of teams..</param>
        /// <param name="varVersion">A configuration schema version. (required).</param>
        public MatchmakingQueueConfiguration(bool confirmationRequired = default(bool), decimal confirmationTimeSeconds = default(decimal), string deploymentUuid = default(string), List<MatchmakingQueueConfigurationPlayerProperty> playerProperties = default(List<MatchmakingQueueConfigurationPlayerProperty>), List<MatchmakingQueueConfigurationPlayerRule> playerRules = default(List<MatchmakingQueueConfigurationPlayerRule>), List<MatchmakingQueueConfigurationTeamRule> teamRules = default(List<MatchmakingQueueConfigurationTeamRule>), List<MatchmakingQueueConfigurationTeam> teams = default(List<MatchmakingQueueConfigurationTeam>), VarVersionEnum varVersion = default(VarVersionEnum))
        {
            // to ensure "deploymentUuid" is required (not null)
            if (deploymentUuid == null)
            {
                throw new ArgumentNullException("deploymentUuid is a required property for MatchmakingQueueConfiguration and cannot be null");
            }
            this.DeploymentUuid = deploymentUuid;
            this.VarVersion = varVersion;
            this.ConfirmationRequired = confirmationRequired;
            this.ConfirmationTimeSeconds = confirmationTimeSeconds;
            this.PlayerProperties = playerProperties;
            this.PlayerRules = playerRules;
            this.TeamRules = teamRules;
            this.Teams = teams;
        }

        /// <summary>
        /// A boolean value indicating if match confirmation is required. If set to true, players will receive confirmation event before the match is formed. All matched players must confirm their participation within a time specified with \&quot;confirmation_time_seconds\&quot;, otherwise match is aborted.
        /// </summary>
        /// <value>A boolean value indicating if match confirmation is required. If set to true, players will receive confirmation event before the match is formed. All matched players must confirm their participation within a time specified with \&quot;confirmation_time_seconds\&quot;, otherwise match is aborted.</value>
        /// <example>true</example>
        [DataMember(Name = "confirmation_required", EmitDefaultValue = true)]
        public bool ConfirmationRequired { get; set; }

        /// <summary>
        /// A number of seconds given to players to confirm their match participation.
        /// </summary>
        /// <value>A number of seconds given to players to confirm their match participation.</value>
        /// <example>10</example>
        [DataMember(Name = "confirmation_time_seconds", EmitDefaultValue = false)]
        public decimal ConfirmationTimeSeconds { get; set; }

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
        /// A uuid of the deployment this matchmaking queue will point at. When a match is formed, a server is selected from the specified deployment.
        /// </summary>
        /// <value>A uuid of the deployment this matchmaking queue will point at. When a match is formed, a server is selected from the specified deployment.</value>
        /// <example>a37e34eb25e64657bf48e40f5c44b405</example>
        [DataMember(Name = "deployment_uuid", IsRequired = true, EmitDefaultValue = true)]
        public string DeploymentUuid { get; set; }

        /// <summary>
        /// An array of player properties.
        /// </summary>
        /// <value>An array of player properties.</value>
        [DataMember(Name = "player_properties", EmitDefaultValue = false)]
        public List<MatchmakingQueueConfigurationPlayerProperty> PlayerProperties { get; set; }

        /// <summary>
        /// An array of player rules.
        /// </summary>
        /// <value>An array of player rules.</value>
        [DataMember(Name = "player_rules", EmitDefaultValue = false)]
        public List<MatchmakingQueueConfigurationPlayerRule> PlayerRules { get; set; }

        /// <summary>
        /// An array of team rules.
        /// </summary>
        /// <value>An array of team rules.</value>
        [DataMember(Name = "team_rules", EmitDefaultValue = false)]
        public List<MatchmakingQueueConfigurationTeamRule> TeamRules { get; set; }

        /// <summary>
        /// An array of teams.
        /// </summary>
        /// <value>An array of teams.</value>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public List<MatchmakingQueueConfigurationTeam> Teams { get; set; }

        /// <summary>
        /// A unique id of the matchmaking queue configuration.
        /// </summary>
        /// <value>A unique id of the matchmaking queue configuration.</value>
        /// <example>9e97b6a2cb8c443982ec9445647c7858</example>
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
            sb.Append("class MatchmakingQueueConfiguration {\n");
            sb.Append("  ConfirmationRequired: ").Append(ConfirmationRequired).Append("\n");
            sb.Append("  ConfirmationTimeSeconds: ").Append(ConfirmationTimeSeconds).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DeploymentUuid: ").Append(DeploymentUuid).Append("\n");
            sb.Append("  PlayerProperties: ").Append(PlayerProperties).Append("\n");
            sb.Append("  PlayerRules: ").Append(PlayerRules).Append("\n");
            sb.Append("  TeamRules: ").Append(TeamRules).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
