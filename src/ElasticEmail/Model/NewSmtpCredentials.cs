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
    /// Newly generated SMTP Credentials with Token
    /// </summary>
    [DataContract(Name = "NewSmtpCredentials")]
    public partial class NewSmtpCredentials : IEquatable<NewSmtpCredentials>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccessLevel
        /// </summary>
        [DataMember(Name = "AccessLevel", EmitDefaultValue = false)]
        public AccessLevel? AccessLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewSmtpCredentials" /> class.
        /// </summary>
        /// <param name="token">Unique token to be used in the system.</param>
        /// <param name="accessLevel">accessLevel.</param>
        /// <param name="name">Name of the key..</param>
        /// <param name="dateCreated">Date this SmtpCredential was created..</param>
        /// <param name="lastUse">Date this SmtpCredential was last used..</param>
        /// <param name="expires">Date this SmtpCredential expires..</param>
        /// <param name="restrictAccessToIPRange">Which IPs can use this SmtpCredential.</param>
        public NewSmtpCredentials(string token = default(string), AccessLevel? accessLevel = default(AccessLevel?), string name = default(string), DateTime dateCreated = default(DateTime), DateTime? lastUse = default(DateTime?), DateTime? expires = default(DateTime?), List<string> restrictAccessToIPRange = default(List<string>))
        {
            this.Token = token;
            this.AccessLevel = accessLevel;
            this.Name = name;
            this.DateCreated = dateCreated;
            this.LastUse = lastUse;
            this.Expires = expires;
            this.RestrictAccessToIPRange = restrictAccessToIPRange;
        }

        /// <summary>
        /// Unique token to be used in the system
        /// </summary>
        /// <value>Unique token to be used in the system</value>
        [DataMember(Name = "Token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Name of the key.
        /// </summary>
        /// <value>Name of the key.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Date this SmtpCredential was created.
        /// </summary>
        /// <value>Date this SmtpCredential was created.</value>
        [DataMember(Name = "DateCreated", EmitDefaultValue = false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Date this SmtpCredential was last used.
        /// </summary>
        /// <value>Date this SmtpCredential was last used.</value>
        [DataMember(Name = "LastUse", EmitDefaultValue = true)]
        public DateTime? LastUse { get; set; }

        /// <summary>
        /// Date this SmtpCredential expires.
        /// </summary>
        /// <value>Date this SmtpCredential expires.</value>
        [DataMember(Name = "Expires", EmitDefaultValue = true)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Which IPs can use this SmtpCredential
        /// </summary>
        /// <value>Which IPs can use this SmtpCredential</value>
        [DataMember(Name = "RestrictAccessToIPRange", EmitDefaultValue = false)]
        public List<string> RestrictAccessToIPRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewSmtpCredentials {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  AccessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  LastUse: ").Append(LastUse).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  RestrictAccessToIPRange: ").Append(RestrictAccessToIPRange).Append("\n");
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
            return this.Equals(input as NewSmtpCredentials);
        }

        /// <summary>
        /// Returns true if NewSmtpCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of NewSmtpCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewSmtpCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.AccessLevel == input.AccessLevel ||
                    this.AccessLevel.Equals(input.AccessLevel)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.LastUse == input.LastUse ||
                    (this.LastUse != null &&
                    this.LastUse.Equals(input.LastUse))
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
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                hashCode = hashCode * 59 + this.AccessLevel.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.LastUse != null)
                    hashCode = hashCode * 59 + this.LastUse.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.RestrictAccessToIPRange != null)
                    hashCode = hashCode * 59 + this.RestrictAccessToIPRange.GetHashCode();
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
