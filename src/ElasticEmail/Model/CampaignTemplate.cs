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
    /// Content of a Campaign
    /// </summary>
    [DataContract(Name = "CampaignTemplate")]
    public partial class CampaignTemplate : IEquatable<CampaignTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignTemplate" /> class.
        /// </summary>
        /// <param name="poolname">Name of your custom IP Pool to be used in the sending process.</param>
        /// <param name="from">Your e-mail with an optional name (e.g.: John Doe &lt;email@domain.com&gt;).</param>
        /// <param name="replyTo">To what address should the recipients reply to (e.g. John Doe &lt;email@domain.com&gt;).</param>
        /// <param name="subject">Default subject of email..</param>
        /// <param name="templateName">Name of template..</param>
        /// <param name="attachFiles">Names of previously uploaded files that should be sent as downloadable attachments.</param>
        /// <param name="utm">utm.</param>
        public CampaignTemplate(string poolname = default(string), string from = default(string), string replyTo = default(string), string subject = default(string), string templateName = default(string), List<string> attachFiles = default(List<string>), Utm utm = default(Utm))
        {
            this.Poolname = poolname;
            this.From = from;
            this.ReplyTo = replyTo;
            this.Subject = subject;
            this.TemplateName = templateName;
            this.AttachFiles = attachFiles;
            this.Utm = utm;
        }

        /// <summary>
        /// Name of your custom IP Pool to be used in the sending process
        /// </summary>
        /// <value>Name of your custom IP Pool to be used in the sending process</value>
        [DataMember(Name = "Poolname", EmitDefaultValue = false)]
        public string Poolname { get; set; }

        /// <summary>
        /// Your e-mail with an optional name (e.g.: John Doe &lt;email@domain.com&gt;)
        /// </summary>
        /// <value>Your e-mail with an optional name (e.g.: John Doe &lt;email@domain.com&gt;)</value>
        [DataMember(Name = "From", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// To what address should the recipients reply to (e.g. John Doe &lt;email@domain.com&gt;)
        /// </summary>
        /// <value>To what address should the recipients reply to (e.g. John Doe &lt;email@domain.com&gt;)</value>
        [DataMember(Name = "ReplyTo", EmitDefaultValue = false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Default subject of email.
        /// </summary>
        /// <value>Default subject of email.</value>
        [DataMember(Name = "Subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Name of template.
        /// </summary>
        /// <value>Name of template.</value>
        [DataMember(Name = "TemplateName", EmitDefaultValue = false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Names of previously uploaded files that should be sent as downloadable attachments
        /// </summary>
        /// <value>Names of previously uploaded files that should be sent as downloadable attachments</value>
        [DataMember(Name = "AttachFiles", EmitDefaultValue = false)]
        public List<string> AttachFiles { get; set; }

        /// <summary>
        /// Gets or Sets Utm
        /// </summary>
        [DataMember(Name = "Utm", EmitDefaultValue = false)]
        public Utm Utm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CampaignTemplate {\n");
            sb.Append("  Poolname: ").Append(Poolname).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  AttachFiles: ").Append(AttachFiles).Append("\n");
            sb.Append("  Utm: ").Append(Utm).Append("\n");
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
            return this.Equals(input as CampaignTemplate);
        }

        /// <summary>
        /// Returns true if CampaignTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignTemplate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Poolname == input.Poolname ||
                    (this.Poolname != null &&
                    this.Poolname.Equals(input.Poolname))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.AttachFiles == input.AttachFiles ||
                    this.AttachFiles != null &&
                    input.AttachFiles != null &&
                    this.AttachFiles.SequenceEqual(input.AttachFiles)
                ) && 
                (
                    this.Utm == input.Utm ||
                    (this.Utm != null &&
                    this.Utm.Equals(input.Utm))
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
                if (this.Poolname != null)
                {
                    hashCode = (hashCode * 59) + this.Poolname.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.ReplyTo != null)
                {
                    hashCode = (hashCode * 59) + this.ReplyTo.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.TemplateName != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateName.GetHashCode();
                }
                if (this.AttachFiles != null)
                {
                    hashCode = (hashCode * 59) + this.AttachFiles.GetHashCode();
                }
                if (this.Utm != null)
                {
                    hashCode = (hashCode * 59) + this.Utm.GetHashCode();
                }
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
