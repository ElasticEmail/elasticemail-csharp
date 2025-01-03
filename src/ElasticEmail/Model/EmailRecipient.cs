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
    /// List of recipients
    /// </summary>
    [DataContract(Name = "EmailRecipient")]
    public partial class EmailRecipient : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailRecipient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailRecipient() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailRecipient" /> class.
        /// </summary>
        /// <param name="email">Proper email address. (required).</param>
        /// <param name="fields">A key-value collection of merge fields which can be used in e-mail body..</param>
        public EmailRecipient(string email = default(string), Dictionary<string, string> fields = default(Dictionary<string, string>))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for EmailRecipient and cannot be null");
            }
            this.Email = email;
            this.Fields = fields;
        }

        /// <summary>
        /// Proper email address.
        /// </summary>
        /// <value>Proper email address.</value>
        /// <example>mail@example.com</example>
        [DataMember(Name = "Email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// A key-value collection of merge fields which can be used in e-mail body.
        /// </summary>
        /// <value>A key-value collection of merge fields which can be used in e-mail body.</value>
        /// <example>{&quot;city&quot;:&quot;New York&quot;,&quot;age&quot;:&quot;34&quot;}</example>
        [DataMember(Name = "Fields", EmitDefaultValue = false)]
        public Dictionary<string, string> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailRecipient {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
