using System;
using System.Collections.Generic;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;

namespace c_sharp_snippets
{
    class Contacts
    {
        public List<Contact> AddContacts()
        {
            Configuration config = new Configuration();

            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            /**
             * Add contacts
             * Example api call that adds new contacts.
             * Pass array with contact details to add up to 1000 contacts.
             * Specify a list name in options or add to all contacts.
             */

            var apiInstance = new ContactsApi(config);
            List<ContactPayload> myContacts = new List<ContactPayload>();
            ContactPayload singleContact = new ContactPayload(email: "johnsmith@domain.com");
            singleContact.FirstName = "John";
            singleContact.LastName = "Smith";
            myContacts.Add(singleContact);

            List<string> listnames = new List<string>();
            listnames.Add("yourList");

            try
            {
                return apiInstance.ContactsPost(myContacts, listnames);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ContactsApi.ContactsPost: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public void ExportContacts()
        {
            Configuration config = new Configuration();

            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            /**
             * Export contacts
             * Example api call that exports selected contacts to downloadable file.
             * Options:
             * fileFormat: "Csv" "Xml" "Json" – Format of the exported file
             * rule: rule=Status%20=%20Engaged – Query used for filtering.
             * emails: [mail@contact.com,mail1@contact.com,mail2@contact.com] – Array of contact emails
             * compressionFormat: "None" "Zip"
             * fileName=filename.txt – Name of your file including extension.
             */
            var apiInstance = new ContactsApi(config);
            ExportFileFormats fileFormat = new ExportFileFormats();
            fileFormat = ExportFileFormats.Csv;

            List<string> emails = new List<string>();
            emails.Add("johnsmith@domain.com");

            string fileName = "exported.csv";

            try
            {
                apiInstance.ContactsExportPost(fileFormat, null, emails, null, fileName);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ContactsApi.ContactsExportPost: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public void DeleteContact()
        {
            Configuration config = new Configuration();

            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", "YOUR_API_KEY");

            /**
             * Delete contact
             * Example api call that deletes given contact(s).
             */
            var apiInstance = new ContactsApi(config);
            EmailsPayload emails = new EmailsPayload();
            emails.Emails = new List<string>();
            emails.Emails.Add("johnsmith@domain.com");

            try
            {
                apiInstance.ContactsDeletePost(emails);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ContactsApi.ContactsExportPost: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }
    }
}
