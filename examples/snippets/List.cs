using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace c_sharp_snippets
{
    class List
    {
        public ContactsList AddList()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new ListsApi(config);

            /**
             * Add list
             * Example api call that creates a new contacts list.
             * Emails – An array of existing contact emails that should be added to this list. Leave empty for all contacts
             */

            ListPayload listData = new ListPayload(listName: "My contacts");
            listData.AllowUnsubscribe = true;
            listData.Emails = new List<string>();
            listData.Emails.Add("johnsmith@domain.com");

            try
            {
                return apiInstance.ListsPost(listData);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ListsApi.ListsPost: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public ContactsList LoadList()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new ListsApi(config);

            /**
             * Load list
             * Example api call that loads given contacts list.
             */
            string listName = "My contacts";

            try
            {
                return apiInstance.ListsByNameGet(listName);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ListsApi.ListsByNameGet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public void DeleteList()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new ListsApi(config);

            /**
             * Load list
             * Example api call that loads given contacts list.
             */
            string listName = "My contacts";

            try
            {
                apiInstance.ListsByNameDelete(listName);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ListsApi.ListsByNameDelete: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }
    }
}
