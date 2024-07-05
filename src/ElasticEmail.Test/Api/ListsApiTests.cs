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
    ///  Class for testing ListsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ListsApiTests : IDisposable
    {
        private ListsApi instance;

        public ListsApiTests()
        {
            instance = new ListsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ListsApi
            //Assert.IsType<ListsApi>(instance);
        }

        /// <summary>
        /// Test ListsByListnameContactsGet
        /// </summary>
        [Fact]
        public void ListsByListnameContactsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string listname = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListsByListnameContactsGet(listname, limit, offset);
            //Assert.IsType<List<Contact>>(response);
        }

        /// <summary>
        /// Test ListsByNameContactsPost
        /// </summary>
        [Fact]
        public void ListsByNameContactsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //EmailsPayload emailsPayload = null;
            //var response = instance.ListsByNameContactsPost(name, emailsPayload);
            //Assert.IsType<ContactsList>(response);
        }

        /// <summary>
        /// Test ListsByNameContactsRemovePost
        /// </summary>
        [Fact]
        public void ListsByNameContactsRemovePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //EmailsPayload emailsPayload = null;
            //instance.ListsByNameContactsRemovePost(name, emailsPayload);
        }

        /// <summary>
        /// Test ListsByNameDelete
        /// </summary>
        [Fact]
        public void ListsByNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //instance.ListsByNameDelete(name);
        }

        /// <summary>
        /// Test ListsByNameGet
        /// </summary>
        [Fact]
        public void ListsByNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.ListsByNameGet(name);
            //Assert.IsType<ContactsList>(response);
        }

        /// <summary>
        /// Test ListsByNamePut
        /// </summary>
        [Fact]
        public void ListsByNamePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //ListUpdatePayload listUpdatePayload = null;
            //var response = instance.ListsByNamePut(name, listUpdatePayload);
            //Assert.IsType<ContactsList>(response);
        }

        /// <summary>
        /// Test ListsGet
        /// </summary>
        [Fact]
        public void ListsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListsGet(limit, offset);
            //Assert.IsType<List<ContactsList>>(response);
        }

        /// <summary>
        /// Test ListsPost
        /// </summary>
        [Fact]
        public void ListsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ListPayload listPayload = null;
            //var response = instance.ListsPost(listPayload);
            //Assert.IsType<ContactsList>(response);
        }
    }
}
