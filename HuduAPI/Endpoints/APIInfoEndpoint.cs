using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the api_info endpoint of the Hudu API.
    /// </summary>
    /// <remarks>
    /// The endpoint will return the version and date of your Hudu instance
    /// </remarks>
    /// <seealso cref="HuduAPI.Endpoints.IEndpoint" />
    public class APIInfoEndpoint : IEndpoint
    {
        /// <summary>
        /// Gets or sets the hudu API key that will be used for all calls to this Endpoint.
        /// </summary>
        /// <value>
        /// The hudu API key.
        /// </value>
        public string HuduAPIKey { get; set; }

        /// <summary>
        /// Gets or sets the hudu base URL that will be used for all calls to the Endpoint.
        /// </summary>
        /// <value>
        /// The hudu base URL.
        /// </value>
        public string HuduBaseURL { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIInfoEndpoint" /> class with the required
        /// URL and API Keys.
        /// </summary>
        /// <param name="huduAPIKey">
        /// The hudu API key.
        /// </param>
        /// <param name="huduBaseURL">
        /// The hudu base URL.
        /// </param>
        public APIInfoEndpoint(string huduAPIKey, string huduBaseURL)
        {
            HuduAPIKey = huduAPIKey;
            HuduBaseURL = huduBaseURL;
        }

        /// <summary>
        /// Gets the current Hudu API information as returned by the api_info endpoint.
        /// </summary>
        /// <returns>
        /// </returns>
        public APIInfo Get()
        {
            Commands.GetAPIInfo command = new(this.HuduBaseURL, this.HuduAPIKey);

            return command.Execute();
        }
    }
}