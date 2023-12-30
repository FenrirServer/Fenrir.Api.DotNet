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
    /// DeploymentStats
    /// </summary>
    [DataContract(Name = "DeploymentStats")]
    public partial class DeploymentStats : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentStats" /> class.
        /// </summary>
        /// <param name="ccuTotal">A number of players currently connected..</param>
        /// <param name="cpuAvg">The average CPU utilization of the application across all instances in this deployment..</param>
        /// <param name="instanceStats">A dictionary of instance stats, per instance..</param>
        /// <param name="memAvg">The average memory utilization of the application across all instances in this deployment, in megabytes..</param>
        /// <param name="numInstances">The total number of instances in this deployment..</param>
        public DeploymentStats(int ccuTotal = default(int), decimal cpuAvg = default(decimal), Dictionary<string, ApplicationInstanceStats> instanceStats = default(Dictionary<string, ApplicationInstanceStats>), decimal memAvg = default(decimal), int numInstances = default(int))
        {
            this.CcuTotal = ccuTotal;
            this.CpuAvg = cpuAvg;
            this.InstanceStats = instanceStats;
            this.MemAvg = memAvg;
            this.NumInstances = numInstances;
        }

        /// <summary>
        /// A number of players currently connected.
        /// </summary>
        /// <value>A number of players currently connected.</value>
        /// <example>100</example>
        [DataMember(Name = "ccu_total", EmitDefaultValue = false)]
        public int CcuTotal { get; set; }

        /// <summary>
        /// The average CPU utilization of the application across all instances in this deployment.
        /// </summary>
        /// <value>The average CPU utilization of the application across all instances in this deployment.</value>
        /// <example>55.5</example>
        [DataMember(Name = "cpu_avg", EmitDefaultValue = false)]
        public decimal CpuAvg { get; set; }

        /// <summary>
        /// A dictionary of instance stats, per instance.
        /// </summary>
        /// <value>A dictionary of instance stats, per instance.</value>
        [DataMember(Name = "instance_stats", EmitDefaultValue = false)]
        public Dictionary<string, ApplicationInstanceStats> InstanceStats { get; set; }

        /// <summary>
        /// The average memory utilization of the application across all instances in this deployment, in megabytes.
        /// </summary>
        /// <value>The average memory utilization of the application across all instances in this deployment, in megabytes.</value>
        /// <example>25</example>
        [DataMember(Name = "mem_avg", EmitDefaultValue = false)]
        public decimal MemAvg { get; set; }

        /// <summary>
        /// The total number of instances in this deployment.
        /// </summary>
        /// <value>The total number of instances in this deployment.</value>
        /// <example>10</example>
        [DataMember(Name = "num_instances", EmitDefaultValue = false)]
        public int NumInstances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeploymentStats {\n");
            sb.Append("  CcuTotal: ").Append(CcuTotal).Append("\n");
            sb.Append("  CpuAvg: ").Append(CpuAvg).Append("\n");
            sb.Append("  InstanceStats: ").Append(InstanceStats).Append("\n");
            sb.Append("  MemAvg: ").Append(MemAvg).Append("\n");
            sb.Append("  NumInstances: ").Append(NumInstances).Append("\n");
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
