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
    /// EmailJobStatus
    /// </summary>
    [DataContract(Name = "EmailJobStatus")]
    public partial class EmailJobStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailJobStatus" /> class.
        /// </summary>
        /// <param name="iD">ID number of your attachment.</param>
        /// <param name="status">Name of status: submitted, complete, in_progress.</param>
        /// <param name="recipientsCount">recipientsCount.</param>
        /// <param name="failed">failed.</param>
        /// <param name="failedCount">Total emails failed..</param>
        /// <param name="sent">sent.</param>
        /// <param name="sentCount">Total emails sent..</param>
        /// <param name="delivered">Number of delivered messages.</param>
        /// <param name="deliveredCount">deliveredCount.</param>
        /// <param name="pending">pending.</param>
        /// <param name="pendingCount">pendingCount.</param>
        /// <param name="opened">Number of opened messages.</param>
        /// <param name="openedCount">Total emails opened..</param>
        /// <param name="clicked">Number of clicked messages.</param>
        /// <param name="clickedCount">Total emails clicked.</param>
        /// <param name="unsubscribed">Number of unsubscribed messages.</param>
        /// <param name="unsubscribedCount">Total emails unsubscribed.</param>
        /// <param name="abuseReports">abuseReports.</param>
        /// <param name="abuseReportsCount">abuseReportsCount.</param>
        /// <param name="messageIDs">List of all MessageIDs for this job..</param>
        public EmailJobStatus(string iD = default(string), string status = default(string), int recipientsCount = default(int), List<EmailJobFailedStatus> failed = default(List<EmailJobFailedStatus>), int failedCount = default(int), List<string> sent = default(List<string>), int sentCount = default(int), List<string> delivered = default(List<string>), int deliveredCount = default(int), List<string> pending = default(List<string>), int pendingCount = default(int), List<string> opened = default(List<string>), int openedCount = default(int), List<string> clicked = default(List<string>), int clickedCount = default(int), List<string> unsubscribed = default(List<string>), int unsubscribedCount = default(int), List<string> abuseReports = default(List<string>), int abuseReportsCount = default(int), List<string> messageIDs = default(List<string>))
        {
            this.ID = iD;
            this.Status = status;
            this.RecipientsCount = recipientsCount;
            this.Failed = failed;
            this.FailedCount = failedCount;
            this.Sent = sent;
            this.SentCount = sentCount;
            this.Delivered = delivered;
            this.DeliveredCount = deliveredCount;
            this.Pending = pending;
            this.PendingCount = pendingCount;
            this.Opened = opened;
            this.OpenedCount = openedCount;
            this.Clicked = clicked;
            this.ClickedCount = clickedCount;
            this.Unsubscribed = unsubscribed;
            this.UnsubscribedCount = unsubscribedCount;
            this.AbuseReports = abuseReports;
            this.AbuseReportsCount = abuseReportsCount;
            this.MessageIDs = messageIDs;
        }

        /// <summary>
        /// ID number of your attachment
        /// </summary>
        /// <value>ID number of your attachment</value>
        /// <example>123456</example>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; }

        /// <summary>
        /// Name of status: submitted, complete, in_progress
        /// </summary>
        /// <value>Name of status: submitted, complete, in_progress</value>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets RecipientsCount
        /// </summary>
        [DataMember(Name = "RecipientsCount", EmitDefaultValue = false)]
        public int RecipientsCount { get; set; }

        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name = "Failed", EmitDefaultValue = false)]
        public List<EmailJobFailedStatus> Failed { get; set; }

        /// <summary>
        /// Total emails failed.
        /// </summary>
        /// <value>Total emails failed.</value>
        /// <example>1000</example>
        [DataMember(Name = "FailedCount", EmitDefaultValue = false)]
        public int FailedCount { get; set; }

        /// <summary>
        /// Gets or Sets Sent
        /// </summary>
        [DataMember(Name = "Sent", EmitDefaultValue = false)]
        public List<string> Sent { get; set; }

        /// <summary>
        /// Total emails sent.
        /// </summary>
        /// <value>Total emails sent.</value>
        /// <example>1000</example>
        [DataMember(Name = "SentCount", EmitDefaultValue = false)]
        public int SentCount { get; set; }

        /// <summary>
        /// Number of delivered messages
        /// </summary>
        /// <value>Number of delivered messages</value>
        /// <example>[&quot;1000&quot;]</example>
        [DataMember(Name = "Delivered", EmitDefaultValue = false)]
        public List<string> Delivered { get; set; }

        /// <summary>
        /// Gets or Sets DeliveredCount
        /// </summary>
        [DataMember(Name = "DeliveredCount", EmitDefaultValue = false)]
        public int DeliveredCount { get; set; }

        /// <summary>
        /// Gets or Sets Pending
        /// </summary>
        [DataMember(Name = "Pending", EmitDefaultValue = false)]
        public List<string> Pending { get; set; }

        /// <summary>
        /// Gets or Sets PendingCount
        /// </summary>
        [DataMember(Name = "PendingCount", EmitDefaultValue = false)]
        public int PendingCount { get; set; }

        /// <summary>
        /// Number of opened messages
        /// </summary>
        /// <value>Number of opened messages</value>
        /// <example>[&quot;1000&quot;]</example>
        [DataMember(Name = "Opened", EmitDefaultValue = false)]
        public List<string> Opened { get; set; }

        /// <summary>
        /// Total emails opened.
        /// </summary>
        /// <value>Total emails opened.</value>
        /// <example>1000</example>
        [DataMember(Name = "OpenedCount", EmitDefaultValue = false)]
        public int OpenedCount { get; set; }

        /// <summary>
        /// Number of clicked messages
        /// </summary>
        /// <value>Number of clicked messages</value>
        /// <example>[&quot;1000&quot;]</example>
        [DataMember(Name = "Clicked", EmitDefaultValue = false)]
        public List<string> Clicked { get; set; }

        /// <summary>
        /// Total emails clicked
        /// </summary>
        /// <value>Total emails clicked</value>
        /// <example>1000</example>
        [DataMember(Name = "ClickedCount", EmitDefaultValue = false)]
        public int ClickedCount { get; set; }

        /// <summary>
        /// Number of unsubscribed messages
        /// </summary>
        /// <value>Number of unsubscribed messages</value>
        /// <example>[&quot;1000&quot;]</example>
        [DataMember(Name = "Unsubscribed", EmitDefaultValue = false)]
        public List<string> Unsubscribed { get; set; }

        /// <summary>
        /// Total emails unsubscribed
        /// </summary>
        /// <value>Total emails unsubscribed</value>
        /// <example>1000</example>
        [DataMember(Name = "UnsubscribedCount", EmitDefaultValue = false)]
        public int UnsubscribedCount { get; set; }

        /// <summary>
        /// Gets or Sets AbuseReports
        /// </summary>
        [DataMember(Name = "AbuseReports", EmitDefaultValue = false)]
        public List<string> AbuseReports { get; set; }

        /// <summary>
        /// Gets or Sets AbuseReportsCount
        /// </summary>
        [DataMember(Name = "AbuseReportsCount", EmitDefaultValue = false)]
        public int AbuseReportsCount { get; set; }

        /// <summary>
        /// List of all MessageIDs for this job.
        /// </summary>
        /// <value>List of all MessageIDs for this job.</value>
        [DataMember(Name = "MessageIDs", EmitDefaultValue = false)]
        public List<string> MessageIDs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailJobStatus {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RecipientsCount: ").Append(RecipientsCount).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  FailedCount: ").Append(FailedCount).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  SentCount: ").Append(SentCount).Append("\n");
            sb.Append("  Delivered: ").Append(Delivered).Append("\n");
            sb.Append("  DeliveredCount: ").Append(DeliveredCount).Append("\n");
            sb.Append("  Pending: ").Append(Pending).Append("\n");
            sb.Append("  PendingCount: ").Append(PendingCount).Append("\n");
            sb.Append("  Opened: ").Append(Opened).Append("\n");
            sb.Append("  OpenedCount: ").Append(OpenedCount).Append("\n");
            sb.Append("  Clicked: ").Append(Clicked).Append("\n");
            sb.Append("  ClickedCount: ").Append(ClickedCount).Append("\n");
            sb.Append("  Unsubscribed: ").Append(Unsubscribed).Append("\n");
            sb.Append("  UnsubscribedCount: ").Append(UnsubscribedCount).Append("\n");
            sb.Append("  AbuseReports: ").Append(AbuseReports).Append("\n");
            sb.Append("  AbuseReportsCount: ").Append(AbuseReportsCount).Append("\n");
            sb.Append("  MessageIDs: ").Append(MessageIDs).Append("\n");
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