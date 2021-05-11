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
    /// List of transactional recipients
    /// </summary>
    [DataContract(Name = "TransactionalRecipient")]
    public partial class TransactionalRecipient : IEquatable<TransactionalRecipient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionalRecipient" /> class.
        /// </summary>
        /// <param name="to">List of recipients (visible to others).</param>
        /// <param name="cC">List of Carbon Copy recipients (visible to others).</param>
        /// <param name="bCC">List of Blind Carbon Copy recipients (hidden from other recipients).</param>
        public TransactionalRecipient(List<string> to = default(List<string>), List<string> cC = default(List<string>), List<string> bCC = default(List<string>))
        {
            this.To = to;
            this.CC = cC;
            this.BCC = bCC;
        }

        /// <summary>
        /// List of recipients (visible to others)
        /// </summary>
        /// <value>List of recipients (visible to others)</value>
        [DataMember(Name = "To", EmitDefaultValue = false)]
        public List<string> To { get; set; }

        /// <summary>
        /// List of Carbon Copy recipients (visible to others)
        /// </summary>
        /// <value>List of Carbon Copy recipients (visible to others)</value>
        [DataMember(Name = "CC", EmitDefaultValue = false)]
        public List<string> CC { get; set; }

        /// <summary>
        /// List of Blind Carbon Copy recipients (hidden from other recipients)
        /// </summary>
        /// <value>List of Blind Carbon Copy recipients (hidden from other recipients)</value>
        [DataMember(Name = "BCC", EmitDefaultValue = false)]
        public List<string> BCC { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionalRecipient {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  CC: ").Append(CC).Append("\n");
            sb.Append("  BCC: ").Append(BCC).Append("\n");
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
            return this.Equals(input as TransactionalRecipient);
        }

        /// <summary>
        /// Returns true if TransactionalRecipient instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionalRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionalRecipient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.CC == input.CC ||
                    this.CC != null &&
                    input.CC != null &&
                    this.CC.SequenceEqual(input.CC)
                ) && 
                (
                    this.BCC == input.BCC ||
                    this.BCC != null &&
                    input.BCC != null &&
                    this.BCC.SequenceEqual(input.BCC)
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
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.CC != null)
                    hashCode = hashCode * 59 + this.CC.GetHashCode();
                if (this.BCC != null)
                    hashCode = hashCode * 59 + this.BCC.GetHashCode();
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
