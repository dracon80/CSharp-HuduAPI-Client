using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class UpdateCompany : ICommand<Company>
    {
        private readonly string _apiKey;
        private readonly Parameters.UpdateCompany _params;
        private readonly string _url;

        public UpdateCompany(String huduBaseURL, string huduAPIKey, Parameters.UpdateCompany parameters)
        {
            _apiKey = huduAPIKey;
            _url = huduBaseURL + "api/v1/companies/" + parameters.Id;
            _params = parameters;
        }

        public Company Execute()
        {
            var result = BaseReceiver<CompanyRoot, Parameters.UpdateCompany>.Update(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error updating the Company");
            }

            return result.Company;
        }
    }
}