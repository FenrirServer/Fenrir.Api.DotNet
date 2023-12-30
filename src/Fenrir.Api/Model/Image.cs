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
    /// Image
    /// </summary>
    [DataContract(Name = "Image")]
    public partial class Image : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="id">A unique id of this image.</param>
        /// <param name="lastTagTime">Time when image was last tagged.</param>
        /// <param name="size">The size of the image, in megabytes..</param>
        /// <param name="tags">A list of tags attached to this image.</param>
        public Image(string id = default(string), DateTime lastTagTime = default(DateTime), int size = default(int), List<string> tags = default(List<string>))
        {
            this.Id = id;
            this.LastTagTime = lastTagTime;
            this.Size = size;
            this.Tags = tags;
        }

        /// <summary>
        /// Time when the image was created.
        /// </summary>
        /// <value>Time when the image was created.</value>
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
        /// A unique id of this image
        /// </summary>
        /// <value>A unique id of this image</value>
        /// <example>ab9fccc4d4c949a4ae12e4206277e8b4</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Time when image was last tagged
        /// </summary>
        /// <value>Time when image was last tagged</value>
        /// <example>2024-01-22T19:28:42Z</example>
        [DataMember(Name = "last_tag_time", EmitDefaultValue = false)]
        public DateTime LastTagTime { get; set; }

        /// <summary>
        /// The size of the image, in megabytes.
        /// </summary>
        /// <value>The size of the image, in megabytes.</value>
        /// <example>25</example>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// A list of tags attached to this image
        /// </summary>
        /// <value>A list of tags attached to this image</value>
        /// <example>[&quot;1.0.0&quot;]</example>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Image {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastTagTime: ").Append(LastTagTime).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
