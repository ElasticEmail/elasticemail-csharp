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
    /// SegmentPayload
    /// </summary>
    [DataContract(Name = "SegmentPayload")]
    public partial class SegmentPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SegmentPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentPayload" /> class.
        /// </summary>
        /// <param name="name">Segment name (required).</param>
        /// <param name="rule">SQL-like rule to determine which Contacts belong to this Segment. Help for building a segment rule can be found here: https://help.elasticemail.com/en/articles/5162182-segment-rules (required).</param>
        public SegmentPayload(string name = default(string), string rule = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SegmentPayload and cannot be null");
            }
            this.Name = name;
            // to ensure "rule" is required (not null)
            if (rule == null)
            {
                throw new ArgumentNullException("rule is a required property for SegmentPayload and cannot be null");
            }
            this.Rule = rule;
        }

        /// <summary>
        /// Segment name
        /// </summary>
        /// <value>Segment name</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// SQL-like rule to determine which Contacts belong to this Segment. Help for building a segment rule can be found here: https://help.elasticemail.com/en/articles/5162182-segment-rules
        /// </summary>
        /// <value>SQL-like rule to determine which Contacts belong to this Segment. Help for building a segment rule can be found here: https://help.elasticemail.com/en/articles/5162182-segment-rules</value>
        [DataMember(Name = "Rule", IsRequired = true, EmitDefaultValue = true)]
        public string Rule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SegmentPayload {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
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
