using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the company endpoint of the Hudu API.
    /// </summary>
    public class CompanyEndpoint : IEndpoint,
        IEndpointGetMethod<Company, Parameters.ItemById>,
        IEndpointGetMethod<Companies, Parameters.GetCompanies>

    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyEndpoint" /> class with the required
        /// API key and Hudu URL to make the calls.
        /// </summary>
        /// <param name="huduAPIKey">
        /// The hudu API key.
        /// </param>
        /// <param name="huduBaseURL">
        /// The hudu base URL.
        /// </param>
        public CompanyEndpoint(string huduAPIKey, string huduBaseURL)
        {
            this.HuduAPIKey = huduAPIKey;
            this.HuduBaseURL = huduBaseURL;
            Configuration.ConfigFurlSerializer();
        }

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
        /// Performs a get call to the api/v1/companies/:id endpoint on the Hudu API.
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// A single company object will be returned using the ID provided.
        /// </returns>
        /// <exception cref="HuduAPI.Endpoints.Exceptions.RecordNotFoundException">
        /// If the company is not found than an exception is raised
        /// </exception>
        public Company Get(Parameters.ItemById parameters)
        {
            Commands.GetCompany myCommand = new Commands.GetCompany(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Performs a get call to the api/v1/companies endpoint on the Hudu API.
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// <br />
        /// </returns>
        /// <remarks>
        /// Results can be filtered using an optional <see
        /// cref="Parameters.GetCompanies">GetCompanies</see> object
        /// </remarks>
        public Companies Get([Optional] Parameters.GetCompanies parameters)
        {
            Commands.GetCompanies myCommand = new Commands.GetCompanies(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}