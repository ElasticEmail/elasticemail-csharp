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
    /// Detailed information about SubAccount.
    /// </summary>
    [DataContract(Name = "SubAccountInfo")]
    public partial class SubAccountInfo : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public AccountStatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccountInfo" /> class.
        /// </summary>
        /// <param name="publicAccountID">Public key for limited access to your Account such as contact/add so you can use it safely on public websites..</param>
        /// <param name="email">Proper email address..</param>
        /// <param name="settings">settings.</param>
        /// <param name="lastActivity">Date of last activity on Account.</param>
        /// <param name="emailCredits">Amount of email credits.</param>
        /// <param name="totalEmailsSent">Amount of emails sent from this Account.</param>
        /// <param name="reputation">Numeric reputation.</param>
        /// <param name="status">status.</param>
        /// <param name="contactsCount">How many contacts this SubAccount has stored.</param>
        public SubAccountInfo(string publicAccountID = default(string), string email = default(string), SubaccountSettingsInfo settings = default(SubaccountSettingsInfo), DateTime lastActivity = default(DateTime), int emailCredits = default(int), long totalEmailsSent = default(long), double reputation = default(double), AccountStatusEnum? status = default(AccountStatusEnum?), int contactsCount = default(int))
        {
            this.PublicAccountID = publicAccountID;
            this.Email = email;
            this.Settings = settings;
            this.LastActivity = lastActivity;
            this.EmailCredits = emailCredits;
            this.TotalEmailsSent = totalEmailsSent;
            this.Reputation = reputation;
            this.Status = status;
            this.ContactsCount = contactsCount;
        }

        /// <summary>
        /// Public key for limited access to your Account such as contact/add so you can use it safely on public websites.
        /// </summary>
        /// <value>Public key for limited access to your Account such as contact/add so you can use it safely on public websites.</value>
        /// <example>EB3EBB7A-C20D-4D39-8F2F-5E6842F58E6F</example>
        [DataMember(Name = "PublicAccountID", EmitDefaultValue = false)]
        public string PublicAccountID { get; set; }

        /// <summary>
        /// Proper email address.
        /// </summary>
        /// <value>Proper email address.</value>
        /// <example>mail@example.com</example>
        [DataMember(Name = "Email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "Settings", EmitDefaultValue = false)]
        public SubaccountSettingsInfo Settings { get; set; }

        /// <summary>
        /// Date of last activity on Account
        /// </summary>
        /// <value>Date of last activity on Account</value>
        [DataMember(Name = "LastActivity", EmitDefaultValue = false)]
        public DateTime LastActivity { get; set; }

        /// <summary>
        /// Amount of email credits
        /// </summary>
        /// <value>Amount of email credits</value>
        /// <example>1000</example>
        [DataMember(Name = "EmailCredits", EmitDefaultValue = false)]
        public int EmailCredits { get; set; }

        /// <summary>
        /// Amount of emails sent from this Account
        /// </summary>
        /// <value>Amount of emails sent from this Account</value>
        /// <example>1000</example>
        [DataMember(Name = "TotalEmailsSent", EmitDefaultValue = false)]
        public long TotalEmailsSent { get; set; }

        /// <summary>
        /// Numeric reputation
        /// </summary>
        /// <value>Numeric reputation</value>
        /// <example>100</example>
        [DataMember(Name = "Reputation", EmitDefaultValue = false)]
        public double Reputation { get; set; }

        /// <summary>
        /// How many contacts this SubAccount has stored
        /// </summary>
        /// <value>How many contacts this SubAccount has stored</value>
        [DataMember(Name = "ContactsCount", EmitDefaultValue = false)]
        public int ContactsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubAccountInfo {\n");
            sb.Append("  PublicAccountID: ").Append(PublicAccountID).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  LastActivity: ").Append(LastActivity).Append("\n");
            sb.Append("  EmailCredits: ").Append(EmailCredits).Append("\n");
            sb.Append("  TotalEmailsSent: ").Append(TotalEmailsSent).Append("\n");
            sb.Append("  Reputation: ").Append(Reputation).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ContactsCount: ").Append(ContactsCount).Append("\n");
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
