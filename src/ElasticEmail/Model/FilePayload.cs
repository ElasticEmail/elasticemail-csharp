/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    The API has a limit of 20 concurrent connections and a hard timeout of 600 seconds per request.    To start using this API, you will need your Access Token (available <a target=\"_blank\" href=\"https://app.elasticemail.com/marketing/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    Downloadable library clients can be found in our Github repository <a target=\"_blank\" href=\"https://github.com/ElasticEmail?tab=repositories&q=%22rest+api%22+in%3Areadme\">here</a>
 *
 * The version of the OpenAPI document: 4.0.0
 * Contact: support@elasticemail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = ElasticEmail.Client.OpenAPIDateConverter;

namespace ElasticEmail.Model
{
    /// <summary>
    /// FilePayload
    /// </summary>
    [DataContract(Name = "FilePayload")]
    public partial class FilePayload : IEquatable<FilePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilePayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilePayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilePayload" /> class.
        /// </summary>
        /// <param name="binaryContent">Content of the file sent as binary data (required).</param>
        /// <param name="name">Filename.</param>
        /// <param name="contentType">Type of file&#39;s content (e.g. image/jpeg).</param>
        public FilePayload(byte[] binaryContent = default(byte[]), string name = default(string), string contentType = default(string))
        {
            // to ensure "binaryContent" is required (not null)
            if (binaryContent == null)
            {
                throw new ArgumentNullException("binaryContent is a required property for FilePayload and cannot be null");
            }
            this.BinaryContent = binaryContent;
            this.Name = name;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Content of the file sent as binary data
        /// </summary>
        /// <value>Content of the file sent as binary data</value>
        [DataMember(Name = "BinaryContent", IsRequired = true, EmitDefaultValue = true)]
        public byte[] BinaryContent { get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        /// <value>Filename</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Type of file&#39;s content (e.g. image/jpeg)
        /// </summary>
        /// <value>Type of file&#39;s content (e.g. image/jpeg)</value>
        [DataMember(Name = "ContentType", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilePayload {\n");
            sb.Append("  BinaryContent: ").Append(BinaryContent).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FilePayload);
        }

        /// <summary>
        /// Returns true if FilePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of FilePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilePayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BinaryContent == input.BinaryContent ||
                    (this.BinaryContent != null &&
                    this.BinaryContent.Equals(input.BinaryContent))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BinaryContent != null)
                {
                    hashCode = (hashCode * 59) + this.BinaryContent.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
