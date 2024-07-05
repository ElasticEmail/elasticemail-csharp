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
    /// InboundPayload
    /// </summary>
    [DataContract(Name = "InboundPayload")]
    public partial class InboundPayload : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FilterType
        /// </summary>
        [DataMember(Name = "FilterType", IsRequired = true, EmitDefaultValue = true)]
        public InboundRouteFilterType FilterType { get; set; }

        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name = "ActionType", IsRequired = true, EmitDefaultValue = true)]
        public InboundRouteActionType ActionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboundPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPayload" /> class.
        /// </summary>
        /// <param name="filter">Filter of the inbound data (required).</param>
        /// <param name="name">Name of this route (required).</param>
        /// <param name="filterType">filterType (required).</param>
        /// <param name="actionType">actionType (required).</param>
        /// <param name="emailAddress">Email to forward the inbound to.</param>
        /// <param name="httpAddress">Address to notify about the inbound.</param>
        public InboundPayload(string filter = default(string), string name = default(string), InboundRouteFilterType filterType = default(InboundRouteFilterType), InboundRouteActionType actionType = default(InboundRouteActionType), string emailAddress = default(string), string httpAddress = default(string))
        {
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new ArgumentNullException("filter is a required property for InboundPayload and cannot be null");
            }
            this.Filter = filter;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for InboundPayload and cannot be null");
            }
            this.Name = name;
            this.FilterType = filterType;
            this.ActionType = actionType;
            this.EmailAddress = emailAddress;
            this.HttpAddress = httpAddress;
        }

        /// <summary>
        /// Filter of the inbound data
        /// </summary>
        /// <value>Filter of the inbound data</value>
        [DataMember(Name = "Filter", IsRequired = true, EmitDefaultValue = true)]
        public string Filter { get; set; }

        /// <summary>
        /// Name of this route
        /// </summary>
        /// <value>Name of this route</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Email to forward the inbound to
        /// </summary>
        /// <value>Email to forward the inbound to</value>
        [DataMember(Name = "EmailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Address to notify about the inbound
        /// </summary>
        /// <value>Address to notify about the inbound</value>
        [DataMember(Name = "HttpAddress", EmitDefaultValue = false)]
        public string HttpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InboundPayload {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  HttpAddress: ").Append(HttpAddress).Append("\n");
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
