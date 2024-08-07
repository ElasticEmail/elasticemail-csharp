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
    ///  Class for testing CampaignOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CampaignOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CampaignOptions
        //private CampaignOptions instance;

        public CampaignOptionsTests()
        {
            // TODO uncomment below to create an instance of CampaignOptions
            //instance = new CampaignOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CampaignOptions
        /// </summary>
        [Fact]
        public void CampaignOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" CampaignOptions
            //Assert.IsType<CampaignOptions>(instance);
        }

        /// <summary>
        /// Test the property 'DeliveryOptimization'
        /// </summary>
        [Fact]
        public void DeliveryOptimizationTest()
        {
            // TODO unit test for the property 'DeliveryOptimization'
        }

        /// <summary>
        /// Test the property 'TrackOpens'
        /// </summary>
        [Fact]
        public void TrackOpensTest()
        {
            // TODO unit test for the property 'TrackOpens'
        }

        /// <summary>
        /// Test the property 'TrackClicks'
        /// </summary>
        [Fact]
        public void TrackClicksTest()
        {
            // TODO unit test for the property 'TrackClicks'
        }

        /// <summary>
        /// Test the property 'ScheduleFor'
        /// </summary>
        [Fact]
        public void ScheduleForTest()
        {
            // TODO unit test for the property 'ScheduleFor'
        }

        /// <summary>
        /// Test the property 'TriggerFrequency'
        /// </summary>
        [Fact]
        public void TriggerFrequencyTest()
        {
            // TODO unit test for the property 'TriggerFrequency'
        }

        /// <summary>
        /// Test the property 'TriggerCount'
        /// </summary>
        [Fact]
        public void TriggerCountTest()
        {
            // TODO unit test for the property 'TriggerCount'
        }

        /// <summary>
        /// Test the property 'SplitOptions'
        /// </summary>
        [Fact]
        public void SplitOptionsTest()
        {
            // TODO unit test for the property 'SplitOptions'
        }
    }
}
