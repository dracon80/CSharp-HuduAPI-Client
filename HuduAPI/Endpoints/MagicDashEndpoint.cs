using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the MagicDash endpoint of the Hudu API.
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.IEndpoint"/>
    public class MagicDashEndpoint : IEndpoint,
        IEndpointGetMethod<MagicDashes, Parameters.GetMagicDash>,
        IEndpointCreateMethod<MagicDash, CreateMagicDash>,
        IEndpointDeleteMethod<ItemById>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagicDashEndpoint"/> class with the
        /// required API Key and Hudu URL to make all calls.
        /// </summary>
        /// <param name="huduAPIKey">The hudu API key.</param>
        /// <param name="huduBaseURL">The hudu base URL.</param>
        public MagicDashEndpoint(string huduAPIKey, string huduBaseURL)
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
        /// Creates a new, or updates and existing MagicDash item in Hudu
        /// </summary>
        /// <param name="parameters">The required MagicDash parameters to use when making the call.</param>
        /// <returns>A MagicDash object that represents the created dash in hudu</returns>
        public MagicDash Create(CreateMagicDash parameters)
        {
            Commands.CreateMagicDash myCommand = new Commands.CreateMagicDash(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Delete the specified MagicDash from Hudu
        /// </summary>
        /// <param name="parameters">The MagicDash ID to use when making the call.</param>
        public void Delete(ItemById parameters)
        {
            Commands.DeleteMagicDash myCommand = new Commands.DeleteMagicDash(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            myCommand.Execute();
        }

        /// <summary>
        /// Get a list of MagicDash objects from the Hudu Endpoint
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A MagicDashs object that contains a list of MagicDashs found in hudu</returns>
        public MagicDashes Get([Optional] GetMagicDash parameters)
        {
            Commands.GetMagicDash myCommand = new Commands.GetMagicDash(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}