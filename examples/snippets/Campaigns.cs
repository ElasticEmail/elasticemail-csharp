using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace c_sharp_snippets
{
    class Campaigns
    {
        public Campaign AddCampaign()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            /**
                * Add Campaign
                * Example api call that creates a new campaign.
                * Send will be triggered immediately or postponed, depending on given options.
            */
            var apiInstance = new CampaignsApi(config);

            var recipients = new CampaignRecipient();
            recipients.ListNames = new List<string>();
            recipients.ListNames.Add("your list");

            Campaign yourCampaign = new Campaign(name: "My Campaign", recipients: recipients);
            yourCampaign.Content = new List<CampaignTemplate>();
            CampaignTemplate campaignTemplate = new CampaignTemplate();
            campaignTemplate.From = "myemail@domain.com";
            campaignTemplate.ReplyTo = "myemail@domain.com";
            campaignTemplate.TemplateName = "hello_template";
            campaignTemplate.Subject = "Hello";
            yourCampaign.Content.Add(campaignTemplate);
            yourCampaign.Status = CampaignStatus.Draft;

            try
            {
                return apiInstance.CampaignsPost(yourCampaign);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CampaignsApi.CampaignsPost: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public Campaign LoadCampaign()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new CampaignsApi(config);

            /**
             * Load Campaign
             * Example api call that fetches details about single campaign like: name, status, recipients, subject etc.
             */
            string campaignName = "My Campaign";

            try
            {
                return apiInstance.CampaignsByNameGet(campaignName);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CampaignsApi.CampaignsByNameGet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public Campaign UpdateCampaign()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new CampaignsApi(config);

            /**
             * Update Campaign
             * Example api call that updates a campaign.
             * Send will be triggered immediately or postponed, depending on given options.
             */

            var recipients = new CampaignRecipient();
            recipients.ListNames = new List<string>();
            recipients.ListNames.Add("yourList");
            string campaignName = "My Campaign";

            Campaign yourCampaign = new Campaign(name: "new campaignName", recipients: recipients);

            yourCampaign.Content = new List<CampaignTemplate>();
            CampaignTemplate campaignTemplate = new CampaignTemplate();
            campaignTemplate.From = "myemail@domain.com";

            campaignTemplate.ReplyTo = "myemail@domain.com";
            campaignTemplate.TemplateName = "hello_template";
            campaignTemplate.Subject = "Hello";
            yourCampaign.Content.Add(campaignTemplate);
            yourCampaign.Status = CampaignStatus.Draft;

            try
            {
                return apiInstance.CampaignsByNamePut(campaignName, yourCampaign);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CampaignsApi.CampaignsByNamePut: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public void DeleteCampaign()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new CampaignsApi(config);

            /**
             * Delete Campaign
             * Example api call that deletes an existing campaign.
             */
            string campaignName = "new campaignName";

            try
            {
                apiInstance.CampaignsByNameDelete(campaignName);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CampaignsApi.CampaignsByNameDelete: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }
    }
}
