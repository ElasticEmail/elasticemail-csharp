/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    The API has a limit of 20 concurrent connections and a hard timeout of 600 seconds per request.    To start using this API, you will need your Access Token (available <a target=\"_blank\" href=\"https://elasticemail.com/account#/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    This is the documentation for REST API. If you’d like to read our legacy documentation regarding Web API v2 click <a target=\"_blank\" href=\"https://api.elasticemail.com/public/help\">here</a>.    Downloadable library clients can be found in our Github repository <a target=\"_blank\" href=\"https://github.com/ElasticEmail?tab=repositories&q=%22rest+api%22+in%3Areadme\">here</a>
 *
 * The version of the OpenAPI document: 4.0.0
 * Contact: support@elasticemail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Collections.Generic;

namespace ElasticEmail.Client
{
    /// <summary>
    /// <see cref="GlobalConfiguration"/> provides a compile-time extension point for globally configuring
    /// API Clients.
    /// </summary>
    /// <remarks>
    /// A customized implementation via partial class may reside in another file and may
    /// be excluded from automatic generation via a .openapi-generator-ignore file.
    /// </remarks>
    public partial class GlobalConfiguration : Configuration
    {
        #region Private Members

        private static readonly object GlobalConfigSync = new { };
        private static IReadableConfiguration _globalConfiguration;

        #endregion Private Members

        #region Constructors

        /// <inheritdoc />
        private GlobalConfiguration()
        {
        }

        /// <inheritdoc />
        public GlobalConfiguration(IDictionary<string, string> defaultHeader, IDictionary<string, string> apiKey, IDictionary<string, string> apiKeyPrefix, string basePath = "http://localhost:3000/api") : base(defaultHeader, apiKey, apiKeyPrefix, basePath)
        {
        }

        static GlobalConfiguration()
        {
            Instance = new GlobalConfiguration();
        }

        #endregion Constructors

        /// <summary>
        /// Gets or sets the default Configuration.
        /// </summary>
        /// <value>Configuration.</value>
        public static IReadableConfiguration Instance
        {
            get { return _globalConfiguration; }
            set
            {
                lock (GlobalConfigSync)
                {
                    _globalConfiguration = value;
                }
            }
        }
    }
}