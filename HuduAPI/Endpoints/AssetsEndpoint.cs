using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the Asset endpoint of the Hudu API.
    /// </summary>
    public class AssetsEndpoint : IEndpoint,
        IEndpointGetMethod<Asset, Parameters.AssetById>,
        IEndpointGetMethod<Assets, Parameters.GetAssets>,
        IEndpointArchiveMethod<Asset, AssetById>,
        IEndpointCreateMethod<Asset, CreateAsset>,
        IEndpointUpdateMethod<Asset, UpdateAsset>,
        IEndpointDeleteMethod<AssetById>

    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsEndpoint"/> class with the required
        /// API key and Hudu URL to make the calls.
        /// </summary>
        /// <param name="huduAPIKey">The hudu API key.</param>
        /// <param name="huduBaseURL">The hudu base URL.</param>
        public AssetsEndpoint(string huduAPIKey, string huduBaseURL)
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
        /// Archive the Asset record in Hudu
        /// </summary>
        /// <param name="parameters">The The AssetById parameter to find the Asset.</param>
        /// <param name="archive">
        /// Should the item be archived? True will archive the item, fales will unarchive the item
        /// </param>
        /// <returns>
        /// An object of type <typeparamref name="TResult"/> that represents the created object in hudu
        /// </returns>
        public Asset Archive(AssetById parameters, bool archive)
        {
            Commands.ArchiveAsset myCommand = new Commands.ArchiveAsset(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters, archive: archive);
            return myCommand.Execute();
        }

        /// <summary>
        /// Create a new Asset record in Hudu with the supplied parameters
        /// </summary>
        /// <param name="parameters">The parameters to use when creating the Asset.</param>
        /// <returns>
        /// An object of type <typeparamref name="TResult"/> that represents the created object in hudu
        /// </returns>
        public Asset Create(CreateAsset parameters)
        {
            Commands.CreateAsset myCommand = new Commands.CreateAsset(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Delete the Asset from Hudu
        /// </summary>
        /// <param name="parameters">The AssetById parameter to use when making the call.</param>
        public void Delete(AssetById parameters)
        {
            Commands.DeleteAsset myCommand = new Commands.DeleteAsset(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            myCommand.Execute();
        }

        /// <summary>
        /// Performs a get call to the api/v1/Assets/:id endpoint on the Hudu API.
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A single Asset object will be returned using the ID provided.</returns>
        /// <exception cref="HuduAPI.Endpoints.Exceptions.RecordNotFoundException">
        /// If the Asset is not found than an exception is raised
        /// </exception>
        public Asset Get(Parameters.AssetById parameters)
        {
            Commands.GetAsset myCommand = new Commands.GetAsset(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Performs a get call to the api/v1/Assets endpoint on the Hudu API.
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns><br/></returns>
        /// <remarks>
        /// Results can be filtered using an optional <see
        /// cref="Parameters.GetAssets">GetAssets</see> object
        /// </remarks>
        public Assets Get([Optional] Parameters.GetAssets parameters)
        {
            Commands.GetAssets myCommand = new Commands.GetAssets(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Update an existing Asset record with the new details provided in the parameters object
        /// </summary>
        /// <param name="parameters">The parameters to use when updating the Asset record.</param>
        /// <returns>
        /// An object of type <typeparamref name="TResult"/> that represents the updated object in hudu
        /// </returns>
        public Asset Update(UpdateAsset parameters)
        {
            Commands.UpdateAsset myCommand = new Commands.UpdateAsset(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}