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
    ///  Class for testing EmailJobStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EmailJobStatusTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EmailJobStatus
        //private EmailJobStatus instance;

        public EmailJobStatusTests()
        {
            // TODO uncomment below to create an instance of EmailJobStatus
            //instance = new EmailJobStatus();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmailJobStatus
        /// </summary>
        [Fact]
        public void EmailJobStatusInstanceTest()
        {
            // TODO uncomment below to test "IsType" EmailJobStatus
            //Assert.IsType<EmailJobStatus>(instance);
        }

        /// <summary>
        /// Test the property 'ID'
        /// </summary>
        [Fact]
        public void IDTest()
        {
            // TODO unit test for the property 'ID'
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

        /// <summary>
        /// Test the property 'RecipientsCount'
        /// </summary>
        [Fact]
        public void RecipientsCountTest()
        {
            // TODO unit test for the property 'RecipientsCount'
        }

        /// <summary>
        /// Test the property 'Failed'
        /// </summary>
        [Fact]
        public void FailedTest()
        {
            // TODO unit test for the property 'Failed'
        }

        /// <summary>
        /// Test the property 'FailedCount'
        /// </summary>
        [Fact]
        public void FailedCountTest()
        {
            // TODO unit test for the property 'FailedCount'
        }

        /// <summary>
        /// Test the property 'Sent'
        /// </summary>
        [Fact]
        public void SentTest()
        {
            // TODO unit test for the property 'Sent'
        }

        /// <summary>
        /// Test the property 'SentCount'
        /// </summary>
        [Fact]
        public void SentCountTest()
        {
            // TODO unit test for the property 'SentCount'
        }

        /// <summary>
        /// Test the property 'Delivered'
        /// </summary>
        [Fact]
        public void DeliveredTest()
        {
            // TODO unit test for the property 'Delivered'
        }

        /// <summary>
        /// Test the property 'DeliveredCount'
        /// </summary>
        [Fact]
        public void DeliveredCountTest()
        {
            // TODO unit test for the property 'DeliveredCount'
        }

        /// <summary>
        /// Test the property 'Pending'
        /// </summary>
        [Fact]
        public void PendingTest()
        {
            // TODO unit test for the property 'Pending'
        }

        /// <summary>
        /// Test the property 'PendingCount'
        /// </summary>
        [Fact]
        public void PendingCountTest()
        {
            // TODO unit test for the property 'PendingCount'
        }

        /// <summary>
        /// Test the property 'Opened'
        /// </summary>
        [Fact]
        public void OpenedTest()
        {
            // TODO unit test for the property 'Opened'
        }

        /// <summary>
        /// Test the property 'OpenedCount'
        /// </summary>
        [Fact]
        public void OpenedCountTest()
        {
            // TODO unit test for the property 'OpenedCount'
        }

        /// <summary>
        /// Test the property 'Clicked'
        /// </summary>
        [Fact]
        public void ClickedTest()
        {
            // TODO unit test for the property 'Clicked'
        }

        /// <summary>
        /// Test the property 'ClickedCount'
        /// </summary>
        [Fact]
        public void ClickedCountTest()
        {
            // TODO unit test for the property 'ClickedCount'
        }

        /// <summary>
        /// Test the property 'Unsubscribed'
        /// </summary>
        [Fact]
        public void UnsubscribedTest()
        {
            // TODO unit test for the property 'Unsubscribed'
        }

        /// <summary>
        /// Test the property 'UnsubscribedCount'
        /// </summary>
        [Fact]
        public void UnsubscribedCountTest()
        {
            // TODO unit test for the property 'UnsubscribedCount'
        }

        /// <summary>
        /// Test the property 'AbuseReports'
        /// </summary>
        [Fact]
        public void AbuseReportsTest()
        {
            // TODO unit test for the property 'AbuseReports'
        }

        /// <summary>
        /// Test the property 'AbuseReportsCount'
        /// </summary>
        [Fact]
        public void AbuseReportsCountTest()
        {
            // TODO unit test for the property 'AbuseReportsCount'
        }

        /// <summary>
        /// Test the property 'MessageIDs'
        /// </summary>
        [Fact]
        public void MessageIDsTest()
        {
            // TODO unit test for the property 'MessageIDs'
        }
    }
}
