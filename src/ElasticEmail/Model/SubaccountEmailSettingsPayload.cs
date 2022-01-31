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
    /// Settings related to sending emails
    /// </summary>
    [DataContract(Name = "SubaccountEmailSettingsPayload")]
    public partial class SubaccountEmailSettingsPayload : IEquatable<SubaccountEmailSettingsPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubaccountEmailSettingsPayload" /> class.
        /// </summary>
        /// <param name="requiresEmailCredits">True, if Account needs credits to send emails. Otherwise, false.</param>
        /// <param name="emailSizeLimit">Maximum size of email including attachments in MB&#39;s.</param>
        /// <param name="dailySendLimit">Amount of emails Account can send daily.</param>
        /// <param name="maxContacts">Maximum number of contacts the Account can have. 0 means that parent account&#39;s limit is used..</param>
        /// <param name="enablePrivateIPPurchase">Can the SubAccount purchase Private IP for themselves.</param>
        /// <param name="poolName">Name of your custom IP Pool to be used in the sending process.</param>
        /// <param name="validSenderDomainOnly">validSenderDomainOnly.</param>
        public SubaccountEmailSettingsPayload(bool requiresEmailCredits = default(bool), int emailSizeLimit = default(int), int dailySendLimit = default(int), int maxContacts = default(int), bool enablePrivateIPPurchase = default(bool), string poolName = default(string), bool? validSenderDomainOnly = default(bool?))
        {
            this.RequiresEmailCredits = requiresEmailCredits;
            this.EmailSizeLimit = emailSizeLimit;
            this.DailySendLimit = dailySendLimit;
            this.MaxContacts = maxContacts;
            this.EnablePrivateIPPurchase = enablePrivateIPPurchase;
            this.PoolName = poolName;
            this.ValidSenderDomainOnly = validSenderDomainOnly;
        }

        /// <summary>
        /// True, if Account needs credits to send emails. Otherwise, false
        /// </summary>
        /// <value>True, if Account needs credits to send emails. Otherwise, false</value>
        [DataMember(Name = "RequiresEmailCredits", EmitDefaultValue = true)]
        public bool RequiresEmailCredits { get; set; }

        /// <summary>
        /// Maximum size of email including attachments in MB&#39;s
        /// </summary>
        /// <value>Maximum size of email including attachments in MB&#39;s</value>
        [DataMember(Name = "EmailSizeLimit", EmitDefaultValue = false)]
        public int EmailSizeLimit { get; set; }

        /// <summary>
        /// Amount of emails Account can send daily
        /// </summary>
        /// <value>Amount of emails Account can send daily</value>
        [DataMember(Name = "DailySendLimit", EmitDefaultValue = false)]
        public int DailySendLimit { get; set; }

        /// <summary>
        /// Maximum number of contacts the Account can have. 0 means that parent account&#39;s limit is used.
        /// </summary>
        /// <value>Maximum number of contacts the Account can have. 0 means that parent account&#39;s limit is used.</value>
        [DataMember(Name = "MaxContacts", EmitDefaultValue = false)]
        public int MaxContacts { get; set; }

        /// <summary>
        /// Can the SubAccount purchase Private IP for themselves
        /// </summary>
        /// <value>Can the SubAccount purchase Private IP for themselves</value>
        [DataMember(Name = "EnablePrivateIPPurchase", EmitDefaultValue = true)]
        public bool EnablePrivateIPPurchase { get; set; }

        /// <summary>
        /// Name of your custom IP Pool to be used in the sending process
        /// </summary>
        /// <value>Name of your custom IP Pool to be used in the sending process</value>
        [DataMember(Name = "PoolName", EmitDefaultValue = false)]
        public string PoolName { get; set; }

        /// <summary>
        /// Gets or Sets ValidSenderDomainOnly
        /// </summary>
        [DataMember(Name = "ValidSenderDomainOnly", EmitDefaultValue = true)]
        public bool? ValidSenderDomainOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubaccountEmailSettingsPayload {\n");
            sb.Append("  RequiresEmailCredits: ").Append(RequiresEmailCredits).Append("\n");
            sb.Append("  EmailSizeLimit: ").Append(EmailSizeLimit).Append("\n");
            sb.Append("  DailySendLimit: ").Append(DailySendLimit).Append("\n");
            sb.Append("  MaxContacts: ").Append(MaxContacts).Append("\n");
            sb.Append("  EnablePrivateIPPurchase: ").Append(EnablePrivateIPPurchase).Append("\n");
            sb.Append("  PoolName: ").Append(PoolName).Append("\n");
            sb.Append("  ValidSenderDomainOnly: ").Append(ValidSenderDomainOnly).Append("\n");
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
            return this.Equals(input as SubaccountEmailSettingsPayload);
        }

        /// <summary>
        /// Returns true if SubaccountEmailSettingsPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of SubaccountEmailSettingsPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubaccountEmailSettingsPayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequiresEmailCredits == input.RequiresEmailCredits ||
                    this.RequiresEmailCredits.Equals(input.RequiresEmailCredits)
                ) && 
                (
                    this.EmailSizeLimit == input.EmailSizeLimit ||
                    this.EmailSizeLimit.Equals(input.EmailSizeLimit)
                ) && 
                (
                    this.DailySendLimit == input.DailySendLimit ||
                    this.DailySendLimit.Equals(input.DailySendLimit)
                ) && 
                (
                    this.MaxContacts == input.MaxContacts ||
                    this.MaxContacts.Equals(input.MaxContacts)
                ) && 
                (
                    this.EnablePrivateIPPurchase == input.EnablePrivateIPPurchase ||
                    this.EnablePrivateIPPurchase.Equals(input.EnablePrivateIPPurchase)
                ) && 
                (
                    this.PoolName == input.PoolName ||
                    (this.PoolName != null &&
                    this.PoolName.Equals(input.PoolName))
                ) && 
                (
                    this.ValidSenderDomainOnly == input.ValidSenderDomainOnly ||
                    (this.ValidSenderDomainOnly != null &&
                    this.ValidSenderDomainOnly.Equals(input.ValidSenderDomainOnly))
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
                hashCode = (hashCode * 59) + this.RequiresEmailCredits.GetHashCode();
                hashCode = (hashCode * 59) + this.EmailSizeLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.DailySendLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxContacts.GetHashCode();
                hashCode = (hashCode * 59) + this.EnablePrivateIPPurchase.GetHashCode();
                if (this.PoolName != null)
                {
                    hashCode = (hashCode * 59) + this.PoolName.GetHashCode();
                }
                if (this.ValidSenderDomainOnly != null)
                {
                    hashCode = (hashCode * 59) + this.ValidSenderDomainOnly.GetHashCode();
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
