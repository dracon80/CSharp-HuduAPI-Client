using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the company endpoint of the Hudu API.
    /// </summary>
    public class CompaniesEndpoint : IEndpoint,
        IEndpointGetMethod<Company, Parameters.ItemById>,
        IEndpointGetMethod<Companies, Parameters.GetCompanies>,
        IEndpointArchiveMethod<Company, ItemById>,
        IEndpointCreateMethod<Company, CreateCompany>,
        IEndpointUpdateMethod<Company, UpdateCompany>,
        IEndpointDeleteMethod<ItemById>

    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesEndpoint"/> class with the
        /// required API key and Hudu URL to make the calls.
        /// </summary>
        /// <param name="huduAPIKey">The hudu API key.</param>
        /// <param name="huduBaseURL">The hudu base URL.</param>
        public CompaniesEndpoint(string huduAPIKey, string huduBaseURL)
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
        /// Archive the Company record in Hudu
        /// </summary>
        /// <param name="parameters">The The ItemByID parameter to find the company.</param>
        /// <param name="archive">
        /// Should the item be archived? True will archive the item, fales will unarchive the item
        /// </param>
        /// <returns>
        /// An object of type <typeparamref name="TResult"/> that represents the created object in hudu
        /// </returns>
        public Company Archive(ItemById parameters, bool archive)
        {
            Commands.ArchiveCompany myCommand = new Commands.ArchiveCompany(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters, archive: archive);
            return myCommand.Execute();
        }

        /// <summary>
        /// Create a new Company record in Hudu with the supplied parameters
        /// </summary>
        /// <param name="parameters">The parameters to use when creating the company.</param>
        /// <returns>
        /// An object of type <typeparamref name="TResult"/> that represents the created object in hudu
        /// </returns>
        public Company Create(CreateCompany parameters)
        {
            Commands.CreateCompany myCommand = new Commands.CreateCompany(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Delete the company from Hudu
        /// </summary>
        /// <param name="parameters">The ItemById parameter to use when making the call.</param>
        public void Delete(ItemById parameters)
        {
            Commands.DeleteCompany myCommand = new Commands.DeleteCompany(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            myCommand.Execute();
        }

        /// <summary>
        /// Performs a get call to the api/v1/companies/:id endpoint on the Hudu API.
        /// </summary>
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns>A single company object will be returned using the ID provided.</returns>
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
        /// <param name="parameters">The parameters to use when making the call.</param>
        /// <returns><br/></returns>
        /// <remarks>
        /// Results can be filtered using an optional <see
        /// cref="Parameters.GetCompanies">GetCompanies</see> object
        /// </remarks>
        public Companies Get([Optional] Parameters.GetCompanies parameters)
        {
            Commands.GetCompanies myCommand = new Commands.GetCompanies(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Update an existing company record with the new details provided in the parameters object
        /// </summary>
        /// <param name="parameters">The parameters to use when updating the company record.</param>
        /// <returns>
        /// An object of type <typeparamref name="TResult"/> that represents the updated object in hudu
        /// </returns>
        public Company Update(UpdateCompany parameters)
        {
            Commands.UpdateCompany myCommand = new Commands.UpdateCompany(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}