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
    /// Defines LogJobStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LogJobStatus
    {
        /// <summary>
        /// Enum All for value: All
        /// </summary>
        [EnumMember(Value = "All")]
        All = 1,

        /// <summary>
        /// Enum ReadyToSend for value: ReadyToSend
        /// </summary>
        [EnumMember(Value = "ReadyToSend")]
        ReadyToSend = 2,

        /// <summary>
        /// Enum WaitingToRetry for value: WaitingToRetry
        /// </summary>
        [EnumMember(Value = "WaitingToRetry")]
        WaitingToRetry = 3,

        /// <summary>
        /// Enum Sending for value: Sending
        /// </summary>
        [EnumMember(Value = "Sending")]
        Sending = 4,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 5,

        /// <summary>
        /// Enum Sent for value: Sent
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent = 6,

        /// <summary>
        /// Enum Opened for value: Opened
        /// </summary>
        [EnumMember(Value = "Opened")]
        Opened = 7,

        /// <summary>
        /// Enum Clicked for value: Clicked
        /// </summary>
        [EnumMember(Value = "Clicked")]
        Clicked = 8,

        /// <summary>
        /// Enum Unsubscribed for value: Unsubscribed
        /// </summary>
        [EnumMember(Value = "Unsubscribed")]
        Unsubscribed = 9,

        /// <summary>
        /// Enum AbuseReport for value: AbuseReport
        /// </summary>
        [EnumMember(Value = "AbuseReport")]
        AbuseReport = 10
    }

}
