using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class CreateCompany : ICommand<Company>
    {
        private readonly string _apiKey;
        private readonly Parameters.CreateCompany _params;
        private readonly string _url;

        public CreateCompany(String huduBaseURL, string huduAPIKey, Parameters.CreateCompany parameters)
        {
            _apiKey = huduAPIKey;
            _params = parameters;
            _url = huduBaseURL + "api/v1/companies/";
        }

        public Company Execute()
        {
            var result = BaseReceiver<CompanyRoot, Parameters.CreateCompany>.Create(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error creating the new Company");
            }

            return result.Company;
        }
    }
}