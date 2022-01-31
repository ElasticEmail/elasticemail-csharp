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
    /// New template object
    /// </summary>
    [DataContract(Name = "TemplatePayload")]
    public partial class TemplatePayload : IEquatable<TemplatePayload>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TemplateScope
        /// </summary>
        [DataMember(Name = "TemplateScope", EmitDefaultValue = false)]
        public TemplateScope? TemplateScope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatePayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplatePayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatePayload" /> class.
        /// </summary>
        /// <param name="name">Template name (required).</param>
        /// <param name="subject">Default subject of email..</param>
        /// <param name="body">Email content of this template.</param>
        /// <param name="templateScope">templateScope.</param>
        public TemplatePayload(string name = default(string), string subject = default(string), List<BodyPart> body = default(List<BodyPart>), TemplateScope? templateScope = default(TemplateScope?))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for TemplatePayload and cannot be null");
            }
            this.Name = name;
            this.Subject = subject;
            this.Body = body;
            this.TemplateScope = templateScope;
        }

        /// <summary>
        /// Template name
        /// </summary>
        /// <value>Template name</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Default subject of email.
        /// </summary>
        /// <value>Default subject of email.</value>
        [DataMember(Name = "Subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Email content of this template
        /// </summary>
        /// <value>Email content of this template</value>
        [DataMember(Name = "Body", EmitDefaultValue = false)]
        public List<BodyPart> Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplatePayload {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  TemplateScope: ").Append(TemplateScope).Append("\n");
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
            return this.Equals(input as TemplatePayload);
        }

        /// <summary>
        /// Returns true if TemplatePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplatePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplatePayload input)
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
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Body == input.Body ||
                    this.Body != null &&
                    input.Body != null &&
                    this.Body.SequenceEqual(input.Body)
                ) && 
                (
                    this.TemplateScope == input.TemplateScope ||
                    this.TemplateScope.Equals(input.TemplateScope)
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
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TemplateScope.GetHashCode();
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
