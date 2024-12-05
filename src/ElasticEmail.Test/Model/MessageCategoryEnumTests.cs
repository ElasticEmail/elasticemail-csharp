/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    The API has a limit of 20 concurrent connections and a hard timeout of 600 seconds per request.    To start using this API, you will need your Access Token (available <a target=\"_blank\" href=\"https://app.elasticemail.com/marketing/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    Downloadable library clients can be found in our Github repository <a target=\"_blank\" href=\"https://github.com/ElasticEmail?tab=repositories&q=%22rest+api%22+in%3Areadme\">here</a>
 *
 * The version of the OpenAPI document: 4.0.0
 * Contact: support@elasticemail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ElasticEmail.Model;
using ElasticEmail.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ElasticEmail.Test.Model
{
    /// <summary>
    ///  Class for testing MessageCategoryEnum
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MessageCategoryEnumTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MessageCategoryEnum
        //private MessageCategoryEnum instance;

        public MessageCategoryEnumTests()
        {
            // TODO uncomment below to create an instance of MessageCategoryEnum
            //instance = new MessageCategoryEnum();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessageCategoryEnum
        /// </summary>
        [Fact]
        public void MessageCategoryEnumInstanceTest()
        {
            // TODO uncomment below to test "IsType" MessageCategoryEnum
            //Assert.IsType<MessageCategoryEnum>(instance);
        }
    }
}