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
    ///  Class for testing TemplatePayload
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TemplatePayloadTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TemplatePayload
        //private TemplatePayload instance;

        public TemplatePayloadTests()
        {
            // TODO uncomment below to create an instance of TemplatePayload
            //instance = new TemplatePayload();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TemplatePayload
        /// </summary>
        [Fact]
        public void TemplatePayloadInstanceTest()
        {
            // TODO uncomment below to test "IsType" TemplatePayload
            //Assert.IsType<TemplatePayload>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Subject'
        /// </summary>
        [Fact]
        public void SubjectTest()
        {
            // TODO unit test for the property 'Subject'
        }

        /// <summary>
        /// Test the property 'Body'
        /// </summary>
        [Fact]
        public void BodyTest()
        {
            // TODO unit test for the property 'Body'
        }

        /// <summary>
        /// Test the property 'TemplateScope'
        /// </summary>
        [Fact]
        public void TemplateScopeTest()
        {
            // TODO unit test for the property 'TemplateScope'
        }
    }
}
