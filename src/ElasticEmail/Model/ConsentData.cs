/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    To start using this API, you will need your Access Token (available <a href=\"https://elasticemail.com/account#/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    This is the documentation for REST API. If you’d like to read our legacy documentation regarding Web API v2 click <a href=\"https://api.elasticemail.com/public/help\">here</a>.
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
    /// ConsentData
    /// </summary>
    [DataContract(Name = "ConsentData")]
    public partial class ConsentData : IEquatable<ConsentData>, IValidatableObject
    {
        /// <summary>
        /// Does the contant consent to have their tracking data stored.
        /// </summary>
        /// <value>Does the contant consent to have their tracking data stored.</value>
        [DataMember(Name = "ConsentTracking", EmitDefaultValue = false)]
        public ConsentTracking? ConsentTracking { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentData" /> class.
        /// </summary>
        /// <param name="consentIP">IP address of consent to send this contact(s) your email. If not provided your current public IP address is used for consent..</param>
        /// <param name="consentDate">Date of consent to send this contact(s) your email. If not provided current date is used for consent..</param>
        /// <param name="consentTracking">Does the contant consent to have their tracking data stored..</param>
        public ConsentData(string consentIP = default(string), DateTime? consentDate = default(DateTime?), ConsentTracking? consentTracking = default(ConsentTracking?))
        {
            this.ConsentIP = consentIP;
            this.ConsentDate = consentDate;
            this.ConsentTracking = consentTracking;
        }

        /// <summary>
        /// IP address of consent to send this contact(s) your email. If not provided your current public IP address is used for consent.
        /// </summary>
        /// <value>IP address of consent to send this contact(s) your email. If not provided your current public IP address is used for consent.</value>
        [DataMember(Name = "ConsentIP", EmitDefaultValue = false)]
        public string ConsentIP { get; set; }

        /// <summary>
        /// Date of consent to send this contact(s) your email. If not provided current date is used for consent.
        /// </summary>
        /// <value>Date of consent to send this contact(s) your email. If not provided current date is used for consent.</value>
        [DataMember(Name = "ConsentDate", EmitDefaultValue = true)]
        public DateTime? ConsentDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsentData {\n");
            sb.Append("  ConsentIP: ").Append(ConsentIP).Append("\n");
            sb.Append("  ConsentDate: ").Append(ConsentDate).Append("\n");
            sb.Append("  ConsentTracking: ").Append(ConsentTracking).Append("\n");
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
            return this.Equals(input as ConsentData);
        }

        /// <summary>
        /// Returns true if ConsentData instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsentData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsentIP == input.ConsentIP ||
                    (this.ConsentIP != null &&
                    this.ConsentIP.Equals(input.ConsentIP))
                ) && 
                (
                    this.ConsentDate == input.ConsentDate ||
                    (this.ConsentDate != null &&
                    this.ConsentDate.Equals(input.ConsentDate))
                ) && 
                (
                    this.ConsentTracking == input.ConsentTracking ||
                    this.ConsentTracking.Equals(input.ConsentTracking)
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
                if (this.ConsentIP != null)
                    hashCode = hashCode * 59 + this.ConsentIP.GetHashCode();
                if (this.ConsentDate != null)
                    hashCode = hashCode * 59 + this.ConsentDate.GetHashCode();
                hashCode = hashCode * 59 + this.ConsentTracking.GetHashCode();
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
