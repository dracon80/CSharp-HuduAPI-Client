using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the Procedure endpoint of the Hudu API.
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.IEndpoint"/>
    public class ProcedureEndpoint : IEndpoint,
        IEndpointGetMethod<Procedure, Parameters.ItemById>,
        IEndpointGetMethod<Procedures, Parameters.GetProcedures>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureEndpoint"/> class with the
        /// required API Key and Hudu URL to make all calls.
        /// </summary>
        /// <param name="huduAPIKey">The hudu API key.</param>
        /// <param name="huduBaseURL">The hudu base URL.</param>
        public ProcedureEndpoint(string huduAPIKey, string huduBaseURL)
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
        /// Get a list of Procedure objects from the Hudu Endpoint
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A Procedures objec that contains a list of Procedures found in hudu</returns>
        public Procedures Get([Optional] GetProcedures parameters)
        {
            Commands.GetProcedures myCommand = new Commands.GetProcedures(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Gets a single Procedure object from the Hudu API using the supplied Item ID
        /// </summary>
        /// <param name="parameters">The Procedure ID to use when making the call.</param>
        /// <returns>A Procedure object that represents the required Procedure in hudu</returns>
        public Procedure Get(ItemById parameters)
        {
            Commands.GetProcedure myCommand = new Commands.GetProcedure(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}