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
    /// Suppression - Email returning Hard Bounces
    /// </summary>
    [DataContract(Name = "Suppression")]
    public partial class Suppression : IEquatable<Suppression>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Suppression" /> class.
        /// </summary>
        /// <param name="email">Proper email address..</param>
        /// <param name="friendlyErrorMessage">RFC error message.</param>
        /// <param name="errorCode">SMTP Error code.</param>
        /// <param name="dateUpdated">Last change date.</param>
        public Suppression(string email = default(string), string friendlyErrorMessage = default(string), int? errorCode = default(int?), DateTime? dateUpdated = default(DateTime?))
        {
            this.Email = email;
            this.FriendlyErrorMessage = friendlyErrorMessage;
            this.ErrorCode = errorCode;
            this.DateUpdated = dateUpdated;
        }

        /// <summary>
        /// Proper email address.
        /// </summary>
        /// <value>Proper email address.</value>
        [DataMember(Name = "Email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// RFC error message
        /// </summary>
        /// <value>RFC error message</value>
        [DataMember(Name = "FriendlyErrorMessage", EmitDefaultValue = false)]
        public string FriendlyErrorMessage { get; set; }

        /// <summary>
        /// SMTP Error code
        /// </summary>
        /// <value>SMTP Error code</value>
        [DataMember(Name = "ErrorCode", EmitDefaultValue = true)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Last change date
        /// </summary>
        /// <value>Last change date</value>
        [DataMember(Name = "DateUpdated", EmitDefaultValue = true)]
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Suppression {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FriendlyErrorMessage: ").Append(FriendlyErrorMessage).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
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
            return this.Equals(input as Suppression);
        }

        /// <summary>
        /// Returns true if Suppression instances are equal
        /// </summary>
        /// <param name="input">Instance of Suppression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Suppression input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FriendlyErrorMessage == input.FriendlyErrorMessage ||
                    (this.FriendlyErrorMessage != null &&
                    this.FriendlyErrorMessage.Equals(input.FriendlyErrorMessage))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.DateUpdated == input.DateUpdated ||
                    (this.DateUpdated != null &&
                    this.DateUpdated.Equals(input.DateUpdated))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FriendlyErrorMessage != null)
                    hashCode = hashCode * 59 + this.FriendlyErrorMessage.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.DateUpdated != null)
                    hashCode = hashCode * 59 + this.DateUpdated.GetHashCode();
                return hashCode;
            }
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
