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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using ElasticEmail.Client;
using ElasticEmail.Api;
// uncomment below to import models
//using ElasticEmail.Model;

namespace ElasticEmail.Test.Api
{
    /// <summary>
    ///  Class for testing CampaignsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CampaignsApiTests : IDisposable
    {
        private CampaignsApi instance;

        public CampaignsApiTests()
        {
            instance = new CampaignsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CampaignsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CampaignsApi
            //Assert.IsType<CampaignsApi>(instance);
        }

        /// <summary>
        /// Test CampaignsByNameDelete
        /// </summary>
        [Fact]
        public void CampaignsByNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //instance.CampaignsByNameDelete(name);
        }

        /// <summary>
        /// Test CampaignsByNameGet
        /// </summary>
        [Fact]
        public void CampaignsByNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.CampaignsByNameGet(name);
            //Assert.IsType<Campaign>(response);
        }

        /// <summary>
        /// Test CampaignsByNamePut
        /// </summary>
        [Fact]
        public void CampaignsByNamePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //Campaign campaign = null;
            //var response = instance.CampaignsByNamePut(name, campaign);
            //Assert.IsType<Campaign>(response);
        }

        /// <summary>
        /// Test CampaignsGet
        /// </summary>
        [Fact]
        public void CampaignsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.CampaignsGet(search, offset, limit);
            //Assert.IsType<List<Campaign>>(response);
        }

        /// <summary>
        /// Test CampaignsPost
        /// </summary>
        [Fact]
        public void CampaignsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Campaign campaign = null;
            //var response = instance.CampaignsPost(campaign);
            //Assert.IsType<Campaign>(response);
        }
    }
}
