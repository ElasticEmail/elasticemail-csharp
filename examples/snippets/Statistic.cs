using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace c_sharp_snippets
{
    class Statistic
    {
        public LogStatusSummary LoadStatistics()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new StatisticsApi(config);

            /**
             * Load statistics
             * Example api call that loads basic statistics.
             */

            DateTime from = new DateTime(2022, 01, 17);
            DateTime to = DateTime.Today;

            try
            {
                return apiInstance.StatisticsGet(from, to);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling StatisticsApi.StatisticsGet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public List<ChannelLogStatusSummary> LoadCampaignsStats()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new StatisticsApi(config);

            /**
             * Load campaigns stats
             * Example api call that loads a list of your campaigns' stats.
             */

            int limit = 0;
            int offset = 0;

            try
            {
                return apiInstance.StatisticsCampaignsGet(limit, offset);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling StatisticsApi.StatisticsCampaignsGet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public List<ChannelLogStatusSummary> LoadChannelsStats()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new StatisticsApi(config);

            /**
             * Load channels stats
             * Example api call that loads a list of your channels' stats.
             */

            int limit = 0;
            int offset = 0;

            try
            {
                return apiInstance.StatisticsChannelsGet(limit, offset);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling StatisticsApi.StatisticsChannelsGet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }
    }
}
