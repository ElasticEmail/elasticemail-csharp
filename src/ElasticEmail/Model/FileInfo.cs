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
    /// File information
    /// </summary>
    [DataContract(Name = "FileInfo")]
    public partial class FileInfo : IEquatable<FileInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileInfo" /> class.
        /// </summary>
        /// <param name="fileName">Name of your file including extension..</param>
        /// <param name="size">Size of your attachment (in bytes)..</param>
        /// <param name="dateAdded">Date of creation in YYYY-MM-DDThh:ii:ss format.</param>
        /// <param name="expirationDate">Date when the file will be deleted from your Account..</param>
        /// <param name="contentType">Content type of the file..</param>
        public FileInfo(string fileName = default(string), int? size = default(int?), DateTime dateAdded = default(DateTime), DateTime? expirationDate = default(DateTime?), string contentType = default(string))
        {
            this.FileName = fileName;
            this.Size = size;
            this.DateAdded = dateAdded;
            this.ExpirationDate = expirationDate;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Name of your file including extension.
        /// </summary>
        /// <value>Name of your file including extension.</value>
        [DataMember(Name = "FileName", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// Size of your attachment (in bytes).
        /// </summary>
        /// <value>Size of your attachment (in bytes).</value>
        [DataMember(Name = "Size", EmitDefaultValue = true)]
        public int? Size { get; set; }

        /// <summary>
        /// Date of creation in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        /// <value>Date of creation in YYYY-MM-DDThh:ii:ss format</value>
        [DataMember(Name = "DateAdded", EmitDefaultValue = false)]
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Date when the file will be deleted from your Account.
        /// </summary>
        /// <value>Date when the file will be deleted from your Account.</value>
        [DataMember(Name = "ExpirationDate", EmitDefaultValue = true)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Content type of the file.
        /// </summary>
        /// <value>Content type of the file.</value>
        [DataMember(Name = "ContentType", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileInfo {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  DateAdded: ").Append(DateAdded).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
            return this.Equals(input as FileInfo);
        }

        /// <summary>
        /// Returns true if FileInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FileInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.DateAdded == input.DateAdded ||
                    (this.DateAdded != null &&
                    this.DateAdded.Equals(input.DateAdded))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
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
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
                }
                if (this.DateAdded != null)
                {
                    hashCode = (hashCode * 59) + this.DateAdded.GetHashCode();
                }
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
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
