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
    /// Defines AccountStatusEnum
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccountStatusEnum
    {
        /// <summary>
        /// Enum Disabled for value: Disabled
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled = 1,

        /// <summary>
        /// Enum UnderReview for value: UnderReview
        /// </summary>
        [EnumMember(Value = "UnderReview")]
        UnderReview = 2,

        /// <summary>
        /// Enum NoPaymentsAllowed for value: NoPaymentsAllowed
        /// </summary>
        [EnumMember(Value = "NoPaymentsAllowed")]
        NoPaymentsAllowed = 3,

        /// <summary>
        /// Enum NeverSignedIn for value: NeverSignedIn
        /// </summary>
        [EnumMember(Value = "NeverSignedIn")]
        NeverSignedIn = 4,

        /// <summary>
        /// Enum Active for value: Active
        /// </summary>
        [EnumMember(Value = "Active")]
        Active = 5

    }

}
