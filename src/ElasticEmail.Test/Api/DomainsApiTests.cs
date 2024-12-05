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
    ///  Class for testing DomainsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DomainsApiTests : IDisposable
    {
        private DomainsApi instance;

        public DomainsApiTests()
        {
            instance = new DomainsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DomainsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DomainsApi
            //Assert.IsType<DomainsApi>(instance);
        }

        /// <summary>
        /// Test DomainsByDomainDelete
        /// </summary>
        [Fact]
        public void DomainsByDomainDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //instance.DomainsByDomainDelete(domain);
        }

        /// <summary>
        /// Test DomainsByDomainGet
        /// </summary>
        [Fact]
        public void DomainsByDomainGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //var response = instance.DomainsByDomainGet(domain);
            //Assert.IsType<DomainData>(response);
        }

        /// <summary>
        /// Test DomainsByDomainPut
        /// </summary>
        [Fact]
        public void DomainsByDomainPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //DomainUpdatePayload domainUpdatePayload = null;
            //var response = instance.DomainsByDomainPut(domain, domainUpdatePayload);
            //Assert.IsType<DomainDetail>(response);
        }

        /// <summary>
        /// Test DomainsByDomainRestrictedGet
        /// </summary>
        [Fact]
        public void DomainsByDomainRestrictedGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //var response = instance.DomainsByDomainRestrictedGet(domain);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test DomainsByDomainVerificationPut
        /// </summary>
        [Fact]
        public void DomainsByDomainVerificationPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //string body = null;
            //var response = instance.DomainsByDomainVerificationPut(domain, body);
            //Assert.IsType<DomainData>(response);
        }

        /// <summary>
        /// Test DomainsByEmailDefaultPatch
        /// </summary>
        [Fact]
        public void DomainsByEmailDefaultPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //var response = instance.DomainsByEmailDefaultPatch(email);
            //Assert.IsType<DomainDetail>(response);
        }

        /// <summary>
        /// Test DomainsGet
        /// </summary>
        [Fact]
        public void DomainsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DomainsGet();
            //Assert.IsType<List<DomainDetail>>(response);
        }

        /// <summary>
        /// Test DomainsPost
        /// </summary>
        [Fact]
        public void DomainsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DomainPayload domainPayload = null;
            //var response = instance.DomainsPost(domainPayload);
            //Assert.IsType<DomainDetail>(response);
        }
    }
}
