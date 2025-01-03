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
    /// ListPayload
    /// </summary>
    [DataContract(Name = "ListPayload")]
    public partial class ListPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPayload" /> class.
        /// </summary>
        /// <param name="listName">Name of your list. (required).</param>
        /// <param name="allowUnsubscribe">True: Allow unsubscribing from this list. Otherwise, false.</param>
        /// <param name="emails">Comma delimited list of existing contact emails that should be added to this list. Leave empty for all contacts.</param>
        public ListPayload(string listName = default(string), bool allowUnsubscribe = default(bool), List<string> emails = default(List<string>))
        {
            // to ensure "listName" is required (not null)
            if (listName == null)
            {
                throw new ArgumentNullException("listName is a required property for ListPayload and cannot be null");
            }
            this.ListName = listName;
            this.AllowUnsubscribe = allowUnsubscribe;
            this.Emails = emails;
        }

        /// <summary>
        /// Name of your list.
        /// </summary>
        /// <value>Name of your list.</value>
        /// <example>My List 1</example>
        [DataMember(Name = "ListName", IsRequired = true, EmitDefaultValue = true)]
        public string ListName { get; set; }

        /// <summary>
        /// True: Allow unsubscribing from this list. Otherwise, false
        /// </summary>
        /// <value>True: Allow unsubscribing from this list. Otherwise, false</value>
        /// <example>false</example>
        [DataMember(Name = "AllowUnsubscribe", EmitDefaultValue = true)]
        public bool AllowUnsubscribe { get; set; }

        /// <summary>
        /// Comma delimited list of existing contact emails that should be added to this list. Leave empty for all contacts
        /// </summary>
        /// <value>Comma delimited list of existing contact emails that should be added to this list. Leave empty for all contacts</value>
        /// <example>[&quot;john.doe@sample.com&quot;]</example>
        [DataMember(Name = "Emails", EmitDefaultValue = false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListPayload {\n");
            sb.Append("  ListName: ").Append(ListName).Append("\n");
            sb.Append("  AllowUnsubscribe: ").Append(AllowUnsubscribe).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
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
