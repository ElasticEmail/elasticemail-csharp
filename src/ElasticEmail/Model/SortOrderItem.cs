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
    /// Change the ordering of this inbound route for when matching the inbound
    /// </summary>
    [DataContract(Name = "SortOrderItem")]
    public partial class SortOrderItem : IEquatable<SortOrderItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortOrderItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SortOrderItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SortOrderItem" /> class.
        /// </summary>
        /// <param name="publicInboundId">ID of the route to change the order of (required).</param>
        /// <param name="sortOrder">1 - route will be used first (required).</param>
        public SortOrderItem(string publicInboundId = default(string), int sortOrder = default(int))
        {
            // to ensure "publicInboundId" is required (not null)
            if (publicInboundId == null)
            {
                throw new ArgumentNullException("publicInboundId is a required property for SortOrderItem and cannot be null");
            }
            this.PublicInboundId = publicInboundId;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// ID of the route to change the order of
        /// </summary>
        /// <value>ID of the route to change the order of</value>
        [DataMember(Name = "PublicInboundId", IsRequired = true, EmitDefaultValue = true)]
        public string PublicInboundId { get; set; }

        /// <summary>
        /// 1 - route will be used first
        /// </summary>
        /// <value>1 - route will be used first</value>
        [DataMember(Name = "SortOrder", IsRequired = true, EmitDefaultValue = true)]
        public int SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SortOrderItem {\n");
            sb.Append("  PublicInboundId: ").Append(PublicInboundId).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as SortOrderItem);
        }

        /// <summary>
        /// Returns true if SortOrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SortOrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SortOrderItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PublicInboundId == input.PublicInboundId ||
                    (this.PublicInboundId != null &&
                    this.PublicInboundId.Equals(input.PublicInboundId))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder.Equals(input.SortOrder)
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
                if (this.PublicInboundId != null)
                {
                    hashCode = (hashCode * 59) + this.PublicInboundId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SortOrder.GetHashCode();
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
