using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the Matchers endpoint of the Hudu API.
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.IEndpoint"/>
    public class MatchersEndpoint : IEndpoint,
        IEndpointGetMethod<Matchers, Parameters.GetMatchers>,
        IEndpointUpdateMethod<Matcher, UpdateMatcher>,
        IEndpointDeleteMethod<ItemById>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatcherEndpoint"/> class with the required
        /// API Key and Hudu URL to make all calls.
        /// </summary>
        /// <param name="huduAPIKey">The hudu API key.</param>
        /// <param name="huduBaseURL">The hudu base URL.</param>
        public MatchersEndpoint(string huduAPIKey, string huduBaseURL)
        {
            this.HuduAPIKey = huduAPIKey;
            this.HuduBaseURL = huduBaseURL;
            Configuration.ConfigFurlSerializer();
        }

        /// <summary>
        /// Gets or sets the hudu API key that will be used for all calls to this Endpoint.
        /// </summary>
        /// <value>The hudu API key.</value>
        public string HuduAPIKey { get; set; }

        /// <summary>
        /// Gets or sets the hudu base URL that will be used for all calls to the Endpoint.
        /// </summary>
        /// <value>The hudu base URL.</value>
        public string HuduBaseURL { get; set; }

        /// <summary>
        /// Delete the specified Matcher from Hudu
        /// </summary>
        /// <param name="parameters">The Matcher ID to use when making the call.</param>
        public void Delete(ItemById parameters)
        {
            Commands.DeleteMatcher myCommand = new Commands.DeleteMatcher(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            myCommand.Execute();
        }

        /// <summary>
        /// Get a list of Matcher objects from the Hudu Endpoint
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A Matchers objec that contains a list of Matchers found in hudu</returns>
        public Matchers Get(GetMatchers parameters)
        {
            Commands.GetMatchers myCommand = new Commands.GetMatchers(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Update an existing Matcher with the new details.
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A Matcher object that represents the updated object in hudu</returns>
        public Matcher Update(UpdateMatcher parameters)
        {
            Commands.UpdateMatcher myCommand = new Commands.UpdateMatcher(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}