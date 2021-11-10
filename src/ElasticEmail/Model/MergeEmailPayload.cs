/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    The API has a limit of 20 concurrent connections and a hard timeout of 600 seconds per request.    To start using this API, you will need your Access Token (available <a target=\"_blank\" href=\"https://elasticemail.com/account#/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    This is the documentation for REST API. If you’d like to read our legacy documentation regarding Web API v2 click <a target=\"_blank\" href=\"https://api.elasticemail.com/public/help\">here</a>.    Downloadable library clients can be found in our Github repository <a target=\"_blank\" href=\"https://github.com/ElasticEmail?tab=repositories&q=%22rest+api%22+in%3Areadme\">here</a>
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
    /// MergeEmailPayload
    /// </summary>
    [DataContract(Name = "MergeEmailPayload")]
    public partial class MergeEmailPayload : IEquatable<MergeEmailPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeEmailPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MergeEmailPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeEmailPayload" /> class.
        /// </summary>
        /// <param name="mergeFile">mergeFile (required).</param>
        /// <param name="content">content.</param>
        /// <param name="options">options.</param>
        public MergeEmailPayload(MessageAttachment mergeFile = default(MessageAttachment), EmailContent content = default(EmailContent), Options options = default(Options))
        {
            // to ensure "mergeFile" is required (not null)
            if (mergeFile == null) {
                throw new ArgumentNullException("mergeFile is a required property for MergeEmailPayload and cannot be null");
            }
            this.MergeFile = mergeFile;
            this.Content = content;
            this.Options = options;
        }

        /// <summary>
        /// Gets or Sets MergeFile
        /// </summary>
        [DataMember(Name = "MergeFile", IsRequired = true, EmitDefaultValue = false)]
        public MessageAttachment MergeFile { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "Content", EmitDefaultValue = false)]
        public EmailContent Content { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "Options", EmitDefaultValue = false)]
        public Options Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeEmailPayload {\n");
            sb.Append("  MergeFile: ").Append(MergeFile).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as MergeEmailPayload);
        }

        /// <summary>
        /// Returns true if MergeEmailPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of MergeEmailPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeEmailPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MergeFile == input.MergeFile ||
                    (this.MergeFile != null &&
                    this.MergeFile.Equals(input.MergeFile))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.MergeFile != null)
                    hashCode = hashCode * 59 + this.MergeFile.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
