/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    To start using this API, you will need your Access Token (available <a href=\"https://elasticemail.com/account#/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    This is the documentation for REST API. If you’d like to read our legacy documentation regarding Web API v2 click <a href=\"https://api.elasticemail.com/public/help\">here</a>.
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
    /// Detailed information about message recipient
    /// </summary>
    [DataContract(Name = "RecipientEvent")]
    public partial class RecipientEvent : IEquatable<RecipientEvent>, IValidatableObject
    {
        /// <summary>
        /// Type of an Event
        /// </summary>
        /// <value>Type of an Event</value>
        [DataMember(Name = "EventType", EmitDefaultValue = false)]
        public EventType? EventType { get; set; }
        /// <summary>
        /// Message category
        /// </summary>
        /// <value>Message category</value>
        [DataMember(Name = "MessageCategory", EmitDefaultValue = false)]
        public MessageCategory? MessageCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientEvent" /> class.
        /// </summary>
        /// <param name="transactionID">ID number of transaction.</param>
        /// <param name="msgID">ID number of selected message..</param>
        /// <param name="fromEmail">Default From: email address..</param>
        /// <param name="to">Ending date for search in YYYY-MM-DDThh:mm:ss format..</param>
        /// <param name="subject">Default subject of email..</param>
        /// <param name="eventType">Type of an Event.</param>
        /// <param name="eventDate">Creation date.</param>
        /// <param name="channelName">Name of selected channel..</param>
        /// <param name="messageCategory">Message category.</param>
        /// <param name="nextTryOn">Date of next try.</param>
        /// <param name="message">Content of message, HTML encoded.</param>
        /// <param name="iPAddress">IP which this email was sent through.</param>
        /// <param name="poolName">Name of an IP pool this email was sent through.</param>
        public RecipientEvent(string transactionID = default(string), string msgID = default(string), string fromEmail = default(string), string to = default(string), string subject = default(string), EventType? eventType = default(EventType?), DateTime eventDate = default(DateTime), string channelName = default(string), MessageCategory? messageCategory = default(MessageCategory?), DateTime? nextTryOn = default(DateTime?), string message = default(string), string iPAddress = default(string), string poolName = default(string))
        {
            this.TransactionID = transactionID;
            this.MsgID = msgID;
            this.FromEmail = fromEmail;
            this.To = to;
            this.Subject = subject;
            this.EventType = eventType;
            this.EventDate = eventDate;
            this.ChannelName = channelName;
            this.MessageCategory = messageCategory;
            this.NextTryOn = nextTryOn;
            this.Message = message;
            this.IPAddress = iPAddress;
            this.PoolName = poolName;
        }

        /// <summary>
        /// ID number of transaction
        /// </summary>
        /// <value>ID number of transaction</value>
        [DataMember(Name = "TransactionID", EmitDefaultValue = false)]
        public string TransactionID { get; set; }

        /// <summary>
        /// ID number of selected message.
        /// </summary>
        /// <value>ID number of selected message.</value>
        [DataMember(Name = "MsgID", EmitDefaultValue = false)]
        public string MsgID { get; set; }

        /// <summary>
        /// Default From: email address.
        /// </summary>
        /// <value>Default From: email address.</value>
        [DataMember(Name = "FromEmail", EmitDefaultValue = false)]
        public string FromEmail { get; set; }

        /// <summary>
        /// Ending date for search in YYYY-MM-DDThh:mm:ss format.
        /// </summary>
        /// <value>Ending date for search in YYYY-MM-DDThh:mm:ss format.</value>
        [DataMember(Name = "To", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Default subject of email.
        /// </summary>
        /// <value>Default subject of email.</value>
        [DataMember(Name = "Subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        /// <value>Creation date</value>
        [DataMember(Name = "EventDate", EmitDefaultValue = false)]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Name of selected channel.
        /// </summary>
        /// <value>Name of selected channel.</value>
        [DataMember(Name = "ChannelName", EmitDefaultValue = false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Date of next try
        /// </summary>
        /// <value>Date of next try</value>
        [DataMember(Name = "NextTryOn", EmitDefaultValue = true)]
        public DateTime? NextTryOn { get; set; }

        /// <summary>
        /// Content of message, HTML encoded
        /// </summary>
        /// <value>Content of message, HTML encoded</value>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// IP which this email was sent through
        /// </summary>
        /// <value>IP which this email was sent through</value>
        [DataMember(Name = "IPAddress", EmitDefaultValue = false)]
        public string IPAddress { get; set; }

        /// <summary>
        /// Name of an IP pool this email was sent through
        /// </summary>
        /// <value>Name of an IP pool this email was sent through</value>
        [DataMember(Name = "PoolName", EmitDefaultValue = false)]
        public string PoolName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientEvent {\n");
            sb.Append("  TransactionID: ").Append(TransactionID).Append("\n");
            sb.Append("  MsgID: ").Append(MsgID).Append("\n");
            sb.Append("  FromEmail: ").Append(FromEmail).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  MessageCategory: ").Append(MessageCategory).Append("\n");
            sb.Append("  NextTryOn: ").Append(NextTryOn).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  IPAddress: ").Append(IPAddress).Append("\n");
            sb.Append("  PoolName: ").Append(PoolName).Append("\n");
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
            return this.Equals(input as RecipientEvent);
        }

        /// <summary>
        /// Returns true if RecipientEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of RecipientEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionID == input.TransactionID ||
                    (this.TransactionID != null &&
                    this.TransactionID.Equals(input.TransactionID))
                ) && 
                (
                    this.MsgID == input.MsgID ||
                    (this.MsgID != null &&
                    this.MsgID.Equals(input.MsgID))
                ) && 
                (
                    this.FromEmail == input.FromEmail ||
                    (this.FromEmail != null &&
                    this.FromEmail.Equals(input.FromEmail))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.EventType == input.EventType ||
                    this.EventType.Equals(input.EventType)
                ) && 
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) && 
                (
                    this.MessageCategory == input.MessageCategory ||
                    this.MessageCategory.Equals(input.MessageCategory)
                ) && 
                (
                    this.NextTryOn == input.NextTryOn ||
                    (this.NextTryOn != null &&
                    this.NextTryOn.Equals(input.NextTryOn))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.IPAddress == input.IPAddress ||
                    (this.IPAddress != null &&
                    this.IPAddress.Equals(input.IPAddress))
                ) && 
                (
                    this.PoolName == input.PoolName ||
                    (this.PoolName != null &&
                    this.PoolName.Equals(input.PoolName))
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
                if (this.TransactionID != null)
                    hashCode = hashCode * 59 + this.TransactionID.GetHashCode();
                if (this.MsgID != null)
                    hashCode = hashCode * 59 + this.MsgID.GetHashCode();
                if (this.FromEmail != null)
                    hashCode = hashCode * 59 + this.FromEmail.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventDate != null)
                    hashCode = hashCode * 59 + this.EventDate.GetHashCode();
                if (this.ChannelName != null)
                    hashCode = hashCode * 59 + this.ChannelName.GetHashCode();
                hashCode = hashCode * 59 + this.MessageCategory.GetHashCode();
                if (this.NextTryOn != null)
                    hashCode = hashCode * 59 + this.NextTryOn.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.IPAddress != null)
                    hashCode = hashCode * 59 + this.IPAddress.GetHashCode();
                if (this.PoolName != null)
                    hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                return hashCode;
            }
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
