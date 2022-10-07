using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the asset_layout endpoint of the Hudu API.
    /// </summary>
    /// <remarks>
    /// The endpoint is a full CRUD endpoint and provides all methods required to create, read,
    /// update delete and archive.
    /// </remarks>
    public class AssetLayoutsEndpoint : IEndpoint,
        IEndpointGetMethod<AssetLayout, ItemById>,
        IEndpointGetMethod<AssetLayouts, GetAssetLayouts>,
        IEndpointCreateMethod<AssetLayout, CreateAssetLayout>,
        IEndpointUpdateMethod<AssetLayout, UpdateAssetLayout>
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
        /// Initializes a new instance of the <see cref="AssetLayoutsEndpoint" /> class.
        /// </summary>
        /// <param name="huduAPIKey">
        /// The hudu API key.
        /// </param>
        /// <param name="huduBaseURL">
        /// The hudu base URL.
        /// </param>
        public AssetLayoutsEndpoint(string huduAPIKey, string huduBaseURL)
        {
            HuduAPIKey = huduAPIKey;
            HuduBaseURL = huduBaseURL;
        }

        /// <summary>
        /// Get a single AssetLayout from Hudu
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// A single AssetLayout Object as returned by the Hudu API
        /// </returns>
        /// <exception cref="HuduAPI.Endpoints.Exceptions.RecordNotFoundException">
        /// If the asset_layout is not found than an exception is raised
        /// </exception>
        public AssetLayout Get(ItemById parameters)
        {
            Commands.GetAssetLayout myCommand = new Commands.GetAssetLayout(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Get AssetLayouts based on the parameters used to filter the resutls
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// A single AssetLayouts object that contains all the asset_layouts found
        /// </returns>
        /// <exception cref="HuduAPI.Endpoints.Exceptions.RecordNotFoundException">
        /// If the asset_layout is not found than an exception is raised
        /// </exception>
        public Records.AssetLayouts Get([Optional] GetAssetLayouts parameters)
        {
            Commands.GetAssetLayouts myCommand = new Commands.GetAssetLayouts(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Performs a Create method call on the Hudu API to create a new assetlayout
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// An object of type <see cref="AssetLayout" /> that represents the created object in hudu
        /// </returns>
        public AssetLayout Create(CreateAssetLayout parameters)
        {
            Commands.CreateAssetLayout myCommand = new Commands.CreateAssetLayout(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Performs an update on the supplied AssetLayout ID using the parameters supplied.
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// An object of type <see cref="AssetLayout" /> that represents the created object in hudu
        /// </returns>
        public AssetLayout Update(UpdateAssetLayout parameters)
        {
            Commands.UpdateAssetLayout myCommand = new Commands.UpdateAssetLayout(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}