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
    ///  Class for testing DomainData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DomainDataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DomainData
        //private DomainData instance;

        public DomainDataTests()
        {
            // TODO uncomment below to create an instance of DomainData
            //instance = new DomainData();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DomainData
        /// </summary>
        [Fact]
        public void DomainDataInstanceTest()
        {
            // TODO uncomment below to test "IsType" DomainData
            //Assert.IsType<DomainData>(instance);
        }

        /// <summary>
        /// Test the property 'ValidationLog'
        /// </summary>
        [Fact]
        public void ValidationLogTest()
        {
            // TODO unit test for the property 'ValidationLog'
        }

        /// <summary>
        /// Test the property 'Domain'
        /// </summary>
        [Fact]
        public void DomainTest()
        {
            // TODO unit test for the property 'Domain'
        }

        /// <summary>
        /// Test the property 'DefaultDomain'
        /// </summary>
        [Fact]
        public void DefaultDomainTest()
        {
            // TODO unit test for the property 'DefaultDomain'
        }

        /// <summary>
        /// Test the property 'Spf'
        /// </summary>
        [Fact]
        public void SpfTest()
        {
            // TODO unit test for the property 'Spf'
        }

        /// <summary>
        /// Test the property 'Dkim'
        /// </summary>
        [Fact]
        public void DkimTest()
        {
            // TODO unit test for the property 'Dkim'
        }

        /// <summary>
        /// Test the property 'MX'
        /// </summary>
        [Fact]
        public void MXTest()
        {
            // TODO unit test for the property 'MX'
        }

        /// <summary>
        /// Test the property 'DMARC'
        /// </summary>
        [Fact]
        public void DMARCTest()
        {
            // TODO unit test for the property 'DMARC'
        }

        /// <summary>
        /// Test the property 'IsRewriteDomainValid'
        /// </summary>
        [Fact]
        public void IsRewriteDomainValidTest()
        {
            // TODO unit test for the property 'IsRewriteDomainValid'
        }

        /// <summary>
        /// Test the property 'Verify'
        /// </summary>
        [Fact]
        public void VerifyTest()
        {
            // TODO unit test for the property 'Verify'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

        /// <summary>
        /// Test the property 'TrackingStatus'
        /// </summary>
        [Fact]
        public void TrackingStatusTest()
        {
            // TODO unit test for the property 'TrackingStatus'
        }

        /// <summary>
        /// Test the property 'CertificateStatus'
        /// </summary>
        [Fact]
        public void CertificateStatusTest()
        {
            // TODO unit test for the property 'CertificateStatus'
        }

        /// <summary>
        /// Test the property 'CertificateValidationError'
        /// </summary>
        [Fact]
        public void CertificateValidationErrorTest()
        {
            // TODO unit test for the property 'CertificateValidationError'
        }

        /// <summary>
        /// Test the property 'TrackingTypeUserRequest'
        /// </summary>
        [Fact]
        public void TrackingTypeUserRequestTest()
        {
            // TODO unit test for the property 'TrackingTypeUserRequest'
        }

        /// <summary>
        /// Test the property 'VERP'
        /// </summary>
        [Fact]
        public void VERPTest()
        {
            // TODO unit test for the property 'VERP'
        }

        /// <summary>
        /// Test the property 'CustomBouncesDomain'
        /// </summary>
        [Fact]
        public void CustomBouncesDomainTest()
        {
            // TODO unit test for the property 'CustomBouncesDomain'
        }

        /// <summary>
        /// Test the property 'IsCustomBouncesDomainDefault'
        /// </summary>
        [Fact]
        public void IsCustomBouncesDomainDefaultTest()
        {
            // TODO unit test for the property 'IsCustomBouncesDomainDefault'
        }

        /// <summary>
        /// Test the property 'IsMarkedForDeletion'
        /// </summary>
        [Fact]
        public void IsMarkedForDeletionTest()
        {
            // TODO unit test for the property 'IsMarkedForDeletion'
        }

        /// <summary>
        /// Test the property 'Ownership'
        /// </summary>
        [Fact]
        public void OwnershipTest()
        {
            // TODO unit test for the property 'Ownership'
        }
    }
}