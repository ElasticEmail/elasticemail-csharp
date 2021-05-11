/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    To start using this API, you will need your Access Token (available <a href=\"https://elasticemail.com/account#/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    This is the documentation for REST API. If you’d like to read our legacy documentation regarding Web API v2 click <a href=\"https://api.elasticemail.com/public/help\">here</a>.
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
using ElasticEmail.Api;
using ElasticEmail.Model;
using ElasticEmail.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ElasticEmail.Test.Model
{
    /// <summary>
    ///  Class for testing SubaccountSettingsInfoPayload
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SubaccountSettingsInfoPayloadTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SubaccountSettingsInfoPayload
        //private SubaccountSettingsInfoPayload instance;

        public SubaccountSettingsInfoPayloadTests()
        {
            // TODO uncomment below to create an instance of SubaccountSettingsInfoPayload
            //instance = new SubaccountSettingsInfoPayload();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SubaccountSettingsInfoPayload
        /// </summary>
        [Fact]
        public void SubaccountSettingsInfoPayloadInstanceTest()
        {
            // TODO uncomment below to test "IsType" SubaccountSettingsInfoPayload
            //Assert.IsType<SubaccountSettingsInfoPayload>(instance);
        }


        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }

    }

}
