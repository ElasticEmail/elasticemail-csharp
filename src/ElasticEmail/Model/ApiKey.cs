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
    /// ApiKey info
    /// </summary>
    [DataContract(Name = "ApiKey")]
    public partial class ApiKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        /// <param name="accessLevel">Access level or permission to be assigned to this ApiKey..</param>
        /// <param name="name">Name of the ApiKey..</param>
        /// <param name="dateCreated">Date this ApiKey was created..</param>
        /// <param name="lastUse">Date this ApiKey was last used..</param>
        /// <param name="expires">Date this ApiKey expires..</param>
        /// <param name="restrictAccessToIPRange">Which IPs can use this ApiKey.</param>
        public ApiKey(List<AccessLevel> accessLevel = default(List<AccessLevel>), string name = default(string), DateTime dateCreated = default(DateTime), DateTime? lastUse = default(DateTime?), DateTime? expires = default(DateTime?), List<string> restrictAccessToIPRange = default(List<string>))
        {
            this.AccessLevel = accessLevel;
            this.Name = name;
            this.DateCreated = dateCreated;
            this.LastUse = lastUse;
            this.Expires = expires;
            this.RestrictAccessToIPRange = restrictAccessToIPRange;
        }

        /// <summary>
        /// Access level or permission to be assigned to this ApiKey.
        /// </summary>
        /// <value>Access level or permission to be assigned to this ApiKey.</value>
        [DataMember(Name = "AccessLevel", EmitDefaultValue = false)]
        public List<AccessLevel> AccessLevel { get; set; }

        /// <summary>
        /// Name of the ApiKey.
        /// </summary>
        /// <value>Name of the ApiKey.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Date this ApiKey was created.
        /// </summary>
        /// <value>Date this ApiKey was created.</value>
        [DataMember(Name = "DateCreated", EmitDefaultValue = false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Date this ApiKey was last used.
        /// </summary>
        /// <value>Date this ApiKey was last used.</value>
        [DataMember(Name = "LastUse", EmitDefaultValue = true)]
        public DateTime? LastUse { get; set; }

        /// <summary>
        /// Date this ApiKey expires.
        /// </summary>
        /// <value>Date this ApiKey expires.</value>
        [DataMember(Name = "Expires", EmitDefaultValue = true)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Which IPs can use this ApiKey
        /// </summary>
        /// <value>Which IPs can use this ApiKey</value>
        [DataMember(Name = "RestrictAccessToIPRange", EmitDefaultValue = false)]
        public List<string> RestrictAccessToIPRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiKey {\n");
            sb.Append("  AccessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  LastUse: ").Append(LastUse).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  RestrictAccessToIPRange: ").Append(RestrictAccessToIPRange).Append("\n");
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
