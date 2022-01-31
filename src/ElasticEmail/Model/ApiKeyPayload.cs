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
    /// Create a new ApiKey
    /// </summary>
    [DataContract(Name = "ApiKeyPayload")]
    public partial class ApiKeyPayload : IEquatable<ApiKeyPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiKeyPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyPayload" /> class.
        /// </summary>
        /// <param name="name">Name of the ApiKey for ease of reference. (required).</param>
        /// <param name="accessLevel">Access level or permission to be assigned to this ApiKey. (required).</param>
        /// <param name="expires">Date this ApiKey expires..</param>
        /// <param name="restrictAccessToIPRange">Which IPs can use this ApiKey.</param>
        /// <param name="subaccount">Email of the subaccount for which this ApiKey should be created.</param>
        public ApiKeyPayload(string name = default(string), List<AccessLevel> accessLevel = default(List<AccessLevel>), DateTime? expires = default(DateTime?), List<string> restrictAccessToIPRange = default(List<string>), string subaccount = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ApiKeyPayload and cannot be null");
            }
            this.Name = name;
            // to ensure "accessLevel" is required (not null)
            if (accessLevel == null) {
                throw new ArgumentNullException("accessLevel is a required property for ApiKeyPayload and cannot be null");
            }
            this.AccessLevel = accessLevel;
            this.Expires = expires;
            this.RestrictAccessToIPRange = restrictAccessToIPRange;
            this.Subaccount = subaccount;
        }

        /// <summary>
        /// Name of the ApiKey for ease of reference.
        /// </summary>
        /// <value>Name of the ApiKey for ease of reference.</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Access level or permission to be assigned to this ApiKey.
        /// </summary>
        /// <value>Access level or permission to be assigned to this ApiKey.</value>
        [DataMember(Name = "AccessLevel", IsRequired = true, EmitDefaultValue = false)]
        public List<AccessLevel> AccessLevel { get; set; }

        /// <summary>
        /// Date this ApiKey expires.
        /// </summary>
        /// <value>Date this ApiKey expires.</value>
        [DataMember(Name = "Expires", EmitDefaultValue = true)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Which IPs can use this ApiKey
        /// </summary>
        /// <value>Which IPs can use this ApiKey</value>
        [DataMember(Name = "RestrictAccessToIPRange", EmitDefaultValue = false)]
        public List<string> RestrictAccessToIPRange { get; set; }

        /// <summary>
        /// Email of the subaccount for which this ApiKey should be created
        /// </summary>
        /// <value>Email of the subaccount for which this ApiKey should be created</value>
        [DataMember(Name = "Subaccount", EmitDefaultValue = false)]
        public string Subaccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiKeyPayload {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  RestrictAccessToIPRange: ").Append(RestrictAccessToIPRange).Append("\n");
            sb.Append("  Subaccount: ").Append(Subaccount).Append("\n");
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
            return this.Equals(input as ApiKeyPayload);
        }

        /// <summary>
        /// Returns true if ApiKeyPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiKeyPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyPayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AccessLevel == input.AccessLevel ||
                    this.AccessLevel != null &&
                    input.AccessLevel != null &&
                    this.AccessLevel.SequenceEqual(input.AccessLevel)
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.RestrictAccessToIPRange == input.RestrictAccessToIPRange ||
                    this.RestrictAccessToIPRange != null &&
                    input.RestrictAccessToIPRange != null &&
                    this.RestrictAccessToIPRange.SequenceEqual(input.RestrictAccessToIPRange)
                ) && 
                (
                    this.Subaccount == input.Subaccount ||
                    (this.Subaccount != null &&
                    this.Subaccount.Equals(input.Subaccount))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.AccessLevel != null)
                {
                    hashCode = (hashCode * 59) + this.AccessLevel.GetHashCode();
                }
                if (this.Expires != null)
                {
                    hashCode = (hashCode * 59) + this.Expires.GetHashCode();
                }
                if (this.RestrictAccessToIPRange != null)
                {
                    hashCode = (hashCode * 59) + this.RestrictAccessToIPRange.GetHashCode();
                }
                if (this.Subaccount != null)
                {
                    hashCode = (hashCode * 59) + this.Subaccount.GetHashCode();
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
