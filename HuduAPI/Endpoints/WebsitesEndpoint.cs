using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the Websites endpoint of the Hudu API.
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.IEndpoint"/>
    public class WebsitesEndpoint : IEndpoint,
        IEndpointGetMethod<Website, Parameters.ItemById>,
        IEndpointGetMethod<Websites, Parameters.GetWebsites>,
        IEndpointCreateMethod<Website, CreateWebsite>,
        IEndpointUpdateMethod<Website, UpdateWebsite>,
        IEndpointDeleteMethod<ItemById>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteEndpoint"/> class with the required
        /// API Key and Hudu URL to make all calls.
        /// </summary>
        /// <param name="huduAPIKey">The hudu API key.</param>
        /// <param name="huduBaseURL">The hudu base URL.</param>
        public WebsitesEndpoint(string huduAPIKey, string huduBaseURL)
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
        /// Create a new Website in Hudu using the suppied parameters
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>
        /// An object of type <typeparamref name="TResult"/> that represents the created object in hudu
        /// </returns>
        public Website Create(CreateWebsite parameters)
        {
            Commands.CreateWebsite myCommand = new Commands.CreateWebsite(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Delete the specified Website from Hudu
        /// </summary>
        /// <param name="parameters">The Website ID to use when making the call.</param>
        public void Delete(ItemById parameters)
        {
            Commands.DeleteWebsite myCommand = new Commands.DeleteWebsite(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            myCommand.Execute();
        }

        /// <summary>
        /// Get a list of Website objects from the Hudu Endpoint
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A Websites objec that contains a list of Websites found in hudu</returns>
        public Websites Get([Optional] GetWebsites parameters)
        {
            Commands.GetWebsites myCommand = new Commands.GetWebsites(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Gets a single Website object from the Hudu API using the supplied Item ID
        /// </summary>
        /// <param name="parameters">The Website ID to use when making the call.</param>
        /// <returns>A Website object that represents the required Website in hudu</returns>
        public Website Get(ItemById parameters)
        {
            Commands.GetWebsite myCommand = new Commands.GetWebsite(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Update an existing Website with the new details.
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A Website object that represents the updated object in hudu</returns>
        public Website Update(UpdateWebsite parameters)
        {
            Commands.UpdateWebsite myCommand = new Commands.UpdateWebsite(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}