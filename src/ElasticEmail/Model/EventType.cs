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
    /// Type of event
    /// </summary>
    /// <value>Type of event</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventType
    {
        /// <summary>
        /// Enum Submission for value: Submission
        /// </summary>
        [EnumMember(Value = "Submission")]
        Submission = 1,

        /// <summary>
        /// Enum FailedAttempt for value: FailedAttempt
        /// </summary>
        [EnumMember(Value = "FailedAttempt")]
        FailedAttempt = 2,

        /// <summary>
        /// Enum Bounce for value: Bounce
        /// </summary>
        [EnumMember(Value = "Bounce")]
        Bounce = 3,

        /// <summary>
        /// Enum Sent for value: Sent
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent = 4,

        /// <summary>
        /// Enum Open for value: Open
        /// </summary>
        [EnumMember(Value = "Open")]
        Open = 5,

        /// <summary>
        /// Enum Click for value: Click
        /// </summary>
        [EnumMember(Value = "Click")]
        Click = 6,

        /// <summary>
        /// Enum Unsubscribe for value: Unsubscribe
        /// </summary>
        [EnumMember(Value = "Unsubscribe")]
        Unsubscribe = 7,

        /// <summary>
        /// Enum Complaint for value: Complaint
        /// </summary>
        [EnumMember(Value = "Complaint")]
        Complaint = 8
    }

}
