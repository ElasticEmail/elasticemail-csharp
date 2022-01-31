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
    /// E-mail configuration
    /// </summary>
    [DataContract(Name = "Options")]
    public partial class Options : IEquatable<Options>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Encoding
        /// </summary>
        [DataMember(Name = "Encoding", EmitDefaultValue = false)]
        public EncodingType? Encoding { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Options" /> class.
        /// </summary>
        /// <param name="timeOffset">By how long should an e-mail be delayed (in minutes). Maximum is 35 days..</param>
        /// <param name="poolName">Name of your custom IP Pool to be used in the sending process.</param>
        /// <param name="channelName">Name of selected channel..</param>
        /// <param name="encoding">encoding.</param>
        /// <param name="trackOpens">Should the opens be tracked? If no value has been provided, Account&#39;s default setting will be used..</param>
        /// <param name="trackClicks">Should the clicks be tracked? If no value has been provided, Account&#39;s default setting will be used..</param>
        public Options(int? timeOffset = default(int?), string poolName = default(string), string channelName = default(string), EncodingType? encoding = default(EncodingType?), bool trackOpens = default(bool), bool trackClicks = default(bool))
        {
            this.TimeOffset = timeOffset;
            this.PoolName = poolName;
            this.ChannelName = channelName;
            this.Encoding = encoding;
            this.TrackOpens = trackOpens;
            this.TrackClicks = trackClicks;
        }

        /// <summary>
        /// By how long should an e-mail be delayed (in minutes). Maximum is 35 days.
        /// </summary>
        /// <value>By how long should an e-mail be delayed (in minutes). Maximum is 35 days.</value>
        [DataMember(Name = "TimeOffset", EmitDefaultValue = true)]
        public int? TimeOffset { get; set; }

        /// <summary>
        /// Name of your custom IP Pool to be used in the sending process
        /// </summary>
        /// <value>Name of your custom IP Pool to be used in the sending process</value>
        [DataMember(Name = "PoolName", EmitDefaultValue = false)]
        public string PoolName { get; set; }

        /// <summary>
        /// Name of selected channel.
        /// </summary>
        /// <value>Name of selected channel.</value>
        [DataMember(Name = "ChannelName", EmitDefaultValue = false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Should the opens be tracked? If no value has been provided, Account&#39;s default setting will be used.
        /// </summary>
        /// <value>Should the opens be tracked? If no value has been provided, Account&#39;s default setting will be used.</value>
        [DataMember(Name = "TrackOpens", EmitDefaultValue = true)]
        public bool TrackOpens { get; set; }

        /// <summary>
        /// Should the clicks be tracked? If no value has been provided, Account&#39;s default setting will be used.
        /// </summary>
        /// <value>Should the clicks be tracked? If no value has been provided, Account&#39;s default setting will be used.</value>
        [DataMember(Name = "TrackClicks", EmitDefaultValue = true)]
        public bool TrackClicks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Options {\n");
            sb.Append("  TimeOffset: ").Append(TimeOffset).Append("\n");
            sb.Append("  PoolName: ").Append(PoolName).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
            sb.Append("  TrackOpens: ").Append(TrackOpens).Append("\n");
            sb.Append("  TrackClicks: ").Append(TrackClicks).Append("\n");
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
            return this.Equals(input as Options);
        }

        /// <summary>
        /// Returns true if Options instances are equal
        /// </summary>
        /// <param name="input">Instance of Options to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Options input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TimeOffset == input.TimeOffset ||
                    (this.TimeOffset != null &&
                    this.TimeOffset.Equals(input.TimeOffset))
                ) && 
                (
                    this.PoolName == input.PoolName ||
                    (this.PoolName != null &&
                    this.PoolName.Equals(input.PoolName))
                ) && 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) && 
                (
                    this.Encoding == input.Encoding ||
                    this.Encoding.Equals(input.Encoding)
                ) && 
                (
                    this.TrackOpens == input.TrackOpens ||
                    this.TrackOpens.Equals(input.TrackOpens)
                ) && 
                (
                    this.TrackClicks == input.TrackClicks ||
                    this.TrackClicks.Equals(input.TrackClicks)
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
                if (this.TimeOffset != null)
                {
                    hashCode = (hashCode * 59) + this.TimeOffset.GetHashCode();
                }
                if (this.PoolName != null)
                {
                    hashCode = (hashCode * 59) + this.PoolName.GetHashCode();
                }
                if (this.ChannelName != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Encoding.GetHashCode();
                hashCode = (hashCode * 59) + this.TrackOpens.GetHashCode();
                hashCode = (hashCode * 59) + this.TrackClicks.GetHashCode();
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
