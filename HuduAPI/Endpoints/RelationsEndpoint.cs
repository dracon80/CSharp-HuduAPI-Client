using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the Relation endpoint of the Hudu API.
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.IEndpoint"/>
    public class RelationEndpoint : IEndpoint,
        IEndpointGetMethod<Relations, Parameters.GetRelations>,
        IEndpointCreateMethod<Relation, CreateRelation>,
        IEndpointDeleteMethod<ItemById>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationEndpoint"/> class with the required
        /// API Key and Hudu URL to make all calls.
        /// </summary>
        /// <param name="huduAPIKey">The hudu API key.</param>
        /// <param name="huduBaseURL">The hudu base URL.</param>
        public RelationEndpoint(string huduAPIKey, string huduBaseURL)
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
        /// Creates a new Relation in Hudu using the provided parameters
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>
        /// An object of type <typeparamref name="TResult"/> that represents the created object in hudu
        /// </returns>
        public Relation Create(CreateRelation parameters)
        {
            Commands.CreateRelation myCommand = new Commands.CreateRelation(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Delete the specified Relation from Hudu
        /// </summary>
        /// <param name="parameters">The Relation ID to use when making the call.</param>
        public void Delete(ItemById parameters)
        {
            Commands.DeleteRelation myCommand = new Commands.DeleteRelation(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            myCommand.Execute();
        }

        /// <summary>
        /// Get a list of Relation objects from the Hudu Endpoint
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A Relations objec that contains a list of Relations found in hudu</returns>
        public Relations Get([Optional] GetRelations parameters)
        {
            Commands.GetRelations myCommand = new Commands.GetRelations(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}