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
    ///  Class for testing SubaccountEmailSettingsPayload
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SubaccountEmailSettingsPayloadTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SubaccountEmailSettingsPayload
        //private SubaccountEmailSettingsPayload instance;

        public SubaccountEmailSettingsPayloadTests()
        {
            // TODO uncomment below to create an instance of SubaccountEmailSettingsPayload
            //instance = new SubaccountEmailSettingsPayload();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SubaccountEmailSettingsPayload
        /// </summary>
        [Fact]
        public void SubaccountEmailSettingsPayloadInstanceTest()
        {
            // TODO uncomment below to test "IsType" SubaccountEmailSettingsPayload
            //Assert.IsType<SubaccountEmailSettingsPayload>(instance);
        }

        /// <summary>
        /// Test the property 'RequiresEmailCredits'
        /// </summary>
        [Fact]
        public void RequiresEmailCreditsTest()
        {
            // TODO unit test for the property 'RequiresEmailCredits'
        }

        /// <summary>
        /// Test the property 'EmailSizeLimit'
        /// </summary>
        [Fact]
        public void EmailSizeLimitTest()
        {
            // TODO unit test for the property 'EmailSizeLimit'
        }

        /// <summary>
        /// Test the property 'DailySendLimit'
        /// </summary>
        [Fact]
        public void DailySendLimitTest()
        {
            // TODO unit test for the property 'DailySendLimit'
        }

        /// <summary>
        /// Test the property 'MaxContacts'
        /// </summary>
        [Fact]
        public void MaxContactsTest()
        {
            // TODO unit test for the property 'MaxContacts'
        }

        /// <summary>
        /// Test the property 'EnablePrivateIPPurchase'
        /// </summary>
        [Fact]
        public void EnablePrivateIPPurchaseTest()
        {
            // TODO unit test for the property 'EnablePrivateIPPurchase'
        }

        /// <summary>
        /// Test the property 'PoolName'
        /// </summary>
        [Fact]
        public void PoolNameTest()
        {
            // TODO unit test for the property 'PoolName'
        }

        /// <summary>
        /// Test the property 'ValidSenderDomainOnly'
        /// </summary>
        [Fact]
        public void ValidSenderDomainOnlyTest()
        {
            // TODO unit test for the property 'ValidSenderDomainOnly'
        }
    }
}
