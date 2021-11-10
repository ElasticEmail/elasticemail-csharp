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
    /// ListUpdatePayload
    /// </summary>
    [DataContract(Name = "ListUpdatePayload")]
    public partial class ListUpdatePayload : IEquatable<ListUpdatePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUpdatePayload" /> class.
        /// </summary>
        /// <param name="newListName">Name of your list if you want to change it..</param>
        /// <param name="allowUnsubscribe">True: Allow unsubscribing from this list. Otherwise, false.</param>
        public ListUpdatePayload(string newListName = default(string), bool allowUnsubscribe = default(bool))
        {
            this.NewListName = newListName;
            this.AllowUnsubscribe = allowUnsubscribe;
        }

        /// <summary>
        /// Name of your list if you want to change it.
        /// </summary>
        /// <value>Name of your list if you want to change it.</value>
        [DataMember(Name = "NewListName", EmitDefaultValue = false)]
        public string NewListName { get; set; }

        /// <summary>
        /// True: Allow unsubscribing from this list. Otherwise, false
        /// </summary>
        /// <value>True: Allow unsubscribing from this list. Otherwise, false</value>
        [DataMember(Name = "AllowUnsubscribe", EmitDefaultValue = true)]
        public bool AllowUnsubscribe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUpdatePayload {\n");
            sb.Append("  NewListName: ").Append(NewListName).Append("\n");
            sb.Append("  AllowUnsubscribe: ").Append(AllowUnsubscribe).Append("\n");
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
            return this.Equals(input as ListUpdatePayload);
        }

        /// <summary>
        /// Returns true if ListUpdatePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of ListUpdatePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListUpdatePayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewListName == input.NewListName ||
                    (this.NewListName != null &&
                    this.NewListName.Equals(input.NewListName))
                ) && 
                (
                    this.AllowUnsubscribe == input.AllowUnsubscribe ||
                    this.AllowUnsubscribe.Equals(input.AllowUnsubscribe)
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
                if (this.NewListName != null)
                    hashCode = hashCode * 59 + this.NewListName.GetHashCode();
                hashCode = hashCode * 59 + this.AllowUnsubscribe.GetHashCode();
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
