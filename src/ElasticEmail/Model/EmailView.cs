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
    /// Email details formatted in json
    /// </summary>
    [DataContract(Name = "EmailView")]
    public partial class EmailView : IEquatable<EmailView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailView" /> class.
        /// </summary>
        /// <param name="body">Body (HTML, otherwise plain text) of email.</param>
        /// <param name="subject">Default subject of email..</param>
        /// <param name="from">From email address.</param>
        public EmailView(string body = default(string), string subject = default(string), string from = default(string))
        {
            this.Body = body;
            this.Subject = subject;
            this.From = from;
        }

        /// <summary>
        /// Body (HTML, otherwise plain text) of email
        /// </summary>
        /// <value>Body (HTML, otherwise plain text) of email</value>
        [DataMember(Name = "Body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Default subject of email.
        /// </summary>
        /// <value>Default subject of email.</value>
        [DataMember(Name = "Subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// From email address
        /// </summary>
        /// <value>From email address</value>
        [DataMember(Name = "From", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailView {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
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
            return this.Equals(input as EmailView);
        }

        /// <summary>
        /// Returns true if EmailView instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailView input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
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
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
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
