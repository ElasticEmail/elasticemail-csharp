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
    ///  Class for testing FileInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class FileInfoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FileInfo
        //private FileInfo instance;

        public FileInfoTests()
        {
            // TODO uncomment below to create an instance of FileInfo
            //instance = new FileInfo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FileInfo
        /// </summary>
        [Fact]
        public void FileInfoInstanceTest()
        {
            // TODO uncomment below to test "IsType" FileInfo
            //Assert.IsType<FileInfo>(instance);
        }

        /// <summary>
        /// Test the property 'FileName'
        /// </summary>
        [Fact]
        public void FileNameTest()
        {
            // TODO unit test for the property 'FileName'
        }

        /// <summary>
        /// Test the property 'Size'
        /// </summary>
        [Fact]
        public void SizeTest()
        {
            // TODO unit test for the property 'Size'
        }

        /// <summary>
        /// Test the property 'DateAdded'
        /// </summary>
        [Fact]
        public void DateAddedTest()
        {
            // TODO unit test for the property 'DateAdded'
        }

        /// <summary>
        /// Test the property 'ExpirationDate'
        /// </summary>
        [Fact]
        public void ExpirationDateTest()
        {
            // TODO unit test for the property 'ExpirationDate'
        }

        /// <summary>
        /// Test the property 'ContentType'
        /// </summary>
        [Fact]
        public void ContentTypeTest()
        {
            // TODO unit test for the property 'ContentType'
        }
    }
}
