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
    /// Defines ContactSource
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContactSource
    {
        /// <summary>
        /// Enum DeliveryApi for value: DeliveryApi
        /// </summary>
        [EnumMember(Value = "DeliveryApi")]
        DeliveryApi = 1,

        /// <summary>
        /// Enum ManualInput for value: ManualInput
        /// </summary>
        [EnumMember(Value = "ManualInput")]
        ManualInput = 2,

        /// <summary>
        /// Enum FileUpload for value: FileUpload
        /// </summary>
        [EnumMember(Value = "FileUpload")]
        FileUpload = 3,

        /// <summary>
        /// Enum WebForm for value: WebForm
        /// </summary>
        [EnumMember(Value = "WebForm")]
        WebForm = 4,

        /// <summary>
        /// Enum ContactApi for value: ContactApi
        /// </summary>
        [EnumMember(Value = "ContactApi")]
        ContactApi = 5,

        /// <summary>
        /// Enum VerificationApi for value: VerificationApi
        /// </summary>
        [EnumMember(Value = "VerificationApi")]
        VerificationApi = 6,

        /// <summary>
        /// Enum FileVerificationApi for value: FileVerificationApi
        /// </summary>
        [EnumMember(Value = "FileVerificationApi")]
        FileVerificationApi = 7
    }

}
