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
    /// HTTP or HTTPS Protocal used for link tracking.
    /// </summary>
    /// <value>HTTP or HTTPS Protocal used for link tracking.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrackingType
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Delete for value: Delete
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete = 2,

        /// <summary>
        /// Enum Http for value: Http
        /// </summary>
        [EnumMember(Value = "Http")]
        Http = 3,

        /// <summary>
        /// Enum ExternalHttps for value: ExternalHttps
        /// </summary>
        [EnumMember(Value = "ExternalHttps")]
        ExternalHttps = 4,

        /// <summary>
        /// Enum InternalCertHttps for value: InternalCertHttps
        /// </summary>
        [EnumMember(Value = "InternalCertHttps")]
        InternalCertHttps = 5,

        /// <summary>
        /// Enum LetsEncryptCert for value: LetsEncryptCert
        /// </summary>
        [EnumMember(Value = "LetsEncryptCert")]
        LetsEncryptCert = 6
    }

}
