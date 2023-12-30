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
    /// ApplicationInstance
    /// </summary>
    [DataContract(Name = "ApplicationInstance")]
    public partial class ApplicationInstance : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInstance" /> class.
        /// </summary>
        /// <param name="applicationUuid">A uuid of the application..</param>
        /// <param name="containerId">A unique id of the container.</param>
        /// <param name="deploymentUuid">A uuid of the deployment.</param>
        /// <param name="desiredState">Desired state of the instance. Corresponds with docker container states..</param>
        /// <param name="hostname">A hostname of the node the instance is running on..</param>
        /// <param name="ports">A list of ports exposed on the instance. .</param>
        /// <param name="state">State of the running instance. Corresponds with docker container states..</param>
        /// <param name="uuid">A unique id of the instance..</param>
        public ApplicationInstance(string applicationUuid = default(string), string containerId = default(string), string deploymentUuid = default(string), string desiredState = default(string), string hostname = default(string), List<ApplicationInstancePort> ports = default(List<ApplicationInstancePort>), string state = default(string), string uuid = default(string))
        {
            this.ApplicationUuid = applicationUuid;
            this.ContainerId = containerId;
            this.DeploymentUuid = deploymentUuid;
            this.DesiredState = desiredState;
            this.Hostname = hostname;
            this.Ports = ports;
            this.State = state;
            this.Uuid = uuid;
        }

        /// <summary>
        /// A uuid of the application.
        /// </summary>
        /// <value>A uuid of the application.</value>
        /// <example>7bc16159acff4b689fe7224a7c79fb96</example>
        [DataMember(Name = "application_uuid", EmitDefaultValue = false)]
        public string ApplicationUuid { get; set; }

        /// <summary>
        /// A unique id of the container
        /// </summary>
        /// <value>A unique id of the container</value>
        /// <example>0d65495b663f42ef835cc2801fb9feba</example>
        [DataMember(Name = "container_id", EmitDefaultValue = false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// Time when the instance was created.
        /// </summary>
        /// <value>Time when the instance was created.</value>
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
        /// A uuid of the deployment
        /// </summary>
        /// <value>A uuid of the deployment</value>
        /// <example>f01ffac3b2774b0fb95c0b510292e3f7</example>
        [DataMember(Name = "deployment_uuid", EmitDefaultValue = false)]
        public string DeploymentUuid { get; set; }

        /// <summary>
        /// Desired state of the instance. Corresponds with docker container states.
        /// </summary>
        /// <value>Desired state of the instance. Corresponds with docker container states.</value>
        /// <example>running</example>
        [DataMember(Name = "desired_state", EmitDefaultValue = false)]
        public string DesiredState { get; set; }

        /// <summary>
        /// A hostname of the node the instance is running on.
        /// </summary>
        /// <value>A hostname of the node the instance is running on.</value>
        /// <example>host001.fenrircloud.com</example>
        [DataMember(Name = "hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }

        /// <summary>
        /// A list of ports exposed on the instance. 
        /// </summary>
        /// <value>A list of ports exposed on the instance. </value>
        [DataMember(Name = "ports", EmitDefaultValue = false)]
        public List<ApplicationInstancePort> Ports { get; set; }

        /// <summary>
        /// State of the running instance. Corresponds with docker container states.
        /// </summary>
        /// <value>State of the running instance. Corresponds with docker container states.</value>
        /// <example>created</example>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Time when the instance was last updated.
        /// </summary>
        /// <value>Time when the instance was last updated.</value>
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
        /// A unique id of the instance.
        /// </summary>
        /// <value>A unique id of the instance.</value>
        /// <example>be29c08199514affa4580f4d4d2fecd1</example>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationInstance {\n");
            sb.Append("  ApplicationUuid: ").Append(ApplicationUuid).Append("\n");
            sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DeploymentUuid: ").Append(DeploymentUuid).Append("\n");
            sb.Append("  DesiredState: ").Append(DesiredState).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            yield break;
        }
    }

}
