using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetCompany : ICommand<Company>
    {
        private readonly string _apiKye;
        private readonly Parameters.ItemById _getParams;
        private readonly string _url;

        public GetCompany(String huduBaseURL, string huduAPIKey, Parameters.ItemById parameters)
        {
            _getParams = parameters ?? throw new ArgumentNullException("GetCompany parameters cannot be null"); ;
            _url = huduBaseURL + "api/v1/companies/" + parameters.ID;
            _apiKye = huduAPIKey;
        }

        /// <summary>
        /// Executes the command implemented in the implementor class.
        /// </summary>
        /// <returns>
        /// Returns a generic object of type TResult
        /// </returns>
        /// <exception cref="HuduAPI.Endpoints.Exceptions.RecordNotFoundException">
        /// Company ID: " + _getParams.ID + " was not found
        /// </exception>
        public Company Execute()
        {
            var result = BaseReceiver<CompanyRoot, Parameters.ItemById>.Get(
                url: _url,
                apiKey: _apiKye
                );

            if (result == null)
            {
                throw new RecordNotFoundException("Company ID: " + _getParams.ID + " was not found");
            }

            return result.Company;
        }
    }
}