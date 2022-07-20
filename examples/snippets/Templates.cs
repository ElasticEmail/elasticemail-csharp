using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace c_sharp_snippets
{
    class Templates
    {
        public Template AddTemplate()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new TemplatesApi(config);

            /**
              * Add template
              * Example api call that adds a new template.
              * TemplateScope: "Personal" or "Global"
              */

            TemplatePayload template = new TemplatePayload(name: "My new template");
            template.Subject = "Default Subject";
            template.TemplateScope = TemplateScope.Personal;
            template.Body = new List<BodyPart>();

            BodyPart bodyPart = new BodyPart();
            bodyPart.ContentType = BodyContentType.HTML;
            bodyPart.Charset = "utf-8";
            bodyPart.Content = "<h1>My template</h1>";

            template.Body.Add(bodyPart);

            try
            {
                return apiInstance.TemplatesPost(template);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TemplatesApi.TemplatesPost: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public Template LoadTemplate()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new TemplatesApi(config);

            /**
            * Load template
            * Example api call that loads an existing template.
            */

            string templateName = "My template";

            try
            {
                return apiInstance.TemplatesByNameGet(templateName);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TemplatesApi.TemplatesByNameGet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public void DeleteTemplate()
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            var apiInstance = new TemplatesApi(config);

            /**
             * Delete template
             * Example api call that deletes existing template.
             */

            string templateName = "My template";

            try
            {
                apiInstance.TemplatesByNameDelete(templateName);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TemplatesApi.TemplatesByNameGet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }
    }
}