using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the asset_passwords endpoint of the Hudu API.
    /// </summary>
    /// <remarks>
    /// The endpoint is a full CRUD endpoint and provides all methods required to create, read,
    /// update delete and archive.
    /// </remarks>
    public class AssetPasswordsEndpoint : IEndpoint,
        IEndpointGetMethod<AssetPassword, ItemById>,
        IEndpointGetMethod<AssetPasswords, GetAssetPasswords>
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
        /// Initializes a new instance of the <see cref="AssetPasswordsEndpoint" /> class.
        /// </summary>
        /// <param name="huduAPIKey">
        /// The hudu API key.
        /// </param>
        /// <param name="huduBaseURL">
        /// The hudu base URL.
        /// </param>
        public AssetPasswordsEndpoint(string huduAPIKey, string huduBaseURL)
        {
            HuduAPIKey = huduAPIKey;
            HuduBaseURL = huduBaseURL;
        }

        /// <summary>
        /// Get a single AssetPassword from Hudu
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// A single AssetPassword Object as returned by the Hudu API
        /// </returns>
        /// <exception cref="HuduAPI.Endpoints.Exceptions.RecordNotFoundException">
        /// If the asset_password is not found than an exception is raised
        /// </exception>
        public AssetPassword Get(ItemById parameters)
        {
            Commands.GetAssetPassword myCommand = new Commands.GetAssetPassword(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Get AssetPasswords based on the parameters used to filter the resutls
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// A single AssetPasswords object that contains all the asset_passwords found
        /// </returns>
        /// <exception cref="HuduAPI.Endpoints.Exceptions.RecordNotFoundException">
        /// If the asset_password is not found than an exception is raised
        /// </exception>
        public AssetPasswords Get([Optional] GetAssetPasswords parameters)
        {
            Commands.GetAssetPasswords myCommand = new Commands.GetAssetPasswords(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}