using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the folder endpoint of the Hudu API.
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.IEndpoint"/>
    public class FolderEndpoint : IEndpoint,
        IEndpointGetMethod<Folder, Parameters.ItemById>,
        IEndpointGetMethod<Folders, Parameters.GetFolders>,
        IEndpointCreateMethod<Folder, CreateFolder>,
        IEndpointUpdateMethod<Folder, UpdateFolder>,
        IEndpointDeleteMethod<ItemById>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEndpoint"/> class with the required
        /// API Key and Hudu URL to make all calls.
        /// </summary>
        /// <param name="huduAPIKey">The hudu API key.</param>
        /// <param name="huduBaseURL">The hudu base URL.</param>
        public FolderEndpoint(string huduAPIKey, string huduBaseURL)
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

        public Folder Create(CreateFolder parameters)
        {
            Commands.CreateFolder myCommand = new Commands.CreateFolder(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Delete the specified folder from Hudu
        /// </summary>
        /// <param name="parameters">The folder ID to use when making the call.</param>
        public void Delete(ItemById parameters)
        {
            Commands.DeleteFolder myCommand = new Commands.DeleteFolder(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            myCommand.Execute();
        }

        /// <summary>
        /// Get a list of folder objects from the Hudu Endpoint
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A Folders objec that contains a list of folders found in hudu</returns>
        public Folders Get([Optional] GetFolders parameters)
        {
            Commands.GetFolders myCommand = new Commands.GetFolders(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Gets a single Folder object from the Hudu API using the supplied Item ID
        /// </summary>
        /// <param name="parameters">The folder ID to use when making the call.</param>
        /// <returns>A Folder object that represents the required folder in hudu</returns>
        public Folder Get(ItemById parameters)
        {
            Commands.GetFolder myCommand = new Commands.GetFolder(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Update an existing folder with the new details.
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A Folder object that represents the updated object in hudu</returns>
        public Folder Update(UpdateFolder parameters)
        {
            Commands.UpdateFolder myCommand = new Commands.UpdateFolder(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}