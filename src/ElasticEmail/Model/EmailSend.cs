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
    /// EmailSend
    /// </summary>
    [DataContract(Name = "EmailSend")]
    public partial class EmailSend : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSend" /> class.
        /// </summary>
        /// <param name="transactionID">ID number of transaction.</param>
        /// <param name="messageID">Unique identifier for this email..</param>
        public EmailSend(string transactionID = default(string), string messageID = default(string))
        {
            this.TransactionID = transactionID;
            this.MessageID = messageID;
        }

        /// <summary>
        /// ID number of transaction
        /// </summary>
        /// <value>ID number of transaction</value>
        /// <example>TransactionID</example>
        [DataMember(Name = "TransactionID", EmitDefaultValue = false)]
        public string TransactionID { get; set; }

        /// <summary>
        /// Unique identifier for this email.
        /// </summary>
        /// <value>Unique identifier for this email.</value>
        /// <example>-HHGPM_9RPhSMiaJq_ab4g3</example>
        [DataMember(Name = "MessageID", EmitDefaultValue = false)]
        public string MessageID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailSend {\n");
            sb.Append("  TransactionID: ").Append(TransactionID).Append("\n");
            sb.Append("  MessageID: ").Append(MessageID).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
