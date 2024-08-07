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
    /// Defines ContactStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContactStatus
    {
        /// <summary>
        /// Enum Transactional for value: Transactional
        /// </summary>
        [EnumMember(Value = "Transactional")]
        Transactional = 1,

        /// <summary>
        /// Enum Engaged for value: Engaged
        /// </summary>
        [EnumMember(Value = "Engaged")]
        Engaged = 2,

        /// <summary>
        /// Enum Active for value: Active
        /// </summary>
        [EnumMember(Value = "Active")]
        Active = 3,

        /// <summary>
        /// Enum Bounced for value: Bounced
        /// </summary>
        [EnumMember(Value = "Bounced")]
        Bounced = 4,

        /// <summary>
        /// Enum Unsubscribed for value: Unsubscribed
        /// </summary>
        [EnumMember(Value = "Unsubscribed")]
        Unsubscribed = 5,

        /// <summary>
        /// Enum Abuse for value: Abuse
        /// </summary>
        [EnumMember(Value = "Abuse")]
        Abuse = 6,

        /// <summary>
        /// Enum Inactive for value: Inactive
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive = 7,

        /// <summary>
        /// Enum Stale for value: Stale
        /// </summary>
        [EnumMember(Value = "Stale")]
        Stale = 8,

        /// <summary>
        /// Enum NotConfirmed for value: NotConfirmed
        /// </summary>
        [EnumMember(Value = "NotConfirmed")]
        NotConfirmed = 9
    }

}
