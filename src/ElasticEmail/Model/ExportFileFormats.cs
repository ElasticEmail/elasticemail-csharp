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
    /// Format of the exported file.
    /// </summary>
    /// <value>Format of the exported file.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ExportFileFormats
    {
        /// <summary>
        /// Enum Csv for value: Csv
        /// </summary>
        [EnumMember(Value = "Csv")]
        Csv = 1,

        /// <summary>
        /// Enum Xml for value: Xml
        /// </summary>
        [EnumMember(Value = "Xml")]
        Xml = 2,

        /// <summary>
        /// Enum Json for value: Json
        /// </summary>
        [EnumMember(Value = "Json")]
        Json = 3

    }

}
